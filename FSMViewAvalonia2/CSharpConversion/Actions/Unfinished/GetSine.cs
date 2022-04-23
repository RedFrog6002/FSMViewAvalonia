using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetSine
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat angle = action.Values[0].Item2 as FsmFloat;
            FsmBool DegToRad = action.Values[1].Item2 as FsmBool;
            FsmFloat result = action.Values[2].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[3].Item2;
        }
    }
}