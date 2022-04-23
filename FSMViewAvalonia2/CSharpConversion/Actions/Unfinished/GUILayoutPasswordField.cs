using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GUILayoutPasswordField
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString text = action.Values[0].Item2 as FsmString;
            FsmInt maxLength = action.Values[1].Item2 as FsmInt;
            FsmString style = action.Values[2].Item2 as FsmString;
            string changedEvent = action.Values[3].Item2 as string;
            FsmString mask = action.Values[4].Item2 as FsmString;
            LayoutOption[] layoutOptions = action.Values[5].Item2 as LayoutOption[];
        }
    }
}