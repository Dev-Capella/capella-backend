using Domain.Entities.Common;
using Domain.Enums;

namespace Domain.Entities;

public class Media : CodeBaseEntity
{
    public string RealFilename { get; set; }
    public string EncodedFilename { get; set; }
    public string FilePath { get; set; }
    public string RootPath { get; set; }
    public string ServePath { get; set; }
    public string AbsolutePath { get; set; }
    public string Mime { get; set; }
    public string Extension { get; set; }
    public long Size { get; set; }
    public bool Secure { get; set; }
    public bool Deleted { get; set; }

    public MediaType MediaType { get; set; }
    public MediaFormat MediaFormat { get; set; }
    
    public int? MediaFormatId { get; set; }
    public ICollection<Product> Products { get; set; }
    public ContentCategory ContentCategory { get; set; }

}