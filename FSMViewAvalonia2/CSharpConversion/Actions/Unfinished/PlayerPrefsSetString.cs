using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class PlayerPrefsSetString
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString[] keys = action.Values[0].Item2 as FsmString[];
            FsmString[] values = action.Values[1].Item2 as FsmString[];
        }
    }
}