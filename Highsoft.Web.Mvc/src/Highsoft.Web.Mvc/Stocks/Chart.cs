﻿// Type: Highsoft.Web.Mvc.Stocks.Chart


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class Chart : BaseObject
    {
        public Chart()
        {
            bool? nullable1 = new bool?(true);
            this.AlignTicks_DefaultValue = nullable1;
            this.AlignTicks = nullable1;
            this.Animation = this.Animation_DefaultValue = new Animation()
            {
                Enabled = true
            };
            this.BackgroundColor = this.BackgroundColor_DefaultValue = "#FFFFFF";
            this.BorderColor = this.BorderColor_DefaultValue = "#335cad";
            double? nullable2 = new double?(0.0);
            this.BorderRadius_DefaultValue = nullable2;
            this.BorderRadius = nullable2;
            nullable2 = new double?(0.0);
            this.BorderWidth_DefaultValue = nullable2;
            this.BorderWidth = nullable2;
            this.ClassName = this.ClassName_DefaultValue = " ";
            nullable2 = new double?(10.0);
            this.ColorCount_DefaultValue = nullable2;
            this.ColorCount = nullable2;
            this.Description = this.Description_DefaultValue = "undefined";
            this.Events = this.Events_DefaultValue = new ChartEvents();
            double? nullable3 = new double?();
            this.Height_DefaultValue = nullable3;
            this.Height = nullable3;
            nullable1 = new bool?(true);
            this.IgnoreHiddenSeries_DefaultValue = nullable1;
            this.IgnoreHiddenSeries = nullable1;
            nullable1 = new bool?(false);
            this.Inverted_DefaultValue = nullable1;
            this.Inverted = nullable1;
            this.Margin = this.Margin_DefaultValue = new double[0];
            double? nullable4 = new double?();
            this.MarginBottom_DefaultValue = nullable4;
            this.MarginBottom = nullable4;
            double? nullable5 = new double?();
            this.MarginLeft_DefaultValue = nullable5;
            this.MarginLeft = nullable5;
            double? nullable6 = new double?();
            this.MarginRight_DefaultValue = nullable6;
            this.MarginRight = nullable6;
            double? nullable7 = new double?();
            this.MarginTop_DefaultValue = nullable7;
            this.MarginTop = nullable7;
            nullable1 = new bool?(true);
            this.Panning_DefaultValue = nullable1;
            this.Panning = nullable1;
            this.PinchType = this.PinchType_DefaultValue = ChartPinchType.X;
            this.PlotBackgroundColor = this.PlotBackgroundColor_DefaultValue = "null";
            this.PlotBackgroundImage = this.PlotBackgroundImage_DefaultValue = "null";
            this.PlotBorderColor = this.PlotBorderColor_DefaultValue = "#cccccc";
            nullable7 = new double?(0.0);
            this.PlotBorderWidth_DefaultValue = nullable7;
            this.PlotBorderWidth = nullable7;
            this.PlotShadow = this.PlotShadow_DefaultValue = new Shadow()
            {
                Enabled = false
            };
            nullable1 = new bool?(true);
            this.Reflow_DefaultValue = nullable1;
            this.Reflow = nullable1;
            this.RenderTo = this.RenderTo_DefaultValue = (string) null;
            this.ResetZoomButton = this.ResetZoomButton_DefaultValue = new ChartResetZoomButton();
            this.SelectionMarkerFill = this.SelectionMarkerFill_DefaultValue = "rgba(51,92,173,0.25)";
            this.Shadow = this.Shadow_DefaultValue = new Shadow()
            {
                Enabled = false
            };
            nullable7 = new double?(15.0);
            this.SpacingBottom_DefaultValue = nullable7;
            this.SpacingBottom = nullable7;
            nullable7 = new double?(10.0);
            this.SpacingLeft_DefaultValue = nullable7;
            this.SpacingLeft = nullable7;
            nullable7 = new double?(10.0);
            this.SpacingRight_DefaultValue = nullable7;
            this.SpacingRight = nullable7;
            nullable7 = new double?(10.0);
            this.SpacingTop_DefaultValue = nullable7;
            this.SpacingTop = nullable7;
            this.Style = this.Style_DefaultValue = new Hashtable()
            {
                {
                    (object) "fontFamily",
                    (object)
                    "\"Lucida Grande\"},{ \"Lucida Sans Unicode\"},{ Verdana},{ Arial},{ Helvetica},{ sans-serif"
                },
                {
                    (object) "fontSize",
                    (object) "12px"
                }
            };
            this.Type = this.Type_DefaultValue = ChartType.Line;
            this.TypeDescription = this.TypeDescription_DefaultValue = "undefined";
            double? nullable8 = new double?();
            this.Width_DefaultValue = nullable8;
            this.Width = nullable8;
            this.ZoomType = this.ZoomType_DefaultValue = ChartZoomType.Null;
        }

        public bool? AlignTicks { get; set; }

        private bool? AlignTicks_DefaultValue { get; set; }

        public Animation Animation { get; set; }

        private Animation Animation_DefaultValue { get; set; }

        public string BackgroundColor { get; set; }

        private string BackgroundColor_DefaultValue { get; set; }

        public string BorderColor { get; set; }

        private string BorderColor_DefaultValue { get; set; }

        public double? BorderRadius { get; set; }

        private double? BorderRadius_DefaultValue { get; set; }

        public double? BorderWidth { get; set; }

        private double? BorderWidth_DefaultValue { get; set; }

        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public double? ColorCount { get; set; }

        private double? ColorCount_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public ChartEvents Events { get; set; }

        private ChartEvents Events_DefaultValue { get; set; }

        public double? Height { get; set; }

        private double? Height_DefaultValue { get; set; }

        public bool? IgnoreHiddenSeries { get; set; }

        private bool? IgnoreHiddenSeries_DefaultValue { get; set; }

        public bool? Inverted { get; set; }

        private bool? Inverted_DefaultValue { get; set; }

        public double[] Margin { get; set; }

        private double[] Margin_DefaultValue { get; set; }

        public double? MarginBottom { get; set; }

        private double? MarginBottom_DefaultValue { get; set; }

        public double? MarginLeft { get; set; }

        private double? MarginLeft_DefaultValue { get; set; }

        public double? MarginRight { get; set; }

        private double? MarginRight_DefaultValue { get; set; }

        public double? MarginTop { get; set; }

        private double? MarginTop_DefaultValue { get; set; }

        public bool? Panning { get; set; }

        private bool? Panning_DefaultValue { get; set; }

        public ChartPinchType PinchType { get; set; }

        private ChartPinchType PinchType_DefaultValue { get; set; }

        public string PlotBackgroundColor { get; set; }

        private string PlotBackgroundColor_DefaultValue { get; set; }

        public string PlotBackgroundImage { get; set; }

        private string PlotBackgroundImage_DefaultValue { get; set; }

        public string PlotBorderColor { get; set; }

        private string PlotBorderColor_DefaultValue { get; set; }

        public double? PlotBorderWidth { get; set; }

        private double? PlotBorderWidth_DefaultValue { get; set; }

        public Shadow PlotShadow { get; set; }

        private Shadow PlotShadow_DefaultValue { get; set; }

        public bool? Reflow { get; set; }

        private bool? Reflow_DefaultValue { get; set; }

        public string RenderTo { get; set; }

        private string RenderTo_DefaultValue { get; set; }

        public ChartResetZoomButton ResetZoomButton { get; set; }

        private ChartResetZoomButton ResetZoomButton_DefaultValue { get; set; }

        public string SelectionMarkerFill { get; set; }

        private string SelectionMarkerFill_DefaultValue { get; set; }

        public Shadow Shadow { get; set; }

        private Shadow Shadow_DefaultValue { get; set; }

        public double? SpacingBottom { get; set; }

        private double? SpacingBottom_DefaultValue { get; set; }

        public double? SpacingLeft { get; set; }

        private double? SpacingLeft_DefaultValue { get; set; }

        public double? SpacingRight { get; set; }

        private double? SpacingRight_DefaultValue { get; set; }

        public double? SpacingTop { get; set; }

        private double? SpacingTop_DefaultValue { get; set; }

        public Hashtable Style { get; set; }

        private Hashtable Style_DefaultValue { get; set; }

        public ChartType Type { get; set; }

        private ChartType Type_DefaultValue { get; set; }

        public string TypeDescription { get; set; }

        private string TypeDescription_DefaultValue { get; set; }

        public double? Width { get; set; }

        private double? Width_DefaultValue { get; set; }

        public ChartZoomType ZoomType { get; set; }

        private ChartZoomType ZoomType_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            bool? nullable1 = this.AlignTicks;
            bool? nullable2 = this.AlignTicks_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "alignTicks", (object) this.AlignTicks);
            if (this.Animation.IsDirty())
                hashtable.Add((object) "animation", (object) this.Animation.ToJSON());
            if (this.BackgroundColor != this.BackgroundColor_DefaultValue)
                hashtable.Add((object) "backgroundColor", (object) this.BackgroundColor);
            if (this.BorderColor != this.BorderColor_DefaultValue)
                hashtable.Add((object) "borderColor", (object) this.BorderColor);
            double? nullable3 = this.BorderRadius;
            double? nullable4 = this.BorderRadius_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "borderRadius", (object) this.BorderRadius);
            nullable4 = this.BorderWidth;
            nullable3 = this.BorderWidth_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "borderWidth", (object) this.BorderWidth);
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            nullable3 = this.ColorCount;
            nullable4 = this.ColorCount_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "colorCount", (object) this.ColorCount);
            if (this.Description != this.Description_DefaultValue)
                hashtable.Add((object) "description", (object) this.Description);
            if (this.Events.IsDirty())
                hashtable.Add((object) "events", (object) this.Events.ToHashtable());
            nullable4 = this.Height;
            nullable3 = this.Height_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "height", (object) this.Height);
            nullable2 = this.IgnoreHiddenSeries;
            nullable1 = this.IgnoreHiddenSeries_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "ignoreHiddenSeries", (object) this.IgnoreHiddenSeries);
            nullable1 = this.Inverted;
            nullable2 = this.Inverted_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "inverted", (object) this.Inverted);
            if (this.Margin != this.Margin_DefaultValue)
                hashtable.Add((object) "margin", (object) this.Margin);
            nullable3 = this.MarginBottom;
            nullable4 = this.MarginBottom_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "marginBottom", (object) this.MarginBottom);
            nullable4 = this.MarginLeft;
            nullable3 = this.MarginLeft_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "marginLeft", (object) this.MarginLeft);
            nullable3 = this.MarginRight;
            nullable4 = this.MarginRight_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "marginRight", (object) this.MarginRight);
            nullable4 = this.MarginTop;
            nullable3 = this.MarginTop_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "marginTop", (object) this.MarginTop);
            nullable2 = this.Panning;
            nullable1 = this.Panning_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "panning", (object) this.Panning);
            if (this.PinchType != this.PinchType_DefaultValue)
                hashtable.Add((object) "pinchType",
                    (object) Highstock.FirstCharacterToLower(this.PinchType.ToString()));
            if (this.PlotBackgroundColor != this.PlotBackgroundColor_DefaultValue)
                hashtable.Add((object) "plotBackgroundColor", (object) this.PlotBackgroundColor);
            if (this.PlotBackgroundImage != this.PlotBackgroundImage_DefaultValue)
                hashtable.Add((object) "plotBackgroundImage", (object) this.PlotBackgroundImage);
            if (this.PlotBorderColor != this.PlotBorderColor_DefaultValue)
                hashtable.Add((object) "plotBorderColor", (object) this.PlotBorderColor);
            nullable3 = this.PlotBorderWidth;
            nullable4 = this.PlotBorderWidth_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "plotBorderWidth", (object) this.PlotBorderWidth);
            if (this.PlotShadow.IsDirty())
                hashtable.Add((object) "plotShadow", (object) this.PlotShadow.ToJSON());
            nullable1 = this.Reflow;
            nullable2 = this.Reflow_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "reflow", (object) this.Reflow);
            if (this.RenderTo != this.RenderTo_DefaultValue)
                hashtable.Add((object) "renderTo", (object) this.RenderTo);
            if (this.ResetZoomButton.IsDirty())
                hashtable.Add((object) "resetZoomButton", (object) this.ResetZoomButton.ToHashtable());
            if (this.SelectionMarkerFill != this.SelectionMarkerFill_DefaultValue)
                hashtable.Add((object) "selectionMarkerFill", (object) this.SelectionMarkerFill);
            if (this.Shadow.IsDirty())
                hashtable.Add((object) "shadow", (object) this.Shadow.ToHashtable());
            nullable4 = this.SpacingBottom;
            nullable3 = this.SpacingBottom_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "spacingBottom", (object) this.SpacingBottom);
            nullable3 = this.SpacingLeft;
            nullable4 = this.SpacingLeft_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "spacingLeft", (object) this.SpacingLeft);
            nullable4 = this.SpacingRight;
            nullable3 = this.SpacingRight_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "spacingRight", (object) this.SpacingRight);
            nullable3 = this.SpacingTop;
            nullable4 = this.SpacingTop_DefaultValue;
            if (nullable3.GetValueOrDefault() != nullable4.GetValueOrDefault() ||
                nullable3.HasValue != nullable4.HasValue)
                hashtable.Add((object) "spacingTop", (object) this.SpacingTop);
            if (this.Style != this.Style_DefaultValue)
                hashtable.Add((object) "style", (object) this.Style);
            if (this.Type != this.Type_DefaultValue)
                hashtable.Add((object) "type", (object) Highstock.FirstCharacterToLower(this.Type.ToString()));
            if (this.TypeDescription != this.TypeDescription_DefaultValue)
                hashtable.Add((object) "typeDescription", (object) this.TypeDescription);
            nullable4 = this.Width;
            nullable3 = this.Width_DefaultValue;
            if (nullable4.GetValueOrDefault() != nullable3.GetValueOrDefault() ||
                nullable4.HasValue != nullable3.HasValue)
                hashtable.Add((object) "width", (object) this.Width);
            if (this.ZoomType != this.ZoomType_DefaultValue)
                hashtable.Add((object) "zoomType", (object) Highstock.FirstCharacterToLower(this.ZoomType.ToString()));
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