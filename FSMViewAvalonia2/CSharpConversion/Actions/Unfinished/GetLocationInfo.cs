using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetLocationInfo
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmVector3 vectorPosition = action.Values[0].Item2 as FsmVector3;
            FsmFloat longitude = action.Values[1].Item2 as FsmFloat;
            FsmFloat latitude = action.Values[2].Item2 as FsmFloat;
            FsmFloat altitude = action.Values[3].Item2 as FsmFloat;
            FsmFloat horizontalAccuracy = action.Values[4].Item2 as FsmFloat;
            FsmFloat verticalAccuracy = action.Values[5].Item2 as FsmFloat;
            string errorEvent = action.Values[6].Item2 as string;
        }
    }
}