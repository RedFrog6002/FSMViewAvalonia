using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GUILayoutFloatField
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat floatVariable = action.Values[0].Item2 as FsmFloat;
            FsmString style = action.Values[1].Item2 as FsmString;
            string changedEvent = action.Values[2].Item2 as string;
            LayoutOption[] layoutOptions = action.Values[3].Item2 as LayoutOption[];
        }
    }
}