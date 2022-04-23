using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ConvertIntToString
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmInt intVariable = action.Values[0].Item2 as FsmInt;
            FsmString stringVariable = action.Values[1].Item2 as FsmString;
            FsmString format = action.Values[2].Item2 as FsmString;
            bool everyFrame = (bool)action.Values[3].Item2;
        }
    }
}