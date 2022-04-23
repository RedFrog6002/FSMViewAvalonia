using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GUILayoutBeginHorizontal
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmTexture image = action.Values[0].Item2 as FsmTexture;
            FsmString text = action.Values[1].Item2 as FsmString;
            FsmString tooltip = action.Values[2].Item2 as FsmString;
            FsmString style = action.Values[3].Item2 as FsmString;
            LayoutOption[] layoutOptions = action.Values[4].Item2 as LayoutOption[];
        }
    }
}