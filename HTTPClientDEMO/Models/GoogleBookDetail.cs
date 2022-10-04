    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using System.Text.Json.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

namespace HTTPClientDEMO.Models
{
    public partial class GoogleBookDetail
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("totalItems")]
        public long TotalItems { get; set; }

        [JsonPropertyName("items")]
        public List<Item> Items { get; set; }
    }

    public partial class Item
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("etag")]
        public string Etag { get; set; }

        [JsonPropertyName("selfLink")]
        public Uri SelfLink { get; set; }

        [JsonPropertyName("volumeInfo")]
        public VolumeInfo VolumeInfo { get; set; }

        [JsonPropertyName("saleInfo")]
        public SaleInfo SaleInfo { get; set; }

        [JsonPropertyName("accessInfo")]
        public AccessInfo AccessInfo { get; set; }

        [JsonPropertyName("searchInfo")]
        public SearchInfo SearchInfo { get; set; }
    }

    public partial class AccessInfo
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("viewability")]
        public string Viewability { get; set; }

        [JsonPropertyName("embeddable")]
        public bool Embeddable { get; set; }

        [JsonPropertyName("publicDomain")]
        public bool PublicDomain { get; set; }

        [JsonPropertyName("textToSpeechPermission")]
        public string TextToSpeechPermission { get; set; }

        [JsonPropertyName("epub")]
        public Epub Epub { get; set; }

        [JsonPropertyName("pdf")]
        public Epub Pdf { get; set; }

        [JsonPropertyName("webReaderLink")]
        public Uri WebReaderLink { get; set; }

        [JsonPropertyName("accessViewStatus")]
        public string AccessViewStatus { get; set; }

        [JsonPropertyName("quoteSharingAllowed")]
        public bool QuoteSharingAllowed { get; set; }
    }

    public partial class Epub
    {
        [JsonPropertyName("isAvailable")]
        public bool IsAvailable { get; set; }
    }

    public partial class SaleInfo
    {
        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("saleability")]
        public string Saleability { get; set; }

        [JsonPropertyName("isEbook")]
        public bool IsEbook { get; set; }
    }

    public partial class SearchInfo
    {
        [JsonPropertyName("textSnippet")]
        public string TextSnippet { get; set; }
    }

    public partial class VolumeInfo
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("subtitle")]
        public string Subtitle { get; set; }

        [JsonPropertyName("authors")]
        public List<string> Authors { get; set; }

        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }

        //[JsonPropertyName("publishedDate")]
        //// [JsonConverter(typeof(ParseStringConverter))]
        //public long PublishedDate { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("industryIdentifiers")]
        public List<IndustryIdentifier> IndustryIdentifiers { get; set; }

        [JsonPropertyName("readingModes")]
        public ReadingModes ReadingModes { get; set; }

        [JsonPropertyName("pageCount")]
        public long PageCount { get; set; }

        [JsonPropertyName("printType")]
        public string PrintType { get; set; }

        [JsonPropertyName("categories")]
        public List<string> Categories { get; set; }

        //[JsonPropertyName("averageRating")]
        //public long AverageRating { get; set; }

        [JsonPropertyName("ratingsCount")]
        public long RatingsCount { get; set; }

        [JsonPropertyName("maturityRating")]
        public string MaturityRating { get; set; }

        [JsonPropertyName("allowAnonLogging")]
        public bool AllowAnonLogging { get; set; }

        [JsonPropertyName("contentVersion")]
        public string ContentVersion { get; set; }

        [JsonPropertyName("panelizationSummary")]
        public PanelizationSummary PanelizationSummary { get; set; }

        [JsonPropertyName("imageLinks")]
        public ImageLinks ImageLinks { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("previewLink")]
        public Uri PreviewLink { get; set; }

        [JsonPropertyName("infoLink")]
        public Uri InfoLink { get; set; }

        [JsonPropertyName("canonicalVolumeLink")]
        public Uri CanonicalVolumeLink { get; set; }
    }

    public partial class ImageLinks
    {
        [JsonPropertyName("smallThumbnail")]
        public Uri SmallThumbnail { get; set; }

        [JsonPropertyName("thumbnail")]
        public Uri Thumbnail { get; set; }
    }

    public partial class IndustryIdentifier
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }
    }

    public partial class PanelizationSummary
    {
        [JsonPropertyName("containsEpubBubbles")]
        public bool ContainsEpubBubbles { get; set; }

        [JsonPropertyName("containsImageBubbles")]
        public bool ContainsImageBubbles { get; set; }
    }

    public partial class ReadingModes
    {
        [JsonPropertyName("text")]
        public bool Text { get; set; }

        [JsonPropertyName("image")]
        public bool Image { get; set; }
    }
}
