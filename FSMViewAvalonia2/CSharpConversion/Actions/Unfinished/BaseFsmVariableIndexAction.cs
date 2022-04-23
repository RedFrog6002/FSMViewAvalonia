using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class BaseFsmVariableIndexAction
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            string indexOutOfRange = action.Values[0].Item2 as string;
            string fsmNotFound = action.Values[1].Item2 as string;
            string variableNotFound = action.Values[2].Item2 as string;
        }
    }
}