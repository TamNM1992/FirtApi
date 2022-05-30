﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MT.Common.Enums;
using MT.Service.AuthorityServices;
using MT.WebAPI.Providers;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace MT.WebAPI.Attributes
{
    public class RoleAttribute : Attribute, IActionFilter
    {
        public Role[] Roles { get; set; }
        public RoleAttribute(params Role[] roles)
        {
            Roles = roles;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // giải thích chút, em không thể khởi tạo service thông qua contructor như bình thường được, vì lúc dùng em sẽ ko dùng dc nó
            // Nên mình phải tạo ra 1 cái là provider, cái này cũng là 1 cách để lấy service đã được khởi tạo ra dùng
            // bên cạnh cách dùng contructor
            // giờ đi đăng kí nữa là ok
            var httpContext = (IHttpContextAccessor)StaticServiceProvider.Provider.GetService(typeof(IHttpContextAccessor));
            var authorityService = (IAuthorityService)httpContext.HttpContext.RequestServices.GetService(typeof(IAuthorityService));

            // bước này lấy token
            Microsoft.Extensions.Primitives.StringValues authTokens;
            context.HttpContext.Request.Headers.TryGetValue("Authorization", out authTokens);
            var _token = authTokens.FirstOrDefault().Replace("Bearer ", "");
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(_token);
            Guid userId = Guid.Empty;
            Guid.TryParse(jwtSecurityToken.Claims.FirstOrDefault(x => x.Type == "id").Value, out userId);

            var isCheked = authorityService.CheckUserRole(Roles, userId);

            if (!isCheked)
            {
                context.Result = new JsonResult("NoPermission")
                {
                    StatusCode = 405,
                    Value = new
                    {
                        Status = "Error",
                        Message = "Sorry, You don't have permission for the acction."
                    },
                };
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("OnActionExecuted");
        }
    }
}
