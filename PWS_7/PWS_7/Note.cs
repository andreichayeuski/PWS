using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWS_7
{
    class Note
    {
        [JsonProperty("Subj")]
        public string Subj { get; set; }
        [JsonProperty("Note1")]
        public int Note1 { get; set; }
    }

    class NoteResponse
    {
        public Note[] Value { get; set; }
    }
}
