using BusinessManagementApp.Common;
using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.Common.Interfaces;
using BussinesManagementApp.Dtos;
using BussinessManagementApp.DataAccess.Constants;
using BussinessManagementApp.Entities.IdentityEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Services
{
    public class IdentityService
    {
        readonly UserManager<AppUser> _userManager;
        readonly SignInManager<AppUser> _signInManager;

        public IdentityService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<IResponse<AppUserLoginModel>> LoginCheck(AppUserLoginModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user is not null)
            {
                var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, true);

                if (result.IsLockedOut)
                {
                    var date = await _userManager.GetLockoutEndDateAsync(user); // türkiye utc 3 saat zamanı eklendi.
                    return new Response<AppUserLoginModel>(ResponseType.Error, $"Hesabınız {date.Value.AddHours(3)} tarihine kadar kitlenmiştir ", model);
                }
                else if (result.Succeeded)
                {
                    return new Response<AppUserLoginModel>(ResponseType.Success, model);

                }
                return new Response<AppUserLoginModel>(ResponseType.Error,
                    $"Şifre yanlış, tekrar giriniz . Kalan deneme hakkı :{ IdentityDbOptionsConstant.MaxFailedAccessAttempts - await _userManager.GetAccessFailedCountAsync(user)}", model);
            }
            return new Response<AppUserLoginModel>(ResponseType.NotFound, "İlgili kullanıcıya ait bir hesap bulunmamaktadır.", model);
        }
    }
}
