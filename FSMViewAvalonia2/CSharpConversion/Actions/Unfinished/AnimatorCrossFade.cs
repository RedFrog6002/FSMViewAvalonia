using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class AnimatorCrossFade
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString stateName = action.Values[1].Item2 as FsmString;
            FsmFloat transitionDuration = action.Values[2].Item2 as FsmFloat;
            FsmInt layer = action.Values[3].Item2 as FsmInt;
            FsmFloat normalizedTime = action.Values[4].Item2 as FsmFloat;
        }
    }
}