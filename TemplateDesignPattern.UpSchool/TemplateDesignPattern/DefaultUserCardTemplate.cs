using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TemplateDesignPattern.UpSchool.TemplateDesignPattern
{
    public class DefaultUserCardTemplate : UserCardTemplate
    {
        protected override string SetFooter()
        {
            return string.Empty;
        }

        protected override string SetImage()
        {
            return "<img class='card-img-top' src='../images/user.png' style='width:50px; height:50px;'>";
        }

        protected override string SetScore()
        {
            return string.Empty;
        }
    }
}
