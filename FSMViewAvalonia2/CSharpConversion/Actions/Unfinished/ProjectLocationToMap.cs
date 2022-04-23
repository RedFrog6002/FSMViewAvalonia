using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ProjectLocationToMap
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmVector3 GPSLocation = action.Values[0].Item2 as FsmVector3;
            MapProjection mapProjection = action.Values[1].Item2 as MapProjection;
            FsmFloat minLongitude = action.Values[2].Item2 as FsmFloat;
            FsmFloat maxLongitude = action.Values[3].Item2 as FsmFloat;
            FsmFloat minLatitude = action.Values[4].Item2 as FsmFloat;
            FsmFloat maxLatitude = action.Values[5].Item2 as FsmFloat;
            FsmFloat minX = action.Values[6].Item2 as FsmFloat;
            FsmFloat minY = action.Values[7].Item2 as FsmFloat;
            FsmFloat width = action.Values[8].Item2 as FsmFloat;
            FsmFloat height = action.Values[9].Item2 as FsmFloat;
            FsmFloat projectedX = action.Values[10].Item2 as FsmFloat;
            FsmFloat projectedY = action.Values[11].Item2 as FsmFloat;
            FsmBool normalized = action.Values[12].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[13].Item2;
        }
    }
}