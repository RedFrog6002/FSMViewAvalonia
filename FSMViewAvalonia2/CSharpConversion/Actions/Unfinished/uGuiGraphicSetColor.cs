using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class uGuiGraphicSetColor
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmColor color = action.Values[1].Item2 as FsmColor;
            FsmFloat red = action.Values[2].Item2 as FsmFloat;
            FsmFloat green = action.Values[3].Item2 as FsmFloat;
            FsmFloat blue = action.Values[4].Item2 as FsmFloat;
            FsmFloat alpha = action.Values[5].Item2 as FsmFloat;
            FsmBool resetOnExit = action.Values[6].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[7].Item2;
        }
    }
}