using HospitalPersonnelSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HospitalPersonnelSystem.TagHelpers
{
    [HtmlTargetElement(SelectTagName)]
    public class SelectExTagHelper : TagHelper
    {
        /// <summary>
        /// 标记名称
        /// </summary>
        private const string SelectTagName = "gt-select";
        private const string ForAttributeName = "asp-for";
        private const string ItemsAttributeName = "asp-items";
        /// <summary>
        /// 控件
        /// </summary>
        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression For { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        [HtmlAttributeName(ItemsAttributeName)]
        //public IEnumerable<SelectListItem> Items { get; set; }
        public IEnumerable<GTSharp.SelectListItemEx> Items { get; set; }
        /// <summary>
        /// 不清楚
        /// </summary>
        [ViewContext]
        public ViewContext ViewContext { get; set; }
        /// <summary>
        /// 
        /// </summary>
        protected IHtmlGenerator Generator { get; }
        public SelectExTagHelper(IHtmlGenerator generator)
        {
            Generator = generator;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //获取绑定的生成的Name属性
            string inputName = ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(For?.Name);
            output.TagName = "select";
            //标记模式
            //output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.Add("id", inputName);
            output.Attributes.Add("name", inputName);
            output.Attributes.Add("data-live-search", "true");
            output.Attributes.Add("class", "form-control selectpicker");
            foreach (var item in Items)
            {
                // TagBuilder帮助创建具有属性的html元素
                var option = new TagBuilder("option");
                option.Attributes["value"] = item.Value;
                option.Attributes["data-tokens"] = item.Spell;
                //option.TagRenderMode = TagRenderMode.SelfClosing;
                option.InnerHtml.Append(item.Text);
                output.Content.AppendHtml(option);
            }
        }
    }
}
