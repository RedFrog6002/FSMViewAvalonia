using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ScaleTime
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat timeScale = action.Values[0].Item2 as FsmFloat;
            FsmBool adjustFixedDeltaTime = action.Values[1].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[2].Item2;
        }
    }
}