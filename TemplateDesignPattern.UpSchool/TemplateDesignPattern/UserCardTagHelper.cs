using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateDesignPattern.UpSchool.DAL.Entities;

namespace TemplateDesignPattern.UpSchool.TemplateDesignPattern
{
    public class UserCardTagHelper:TagHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<AppUser> _userManager;

        public UserCardTagHelper(IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        public AppUser AppUser { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            UserCardTemplate userCardTemplate;

            var user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);

            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                if (user.EmailConfirmed==true)
                {
                    userCardTemplate = new PremiumCardTemplate();

                }
                else
                {
                    userCardTemplate = new GoldUserCardTemplate();

                }
            }
            else
            {
                userCardTemplate = new DefaultUserCardTemplate();
            }
            userCardTemplate.SetUser(AppUser);
            output.Content.SetHtmlContent(userCardTemplate.Build());
        }

    }
}
