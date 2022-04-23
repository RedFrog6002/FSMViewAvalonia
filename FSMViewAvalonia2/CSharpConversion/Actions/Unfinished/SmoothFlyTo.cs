using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SmoothFlyTo
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject target = action.Values[1].Item2 as FsmGameObject;
            FsmFloat distance = action.Values[2].Item2 as FsmFloat;
            FsmFloat speedMax = action.Values[3].Item2 as FsmFloat;
            FsmFloat accelerationForce = action.Values[4].Item2 as FsmFloat;
            FsmFloat targetRadius = action.Values[5].Item2 as FsmFloat;
            FsmFloat deceleration = action.Values[6].Item2 as FsmFloat;
            FsmVector3 offset = action.Values[7].Item2 as FsmVector3;
        }
    }
}