using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FloatInRange
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat floatVariable = action.Values[0].Item2 as FsmFloat;
            FsmFloat lowerValue = action.Values[1].Item2 as FsmFloat;
            FsmFloat upperValue = action.Values[2].Item2 as FsmFloat;
            FsmBool boolVariable = action.Values[3].Item2 as FsmBool;
            string trueEvent = action.Values[4].Item2 as string;
            string falseEvent = action.Values[5].Item2 as string;
            bool everyFrame = (bool)action.Values[6].Item2;
        }
    }
}