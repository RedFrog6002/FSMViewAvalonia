using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GUILayoutToggle
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmBool storeButtonState = action.Values[0].Item2 as FsmBool;
            FsmTexture image = action.Values[1].Item2 as FsmTexture;
            FsmString text = action.Values[2].Item2 as FsmString;
            FsmString tooltip = action.Values[3].Item2 as FsmString;
            FsmString style = action.Values[4].Item2 as FsmString;
            string changedEvent = action.Values[5].Item2 as string;
            LayoutOption[] layoutOptions = action.Values[6].Item2 as LayoutOption[];
        }
    }
}