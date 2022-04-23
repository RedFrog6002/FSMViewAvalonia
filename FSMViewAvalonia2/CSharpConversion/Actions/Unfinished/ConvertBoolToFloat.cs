using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ConvertBoolToFloat
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmBool boolVariable = action.Values[0].Item2 as FsmBool;
            FsmFloat floatVariable = action.Values[1].Item2 as FsmFloat;
            FsmFloat falseValue = action.Values[2].Item2 as FsmFloat;
            FsmFloat trueValue = action.Values[3].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}