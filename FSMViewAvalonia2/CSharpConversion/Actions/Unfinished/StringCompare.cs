using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class StringCompare
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString stringVariable = action.Values[0].Item2 as FsmString;
            FsmString compareTo = action.Values[1].Item2 as FsmString;
            string equalEvent = action.Values[2].Item2 as string;
            string notEqualEvent = action.Values[3].Item2 as string;
            FsmBool storeResult = action.Values[4].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[5].Item2;
        }
    }
}