using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ScopeTagHelperSample.Infrastructure.TagHelpers
{
    // Данный дескрипторный вспомогательный класс будет использоваться для элементов button
    // при этом эти элементы должны содержать атрибут my-button-color, их родителем должен быть элемент body и это должны быть элементы
    // со струкутрой <element></element> или <element />
    [HtmlTargetElement("button", Attributes = "my-button-color", ParentTag = "body", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class ButtonTagHelper : TagHelper
    {
        public string MyButtonColor { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", $"my-btn my-btn-{MyButtonColor}");
        }
    }
}

