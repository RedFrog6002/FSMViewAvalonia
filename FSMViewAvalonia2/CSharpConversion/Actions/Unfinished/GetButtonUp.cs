using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetButtonUp
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString buttonName = action.Values[0].Item2 as FsmString;
            string sendEvent = action.Values[1].Item2 as string;
            FsmBool storeResult = action.Values[2].Item2 as FsmBool;
        }
    }
}