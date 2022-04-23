using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayListCopyTo
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString reference = action.Values[1].Item2 as FsmString;
            FsmOwnerDefault gameObjectTarget = action.Values[2].Item2 as FsmOwnerDefault;
            FsmString referenceTarget = action.Values[3].Item2 as FsmString;
            FsmInt startIndex = action.Values[4].Item2 as FsmInt;
            FsmInt count = action.Values[5].Item2 as FsmInt;
        }
    }
}