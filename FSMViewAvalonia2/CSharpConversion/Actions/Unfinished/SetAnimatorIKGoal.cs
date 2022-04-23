using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetAnimatorIKGoal
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            AvatarIKGoal iKGoal = action.Values[1].Item2 as AvatarIKGoal;
            FsmGameObject goal = action.Values[2].Item2 as FsmGameObject;
            FsmVector3 position = action.Values[3].Item2 as FsmVector3;
            FsmQuaternion rotation = action.Values[4].Item2 as FsmQuaternion;
            FsmFloat positionWeight = action.Values[5].Item2 as FsmFloat;
            FsmFloat rotationWeight = action.Values[6].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[7].Item2;
        }
    }
}