using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class AnimatorStopRecording
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmFloat recorderStartTime = action.Values[1].Item2 as FsmFloat;
            FsmFloat recorderStopTime = action.Values[2].Item2 as FsmFloat;
        }
    }
}