using System;
using System.Collections.Generic;
using System.Text;

namespace EfSamurai.Domain
{
    public class Quote
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Samurai Samurai { get; set; }
        public int SamuraiId { get; set; }
        public string TypeId { get; set; }
        public Type QuoteType { get; set; }

    }
}
