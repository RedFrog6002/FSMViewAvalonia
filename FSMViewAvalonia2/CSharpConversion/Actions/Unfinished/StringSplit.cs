using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class StringSplit
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString stringToSplit = action.Values[0].Item2 as FsmString;
            FsmString separators = action.Values[1].Item2 as FsmString;
            FsmBool trimStrings = action.Values[2].Item2 as FsmBool;
            FsmString trimChars = action.Values[3].Item2 as FsmString;
            FsmArray stringArray = action.Values[4].Item2 as FsmArray;
        }
    }
}