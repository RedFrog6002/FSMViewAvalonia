using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class CheckCollisionSideEnter
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmBool topHit = action.Values[0].Item2 as FsmBool;
            FsmBool rightHit = action.Values[1].Item2 as FsmBool;
            FsmBool bottomHit = action.Values[2].Item2 as FsmBool;
            FsmBool leftHit = action.Values[3].Item2 as FsmBool;
            string topHitEvent = action.Values[4].Item2 as string;
            string rightHitEvent = action.Values[5].Item2 as string;
            string bottomHitEvent = action.Values[6].Item2 as string;
            string leftHitEvent = action.Values[7].Item2 as string;
            bool otherLayer = (bool)action.Values[8].Item2;
            int otherLayerNumber = (int)action.Values[9].Item2;
            FsmBool ignoreTriggers = action.Values[10].Item2 as FsmBool;
        }
    }
}