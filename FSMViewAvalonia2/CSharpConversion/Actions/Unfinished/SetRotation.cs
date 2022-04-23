using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetRotation
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmQuaternion quaternion = action.Values[1].Item2 as FsmQuaternion;
            FsmVector3 vector = action.Values[2].Item2 as FsmVector3;
            FsmFloat xAngle = action.Values[3].Item2 as FsmFloat;
            FsmFloat yAngle = action.Values[4].Item2 as FsmFloat;
            FsmFloat zAngle = action.Values[5].Item2 as FsmFloat;
            Space space = action.Values[6].Item2 as Space;
            bool everyFrame = (bool)action.Values[7].Item2;
            bool lateUpdate = (bool)action.Values[8].Item2;
        }
    }
}