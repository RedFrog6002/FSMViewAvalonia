using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetAnimatorLookAt
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject target = action.Values[1].Item2 as FsmGameObject;
            FsmVector3 targetPosition = action.Values[2].Item2 as FsmVector3;
            FsmFloat weight = action.Values[3].Item2 as FsmFloat;
            FsmFloat bodyWeight = action.Values[4].Item2 as FsmFloat;
            FsmFloat headWeight = action.Values[5].Item2 as FsmFloat;
            FsmFloat eyesWeight = action.Values[6].Item2 as FsmFloat;
            FsmFloat clampWeight = action.Values[7].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[8].Item2;
        }
    }
}