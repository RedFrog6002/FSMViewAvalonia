using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class Vector3Subtract
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmVector3 vector3Variable = action.Values[0].Item2 as FsmVector3;
            FsmVector3 subtractVector = action.Values[1].Item2 as FsmVector3;
            bool everyFrame = (bool)action.Values[2].Item2;
        }
    }
}