using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayListGetNearestFloatValue
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString reference = action.Values[1].Item2 as FsmString;
            FsmFloat floatValue = action.Values[2].Item2 as FsmFloat;
            bool everyframe = (bool)action.Values[3].Item2;
            FsmInt nearestIndex = action.Values[4].Item2 as FsmInt;
            FsmFloat nearestValue = action.Values[5].Item2 as FsmFloat;
        }
    }
}