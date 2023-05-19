using System.ComponentModel;
using System.Reflection;
using Application.Constant;
using Application.Repositories;
using Application.Services.ImportData;
using Application.Services.Search;
using Domain.Entities;
using Domain.Entities.Common;
using Domain.Enums;
using Persistence.Contexts;
using Persistence.Repositories;
using Persistence.Services.Search;

namespace Persistence.Services.ImportData;

public class ImportDataService: IImportDataService
{
    private static readonly string UNIQUE_POINTER = "[unique]";
    private static readonly string CODE_POINTER = "(code)";
    private static readonly string COLON = ":";
    private static readonly string SEMI_COLON = ";";

    private readonly ISearchService _searchService;

    public ImportDataService(ISearchService searchService)
    {
        _searchService = searchService;
    }

    public Task<(bool, string)> ImportData(Type itemType, List<Dictionary<string, object>> data, ImportProcessType importProcessType)
    {
        try
        {
            foreach (var row in data)
            {
                foreach (var rowValue in row)
                {
                    row[rowValue.Key] = rowValue.Value.ToString().Trim();
                }

                BaseEntity baseEntity;
                var uniqueFields = row.Keys.Where(p => p.Contains(UNIQUE_POINTER)).ToHashSet();
                var uniqueMapForQuery = new Dictionary<string, object>();
                var tempObj = Activator.CreateInstance(itemType);
                foreach (var uniqueField in uniqueFields)
                {
                    if (uniqueField.Contains("("))
                    {
                        var relationType = uniqueField.Split('(')[0];
                        var contents = uniqueField.Substring(uniqueField.IndexOf("(") + 1, uniqueField.IndexOf(")") - uniqueField.IndexOf("(") - 1).Split(':');

                        var relationContents = row[uniqueField].ToString().Split(SEMI_COLON);
                        var map = new Dictionary<string, string>();
                        foreach (var rel in relationContents)
                        {
                            if (rel.Split(':').Length != contents.Length)
                            {
                                throw new ArgumentException("Parameter count can not be matched.");
                            }

                            for (int i = 0; i < contents.Length; i++)
                            {
                                map[contents[i]] = rel.Split(':')[i];
                            }
                        }

                        var isNullRelation = map.Keys.Any(p =>
                            string.IsNullOrEmpty(map[p]) || map[p].Equals("null", StringComparison.OrdinalIgnoreCase));
                        if (isNullRelation)
                        {
                            uniqueMapForQuery[relationType] = null;
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        var fieldName = ClearFieldName((uniqueField));
                        PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProperties(tempObj)[fieldName];
                        uniqueMapForQuery.Add(fieldName, ConvertWrapperType(propertyDescriptor,row.Where(x=>x.Key==uniqueField).FirstOrDefault().Value.ToString()));
                    }
                }

                try
                {
                    // BURADA YAPILACAK KOD...
                    var a = _searchService.SearchSingleResult(itemType, uniqueMapForQuery, SearchOperator.AND);


                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
                return Task.FromResult((true, ""));
                
                
                
            }

            return Task.FromResult((true, ""));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private string ClearFieldName(string fieldName)
    {
        var start = fieldName.IndexOf("[");
        var end = fieldName.IndexOf("]", start + 1);
        while (start != -1 && end != -1)
        {
            fieldName = fieldName.Remove(start, end - start + 1);
            start = fieldName.IndexOf("[");
            end = fieldName.IndexOf("]", start + 1);
        }

        return fieldName;
    }
    
    
    private object ConvertWrapperType(PropertyDescriptor propertyDescriptor, string value)
{
    Type tClass = propertyDescriptor.PropertyType;
    
    switch (tClass.Name)
    {
        case "Double":
        case "double":
            try
            {
                return double.Parse(value);
            }
            catch (FormatException)
            {
                return 0.0;
            }
        case "Int32":
        case "int":
            try
            {
                return int.Parse(value);
            }
            catch (FormatException)
            {
                return 0;
            }
        case "Single":
        case "float":
            try
            {
                return float.Parse(value);
            }
            catch (FormatException)
            {
                return 0.0f;
            }
        case "Int64":
        case "long":
            try
            {
                return long.Parse(value);
            }
            catch (FormatException)
            {
                return 0L;
            }
        case "Boolean":
        case "bool":
            return bool.Parse(value);

        case "Decimal":
            try
            {
                return decimal.Parse(value);
            }
            catch (FormatException)
            {
                return decimal.Zero;
            }
        case "TimeSpan":
            return TimeSpan.Parse(value);

        default:
            return value;
    }
}
    
    
    
}