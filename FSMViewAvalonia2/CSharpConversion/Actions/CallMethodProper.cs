using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class CallMethodProper
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            string code = GetOwnerDefaultString(action.Values[0].Item2 as FsmOwnerDefault) + ".GetComponent<" + (action.Values[1].Item2 as FsmString).value + ">()." + (action.Values[2].Item2 as FsmString).value + "(";
            int length = action.Values.Count;
            for (int i = 4; i < length; i++)
            {
                if (i != 4)
                    code += ", ";
                code += GetOnlyValue(action.Values[i].Item2 as FsmVar);
            }
            code += ");";
            state.AddMiddleCode(code);
        }
    }
}
