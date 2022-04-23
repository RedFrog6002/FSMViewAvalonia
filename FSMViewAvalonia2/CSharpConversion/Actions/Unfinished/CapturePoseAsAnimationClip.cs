using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class CapturePoseAsAnimationClip
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmBool position = action.Values[1].Item2 as FsmBool;
            FsmBool rotation = action.Values[2].Item2 as FsmBool;
            FsmBool scale = action.Values[3].Item2 as FsmBool;
            FsmObject storeAnimationClip = action.Values[4].Item2 as FsmObject;
        }
    }
}