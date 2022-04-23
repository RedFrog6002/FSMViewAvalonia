using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class uGuiSetColorBlock
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmFloat fadeDuration = action.Values[1].Item2 as FsmFloat;
            FsmFloat colorMultiplier = action.Values[2].Item2 as FsmFloat;
            FsmColor normalColor = action.Values[3].Item2 as FsmColor;
            FsmColor pressedColor = action.Values[4].Item2 as FsmColor;
            FsmColor highlightedColor = action.Values[5].Item2 as FsmColor;
            FsmColor disabledColor = action.Values[6].Item2 as FsmColor;
            FsmBool resetOnExit = action.Values[7].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[8].Item2;
        }
    }
}