using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures.LinkedLists.Example
{
    public class History
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;
        public override string ToString()
        {
            return Url;
        }
    }
}
