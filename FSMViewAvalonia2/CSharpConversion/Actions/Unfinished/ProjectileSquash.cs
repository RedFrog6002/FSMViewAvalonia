using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ProjectileSquash
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmFloat stretchFactor = action.Values[1].Item2 as FsmFloat;
            float stretchMinX = (float)action.Values[2].Item2;
            float stretchMaxY = (float)action.Values[3].Item2;
            FsmFloat scaleModifier = action.Values[4].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[5].Item2;
        }
    }
}