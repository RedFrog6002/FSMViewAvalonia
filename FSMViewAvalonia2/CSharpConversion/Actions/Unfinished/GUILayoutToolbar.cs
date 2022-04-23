using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GUILayoutToolbar
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmInt numButtons = action.Values[0].Item2 as FsmInt;
            FsmInt selectedButton = action.Values[1].Item2 as FsmInt;
            FsmEvent[] buttonEventsArray = action.Values[2].Item2 as FsmEvent[];
            FsmTexture[] imagesArray = action.Values[3].Item2 as FsmTexture[];
            FsmString[] textsArray = action.Values[4].Item2 as FsmString[];
            FsmString[] tooltipsArray = action.Values[5].Item2 as FsmString[];
            FsmString style = action.Values[6].Item2 as FsmString;
            bool everyFrame = (bool)action.Values[7].Item2;
            LayoutOption[] layoutOptions = action.Values[8].Item2 as LayoutOption[];
        }
    }
}