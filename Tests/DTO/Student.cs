using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Interfaces;

namespace Tests.DTO
{
    internal class Student: IStudy
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public bool HomeTask(List<string> hometasks)
        {
           foreach(string s in hometasks)
           {
                if (s == "no")
                    return false;
               // lfkglfklg
                //    dkjfkdjfk
           }
            return true;
        }

        public bool SchoolTshirt()
        {
            throw new NotImplementedException();
        }
    }
}
