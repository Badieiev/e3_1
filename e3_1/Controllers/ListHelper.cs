using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace e3_1.Controllers
{
    public static class ListHelper
    {
        public static MvcHtmlString CreateOrderedList(this HtmlHelper html, List<string> items)
        {
            var ol = new TagBuilder("ol");
            foreach (var item in items)
            {
                var li = new TagBuilder("li");
                li.SetInnerText(item);
                ol.InnerHtml += li.ToString();
            }
            return new MvcHtmlString(ol.ToString());
        }
    }
}