using System.Globalization;
using System.Reflection;

namespace DataIntegrationAPI.Helpers;

public class CapellaClassUtils
{
    public static Type GetClassForNamespace(string className, string namespaceName, string assembly)
    {
        Type type = GetClass(className, namespaceName, assembly);
        if (!type.Equals(null))
        {
            return type;
        }
        throw new Exception("Sınıf bulunamadı");
    }
    
    public static Type GetClass(string className, string namespaceName, string assembly)
    {
        string assemblyName = assembly;
        string qualifiedName = $"{namespaceName}.{className}, " + assemblyName;
        Type type = Type.GetType(qualifiedName);
        return type;
    }
    
}