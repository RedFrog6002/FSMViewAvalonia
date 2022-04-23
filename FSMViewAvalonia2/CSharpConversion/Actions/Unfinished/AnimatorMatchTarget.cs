using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class AnimatorMatchTarget
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            AvatarTarget bodyPart = action.Values[1].Item2 as AvatarTarget;
            FsmGameObject target = action.Values[2].Item2 as FsmGameObject;
            FsmVector3 targetPosition = action.Values[3].Item2 as FsmVector3;
            FsmQuaternion targetRotation = action.Values[4].Item2 as FsmQuaternion;
            FsmVector3 positionWeight = action.Values[5].Item2 as FsmVector3;
            FsmFloat rotationWeight = action.Values[6].Item2 as FsmFloat;
            FsmFloat startNormalizedTime = action.Values[7].Item2 as FsmFloat;
            FsmFloat targetNormalizedTime = action.Values[8].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[9].Item2;
        }
    }
}