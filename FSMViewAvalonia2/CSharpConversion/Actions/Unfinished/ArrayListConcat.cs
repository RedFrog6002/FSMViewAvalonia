using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayListConcat
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString reference = action.Values[1].Item2 as FsmString;
            FsmOwnerDefault[] arrayListGameObjectTargets = action.Values[2].Item2 as FsmOwnerDefault[];
            FsmString[] referenceTargets = action.Values[3].Item2 as FsmString[];
        }
    }
}