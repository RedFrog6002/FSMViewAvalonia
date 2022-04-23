using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetBoxCollider2DSizeVector
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject1 = action.Values[0].Item2 as FsmOwnerDefault;
            FsmVector2 size = action.Values[1].Item2 as FsmVector2;
            FsmVector2 offset = action.Values[2].Item2 as FsmVector2;
        }
    }
}