﻿// Type: Highsoft.Web.Mvc.Charts.BoxplotSeriesData


using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
    public class BoxplotSeriesData : BaseObject
    {
        public BoxplotSeriesData()
        {
            this.ClassName = this.ClassName_DefaultValue = (string) null;
            this.Color = this.Color_DefaultValue = "undefined";
            double? nullable1 = new double?();
            this.ColorIndex_DefaultValue = nullable1;
            this.ColorIndex = nullable1;
            this.DataLabels = this.DataLabels_DefaultValue = new BoxplotSeriesDataLabels();
            this.Description = this.Description_DefaultValue = "undefined";
            this.Drilldown = this.Drilldown_DefaultValue = "";
            this.Events = this.Events_DefaultValue = new BoxplotSeriesDataEvents();
            double? nullable2 = new double?();
            this.High_DefaultValue = nullable2;
            this.High = nullable2;
            this.Id = this.Id_DefaultValue = (string) null;
            double? nullable3 = new double?();
            this.Labelrank_DefaultValue = nullable3;
            this.Labelrank = nullable3;
            double? nullable4 = new double?();
            this.Low_DefaultValue = nullable4;
            this.Low = nullable4;
            double? nullable5 = new double?();
            this.Median_DefaultValue = nullable5;
            this.Median = nullable5;
            this.Name = this.Name_DefaultValue = (string) null;
            double? nullable6 = new double?();
            this.Q1_DefaultValue = nullable6;
            this.Q1 = nullable6;
            double? nullable7 = new double?();
            this.Q3_DefaultValue = nullable7;
            this.Q3 = nullable7;
            bool? nullable8 = new bool?(false);
            this.Selected_DefaultValue = nullable8;
            this.Selected = nullable8;
            nullable7 = new double?(double.MinValue);
            this.X_DefaultValue = nullable7;
            this.X = nullable7;
            nullable7 = new double?(double.MinValue);
            this.Y_DefaultValue = nullable7;
            this.Y = nullable7;
        }

        public string ClassName { get; set; }

        private string ClassName_DefaultValue { get; set; }

        public string Color { get; set; }

        private string Color_DefaultValue { get; set; }

        public double? ColorIndex { get; set; }

        private double? ColorIndex_DefaultValue { get; set; }

        public BoxplotSeriesDataLabels DataLabels { get; set; }

        private BoxplotSeriesDataLabels DataLabels_DefaultValue { get; set; }

        public string Description { get; set; }

        private string Description_DefaultValue { get; set; }

        public string Drilldown { get; set; }

        private string Drilldown_DefaultValue { get; set; }

        public BoxplotSeriesDataEvents Events { get; set; }

        private BoxplotSeriesDataEvents Events_DefaultValue { get; set; }

        public double? High { get; set; }

        private double? High_DefaultValue { get; set; }

        public string Id { get; set; }

        private string Id_DefaultValue { get; set; }

        public double? Labelrank { get; set; }

        private double? Labelrank_DefaultValue { get; set; }

        public double? Low { get; set; }

        private double? Low_DefaultValue { get; set; }

        public double? Median { get; set; }

        private double? Median_DefaultValue { get; set; }

        public string Name { get; set; }

        private string Name_DefaultValue { get; set; }

        public double? Q1 { get; set; }

        private double? Q1_DefaultValue { get; set; }

        public double? Q3 { get; set; }

        private double? Q3_DefaultValue { get; set; }

        public bool? Selected { get; set; }

        private bool? Selected_DefaultValue { get; set; }

        public double? X { get; set; }

        private double? X_DefaultValue { get; set; }

        public double? Y { get; set; }

        private double? Y_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.ClassName != this.ClassName_DefaultValue)
                hashtable.Add((object) "className", (object) this.ClassName);
            if (this.Color != this.Color_DefaultValue)
                hashtable.Add((object) "color", (object) this.Color);
            double? nullable1 = this.ColorIndex;
            double? nullable2 = this.ColorIndex_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "colorIndex", (object) this.ColorIndex);
            if (this.DataLabels.IsDirty())
                hashtable.Add((object) "dataLabels", (object) this.DataLabels.ToHashtable());
            if (this.Description != this.Description_DefaultValue)
                hashtable.Add((object) "description", (object) this.Description);
            if (this.Drilldown != this.Drilldown_DefaultValue)
                hashtable.Add((object) "drilldown", (object) this.Drilldown);
            if (this.Events.IsDirty())
                hashtable.Add((object) "events", (object) this.Events.ToHashtable());
            nullable2 = this.High;
            nullable1 = this.High_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "high", (object) this.High);
            if (this.Id != this.Id_DefaultValue)
                hashtable.Add((object) "id", (object) this.Id);
            nullable1 = this.Labelrank;
            nullable2 = this.Labelrank_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "labelrank", (object) this.Labelrank);
            nullable2 = this.Low;
            nullable1 = this.Low_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "low", (object) this.Low);
            nullable1 = this.Median;
            nullable2 = this.Median_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "median", (object) this.Median);
            if (this.Name != this.Name_DefaultValue)
                hashtable.Add((object) "name", (object) this.Name);
            nullable2 = this.Q1;
            nullable1 = this.Q1_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "q1", (object) this.Q1);
            nullable1 = this.Q3;
            nullable2 = this.Q3_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "q3", (object) this.Q3);
            bool? selected = this.Selected;
            bool? selectedDefaultValue = this.Selected_DefaultValue;
            if (selected.GetValueOrDefault() != selectedDefaultValue.GetValueOrDefault() ||
                selected.HasValue != selectedDefaultValue.HasValue)
                hashtable.Add((object) "selected", (object) this.Selected);
            nullable2 = this.X;
            nullable1 = this.X_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "x", (object) this.X);
            nullable1 = this.Y;
            nullable2 = this.Y_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
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