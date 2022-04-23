using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetFogDensity
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat fogDensity = action.Values[0].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[1].Item2;
        }
    }
}