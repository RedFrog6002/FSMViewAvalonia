using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class DistanceBetweenPoints
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat distanceResult = action.Values[0].Item2 as FsmFloat;
            FsmVector3 point1 = action.Values[1].Item2 as FsmVector3;
            FsmVector3 point2 = action.Values[2].Item2 as FsmVector3;
            bool ignoreZ = (bool)action.Values[3].Item2;
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}