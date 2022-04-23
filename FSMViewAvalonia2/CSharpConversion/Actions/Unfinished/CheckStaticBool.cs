using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class CheckStaticBool
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString variableName = action.Values[0].Item2 as FsmString;
            string trueEvent = action.Values[1].Item2 as string;
            string falseEvent = action.Values[2].Item2 as string;
        }
    }
}