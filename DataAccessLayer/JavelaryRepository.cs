using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class JavelaryRepository : IJavelaryRepository
    {
        private readonly JaveLaryContext _ctx;
        public JavelaryRepository()
        {
            _ctx = new JaveLaryContext();
        }
        public void Create(Jevellery model)
        {
            _ctx.Jevelleries.Add(model);
            _ctx.SaveChanges();
        }
    }
}
