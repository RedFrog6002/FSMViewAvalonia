using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class IdleBuzzV3
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmFloat waitMin = action.Values[1].Item2 as FsmFloat;
            FsmFloat waitMax = action.Values[2].Item2 as FsmFloat;
            FsmFloat speedMax = action.Values[3].Item2 as FsmFloat;
            FsmFloat accelerationMin = action.Values[4].Item2 as FsmFloat;
            FsmFloat accelerationMax = action.Values[5].Item2 as FsmFloat;
            FsmFloat roamingRangeX = action.Values[6].Item2 as FsmFloat;
            FsmFloat roamingRangeY = action.Values[7].Item2 as FsmFloat;
            FsmVector3 manualStartPos = action.Values[8].Item2 as FsmVector3;
        }
    }
}