using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModels
{
    public class BookViewModel
    {
        public Book Book { get; set; }
        public List<string> Authors { get; set; }
        public List<string> Ganres { get; set; }
    }
}
