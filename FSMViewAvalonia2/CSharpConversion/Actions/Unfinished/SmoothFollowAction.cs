using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SmoothFollowAction
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject targetObject = action.Values[1].Item2 as FsmGameObject;
            FsmFloat distance = action.Values[2].Item2 as FsmFloat;
            FsmFloat height = action.Values[3].Item2 as FsmFloat;
            FsmFloat heightDamping = action.Values[4].Item2 as FsmFloat;
            FsmFloat rotationDamping = action.Values[5].Item2 as FsmFloat;
        }
    }
}