using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityPost.Entities
{
    class Comment
    {
        public string text { get; set; }

        public Comment(string text)
        {
            this.text = text;
        }


    }
}
