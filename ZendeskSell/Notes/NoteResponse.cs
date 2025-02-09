using System;
using Newtonsoft.Json;
using ZendeskSell.Utils;

namespace ZendeskSell.Notes {
    public class NoteResponse : NoteRequest {
        public NoteResponse(NoteResponse source) : this() => ClassCopier.Copy(source, this);
        public NoteResponse() : base() { }

        [JsonProperty("id")]
        public long ID { get; set; }
        [JsonProperty("creator_id")]
        public int CreatorID { get; set; }
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
