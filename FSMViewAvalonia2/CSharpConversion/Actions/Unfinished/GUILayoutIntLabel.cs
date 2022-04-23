using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GUILayoutIntLabel
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString prefix = action.Values[0].Item2 as FsmString;
            FsmInt intVariable = action.Values[1].Item2 as FsmInt;
            FsmString style = action.Values[2].Item2 as FsmString;
            LayoutOption[] layoutOptions = action.Values[3].Item2 as LayoutOption[];
        }
    }
}