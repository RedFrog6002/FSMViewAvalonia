using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class CheckCanSeeHero
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmBool storeResult = action.Values[0].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[1].Item2;
        }
    }
}