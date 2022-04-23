using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class StartCoroutine
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString behaviour = action.Values[1].Item2 as FsmString;
            FunctionCall functionCall = action.Values[2].Item2 as FunctionCall;
            bool stopOnExit = (bool)action.Values[3].Item2;
        }
    }
}