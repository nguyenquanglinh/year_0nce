﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public class RegexTextBox : TextBox
    {
        [NonSerialized]
        string lastText;

        /// <summary>A regular expression governing the input allowed in this text field.</summary>
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual Regex Regex { get; set; }

        /// <summary>A regular expression governing the input allowed in this text field.</summary>
        [DefaultValue(null)]
        [Category("Behavior")]
        [Description("Sets the regular expression governing the input allowed for this control.")]
        public virtual string RegexString
        {
            get
            {
                return Regex == null ? string.Empty : Regex.ToString();
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Regex = null;
                else
                    Regex = new Regex(value);
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (Regex != null && !Regex.IsMatch(Text))
            {
                int pos = SelectionStart - Text.Length + (lastText ?? string.Empty).Length;
                Text = lastText;
                SelectionStart = Math.Max(0, pos);
            }

            lastText = Text;

            base.OnTextChanged(e);
        }
    }
}
