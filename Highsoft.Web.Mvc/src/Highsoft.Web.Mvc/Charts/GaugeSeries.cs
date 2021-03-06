﻿// Type: Highsoft.Web.Mvc.Charts.GaugeSeries


using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class GaugeSeries : Series
    {
        public GaugeSeries()
        {
            this.Animation = this.Animation_DefaultValue = new Animation()
            {
                Enabled = true
            };
            double? nullable1 = new double?();
            this.AnimationLimit_DefaultValue = nullable1;
            this.AnimationLimit = nullable1;
            this.ClassName = this.ClassName_DefaultValue = "";
            this.Color = this.Color_DefaultValue = (string) null;
            double? nullable2 = new double?();
            this.ColorIndex_DefaultValue = nullable2;
            this.ColorIndex = nullable2;
            this.Cursor = this.Cursor_DefaultValue = GaugeSeriesCursor.Null;
            this.Data = this.Data_DefaultValue = new List<GaugeSeriesData>();
            this.DataLabels = this.DataLabels_DefaultValue = new GaugeSeriesDataLabels();
            this.Description = this.Description_DefaultValue = "undefined";
            this.Dial = this.Dial_DefaultValue = new GaugeSeriesDial();
            bool? nullable3 = new bool?(true);
            this.EnableMouseTracking_DefaultValue = nullable3;
            this.EnableMouseTracking = nullable3;
            this.Events = this.Events_DefaultValue = new GaugeSeriesEvents();
            nullable3 = new bool?(false);
            this.GetExtremesFromAll_DefaultValue = nullable3;
            this.GetExtremesFromAll = nullable3;
            this.Id = this.Id_DefaultValue = "";
            double? nullable4 = new double?();
            this.Index_DefaultValue = nullable4;
            this.Index = nullable4;
            this.Keys = this.Keys_DefaultValue = new List<string>();
            double? nullable5 = new double?();
            this.LegendIndex_DefaultValue = nullable5;
            this.LegendIndex = nullable5;
            this.LinkedTo = this.LinkedTo_DefaultValue = "";
            this.Name = this.Name_DefaultValue = (string) null;
            this.NegativeColor = this.NegativeColor_DefaultValue = "null";
            nullable5 = new double?(0.0);
            this.Overshoot_DefaultValue = nullable5;
            this.Overshoot = nullable5;
            this.Pivot = this.Pivot_DefaultValue = new GaugeSeriesPivot();
            this.Point = this.Point_DefaultValue = new GaugeSeriesPoint();
            nullable3 = new bool?(false);
            this.Selected_DefaultValue = nullable3;
            this.Selected = nullable3;
            nullable3 = new bool?(false);
            this.ShowCheckbox_DefaultValue = nullable3;
            this.ShowCheckbox = nullable3;
            bool? nullable6 = new bool?();
            this.ShowInLegend_DefaultValue = nullable6;
            this.ShowInLegend = nullable6;
            nullable6 = new bool?(true);
            this.StickyTracking_DefaultValue = nullable6;
            this.StickyTracking = nullable6;
            nullable5 = new double?(0.0);
            this.Threshold_DefaultValue = nullable5;
            this.Threshold = nullable5;
            this.Tooltip = this.Tooltip_DefaultValue = new GaugeSeriesTooltip();
            this.Type = this.Type_DefaultValue = GaugeSeriesType.Null;
            nullable6 = new bool?(true);
            this.Visible_DefaultValue = nullable6;
            this.Visible = nullable6;
            nullable6 = new bool?(true);
            this.Wrap_DefaultValue = nullable6;
            this.Wrap = nullable6;
            this.XAxis = this.XAxis_DefaultValue = "0";
            this.YAxis = this.YAxis_DefaultValue = "0";
            double? nullable7 = new double?();
            this.ZIndex_DefaultValue = nullable7;
            this.ZIndex = nullable7;
        }

        public Animation Animation { get; set; }

        private Animation Animation_DefaultValue { get; set; }

        public double? AnimationLimit { get; set; }

        private double? AnimationLimit_DefaultValue { get; set; }

        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public double? ColorIndex { get; set; }

        private double? ColorIndex_DefaultValue { get; set; }

        public GaugeSeriesCursor Cursor { get; set; }

        private GaugeSeriesCursor Cursor_DefaultValue { get; set; }

        public List<GaugeSeriesData> Data { get; set; }

        private List<GaugeSeriesData> Data_DefaultValue { get; set; }

        public GaugeSeriesDataLabels DataLabels { get; set; }

        private GaugeSeriesDataLabels DataLabels_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public GaugeSeriesDial Dial { get; set; }

        private GaugeSeriesDial Dial_DefaultValue { get; set; }

        public bool? EnableMouseTracking { get; set; }

        private bool? EnableMouseTracking_DefaultValue { get; set; }

        public GaugeSeriesEvents Events { get; set; }

        private GaugeSeriesEvents Events_DefaultValue { get; set; }

        public bool? GetExtremesFromAll { get; set; }

        private bool? GetExtremesFromAll_DefaultValue { get; set; }

        public new string Id { get; set; }

        private string Id_DefaultValue { get; set; }

        public new double? Index { get; set; }

        private double? Index_DefaultValue { get; set; }

        public List<string> Keys { get; set; }

        private List<string> Keys_DefaultValue { get; set; }

        public new double? LegendIndex { get; set; }

        private double? LegendIndex_DefaultValue { get; set; }

        public string LinkedTo { get; set; }

        private string LinkedTo_DefaultValue { get; set; }

        public new string Name { get; set; }

        private string Name_DefaultValue { get; set; }

        public string NegativeColor { get; set; }

        private string NegativeColor_DefaultValue { get; set; }

        public double? Overshoot { get; set; }

        private double? Overshoot_DefaultValue { get; set; }

        public GaugeSeriesPivot Pivot { get; set; }

        private GaugeSeriesPivot Pivot_DefaultValue { get; set; }

        public GaugeSeriesPoint Point { get; set; }

        private GaugeSeriesPoint Point_DefaultValue { get; set; }

        public bool? Selected { get; set; }

        private bool? Selected_DefaultValue { get; set; }

        public bool? ShowCheckbox { get; set; }

        private bool? ShowCheckbox_DefaultValue { get; set; }

        public bool? ShowInLegend { get; set; }

        private bool? ShowInLegend_DefaultValue { get; set; }

        public bool? StickyTracking { get; set; }

        private bool? StickyTracking_DefaultValue { get; set; }

        public double? Threshold { get; set; }

        private double? Threshold_DefaultValue { get; set; }

        public GaugeSeriesTooltip Tooltip { get; set; }

        private GaugeSeriesTooltip Tooltip_DefaultValue { get; set; }

        public GaugeSeriesType Type { get; set; }

        private GaugeSeriesType Type_DefaultValue { get; set; }

        public bool? Visible { get; set; }

        private bool? Visible_DefaultValue { get; set; }

        public bool? Wrap { get; set; }

        private bool? Wrap_DefaultValue { get; set; }

        public new string XAxis { get; set; }

        private string XAxis_DefaultValue { get; set; }

        public new string YAxis { get; set; }

        private string YAxis_DefaultValue { get; set; }

        public new double? ZIndex { get; set; }

        private double? ZIndex_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Animation.IsDirty())
                hashtable.Add((object) "animation", (object) this.Animation.ToJSON());
            double? nullable1 = this.AnimationLimit;
            double? nullable2 = this.AnimationLimit_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "animationLimit", (object) this.AnimationLimit);
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            nullable2 = this.ColorIndex;
            nullable1 = this.ColorIndex_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "colorIndex", (object) this.ColorIndex);
            if (this.Cursor != this.Cursor_DefaultValue)
                hashtable.Add((object) "cursor", (object) Highcharts.FirstCharacterToLower(this.Cursor.ToString()));
            if (this.Data.Any<GaugeSeriesData>())
                hashtable.Add((object) "data", (object) this.HashifyList((IEnumerable) this.Data));
            if (this.DataLabels.IsDirty())
                hashtable.Add((object) "dataLabels", (object) this.DataLabels.ToHashtable());
            if (this.Description != this.Description_DefaultValue)
                hashtable.Add((object) "description", (object) this.Description);
            if (this.Dial.IsDirty())
                hashtable.Add((object) "dial", (object) this.Dial.ToHashtable());
            bool? nullable3 = this.EnableMouseTracking;
            bool? nullable4 = this.EnableMouseTracking_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "enableMouseTracking", (object) this.EnableMouseTracking);
            if (this.Events.IsDirty())
                hashtable.Add((object) "events", (object) this.Events.ToHashtable());
            nullable4 = this.GetExtremesFromAll;
            nullable3 = this.GetExtremesFromAll_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "getExtremesFromAll", (object) this.GetExtremesFromAll);
            if (this.Id != this.Id_DefaultValue)
                hashtable.Add((object) "id", (object) this.Id);
            nullable1 = this.Index;
            nullable2 = this.Index_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "index", (object) this.Index);
            if (this.Keys != this.Keys_DefaultValue)
                hashtable.Add((object) "keys", (object) this.Keys);
            nullable2 = this.LegendIndex;
            nullable1 = this.LegendIndex_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
            if (this.LinkedTo != this.LinkedTo_DefaultValue)
                hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
            if (this.Name != this.Name_DefaultValue)
                hashtable.Add((object) "name", (object) this.Name);
            if (this.NegativeColor != this.NegativeColor_DefaultValue)
                hashtable.Add((object) "negativeColor", (object) this.NegativeColor);
            nullable1 = this.Overshoot;
            nullable2 = this.Overshoot_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "overshoot", (object) this.Overshoot);
            if (this.Pivot.IsDirty())
                hashtable.Add((object) "pivot", (object) this.Pivot.ToHashtable());
            if (this.Point.IsDirty())
                hashtable.Add((object) "point", (object) this.Point.ToHashtable());
            nullable3 = this.Selected;
            nullable4 = this.Selected_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "selected", (object) this.Selected);
            nullable4 = this.ShowCheckbox;
            nullable3 = this.ShowCheckbox_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "showCheckbox", (object) this.ShowCheckbox);
            nullable3 = this.ShowInLegend;
            nullable4 = this.ShowInLegend_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "showInLegend", (object) this.ShowInLegend);
            nullable4 = this.StickyTracking;
            nullable3 = this.StickyTracking_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
            nullable2 = this.Threshold;
            nullable1 = this.Threshold_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "threshold", (object) this.Threshold);
            if (this.Tooltip.IsDirty())
                hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
            if (this.Type != this.Type_DefaultValue)
                hashtable.Add((object) "type", (object) Highcharts.FirstCharacterToLower(this.Type.ToString()));
            nullable3 = this.Visible;
            nullable4 = this.Visible_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "visible", (object) this.Visible);
            nullable4 = this.Wrap;
            nullable3 = this.Wrap_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "wrap", (object) this.Wrap);
            if (this.XAxis != this.XAxis_DefaultValue)
                hashtable.Add((object) "xAxis", (object) this.XAxis);
            if (this.YAxis != this.YAxis_DefaultValue)
                hashtable.Add((object) "yAxis", (object) this.YAxis);
            nullable1 = this.ZIndex;
            nullable2 = this.ZIndex_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "zIndex", (object) this.ZIndex);
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