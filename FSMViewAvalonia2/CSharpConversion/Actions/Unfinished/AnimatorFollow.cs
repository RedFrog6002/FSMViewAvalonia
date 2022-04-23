using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class AnimatorFollow
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject target = action.Values[1].Item2 as FsmGameObject;
            FsmFloat minimumDistance = action.Values[2].Item2 as FsmFloat;
            FsmFloat speedDampTime = action.Values[3].Item2 as FsmFloat;
            FsmFloat directionDampTime = action.Values[4].Item2 as FsmFloat;
        }
    }
}