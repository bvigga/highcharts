﻿// Type: Highsoft.Web.Mvc.Stocks.YAxisLabels


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class YAxisLabels : BaseObject
    {
        public YAxisLabelsAlign Align { get; set; }

        private YAxisLabelsAlign Align_DefaultValue { get; set; }

        public List<double> AutoRotation { get; set; }

        private List<double> AutoRotation_DefaultValue { get; set; }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public string Format { get; set; }

        private string Format_DefaultValue { get; set; }

        public string Formatter { get; set; }

        private string Formatter_DefaultValue { get; set; }

        public double? Rotation { get; set; }

        private double? Rotation_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

        public bool? UseHTML { get; set; }

        private bool? UseHTML_DefaultValue { get; set; }

        public double? X { get; set; }

        private double? X_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        public double? ZIndex { get; set; }

        private double? ZIndex_DefaultValue { get; set; }

        public YAxisLabels()
        {
            this.Align = this.Align_DefaultValue = YAxisLabelsAlign.Left;
            this.AutoRotation = this.AutoRotation_DefaultValue = new List<double>()
            {
                -45.0
            };
            bool? nullable1 = new bool?(true);
            this.Enabled_DefaultValue = nullable1;
            this.Enabled = nullable1;
            this.Format = this.Format_DefaultValue = "{value}";
            this.Formatter = this.Formatter_DefaultValue = "";
            double? nullable2 = new double?(0.0);
            this.Rotation_DefaultValue = nullable2;
            this.Rotation = nullable2;
            this.Style = this.Style_DefaultValue = new Hashtable()
            {
                {
                    (object) "color",
                    (object) "#666666"
                },
                {
                    (object) "cursor",
                    (object) "default"
                },
                {
                    (object) "fontSize",
                    (object) "11px"
                }
            };
            nullable1 = new bool?(false);
            this.UseHTML_DefaultValue = nullable1;
            this.UseHTML = nullable1;
            nullable2 = new double?(0.0);
            this.X_DefaultValue = nullable2;
            this.X = nullable2;
            nullable2 = new double?(-2.0);
            this.Y_DefaultValue = nullable2;
            this.Y = nullable2;
            nullable2 = new double?(7.0);
            this.ZIndex_DefaultValue = nullable2;
            this.ZIndex = nullable2;
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Align != this.Align_DefaultValue)
                hashtable.Add((object) "align", (object) Highstock.FirstCharacterToLower(this.Align.ToString()));
            if (this.AutoRotation != this.AutoRotation_DefaultValue)
                hashtable.Add((object) "autoRotation", (object) this.AutoRotation);
            bool? nullable1 = this.Enabled;
            bool? nullable2 = this.Enabled_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            if (this.Format != this.Format_DefaultValue)
                hashtable.Add((object) "format", (object) this.Format);
            if (this.Formatter != this.Formatter_DefaultValue)
            {
                hashtable.Add((object) "formatter", (object) this.Formatter);
                Highstock.AddFunction("YAxisLabelsFormatter.formatter", this.Formatter);
            }
            double? nullable3 = this.Rotation;
            double? nullable4 = this.Rotation_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "rotation", (object) this.Rotation);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
            nullable2 = this.UseHTML;
            nullable1 = this.UseHTML_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "useHTML", (object) this.UseHTML);
            nullable4 = this.X;
            nullable3 = this.X_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "x", (object) this.X);
            nullable3 = this.Y;
            nullable4 = this.Y_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "y", (object) this.Y);
            nullable4 = this.ZIndex;
            nullable3 = this.ZIndex_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "zIndex", (object) this.ZIndex);
            return hashtable;
        }

        internal override string ToJSON()
        {
            if (this.ToHashtable().Count > 0)
                return JsonConvert.SerializeObject((object) this.ToHashtable());
            return "";
        }

        internal override bool IsDirty()
        {
            return this.ToHashtable().Count > 0;
        }
    }
}