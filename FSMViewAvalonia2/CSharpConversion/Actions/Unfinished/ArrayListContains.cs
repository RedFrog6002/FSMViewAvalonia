using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayListContains
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString reference = action.Values[1].Item2 as FsmString;
            FsmVar variable = action.Values[2].Item2 as FsmVar;
            FsmBool isContained = action.Values[3].Item2 as FsmBool;
            string isContainedEvent = action.Values[4].Item2 as string;
            string isNotContainedEvent = action.Values[5].Item2 as string;
        }
    }
}