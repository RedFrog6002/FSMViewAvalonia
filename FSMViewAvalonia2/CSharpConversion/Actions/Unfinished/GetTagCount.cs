using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetTagCount
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString tag = action.Values[0].Item2 as FsmString;
            FsmInt storeResult = action.Values[1].Item2 as FsmInt;
        }
    }
}