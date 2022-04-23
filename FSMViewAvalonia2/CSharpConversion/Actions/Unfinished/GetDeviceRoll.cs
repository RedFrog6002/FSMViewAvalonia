using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetDeviceRoll
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            BaseOrientation baseOrientation = action.Values[0].Item2 as BaseOrientation;
            FsmFloat storeAngle = action.Values[1].Item2 as FsmFloat;
            FsmFloat limitAngle = action.Values[2].Item2 as FsmFloat;
            FsmFloat smoothing = action.Values[3].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}