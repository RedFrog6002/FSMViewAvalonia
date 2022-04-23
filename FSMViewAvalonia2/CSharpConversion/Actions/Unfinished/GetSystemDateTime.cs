using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetSystemDateTime
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString storeString = action.Values[0].Item2 as FsmString;
            FsmString format = action.Values[1].Item2 as FsmString;
            bool everyFrame = (bool)action.Values[2].Item2;
        }
    }
}