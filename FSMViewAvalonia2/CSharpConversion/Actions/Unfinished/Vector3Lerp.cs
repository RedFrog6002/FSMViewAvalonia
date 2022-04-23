using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class Vector3Lerp
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmVector3 fromVector = action.Values[0].Item2 as FsmVector3;
            FsmVector3 toVector = action.Values[1].Item2 as FsmVector3;
            FsmFloat amount = action.Values[2].Item2 as FsmFloat;
            FsmVector3 storeResult = action.Values[3].Item2 as FsmVector3;
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}