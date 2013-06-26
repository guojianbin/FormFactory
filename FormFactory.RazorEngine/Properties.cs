﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace FormFactory.RazorEngine
{
    public class Properties
    {
        public static IEnumerable<PropertyVm<RazorTemplateHtmlHelper>> For(object target)
        {
            return new RazorTemplateHtmlHelper().PropertiesFor(target, target.GetType());
        }
    }
}