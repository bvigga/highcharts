﻿// Type: Highsoft.Web.Mvc.Stocks.ArearangeSeriesStatesHover


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class ArearangeSeriesStatesHover : BaseObject
    {
        public ArearangeSeriesStatesHover()
        {
            bool? nullable1 = new bool?(true);
            this.Enabled_DefaultValue = nullable1;
            this.Enabled = nullable1;
            this.Halo = this.Halo_DefaultValue = new ArearangeSeriesStatesHoverHalo();
            double? nullable2 = new double?(2.0);
            this.LineWidth_DefaultValue = nullable2;
            this.LineWidth = nullable2;
            nullable2 = new double?(1.0);
            this.LineWidthPlus_DefaultValue = nullable2;
            this.LineWidthPlus = nullable2;
        }

        public bool? Enabled { get; set; }

        private bool? Enabled_DefaultValue { get; set; }

        public ArearangeSeriesStatesHoverHalo Halo { get; set; }

        private ArearangeSeriesStatesHoverHalo Halo_DefaultValue { get; set; }

        public double? LineWidth { get; set; }

        private double? LineWidth_DefaultValue { get; set; }

        public double? LineWidthPlus { get; set; }

        private double? LineWidthPlus_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            bool? enabled = this.Enabled;
            bool? enabledDefaultValue = this.Enabled_DefaultValue;
            if (enabled.GetValueOrDefault() != enabledDefaultValue.GetValueOrDefault() ||
                enabled.HasValue != enabledDefaultValue.HasValue)
                hashtable.Add((object) "enabled", (object) this.Enabled);
            if (this.Halo.IsDirty())
                hashtable.Add((object) "halo", (object) this.Halo.ToHashtable());
            double? nullable1 = this.LineWidth;
            double? nullable2 = this.LineWidth_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "lineWidth", (object) this.LineWidth);
            nullable2 = this.LineWidthPlus;
            nullable1 = this.LineWidthPlus_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "lineWidthPlus", (object) this.LineWidthPlus);
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