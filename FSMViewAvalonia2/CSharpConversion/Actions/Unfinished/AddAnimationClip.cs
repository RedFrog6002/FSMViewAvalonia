using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class AddAnimationClip
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmObject animationClip = action.Values[1].Item2 as FsmObject;
            FsmString animationName = action.Values[2].Item2 as FsmString;
            FsmInt firstFrame = action.Values[3].Item2 as FsmInt;
            FsmInt lastFrame = action.Values[4].Item2 as FsmInt;
            FsmBool addLoopFrame = action.Values[5].Item2 as FsmBool;
        }
    }
}