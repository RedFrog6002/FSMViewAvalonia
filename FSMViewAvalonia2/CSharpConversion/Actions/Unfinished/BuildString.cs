using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class BuildString
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString[] stringParts = action.Values[0].Item2 as FsmString[];
            FsmString separator = action.Values[1].Item2 as FsmString;
            FsmBool addToEnd = action.Values[2].Item2 as FsmBool;
            FsmString storeResult = action.Values[3].Item2 as FsmString;
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}