using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FaceDirection
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmBool spriteFacesRight = action.Values[1].Item2 as FsmBool;
            bool playNewAnimation = (bool)action.Values[2].Item2;
            FsmString newAnimationClip = action.Values[3].Item2 as FsmString;
            bool everyFrame = (bool)action.Values[4].Item2;
            bool pauseBetweenTurns = (bool)action.Values[5].Item2;
            FsmFloat pauseTime = action.Values[6].Item2 as FsmFloat;
        }
    }
}