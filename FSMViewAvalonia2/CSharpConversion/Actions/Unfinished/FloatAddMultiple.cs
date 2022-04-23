using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FloatAddMultiple
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat[] floatVariables = action.Values[0].Item2 as FsmFloat[];
            FsmFloat addTo = action.Values[1].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[2].Item2;
        }
    }
}