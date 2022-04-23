using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SelectRandomString
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString[] strings = action.Values[0].Item2 as FsmString[];
            FsmFloat[] weights = action.Values[1].Item2 as FsmFloat[];
            FsmString storeString = action.Values[2].Item2 as FsmString;
        }
    }
}