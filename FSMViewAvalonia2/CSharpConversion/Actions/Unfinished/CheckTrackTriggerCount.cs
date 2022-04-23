using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class CheckTrackTriggerCount
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault target = action.Values[0].Item2 as FsmOwnerDefault;
            FsmInt count = action.Values[1].Item2 as FsmInt;
            FsmEnum test = action.Values[2].Item2 as FsmEnum;
            bool everyFrame = (bool)action.Values[3].Item2;
            string successEvent = action.Values[4].Item2 as string;
        }
    }
}