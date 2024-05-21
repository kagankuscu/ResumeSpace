using KaganKuscu.Model.Dtos;
using KaganKuscu.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaganKuscu.Model.ViewModels
{
    public class HomePageVm
    {
        public PersonForGetDto? Person { get; set; }
        public Quote? Quote { get; set; }
        public List<Blog> Blogs { get; set; } = new List<Blog>();
    }
}
