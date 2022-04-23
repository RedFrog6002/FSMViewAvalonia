using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetGUISkin
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            GUISkin skin = action.Values[0].Item2 as GUISkin;
            FsmBool applyGlobally = action.Values[1].Item2 as FsmBool;
        }
    }
}