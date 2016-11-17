﻿
// Type: Highsoft.Web.Mvc.Charts.SplineSeriesDataMarkerStates




using System.Collections;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
  public class SplineSeriesDataMarkerStates : BaseObject
  {
    public SplineSeriesDataMarkerStatesHover Hover { get; set; }

    private SplineSeriesDataMarkerStatesHover Hover_DefaultValue { get; set; }

    public SplineSeriesDataMarkerStatesSelect Select { get; set; }

    private SplineSeriesDataMarkerStatesSelect Select_DefaultValue { get; set; }

    public SplineSeriesDataMarkerStates()
    {
      this.Hover = this.Hover_DefaultValue = new SplineSeriesDataMarkerStatesHover();
      this.Select = this.Select_DefaultValue = new SplineSeriesDataMarkerStatesSelect();
    }

    internal override Hashtable ToHashtable()
    {
      Hashtable hashtable = new Hashtable();
      if (this.Hover.IsDirty())
        hashtable.Add((object) "hover", (object) this.Hover.ToHashtable());
      if (this.Select.IsDirty())
        hashtable.Add((object) "select", (object) this.Select.ToHashtable());
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