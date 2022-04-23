using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetBoxCollider2DSize
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject1 = action.Values[0].Item2 as FsmOwnerDefault;
            FsmFloat width = action.Values[1].Item2 as FsmFloat;
            FsmFloat height = action.Values[2].Item2 as FsmFloat;
            FsmFloat offsetX = action.Values[3].Item2 as FsmFloat;
            FsmFloat offsetY = action.Values[4].Item2 as FsmFloat;
        }
    }
}