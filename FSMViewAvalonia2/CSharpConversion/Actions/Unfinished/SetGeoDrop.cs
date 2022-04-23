using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetGeoDrop
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault target = action.Values[0].Item2 as FsmOwnerDefault;
            FsmInt smallGeo = action.Values[1].Item2 as FsmInt;
            FsmInt mediumGeo = action.Values[2].Item2 as FsmInt;
            FsmInt largeGeo = action.Values[3].Item2 as FsmInt;
        }
    }
}