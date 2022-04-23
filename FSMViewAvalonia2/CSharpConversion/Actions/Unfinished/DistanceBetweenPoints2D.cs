using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class DistanceBetweenPoints2D
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat distanceResult = action.Values[0].Item2 as FsmFloat;
            FsmVector2 point1 = action.Values[1].Item2 as FsmVector2;
            FsmVector2 point2 = action.Values[2].Item2 as FsmVector2;
            bool everyFrame = (bool)action.Values[3].Item2;
        }
    }
}