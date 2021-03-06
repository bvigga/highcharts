﻿// Type: Highsoft.Web.Mvc.Stocks.Series


using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
    public class Series : BaseObject
    {
        public Series()
        {
            this.Data = this.Data_DefaultValue = new List<SeriesData>();
            this.Id = this.Id_DefaultValue = "";
            double? nullable1 = new double?();
            this.Index_DefaultValue = nullable1;
            this.Index = nullable1;
            double? nullable2 = new double?();
            this.LegendIndex_DefaultValue = nullable2;
            this.LegendIndex = nullable2;
            this.Name = this.Name_DefaultValue = (string) null;
            this.Stack = this.Stack_DefaultValue = "null";
            this.Type = this.Type_DefaultValue = SeriesType.Null;
            this.XAxis = this.XAxis_DefaultValue = "0";
            this.YAxis = this.YAxis_DefaultValue = "0";
            double? nullable3 = new double?();
            this.ZIndex_DefaultValue = nullable3;
            this.ZIndex = nullable3;
        }

        public List<SeriesData> Data { get; set; }

        private List<SeriesData> Data_DefaultValue { get; set; }

        public string Id { get; set; }

        private string Id_DefaultValue { get; set; }

        public double? Index { get; set; }

        private double? Index_DefaultValue { get; set; }

        public double? LegendIndex { get; set; }

        private double? LegendIndex_DefaultValue { get; set; }

        public string Name { get; set; }

        private string Name_DefaultValue { get; set; }

        public string Stack { get; set; }

        private string Stack_DefaultValue { get; set; }

        public SeriesType Type { get; set; }

        private SeriesType Type_DefaultValue { get; set; }

        public string XAxis { get; set; }

        private string XAxis_DefaultValue { get; set; }

        public string YAxis { get; set; }

        private string YAxis_DefaultValue { get; set; }

        public double? ZIndex { get; set; }

        private double? ZIndex_DefaultValue { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable hashtable = new Hashtable();
            if (this.Data.Any<SeriesData>())
                hashtable.Add((object) "data", (object) this.HashifyList((IEnumerable) this.Data));
            if (this.Id != this.Id_DefaultValue)
                hashtable.Add((object) "id", (object) this.Id);
            double? nullable1 = this.Index;
            double? nullable2 = this.Index_DefaultValue;
            if (nullable1.GetValueOrDefault() != nullable2.GetValueOrDefault() ||
                nullable1.HasValue != nullable2.HasValue)
                hashtable.Add((object) "index", (object) this.Index);
            nullable2 = this.LegendIndex;
            nullable1 = this.LegendIndex_DefaultValue;
            if (nullable2.GetValueOrDefault() != nullable1.GetValueOrDefault() ||
                nullable2.HasValue != nullable1.HasValue)
                hashtable.Add((object) "legendIndex", (object) this.LegendIndex);
            if (this.Name != this.Name_DefaultValue)
                hashtable.Add((object) "name", (object) this.Name);
            if (this.Stack != this.Stack_DefaultValue)
                hashtable.Add((object) "stack", (object) this.Stack);
            if (this.Type != this.Type_DefaultValue)
                hashtable.Add((object) "type", (object) Highstock.FirstCharacterToLower(this.Type.ToString()));
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