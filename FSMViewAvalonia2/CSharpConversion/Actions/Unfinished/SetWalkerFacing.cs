using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetWalkerFacing
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmBool walkRight = action.Values[0].Item2 as FsmBool;
            FsmBool randomStartDir = action.Values[1].Item2 as FsmBool;
            FsmOwnerDefault target = action.Values[2].Item2 as FsmOwnerDefault;
            bool everyFrame = (bool)action.Values[3].Item2;
        }
    }
}