using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetAtan2FromVector3
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmVector3 vector3 = action.Values[0].Item2 as FsmVector3;
            aTan2EnumAxis xAxis = action.Values[1].Item2 as aTan2EnumAxis;
            aTan2EnumAxis yAxis = action.Values[2].Item2 as aTan2EnumAxis;
            FsmFloat angle = action.Values[3].Item2 as FsmFloat;
            FsmBool RadToDeg = action.Values[4].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[5].Item2;
        }
    }
}