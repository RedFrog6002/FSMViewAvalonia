using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ReflectAngle
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat angle = action.Values[0].Item2 as FsmFloat;
            bool reflectHorizontally = (bool)action.Values[1].Item2;
            bool reflectVertically = (bool)action.Values[2].Item2;
            FsmFloat storeResult = action.Values[3].Item2 as FsmFloat;
        }
    }
}