using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetColorRGBA
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmColor color = action.Values[0].Item2 as FsmColor;
            FsmFloat storeRed = action.Values[1].Item2 as FsmFloat;
            FsmFloat storeGreen = action.Values[2].Item2 as FsmFloat;
            FsmFloat storeBlue = action.Values[3].Item2 as FsmFloat;
            FsmFloat storeAlpha = action.Values[4].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[5].Item2;
        }
    }
}