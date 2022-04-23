using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetCanSeeHero
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmObject lineOfSightDetector = action.Values[0].Item2 as FsmObject;
            FsmBool storeResult = action.Values[1].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[2].Item2;
        }
    }
}