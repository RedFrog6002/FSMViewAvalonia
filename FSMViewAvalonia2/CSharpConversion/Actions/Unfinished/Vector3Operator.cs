using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class Vector3Operator
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmVector3 vector1 = action.Values[0].Item2 as FsmVector3;
            FsmVector3 vector2 = action.Values[1].Item2 as FsmVector3;
            Vector3Operation operation = action.Values[2].Item2 as Vector3Operation;
            FsmVector3 storeVector3Result = action.Values[3].Item2 as FsmVector3;
            FsmFloat storeFloatResult = action.Values[4].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[5].Item2;
        }
    }
}