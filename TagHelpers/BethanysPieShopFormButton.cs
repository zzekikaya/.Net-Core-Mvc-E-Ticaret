﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CoreWebApp.TagHelpers
{
    [HtmlTargetElement("bethanysbutton")]
    public class CoreWebAppFormButton : TagHelper
    {
        public string Content { get; set; }

        public string ButtonStyle { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);

            output.TagName = "button";
            output.Attributes.SetAttribute("type", "submit");
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.SetAttribute("class", $"btn btn-{ButtonStyle}");
            output.Content.SetContent(Content);
        }
    }
}
