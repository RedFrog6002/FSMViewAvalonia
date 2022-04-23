using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayListIsEmpty
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString reference = action.Values[1].Item2 as FsmString;
            FsmBool isEmpty = action.Values[2].Item2 as FsmBool;
            string isEmptyEvent = action.Values[3].Item2 as string;
            string isNotEmptyEvent = action.Values[4].Item2 as string;
        }
    }
}