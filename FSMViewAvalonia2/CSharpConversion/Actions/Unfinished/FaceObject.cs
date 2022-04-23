using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FaceObject
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject objectA = action.Values[0].Item2 as FsmGameObject;
            FsmGameObject objectB = action.Values[1].Item2 as FsmGameObject;
            FsmBool spriteFacesRight = action.Values[2].Item2 as FsmBool;
            bool playNewAnimation = (bool)action.Values[3].Item2;
            FsmString newAnimationClip = action.Values[4].Item2 as FsmString;
            bool resetFrame = (bool)action.Values[5].Item2;
            bool everyFrame = (bool)action.Values[6].Item2;
        }
    }
}