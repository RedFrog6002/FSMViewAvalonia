using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class BaseFsmVariableAction
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            string fsmNotFound = action.Values[0].Item2 as string;
            string variableNotFound = action.Values[1].Item2 as string;
        }
    }
}