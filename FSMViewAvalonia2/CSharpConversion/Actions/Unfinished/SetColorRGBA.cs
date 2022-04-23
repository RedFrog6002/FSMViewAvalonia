using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetColorRGBA
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmColor colorVariable = action.Values[0].Item2 as FsmColor;
            FsmFloat red = action.Values[1].Item2 as FsmFloat;
            FsmFloat green = action.Values[2].Item2 as FsmFloat;
            FsmFloat blue = action.Values[3].Item2 as FsmFloat;
            FsmFloat alpha = action.Values[4].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[5].Item2;
        }
    }
}