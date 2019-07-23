using System;
using System.Collections.Generic;
using System.Text;

namespace BitcoinLib.Responses.Ravencoin
{
    public class GetAsssetDataResponse
    {
        public string Name { get; set; }
        public string Amount { get; set; }
        public string Units { get; set; }
        public string Reissuable { get; set; }
        public string Has_ipfs { get; set; }
    }
}
