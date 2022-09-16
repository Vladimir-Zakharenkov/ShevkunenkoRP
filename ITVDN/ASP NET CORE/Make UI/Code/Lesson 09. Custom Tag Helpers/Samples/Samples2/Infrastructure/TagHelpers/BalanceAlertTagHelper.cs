using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace TagHelperSample.Infrastructure.TagHelpers
{
    // tag helper будет применяться к элементам td с атрибутом balance-alert
    [HtmlTargetElement("td", Attributes = "balance-alert", ParentTag = "tr")]
    public class BalanceAlertTagHelper : TagHelper
    {
        // Так как при генерации результата будет использоваться асинхронный метод, используется асинхронный вариант метода Process
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            // получение контента элемента, для которого применяется вспомогательный класс
            string content = (await output.GetChildContentAsync()).GetContent();

            if (double.TryParse(content, out double result))
            {
                if(result < 0)
                {
                    output.Attributes.SetAttribute("class", "alert");
                }
            }
        }
    }
}
