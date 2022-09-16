using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ReplaceElement.Infrastructure.TagHelpers
{
    // formbutton - сокращающий элемент, при визуализации представления он будет заменен на более сложную HTML разметку
    // Если название элемента для вспомогательного класса не соответствует стандартному HTML элементу, перед классом нужно обязательно установить
    // атрибут HtmlTargetElement с именем элемента.
    [HtmlTargetElement("formbutton", ParentTag = "form")]
    public class FormButtonTagHelper : TagHelper
    {
        public string Type { get; set; } = "submit";
        public string MyButtonColor { get; set; } = "blue";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "button";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.SetAttribute("type", Type);
            output.Attributes.SetAttribute("class", $"my-btn my-btn-{MyButtonColor}");
            output.Content.SetContent(Type == "submit" ? "Add" : "Reset");
        }
    }
}
