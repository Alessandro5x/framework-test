using System.Collections.Generic;

namespace domain.Dtos
{
    public class DividerResponse
    {   
        public bool Ok { get; set;}
        public IList<long> Dividers { get; set; }
        public string Error { get; set; }

        static void Main() {}

        public DividerResponse()
        {
            Dividers = new List<long>();
        }
    }
}