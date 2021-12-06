using System.Text.Json.Serialization;

namespace Projet.Components.Models
{
    public class RegistryObject
    {
        [JsonPropertyName("package")]
        public Package Package { get; set; }
    }
}
