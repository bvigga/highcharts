﻿// Type: Highsoft.Web.Mvc.Charts.PlotOptionsScatterEvents


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class PlotOptionsScatterEvents : BaseObject
    {
        public PlotOptionsScatterEvents()
        {
            this.AfterAnimate = this.AfterAnimate_DefaultValue = "";
            this.CheckboxClick = this.CheckboxClick_DefaultValue = "";
            this.Click = this.Click_DefaultValue = "";
            this.Hide = this.Hide_DefaultValue = "";
            this.LegendItemClick = this.LegendItemClick_DefaultValue = "";
            this.MouseOut = this.MouseOut_DefaultValue = "";
            this.MouseOver = this.MouseOver_DefaultValue = "";
            this.Show = this.Show_DefaultValue = "";
        }

        public string AfterAnimate { get; set; }

        private string AfterAnimate_DefaultValue { get; set; }

        public string CheckboxClick { get; set; }

        private string CheckboxClick_DefaultValue { get; set; }

        public string Click { get; set; }

        private string Click_DefaultValue { get; set; }

        public string Hide { get; set; }

        private string Hide_DefaultValue { get; set; }

        public string LegendItemClick { get; set; }

        private string LegendItemClick_DefaultValue { get; set; }

        public string MouseOut { get; set; }

        private string MouseOut_DefaultValue { get; set; }

        public string MouseOver { get; set; }

        private string MouseOver_DefaultValue { get; set; }

        public string Show { get; set; }

        private string Show_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.AfterAnimate != this.AfterAnimate_DefaultValue)
            {
                hashtable.Add((object) "afterAnimate", (object) this.AfterAnimate);
                Highcharts.AddFunction("PlotOptionsScatterEventsAfterAnimate.afterAnimate", this.AfterAnimate);
            }
            if (this.CheckboxClick != this.CheckboxClick_DefaultValue)
            {
                hashtable.Add((object) "checkboxClick", (object) this.CheckboxClick);
                Highcharts.AddFunction("PlotOptionsScatterEventsCheckboxClick.checkboxClick", this.CheckboxClick);
            }
            if (this.Click != this.Click_DefaultValue)
            {
                hashtable.Add((object) "click", (object) this.Click);
                Highcharts.AddFunction("PlotOptionsScatterEventsClick.click", this.Click);
            }
            if (this.Hide != this.Hide_DefaultValue)
            {
                hashtable.Add((object) "hide", (object) this.Hide);
                Highcharts.AddFunction("PlotOptionsScatterEventsHide.hide", this.Hide);
            }
            if (this.LegendItemClick != this.LegendItemClick_DefaultValue)
            {
                hashtable.Add((object) "legendItemClick", (object) this.LegendItemClick);
                Highcharts.AddFunction("PlotOptionsScatterEventsLegendItemClick.legendItemClick", this.LegendItemClick);
            }
            if (this.MouseOut != this.MouseOut_DefaultValue)
            {
                hashtable.Add((object) "mouseOut", (object) this.MouseOut);
                Highcharts.AddFunction("PlotOptionsScatterEventsMouseOut.mouseOut", this.MouseOut);
            }
            if (this.MouseOver != this.MouseOver_DefaultValue)
            {
                hashtable.Add((object) "mouseOver", (object) this.MouseOver);
                Highcharts.AddFunction("PlotOptionsScatterEventsMouseOver.mouseOver", this.MouseOver);
            }
            if (this.Show != this.Show_DefaultValue)
            {
                hashtable.Add((object) "show", (object) this.Show);
                Highcharts.AddFunction("PlotOptionsScatterEventsShow.show", this.Show);
            }
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