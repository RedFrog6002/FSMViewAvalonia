using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetGUIAlpha
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat alpha = action.Values[0].Item2 as FsmFloat;
            FsmBool applyGlobally = action.Values[1].Item2 as FsmBool;
        }
    }
}