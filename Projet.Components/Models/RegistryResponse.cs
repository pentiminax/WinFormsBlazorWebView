using System.Text.Json.Serialization;

namespace Projet.Components.Models
{
    public class RegistryResponse
    {
        [JsonPropertyName("objects")]
        public List<RegistryObject> Objects { get; set; }
    }
}
