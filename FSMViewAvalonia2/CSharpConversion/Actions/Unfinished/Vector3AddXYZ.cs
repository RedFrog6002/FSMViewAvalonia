using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class Vector3AddXYZ
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmVector3 vector3Variable = action.Values[0].Item2 as FsmVector3;
            FsmFloat addX = action.Values[1].Item2 as FsmFloat;
            FsmFloat addY = action.Values[2].Item2 as FsmFloat;
            FsmFloat addZ = action.Values[3].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[4].Item2;
            bool perSecond = (bool)action.Values[5].Item2;
        }
    }
}