using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
    class SamuraiToQuote
    {
        public int SamuraiId { get; set; }
        public Samurai Samurai { get; set; }

        public int QuoteId { get; set; }
        public Quote Quote { get; set; }
    }
}
