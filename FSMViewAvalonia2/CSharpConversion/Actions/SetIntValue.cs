using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetIntValue
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            if ((bool)action.Values[2].Item2)
            {
                state.AddBeginningCode("Coroutine SetIntValueEveryFrame = null;");
                state.AddMiddleCode("IEnumerator SetIntValueEveryFrameRoutine()");
                state.AddMiddleCode("{");
                state.AddMiddleCode("    while (true)");
                state.AddMiddleCode("    {");
                state.AddMiddleCode("        " + (action.Values[0].Item2 as FsmInt).name + " = " + action.Values[1].Item2);
                state.AddMiddleCode("        yield return null;");
                state.AddMiddleCode("    }");
                state.AddMiddleCode("}");
                state.AddMiddleCode("SetIntValueEveryFrame = StartCoroutine(SetIntValueEveryFrameRoutine());");
                state.AddReturnCode("StopCoroutine(SetIntValueEveryFrame);");
            }
            else
                state.AddMiddleCode((action.Values[0].Item2 as FsmInt).name + " = " + action.Values[1].Item2);
        }
    }
}
