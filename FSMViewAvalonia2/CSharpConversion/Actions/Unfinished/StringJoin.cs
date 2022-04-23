using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class StringJoin
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmArray stringArray = action.Values[0].Item2 as FsmArray;
            FsmString separator = action.Values[1].Item2 as FsmString;
            FsmString storeResult = action.Values[2].Item2 as FsmString;
        }
    }
}