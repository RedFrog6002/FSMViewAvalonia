using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class uGuiTransitionGetType
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString transition = action.Values[1].Item2 as FsmString;
            string colorTintEvent = action.Values[2].Item2 as string;
            string spriteSwapEvent = action.Values[3].Item2 as string;
            string animationEvent = action.Values[4].Item2 as string;
            string noTransitionEvent = action.Values[5].Item2 as string;
        }
    }
}