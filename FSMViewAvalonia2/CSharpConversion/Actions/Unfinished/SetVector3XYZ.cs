using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetVector3XYZ
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmVector3 vector3Variable = action.Values[0].Item2 as FsmVector3;
            FsmVector3 vector3Value = action.Values[1].Item2 as FsmVector3;
            FsmFloat x = action.Values[2].Item2 as FsmFloat;
            FsmFloat y = action.Values[3].Item2 as FsmFloat;
            FsmFloat z = action.Values[4].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[5].Item2;
        }
    }
}