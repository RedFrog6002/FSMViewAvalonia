using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetGUIContentColor
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmColor contentColor = action.Values[0].Item2 as FsmColor;
            FsmBool applyGlobally = action.Values[1].Item2 as FsmBool;
        }
    }
}