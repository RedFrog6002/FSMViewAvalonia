using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class QuaternionCompare
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmQuaternion Quaternion1 = action.Values[0].Item2 as FsmQuaternion;
            FsmQuaternion Quaternion2 = action.Values[1].Item2 as FsmQuaternion;
            FsmBool equal = action.Values[2].Item2 as FsmBool;
            string equalEvent = action.Values[3].Item2 as string;
            string notEqualEvent = action.Values[4].Item2 as string;
            bool everyFrame = (bool)action.Values[5].Item2;
            everyFrameOptions everyFrameOption = action.Values[6].Item2 as everyFrameOptions;
        }
    }
}