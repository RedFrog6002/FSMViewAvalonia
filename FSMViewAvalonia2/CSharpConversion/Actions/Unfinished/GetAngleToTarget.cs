using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetAngleToTarget
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject targetObject = action.Values[1].Item2 as FsmGameObject;
            FsmVector3 targetPosition = action.Values[2].Item2 as FsmVector3;
            FsmBool ignoreHeight = action.Values[3].Item2 as FsmBool;
            FsmFloat storeAngle = action.Values[4].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[5].Item2;
        }
    }
}