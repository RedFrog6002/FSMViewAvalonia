using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetAnimatorIsMatchingTarget
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmBool isMatchingActive = action.Values[1].Item2 as FsmBool;
            string matchingActivatedEvent = action.Values[2].Item2 as string;
            string matchingDeactivedEvent = action.Values[3].Item2 as string;
            bool everyFrame = (bool)action.Values[4].Item2;
            AnimatorFrameUpdateSelector everyFrameOption = action.Values[5].Item2 as AnimatorFrameUpdateSelector;
        }
    }
}