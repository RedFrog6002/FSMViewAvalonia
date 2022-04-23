using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GUILayoutRepeatButton
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            string sendEvent = action.Values[0].Item2 as string;
            FsmBool storeButtonState = action.Values[1].Item2 as FsmBool;
            FsmTexture image = action.Values[2].Item2 as FsmTexture;
            FsmString text = action.Values[3].Item2 as FsmString;
            FsmString tooltip = action.Values[4].Item2 as FsmString;
            FsmString style = action.Values[5].Item2 as FsmString;
            LayoutOption[] layoutOptions = action.Values[6].Item2 as LayoutOption[];
        }
    }
}