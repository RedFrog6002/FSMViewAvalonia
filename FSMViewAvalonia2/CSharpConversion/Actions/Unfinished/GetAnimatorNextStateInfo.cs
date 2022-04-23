using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetAnimatorNextStateInfo
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmInt layerIndex = action.Values[1].Item2 as FsmInt;
            FsmString name = action.Values[2].Item2 as FsmString;
            FsmInt nameHash = action.Values[3].Item2 as FsmInt;
            FsmInt tagHash = action.Values[4].Item2 as FsmInt;
            FsmBool isStateLooping = action.Values[5].Item2 as FsmBool;
            FsmFloat length = action.Values[6].Item2 as FsmFloat;
            FsmFloat normalizedTime = action.Values[7].Item2 as FsmFloat;
            FsmInt loopCount = action.Values[8].Item2 as FsmInt;
            FsmFloat currentLoopProgress = action.Values[9].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[10].Item2;
            AnimatorFrameUpdateSelector everyFrameOption = action.Values[11].Item2 as AnimatorFrameUpdateSelector;
        }
    }
}