using BussinesLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
   public class jeveleryControler : IJeveleryControler
    {
        private readonly IJavelaryServis _javelaryServis;
        public jeveleryControler()
        {
            _javelaryServis = new JavelaryServis();
        }
        public void Create(JevelleryViewModel model)
        {
            var jevellerymodel = new JavelaryModel
            {
                Name = "Igor",
                Price = 1999,
                ManufactoryModel = new ManufactoryModel
                {
                    CountryId = 1,
                    Name = "Igor and co.",
                    LicenseNumber = 02194023948923084,
                },
                Gemstones = new List<GemstoneModel>()

            };
            _javelaryServis.Create(jevellerymodel);
        }
    }
}
