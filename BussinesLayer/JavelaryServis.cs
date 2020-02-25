using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
    public class JavelaryServis : IJavelaryServis
    {
        private readonly IJavelaryRepository _javelaryRepository;
        public JavelaryServis()
        {
            _javelaryRepository = new JavelaryRepository();

        }
        public void Create(JavelaryModel model)
        {
            var javelory = new Jevellery
            {
                Name = model.Name,
                Price = model.Price,

                Gemstones = model.Gemstones.Select(x => new Gemstone
                {
                    Color = x.Color,
                    Name = x.Name,
                    GemstoneTypeId = (int)x.Type,
                    Price = x.Price
                }).ToList()
            };
            _javelaryRepository.Create(javelory);
    }   
    }
}
