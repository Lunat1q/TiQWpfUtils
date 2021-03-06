﻿using System;

namespace TiqUtils.Wpf.AbstractClasses.Attributes
{
    public abstract class LabelNameAttributeBase : Attribute
    {
        public abstract string GetProperText();

        protected LabelNameAttributeBase(string label)
        {
            Label = label;
        }

        public string Label { get; }
    }
}
