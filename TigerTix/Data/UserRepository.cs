using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TigerTix.Data
{
    public class UserRepository
    {
        private readonly TigerTixContext _context;
        public UserRepository(TigerTixContext context)
        {
            _context = context;
        }

    }

}
