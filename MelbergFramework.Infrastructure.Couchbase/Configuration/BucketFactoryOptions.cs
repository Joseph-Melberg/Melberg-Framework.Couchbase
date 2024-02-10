namespace MelbergFramework.Infrastructure.Couchbase.Configuration;

public class BucketFactoryOptions
{
    public static string Section => "Couchbase";
    public string Url {get; set;}
    public string Username {get; set;}
    public string Password {get; set;}
    public string Bucket {get; set;}
}