using SE.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE.Library.Services
{
    public class LibraryService
    {
        public IEnumerable<Member> GetAllMembers()
        {
            return new List<Member> {
                new Member { FirstName ="An", LastName="Nguyễn", Id= Guid.NewGuid() },
                new Member { FirstName ="Linh", LastName="Trần", Id= Guid.NewGuid() },
                new Member { FirstName ="Tuấn", LastName="Đỗ", Id= Guid.NewGuid() }
            };
        }
    }
}
