using BaGet.Core;
using System.ComponentModel.DataAnnotations;

namespace BaGet.Gcp;

public class GoogleCloudStorageOptions : StorageOptions
{
    [Required]
    public string BucketName { get; set; }
}
