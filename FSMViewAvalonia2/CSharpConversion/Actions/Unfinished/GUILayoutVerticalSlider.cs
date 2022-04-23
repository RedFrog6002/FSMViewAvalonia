using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GUILayoutVerticalSlider
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat floatVariable = action.Values[0].Item2 as FsmFloat;
            FsmFloat topValue = action.Values[1].Item2 as FsmFloat;
            FsmFloat bottomValue = action.Values[2].Item2 as FsmFloat;
            string changedEvent = action.Values[3].Item2 as string;
            LayoutOption[] layoutOptions = action.Values[4].Item2 as LayoutOption[];
        }
    }
}