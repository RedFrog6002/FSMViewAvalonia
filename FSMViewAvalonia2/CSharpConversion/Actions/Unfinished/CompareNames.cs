using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class CompareNames
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString name = action.Values[0].Item2 as FsmString;
            FsmArray strings = action.Values[1].Item2 as FsmArray;
            FsmEventTarget target = action.Values[2].Item2 as FsmEventTarget;
            string trueEvent = action.Values[3].Item2 as string;
            string falseEvent = action.Values[4].Item2 as string;
        }
    }
}