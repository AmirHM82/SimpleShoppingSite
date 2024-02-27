using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShoppingSite.Models
{
    public class Product : BaseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime PostDate { get; set; }
        public int Price { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsHidden { get; set; }
        public string ImageName { get; set; }
    }
}
