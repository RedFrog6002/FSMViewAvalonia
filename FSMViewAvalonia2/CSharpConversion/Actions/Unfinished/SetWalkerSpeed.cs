using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetWalkerSpeed
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat walkSpeedL = action.Values[0].Item2 as FsmFloat;
            FsmFloat walkSpeedR = action.Values[1].Item2 as FsmFloat;
            FsmOwnerDefault target = action.Values[2].Item2 as FsmOwnerDefault;
            bool everyFrame = (bool)action.Values[3].Item2;
        }
    }
}