using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetRandomRotation
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmBool x = action.Values[1].Item2 as FsmBool;
            FsmBool y = action.Values[2].Item2 as FsmBool;
            FsmBool z = action.Values[3].Item2 as FsmBool;
        }
    }
}