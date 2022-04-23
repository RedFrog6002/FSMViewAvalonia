using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class BoundsBoxCollider
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject1 = action.Values[0].Item2 as FsmOwnerDefault;
            FsmVector2 scaleVector2 = action.Values[1].Item2 as FsmVector2;
            FsmFloat scaleX = action.Values[2].Item2 as FsmFloat;
            FsmFloat scaleY = action.Values[3].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}