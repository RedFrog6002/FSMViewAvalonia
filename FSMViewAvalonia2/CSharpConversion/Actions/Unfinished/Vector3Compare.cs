using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class Vector3Compare
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmVector3 vector3Variable1 = action.Values[0].Item2 as FsmVector3;
            FsmVector3 vector3Variable2 = action.Values[1].Item2 as FsmVector3;
            FsmFloat tolerance = action.Values[2].Item2 as FsmFloat;
            string equal = action.Values[3].Item2 as string;
            string notEqual = action.Values[4].Item2 as string;
            bool everyFrame = (bool)action.Values[5].Item2;
        }
    }
}