using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDTO
{
    public class Borrow
    {
        public int BorrowId { get; set; }
        public int ReaderId { get; set; }
        public string BorrowDate { get; set; }
        public string BorrowStatus { get; set; }
        public int BookId { get; set; }
    }
}
