using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetSubstring
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString stringVariable = action.Values[0].Item2 as FsmString;
            FsmInt startIndex = action.Values[1].Item2 as FsmInt;
            FsmInt length = action.Values[2].Item2 as FsmInt;
            FsmString storeResult = action.Values[3].Item2 as FsmString;
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}