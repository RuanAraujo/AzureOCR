using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace POGSC
{
    public class Resposta
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("orientation")]
        public string Orientation { get; set; }

        [JsonProperty("textAngle")]
        public double TextAngle { get; set; }

        [JsonProperty("regions")]
        public Region[] Regions { get; set; }
    }
    public class Region
    {
        [JsonProperty("boundingBox")]
        public string BoundingBox { get; set; }

        [JsonProperty("lines")]
        public Line[] Lines { get; set; }
    }

    public class Line
    {
        [JsonProperty("boundingBox")]
        public string BoundingBox { get; set; }

        [JsonProperty("words")]
        public Word[] Words { get; set; }
    }

    public class Word
    {
        [JsonProperty("boundingBox")]
        public string BoundingBox { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
