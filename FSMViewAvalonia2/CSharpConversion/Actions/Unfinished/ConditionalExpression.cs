using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ConditionalExpression
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString expression = action.Values[0].Item2 as FsmString;
            string isTrueEvent = action.Values[1].Item2 as string;
            string isFalseEvent = action.Values[2].Item2 as string;
            bool everyFrame = (bool)action.Values[3].Item2;
            bool rawResult = (bool)action.Values[4].Item2;
            FsmBool storeResult = action.Values[5].Item2 as FsmBool;
        }
    }
}