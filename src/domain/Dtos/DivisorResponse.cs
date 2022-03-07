using System.Collections.Generic;

namespace domain.Dtos
{
    public class DividerResponse
    {
        public bool Ok { get; set;}
        public IList<long> Dividers { get; set; }
        public string Error { get; set; }

        public DividerResponse()
        {
            Dividers = new List<long>();
        }
    }
}