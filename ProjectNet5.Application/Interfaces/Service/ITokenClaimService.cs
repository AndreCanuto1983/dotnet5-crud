﻿using Core.Models.Base;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface ITokenClaimService
    {
        Task<string> GenerateJwtClaims(string email, UserManager<UserModel> userManager, AppSettings appSettings);        
    }
}
