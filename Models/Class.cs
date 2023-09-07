using System.Text.Json.Serialization;

namespace Web_API.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Class
    {
        Knight = 1,
        Mage = 2,
        Thief = 3,
        Paladin = 4,
        Necromancer = 5
    }
}