using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ShakePositionV2
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault Target = action.Values[0].Item2 as FsmOwnerDefault;
            FsmVector3 Extents = action.Values[1].Item2 as FsmVector3;
            FsmFloat Duration = action.Values[2].Item2 as FsmFloat;
            FsmBool IsLooping = action.Values[3].Item2 as FsmBool;
            string StopEvent = action.Values[4].Item2 as string;
            FsmFloat FpsLimit = action.Values[5].Item2 as FsmFloat;
            FsmBool IsCameraShake = action.Values[6].Item2 as FsmBool;
        }
    }
}