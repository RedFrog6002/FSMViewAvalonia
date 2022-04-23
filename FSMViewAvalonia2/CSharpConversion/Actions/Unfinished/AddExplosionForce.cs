using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class AddExplosionForce
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmVector3 center = action.Values[1].Item2 as FsmVector3;
            FsmFloat force = action.Values[2].Item2 as FsmFloat;
            FsmFloat radius = action.Values[3].Item2 as FsmFloat;
            FsmFloat upwardsModifier = action.Values[4].Item2 as FsmFloat;
            ForceMode forceMode = action.Values[5].Item2 as ForceMode;
            bool everyFrame = (bool)action.Values[6].Item2;
        }
    }
}