using ArticleProject.Entities.Concrete;
using ArticleProject.Entities.DataTransferObject;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleProject.CrossCuttingConcerns.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Article, ArticleForSaveDto>()
                .ForMember(a => a.ReleaseDate, dest => dest.MapFrom(src => src.ReleaseDate.ToString("dd MMMM yyyy")));

            CreateMap<ArticleForSaveDto, Article>()
                .ForMember(a => a.ReleaseDate, dest => dest.MapFrom(src => DateTime.Parse(src.ReleaseDate)));

            CreateMap<Article, ArticleForListDto>()
                .ForMember(a => a.ReleaseDate, dest => dest.MapFrom(src => src.ReleaseDate.ToString("dd MMMM yyyy")));
        }
    }
}
