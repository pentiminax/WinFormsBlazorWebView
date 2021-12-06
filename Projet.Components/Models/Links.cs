using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Projet.Components.Models
{
    public class Links
    {
        [JsonPropertyName("npm")]
        public string NPM { get; set; }
    }
}
