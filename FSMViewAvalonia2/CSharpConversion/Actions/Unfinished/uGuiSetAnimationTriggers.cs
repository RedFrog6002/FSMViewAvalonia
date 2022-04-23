using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class uGuiSetAnimationTriggers
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString normalTrigger = action.Values[1].Item2 as FsmString;
            FsmString highlightedTrigger = action.Values[2].Item2 as FsmString;
            FsmString pressedTrigger = action.Values[3].Item2 as FsmString;
            FsmString disabledTrigger = action.Values[4].Item2 as FsmString;
            FsmBool resetOnExit = action.Values[5].Item2 as FsmBool;
        }
    }
}