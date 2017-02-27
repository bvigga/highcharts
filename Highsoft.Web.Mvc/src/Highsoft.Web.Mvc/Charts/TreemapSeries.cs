﻿// Type: Highsoft.Web.Mvc.Charts.TreemapSeries


using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class TreemapSeries : Series
    {
        public TreemapSeriesAllowDrillToNode AllowDrillToNode { get; set; }

        private TreemapSeriesAllowDrillToNode AllowDrillToNode_DefaultValue { get; set; }

        public bool? AllowPointSelect { get; set; }

        private bool? AllowPointSelect_DefaultValue { get; set; }

        public bool? AlternateStartingDirection { get; set; }

        private bool? AlternateStartingDirection_DefaultValue { get; set; }

        public Animation Animation { get; set; }

        private Animation Animation_DefaultValue { get; set; }

        public double? AnimationLimit { get; set; }

        private double? AnimationLimit_DefaultValue { get; set; }

        public string BorderColor { get; set; }

        private string BorderColor_DefaultValue { get; set; }

        public double? BorderWidth { get; set; }

        private double? BorderWidth_DefaultValue { get; set; }

        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public bool? ColorByPoint { get; set; }

        private bool? ColorByPoint_DefaultValue { get; set; }

        public List<string> Colors { get; set; }

        private List<string> Colors_DefaultValue { get; set; }

        public double? CropThreshold { get; set; }

        private double? CropThreshold_DefaultValue { get; set; }

        public TreemapSeriesCursor Cursor { get; set; }

        private TreemapSeriesCursor Cursor_DefaultValue { get; set; }

        public List<TreemapSeriesData> Data { get; set; }

        private List<TreemapSeriesData> Data_DefaultValue { get; set; }

        public TreemapSeriesDataLabels DataLabels { get; set; }

        private TreemapSeriesDataLabels DataLabels_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public bool? EnableMouseTracking { get; set; }

        private bool? EnableMouseTracking_DefaultValue { get; set; }

        public TreemapSeriesEvents Events { get; set; }

        private TreemapSeriesEvents Events_DefaultValue { get; set; }

        public bool? GetExtremesFromAll { get; set; }

        private bool? GetExtremesFromAll_DefaultValue { get; set; }

        public new string Id { get; set; }

        private string Id_DefaultValue { get; set; }

        public new double? Index { get; set; }

        private double? Index_DefaultValue { get; set; }

        public bool? InteractByLeaf { get; set; }

        private bool? InteractByLeaf_DefaultValue { get; set; }

        public List<string> Keys { get; set; }

        private List<string> Keys_DefaultValue { get; set; }

        public TreemapSeriesLayoutAlgorithm LayoutAlgorithm { get; set; }

        private TreemapSeriesLayoutAlgorithm LayoutAlgorithm_DefaultValue { get; set; }

        public TreemapSeriesLayoutStartingDirection LayoutStartingDirection { get; set; }

        private TreemapSeriesLayoutStartingDirection LayoutStartingDirection_DefaultValue { get; set; }

        public new double? LegendIndex { get; set; }

        private double? LegendIndex_DefaultValue { get; set; }

        public TreemapSeriesLevelIsConstant LevelIsConstant { get; set; }

        private TreemapSeriesLevelIsConstant LevelIsConstant_DefaultValue { get; set; }

        public List<TreemapSeriesLevels> Levels { get; set; }

        private List<TreemapSeriesLevels> Levels_DefaultValue { get; set; }

        public string LinkedTo { get; set; }

        private string LinkedTo_DefaultValue { get; set; }

        public double? MaxPointWidth { get; set; }

        private double? MaxPointWidth_DefaultValue { get; set; }

        public new string Name { get; set; }

        private string Name_DefaultValue { get; set; }

        public TreemapSeriesPoint Point { get; set; }

        private TreemapSeriesPoint Point_DefaultValue { get; set; }

        public bool? Selected { get; set; }

        private bool? Selected_DefaultValue { get; set; }

        public Shadow Shadow { get; set; }

        private Shadow Shadow_DefaultValue { get; set; }

        public bool? ShowCheckbox { get; set; }

        private bool? ShowCheckbox_DefaultValue { get; set; }

        public bool? ShowInLegend { get; set; }

        private bool? ShowInLegend_DefaultValue { get; set; }

        public double? SortIndex { get; set; }

        private double? SortIndex_DefaultValue { get; set; }

        public TreemapSeriesStates States { get; set; }

        private TreemapSeriesStates States_DefaultValue { get; set; }

        public bool? StickyTracking { get; set; }

        private bool? StickyTracking_DefaultValue { get; set; }

        public TreemapSeriesTooltip Tooltip { get; set; }

        private TreemapSeriesTooltip Tooltip_DefaultValue { get; set; }

        public double? TurboThreshold { get; set; }

        private double? TurboThreshold_DefaultValue { get; set; }

        public TreemapSeriesType Type { get; set; }

        private TreemapSeriesType Type_DefaultValue { get; set; }

        public bool? Visible { get; set; }

        private bool? Visible_DefaultValue { get; set; }

        public new string XAxis { get; set; }

        private string XAxis_DefaultValue { get; set; }

        public new string YAxis { get; set; }

        private string YAxis_DefaultValue { get; set; }

        public new double? ZIndex { get; set; }

        private double? ZIndex_DefaultValue { get; set; }

        public string ZoneAxis { get; set; }

        private string ZoneAxis_DefaultValue { get; set; }

        public TreemapSeriesZones Zones { get; set; }

        private TreemapSeriesZones Zones_DefaultValue { get; set; }

        public TreemapSeries()
        {
            this.AllowDrillToNode = this.AllowDrillToNode_DefaultValue = TreemapSeriesAllowDrillToNode.False;
            bool? nullable1 = new bool?(false);
            this.AllowPointSelect_DefaultValue = nullable1;
            this.AllowPointSelect = nullable1;
            nullable1 = new bool?(false);
            this.AlternateStartingDirection_DefaultValue = nullable1;
            this.AlternateStartingDirection = nullable1;
            this.Animation = this.Animation_DefaultValue = new Animation()
            {
                Enabled = true
            };
            double? nullable2 = new double?();
            this.AnimationLimit_DefaultValue = nullable2;
            this.AnimationLimit = nullable2;
            this.BorderColor = this.BorderColor_DefaultValue = "#e6e6e6";
            nullable2 = new double?(1.0);
            this.BorderWidth_DefaultValue = nullable2;
            this.BorderWidth = nullable2;
            this.ClassName = this.ClassName_DefaultValue = "";
            this.Color = this.Color_DefaultValue = "null";
            nullable1 = new bool?(false);
            this.ColorByPoint_DefaultValue = nullable1;
            this.ColorByPoint = nullable1;
            this.Colors = this.Colors_DefaultValue = new List<string>();
            nullable2 = new double?(300.0);
            this.CropThreshold_DefaultValue = nullable2;
            this.CropThreshold = nullable2;
            this.Cursor = this.Cursor_DefaultValue = TreemapSeriesCursor.Null;
            this.Data = this.Data_DefaultValue = new List<TreemapSeriesData>();
            this.DataLabels = this.DataLabels_DefaultValue = new TreemapSeriesDataLabels();
            this.Description = this.Description_DefaultValue = "undefined";
            nullable1 = new bool?(true);
            this.EnableMouseTracking_DefaultValue = nullable1;
            this.EnableMouseTracking = nullable1;
            this.Events = this.Events_DefaultValue = new TreemapSeriesEvents();
            nullable1 = new bool?(false);
            this.GetExtremesFromAll_DefaultValue = nullable1;
            this.GetExtremesFromAll = nullable1;
            this.Id = this.Id_DefaultValue = "";
            double? nullable3 = new double?();
            this.Index_DefaultValue = nullable3;
            this.Index = nullable3;
            bool? nullable4 = new bool?();
            this.InteractByLeaf_DefaultValue = nullable4;
            this.InteractByLeaf = nullable4;
            this.Keys = this.Keys_DefaultValue = new List<string>();
            this.LayoutAlgorithm = this.LayoutAlgorithm_DefaultValue = TreemapSeriesLayoutAlgorithm.SliceAndDice;
            this.LayoutStartingDirection =
                this.LayoutStartingDirection_DefaultValue = TreemapSeriesLayoutStartingDirection.Vertical;
            double? nullable5 = new double?();
            this.LegendIndex_DefaultValue = nullable5;
            this.LegendIndex = nullable5;
            this.LevelIsConstant = this.LevelIsConstant_DefaultValue = TreemapSeriesLevelIsConstant.True;
            this.Levels = this.Levels_DefaultValue = new List<TreemapSeriesLevels>();
            this.LinkedTo = this.LinkedTo_DefaultValue = "";
            double? nullable6 = new double?();
            this.MaxPointWidth_DefaultValue = nullable6;
            this.MaxPointWidth = nullable6;
            this.Name = this.Name_DefaultValue = (string) null;
            this.Point = this.Point_DefaultValue = new TreemapSeriesPoint();
            nullable4 = new bool?(false);
            this.Selected_DefaultValue = nullable4;
            this.Selected = nullable4;
            this.Shadow = this.Shadow_DefaultValue = new Shadow()
            {
                Enabled = false
            };
            nullable4 = new bool?(false);
            this.ShowCheckbox_DefaultValue = nullable4;
            this.ShowCheckbox = nullable4;
            nullable4 = new bool?(false);
            this.ShowInLegend_DefaultValue = nullable4;
            this.ShowInLegend = nullable4;
            double? nullable7 = new double?();
            this.SortIndex_DefaultValue = nullable7;
            this.SortIndex = nullable7;
            this.States = this.States_DefaultValue = new TreemapSeriesStates();
            nullable4 = new bool?(true);
            this.StickyTracking_DefaultValue = nullable4;
            this.StickyTracking = nullable4;
            this.Tooltip = this.Tooltip_DefaultValue = new TreemapSeriesTooltip();
            nullable7 = new double?(1000.0);
            this.TurboThreshold_DefaultValue = nullable7;
            this.TurboThreshold = nullable7;
            this.Type = this.Type_DefaultValue = TreemapSeriesType.Null;
            nullable4 = new bool?(true);
            this.Visible_DefaultValue = nullable4;
            this.Visible = nullable4;
            this.XAxis = this.XAxis_DefaultValue = "0";
            this.YAxis = this.YAxis_DefaultValue = "0";
            double? nullable8 = new double?();
            this.ZIndex_DefaultValue = nullable8;
            this.ZIndex = nullable8;
            this.ZoneAxis = this.ZoneAxis_DefaultValue = "y";
            this.Zones = this.Zones_DefaultValue = new TreemapSeriesZones();
        }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.AllowDrillToNode != this.AllowDrillToNode_DefaultValue)
                hashtable.Add((object) "allowDrillToNode",
                    (object) Highcharts.FirstCharacterToLower(this.AllowDrillToNode.ToString()));
            bool? nullable1 = this.AllowPointSelect;
            bool? nullable2 = this.AllowPointSelect_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "allowPointSelect", (object) this.AllowPointSelect);
            nullable2 = this.AlternateStartingDirection;
            nullable1 = this.AlternateStartingDirection_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "alternateStartingDirection", (object) this.AlternateStartingDirection);
            if (this.Animation.IsDirty())
                hashtable.Add((object) "animation", (object) this.Animation.ToJSON());
            double? nullable3 = this.AnimationLimit;
            double? nullable4 = this.AnimationLimit_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "animationLimit", (object) this.AnimationLimit);
            if (this.BorderColor != this.BorderColor_DefaultValue)
                hashtable.Add((object) "borderColor", (object) this.BorderColor);
            nullable4 = this.BorderWidth;
            nullable3 = this.BorderWidth_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            nullable1 = this.ColorByPoint;
            nullable2 = this.ColorByPoint_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "colorByPoint", (object) this.ColorByPoint);
            if (this.Colors != this.Colors_DefaultValue)
                hashtable.Add((object) "colors", (object) this.Colors);
            nullable3 = this.CropThreshold;
            nullable4 = this.CropThreshold_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "cropThreshold", (object) this.CropThreshold);
            if (this.Cursor != this.Cursor_DefaultValue)
                hashtable.Add((object) "cursor", (object) Highcharts.FirstCharacterToLower(this.Cursor.ToString()));
            if (this.DataLabels.IsDirty())
                hashtable.Add((object) "dataLabels", (object) this.DataLabels.ToHashtable());
            if (this.Description != this.Description_DefaultValue)
                hashtable.Add((object) "description", (object) this.Description);
            nullable2 = this.EnableMouseTracking;
            nullable1 = this.EnableMouseTracking_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "enableMouseTracking", (object) this.EnableMouseTracking);
            if (this.Events.IsDirty())
                hashtable.Add((object) "events", (object) this.Events.ToHashtable());
            nullable1 = this.GetExtremesFromAll;
            nullable2 = this.GetExtremesFromAll_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "getExtremesFromAll", (object) this.GetExtremesFromAll);
            if (this.Id != this.Id_DefaultValue)
                hashtable.Add((object) "id", (object) this.Id);
            nullable4 = this.Index;
            nullable3 = this.Index_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "index", (object) this.Index);
            nullable2 = this.InteractByLeaf;
            nullable1 = this.InteractByLeaf_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "interactByLeaf", (object) this.InteractByLeaf);
            if (this.Keys != this.Keys_DefaultValue)
                hashtable.Add((object) "keys", (object) this.Keys);
            if (this.LayoutAlgorithm != this.LayoutAlgorithm_DefaultValue)
                hashtable.Add((object) "layoutAlgorithm",
                    (object) Highcharts.FirstCharacterToLower(this.LayoutAlgorithm.ToString()));
            if (this.LayoutStartingDirection != this.LayoutStartingDirection_DefaultValue)
                hashtable.Add((object) "layoutStartingDirection",
                    (object) Highcharts.FirstCharacterToLower(this.LayoutStartingDirection.ToString()));
            nullable3 = this.LegendIndex;
            nullable4 = this.LegendIndex_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
            if (this.LevelIsConstant != this.LevelIsConstant_DefaultValue)
                hashtable.Add((object) "levelIsConstant",
                    (object) Highcharts.FirstCharacterToLower(this.LevelIsConstant.ToString()));
            if (this.Levels != this.Levels_DefaultValue)
                hashtable.Add((object) "levels", (object) this.HashifyList((IEnumerable) this.Levels));
            if (this.LinkedTo != this.LinkedTo_DefaultValue)
                hashtable.Add((object) "linkedTo", (object) this.LinkedTo);
            nullable4 = this.MaxPointWidth;
            nullable3 = this.MaxPointWidth_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "maxPointWidth", (object) this.MaxPointWidth);
            if (this.Name != this.Name_DefaultValue)
                hashtable.Add((object) "name", (object) this.Name);
            if (this.Point.IsDirty())
                hashtable.Add((object) "point", (object) this.Point.ToHashtable());
            nullable1 = this.Selected;
            nullable2 = this.Selected_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "selected", (object) this.Selected);
            if (this.Shadow != this.Shadow_DefaultValue)
                hashtable.Add((object) "shadow", (object) this.Shadow);
            nullable2 = this.ShowCheckbox;
            nullable1 = this.ShowCheckbox_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "showCheckbox", (object) this.ShowCheckbox);
            nullable1 = this.ShowInLegend;
            nullable2 = this.ShowInLegend_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "showInLegend", (object) this.ShowInLegend);
            nullable3 = this.SortIndex;
            nullable4 = this.SortIndex_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "sortIndex", (object) this.SortIndex);
            if (this.States.IsDirty())
                hashtable.Add((object) "states", (object) this.States.ToHashtable());
            nullable2 = this.StickyTracking;
            nullable1 = this.StickyTracking_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "stickyTracking", (object) this.StickyTracking);
            if (this.Tooltip.IsDirty())
                hashtable.Add((object) "tooltip", (object) this.Tooltip.ToHashtable());
            nullable4 = this.TurboThreshold;
            nullable3 = this.TurboThreshold_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "turboThreshold", (object) this.TurboThreshold);
            if (this.Type != this.Type_DefaultValue)
                hashtable.Add((object) "type", (object) Highcharts.FirstCharacterToLower(this.Type.ToString()));
            nullable1 = this.Visible;
            nullable2 = this.Visible_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "visible", (object) this.Visible);
            if (this.XAxis != this.XAxis_DefaultValue)
                hashtable.Add((object) "xAxis", (object) this.XAxis);
            if (this.YAxis != this.YAxis_DefaultValue)
                hashtable.Add((object) "yAxis", (object) this.YAxis);
            nullable3 = this.ZIndex;
            nullable4 = this.ZIndex_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "zIndex", (object) this.ZIndex);
            if (this.ZoneAxis != this.ZoneAxis_DefaultValue)
                hashtable.Add((object) "zoneAxis", (object) this.ZoneAxis);
            if (this.Zones.IsDirty())
                hashtable.Add((object) "zones", (object) this.Zones.ToHashtable());
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