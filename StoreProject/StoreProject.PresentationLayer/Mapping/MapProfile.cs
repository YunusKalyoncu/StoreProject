using AutoMapper;
using StoreProject.DTOLayer.AppUserDtos;
using StoreProject.DTOLayer.CategoryDtos;
using StoreProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreProject.PresentationLayer.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<AppUserRegisterDtos, AppUser>();
            CreateMap<AppUser, AppUserRegisterDtos>();
            CreateMap<CreateCategoryDto, Category>(); //Çift yazmadan yapılabilir.
            CreateMap<Category, CreateCategoryDto>(); //Çift yazmadan yapılabilir.

        }
    }
}
