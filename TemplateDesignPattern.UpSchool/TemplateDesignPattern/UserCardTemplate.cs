using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateDesignPattern.UpSchool.DAL.Entities;

namespace TemplateDesignPattern.UpSchool.TemplateDesignPattern
{
    public abstract class UserCardTemplate
    {
        protected AppUser AppUser { get; set; }

        public void SetUser(AppUser appUser)
        {
            AppUser = appUser;
        }

        protected abstract string SetImage();

        protected abstract string SetFooter();

        protected abstract string SetScore();

        public string Build()
        {
            var sb =new  StringBuilder();

            sb.Append("<div class='card'>");
            sb.Append("<div class='row'><div class='col-md-6'>");
            sb.Append(SetImage());
            sb.Append("</div><div class='col-md-5 text-right mt-3' style='color:blue'>");
            sb.Append(SetScore());
            sb.Append("</div></div>");
            sb.Append($@"<div class='card-body'>
                        <h5>{AppUser.UserName}</h5>
                        <p>{AppUser.Description}</p>");
            sb.Append(SetFooter());
            sb.Append("</div>");
            sb.Append("</div>");
            return sb.ToString();
        }
    }
}
