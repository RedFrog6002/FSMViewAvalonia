using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetIntFromFloat
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmInt intVariable = action.Values[0].Item2 as FsmInt;
            FsmFloat floatValue = action.Values[1].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[2].Item2;
        }
    }
}