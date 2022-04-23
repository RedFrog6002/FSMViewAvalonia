using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetAnimatorCurrentStateInfoIsTag
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmInt layerIndex = action.Values[1].Item2 as FsmInt;
            FsmString tag = action.Values[2].Item2 as FsmString;
            FsmBool tagMatch = action.Values[3].Item2 as FsmBool;
            string tagMatchEvent = action.Values[4].Item2 as string;
            string tagDoNotMatchEvent = action.Values[5].Item2 as string;
            bool everyFrame = (bool)action.Values[6].Item2;
            AnimatorFrameUpdateSelector everyFrameOption = action.Values[7].Item2 as AnimatorFrameUpdateSelector;
        }
    }
}