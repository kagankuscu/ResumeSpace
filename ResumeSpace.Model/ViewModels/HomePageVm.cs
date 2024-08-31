using ResumeSpace.Model.Dtos.QuoteDto;
using ResumeSpace.Model.Dtos.ResumesDto;
using ResumeSpace.Model.Models;

namespace ResumeSpace.Model.ViewModels
{
    public class HomePageVm
    {
        public ResumeForGetWithDetailsDto? Resume { get; set; }
        public QuoteForGetDto? Quote { get; set; }
        public List<Blog> Blogs { get; set; } = [];
    }
}
