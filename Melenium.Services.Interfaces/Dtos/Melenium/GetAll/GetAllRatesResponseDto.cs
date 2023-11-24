using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeleniumBank.Services.Interfaces.Dtos.Melenium.GetAll
{
    public class GetAllRatesResponseDto
    {
        public GetAllRatesResponseDto(List<Item> items)
        {
            Items = items;
        }

       public List<Item> Items { get; set; }
    }
}
