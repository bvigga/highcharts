﻿// Type: Highsoft.Web.Mvc.Charts.Title


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class Title : BaseObject
    {
        public Title()
        {
            this.Align = this.Align_DefaultValue = TitleAlign.Center;
            bool? nullable1 = new bool?(false);
            this.Floating_DefaultValue = nullable1;
            this.Floating = nullable1;
            double? nullable2 = new double?();
            this.Margin_DefaultValue = nullable2;
            this.Margin = nullable2;
            this.Style = this.Style_DefaultValue = new Hashtable()
            {
                {
                    (object) "color",
                    (object) "#333333"
                },
                {
                    (object) "fontSize",
                    (object) "18px"
                }
            };
            this.Text = this.Text_DefaultValue = "Chart title";
            nullable1 = new bool?(false);
            this.UseHTML_DefaultValue = nullable1;
            this.UseHTML = nullable1;
            this.VerticalAlign = this.VerticalAlign_DefaultValue = TitleVerticalAlign.Null;
            nullable2 = new double?(-44.0);
            this.WidthAdjust_DefaultValue = nullable2;
            this.WidthAdjust = nullable2;
            nullable2 = new double?(0.0);
            this.X_DefaultValue = nullable2;
            this.X = nullable2;
            double? nullable3 = new double?();
            this.Y_DefaultValue = nullable3;
            this.Y = nullable3;
        }

        public TitleAlign Align { get; set; }

        private TitleAlign Align_DefaultValue { get; set; }

        public bool? Floating { get; set; }

        private bool? Floating_DefaultValue { get; set; }

        public double? Margin { get; set; }

        private double? Margin_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

        public string Text { get; set; }

        private string Text_DefaultValue { get; set; }

        public bool? UseHTML { get; set; }

        private bool? UseHTML_DefaultValue { get; set; }

        public TitleVerticalAlign VerticalAlign { get; set; }

        private TitleVerticalAlign VerticalAlign_DefaultValue { get; set; }

        public double? WidthAdjust { get; set; }

        private double? WidthAdjust_DefaultValue { get; set; }

        public double? X { get; set; }

        private double? X_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Align != this.Align_DefaultValue)
                hashtable.Add((object) "align", (object) Highcharts.FirstCharacterToLower(this.Align.ToString()));
            bool? nullable1 = this.Floating;
            bool? nullable2 = this.Floating_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "floating", (object) this.Floating);
            double? nullable3 = this.Margin;
            double? nullable4 = this.Margin_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "margin", (object) this.Margin);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
            if (this.Text != this.Text_DefaultValue)
                hashtable.Add((object) "text", (object) this.Text);
            nullable2 = this.UseHTML;
            nullable1 = this.UseHTML_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "useHTML", (object) this.UseHTML);
            if (this.VerticalAlign != this.VerticalAlign_DefaultValue)
                hashtable.Add((object) "verticalAlign",
                    (object) Highcharts.FirstCharacterToLower(this.VerticalAlign.ToString()));
            nullable4 = this.WidthAdjust;
            nullable3 = this.WidthAdjust_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "widthAdjust", (object) this.WidthAdjust);
            nullable3 = this.X;
            nullable4 = this.X_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "x", (object) this.X);
            nullable4 = this.Y;
            nullable3 = this.Y_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "y", (object) this.Y);
            return hashtable;
        }

        internal override string ToJSON()
        {
            Hashtable hashtable = this.ToHashtable();


            if (hashtable.Count > 0)
                return JsonConvert.SerializeObject((object) this.ToHashtable());
            return "";
        }

        internal override bool IsDirty()
        {
            return this.ToHashtable().Count > 0;
        }
    }
}