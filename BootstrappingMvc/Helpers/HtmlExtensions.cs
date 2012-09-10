using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Script.Serialization;

namespace BootstrappingMvc.Helpers
{
    public static partial class HtmlExtensions
    {
        // from John Landheer: http://stackoverflow.com/users/66873/john-landheer
        public static MvcHtmlString ClientIdFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression)
        {
            return MvcHtmlString.Create(htmlHelper.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldId(ExpressionHelper.GetExpressionText(expression)));
        }


        // from Ben Foster: http://ben.onfabrik.com/posts/aspnet-mvc-helper-for-twitter-bootstraps-typeahead-plugin
        public static MvcHtmlString TypeaheadFor<TModel, TValue>(
                this HtmlHelper<TModel> htmlHelper,
                Expression<Func<TModel, TValue>> expression,
                IEnumerable<string> source,
                int items = 8)
        {
            if (expression == null)
                throw new ArgumentNullException("expression");

            if (source == null)
                throw new ArgumentNullException("source");

            var jsonString = new JavaScriptSerializer().Serialize(source);

            return htmlHelper.TextBoxFor(
                expression,
                new
                {
                    autocomplete = "off",
                    data_provide = "typeahead",
                    data_items = items,
                    data_source = jsonString
                }
            );
        }

    }
}