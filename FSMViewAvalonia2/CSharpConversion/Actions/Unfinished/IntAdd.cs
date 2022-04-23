using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class IntAdd
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmInt intVariable = action.Values[0].Item2 as FsmInt;
            FsmInt add = action.Values[1].Item2 as FsmInt;
            bool everyFrame = (bool)action.Values[2].Item2;
        }
    }
}