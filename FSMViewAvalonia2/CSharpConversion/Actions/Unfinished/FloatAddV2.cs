using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FloatAddV2
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat floatVariable = action.Values[0].Item2 as FsmFloat;
            FsmFloat add = action.Values[1].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[2].Item2;
            bool perSecond = (bool)action.Values[3].Item2;
            bool fixedUpdate = (bool)action.Values[4].Item2;
            FsmBool activeBool = action.Values[5].Item2 as FsmBool;
        }
    }
}