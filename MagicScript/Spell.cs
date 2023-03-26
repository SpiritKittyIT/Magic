using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MagicScript
{
    internal enum TargetType
    {
        Touch, Direction, Radius
    }

    internal enum Effect
    {
        Discharge, Absorb, Shape
    }

    internal enum Element
    {
        Heat, Water, Cold, Earth, Wind, Metal, Lightning, Force, Life, Death, Mind, Light
    }

    internal class Target
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? maxDistance { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? minDistance { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TargetType type { get; set; }
    }

    internal class Spell
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Target? target { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Effect? effect { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? duration { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Spell? condition { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Spell? content { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public Element? element { get; set; }
    }
}
