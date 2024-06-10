﻿using KaganKuscu.Model.Dtos.QuoteDto;
using KaganKuscu.Model.Dtos.ResumesDto;
using KaganKuscu.Model.Models;

namespace KaganKuscu.Model.ViewModels
{
    public class HomePageVm
    {
        public ResumeForGetWithDetailsDto? Resume { get; set; }
        public QuoteForGetDto? Quote { get; set; }
        public List<Blog> Blogs { get; set; } = [];
    }
}
