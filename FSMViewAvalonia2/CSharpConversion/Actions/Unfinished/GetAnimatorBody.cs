using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetAnimatorBody
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmVector3 bodyPosition = action.Values[1].Item2 as FsmVector3;
            FsmQuaternion bodyRotation = action.Values[2].Item2 as FsmQuaternion;
            FsmGameObject bodyGameObject = action.Values[3].Item2 as FsmGameObject;
            bool everyFrame = (bool)action.Values[4].Item2;
            AnimatorFrameUpdateSelector everyFrameOption = action.Values[5].Item2 as AnimatorFrameUpdateSelector;
        }
    }
}