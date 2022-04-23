using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class AddMixingTransform
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString animationName = action.Values[1].Item2 as FsmString;
            FsmString transform = action.Values[2].Item2 as FsmString;
            FsmBool recursive = action.Values[3].Item2 as FsmBool;
        }
    }
}