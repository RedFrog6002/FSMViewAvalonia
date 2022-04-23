using System;
using System.Collections.Generic;
using System.Text;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class WalkLeftRight
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            float walkSpeed = (float)action.Values[1].Item2;
            bool spriteFacesLeft = (bool)action.Values[2].Item2;
            FsmString groundLayer = action.Values[3].Item2 as FsmString;
            float turnDelay = (float)action.Values[4].Item2;
            float nextTurnTime = (float)action.Values[5].Item2;
            FsmString walkAnimName = action.Values[6].Item2 as FsmString;
            FsmString turnAnimName = action.Values[7].Item2 as FsmString;
            FsmBool startLeft = action.Values[8].Item2 as FsmBool;
            FsmBool startRight = action.Values[9].Item2 as FsmBool;
            FsmBool keepDirection = action.Values[10].Item2 as FsmBool;
        }
    }
}
