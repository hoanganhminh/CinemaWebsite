using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Accessibility
    {
        public string title { get; set; }
        public string duration { get; set; }
    }

    public class Channel
    {
        public string name { get; set; }
        public string id { get; set; }
        public List<Thumbnail> thumbnails { get; set; }
        public string link { get; set; }
    }

    public class DescriptionSnippet
    {
        public string text { get; set; }
        public bool? bold { get; set; }
    }

    public class Result
    {
        public string type { get; set; }
        public string id { get; set; }
        public string title { get; set; }
        public string publishedTime { get; set; }
        public string duration { get; set; }
        public ViewCount viewCount { get; set; }
        public List<Thumbnail> thumbnails { get; set; }
        public RichThumbnail richThumbnail { get; set; }
        public List<DescriptionSnippet> descriptionSnippet { get; set; }
        public Channel channel { get; set; }
        public Accessibility accessibility { get; set; }
        public string link { get; set; }
        public object shelfTitle { get; set; }
    }

    public class RichThumbnail
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Root
    {
        public List<Result> result { get; set; }
    }

    public class Thumbnail
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class ViewCount
    {
        public string text { get; set; }
        public string @short { get; set; }
    }
}
