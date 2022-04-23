using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class BoolTest
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmBool boolVariable = action.Values[0].Item2 as FsmBool;
            string isTrue = action.Values[1].Item2 as string;
            string isFalse = action.Values[2].Item2 as string;
            bool everyFrame = (bool)action.Values[3].Item2;
        }
    }
}