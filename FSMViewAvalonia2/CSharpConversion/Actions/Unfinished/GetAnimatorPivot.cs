using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetAnimatorPivot
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmFloat pivotWeight = action.Values[1].Item2 as FsmFloat;
            FsmVector3 pivotPosition = action.Values[2].Item2 as FsmVector3;
            bool everyFrame = (bool)action.Values[3].Item2;
            AnimatorFrameUpdateSelector everyFrameOption = action.Values[4].Item2 as AnimatorFrameUpdateSelector;
        }
    }
}