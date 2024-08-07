using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerV2
{
    public class Book
    {
        public int BookId {  get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty ;
        public string Description { get; set; } = string.Empty;
    }
}
