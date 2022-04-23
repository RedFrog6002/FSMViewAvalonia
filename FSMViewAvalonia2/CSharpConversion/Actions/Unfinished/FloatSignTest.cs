using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FloatSignTest
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat floatValue = action.Values[0].Item2 as FsmFloat;
            string isPositive = action.Values[1].Item2 as string;
            string isNegative = action.Values[2].Item2 as string;
            bool everyFrame = (bool)action.Values[3].Item2;
        }
    }
}