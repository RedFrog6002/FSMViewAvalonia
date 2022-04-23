using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetAtan2
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat xValue = action.Values[0].Item2 as FsmFloat;
            FsmFloat yValue = action.Values[1].Item2 as FsmFloat;
            FsmFloat angle = action.Values[2].Item2 as FsmFloat;
            FsmBool RadToDeg = action.Values[3].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}