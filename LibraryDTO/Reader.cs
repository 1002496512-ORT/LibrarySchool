using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDTO
{
    public class Reader
    {
        public int ReaderId { get; set; }
        public string ReaderFirstName { get; set; }
        public string ReaderLastName { get; set; }
        public string ReaderAdress { get; set; }
        public string TeaderTelephone { get; set; } // במקור בדיאגרמה רשום Teader
        public string ReaderIImage { get; set; }    // במקור בדיאגרמה רשום IImage
        public int CityId { get; set; }
        public int ReaderTypeId { get; set; }
        public string ReaderNickName { get; set; }
        public string ReaderPassword { get; set; }
    }

}
