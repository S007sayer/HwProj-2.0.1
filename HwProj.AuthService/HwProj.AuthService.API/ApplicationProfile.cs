﻿using AutoMapper;
using HwProj.AuthService.API.Models;
using HwProj.Models.AuthService.DTO;
using HwProj.Models.AuthService.ViewModels;

namespace HwProj.AuthService.API
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<RegisterDataDTO, User>();
            CreateMap<EditAccountViewModel, EditDataDTO>();
            CreateMap<RegisterViewModel, RegisterDataDTO>();
        }
    }
}
