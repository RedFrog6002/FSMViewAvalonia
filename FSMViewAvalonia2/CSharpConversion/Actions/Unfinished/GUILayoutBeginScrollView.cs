using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GUILayoutBeginScrollView
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmVector2 scrollPosition = action.Values[0].Item2 as FsmVector2;
            FsmBool horizontalScrollbar = action.Values[1].Item2 as FsmBool;
            FsmBool verticalScrollbar = action.Values[2].Item2 as FsmBool;
            FsmBool useCustomStyle = action.Values[3].Item2 as FsmBool;
            FsmString horizontalStyle = action.Values[4].Item2 as FsmString;
            FsmString verticalStyle = action.Values[5].Item2 as FsmString;
            FsmString backgroundStyle = action.Values[6].Item2 as FsmString;
            LayoutOption[] layoutOptions = action.Values[7].Item2 as LayoutOption[];
        }
    }
}