using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ChaseObjectV2
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject target = action.Values[1].Item2 as FsmGameObject;
            FsmFloat speedMax = action.Values[2].Item2 as FsmFloat;
            FsmFloat accelerationForce = action.Values[3].Item2 as FsmFloat;
            FsmFloat offsetX = action.Values[4].Item2 as FsmFloat;
            FsmFloat offsetY = action.Values[5].Item2 as FsmFloat;
        }
    }
}