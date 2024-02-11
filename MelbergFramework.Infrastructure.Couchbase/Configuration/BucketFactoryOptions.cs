using System.ComponentModel.DataAnnotations;

namespace MelbergFramework.Infrastructure.Couchbase.Configuration;

public class BucketFactoryOptions
{
    public static string Section => "Couchbase";
    [Required]
    public string Url {get; set;}
    [Required]
    public string Username {get; set;}
    [Required]
    public string Password {get; set;}
    [Required]
    public string Bucket {get; set;}
    [Required]
    [Range(100,1000)]
    public int RamQuotaMB {get ;set;}
}