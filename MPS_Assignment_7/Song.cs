using System;
using System.Collections.Generic;
using System.Text;

namespace MPS_Assignment_7
{
    public class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
      public string ImageUrl { get; set; }


        public override string ToString()
        {
            return Title;
        }
    }
}