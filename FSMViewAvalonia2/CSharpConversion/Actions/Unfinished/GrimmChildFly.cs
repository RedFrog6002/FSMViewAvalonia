using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GrimmChildFly
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject objectA = action.Values[0].Item2 as FsmGameObject;
            FsmGameObject objectB = action.Values[1].Item2 as FsmGameObject;
            FsmBool spriteFacesRight = action.Values[2].Item2 as FsmBool;
            bool playNewAnimation = (bool)action.Values[3].Item2;
            FsmString newAnimationClip = action.Values[4].Item2 as FsmString;
            bool resetFrame = (bool)action.Values[5].Item2;
            FsmFloat fastAnimSpeed = action.Values[6].Item2 as FsmFloat;
            FsmString fastAnimationClip = action.Values[7].Item2 as FsmString;
            FsmString normalAnimationClip = action.Values[8].Item2 as FsmString;
            FsmFloat pauseBetweenAnimChange = action.Values[9].Item2 as FsmFloat;
            bool flyingFast = (bool)action.Values[10].Item2;
        }
    }
}