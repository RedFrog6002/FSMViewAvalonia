using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class AnimationSettings
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString animName = action.Values[1].Item2 as FsmString;
            WrapMode wrapMode = action.Values[2].Item2 as WrapMode;
            AnimationBlendMode blendMode = action.Values[3].Item2 as AnimationBlendMode;
            FsmFloat speed = action.Values[4].Item2 as FsmFloat;
            FsmInt layer = action.Values[5].Item2 as FsmInt;
        }
    }
}