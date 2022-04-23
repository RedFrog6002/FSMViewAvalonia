using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class LookAt2dGameObjectSmooth
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject targetObject = action.Values[1].Item2 as FsmGameObject;
            FsmFloat rotationOffset = action.Values[2].Item2 as FsmFloat;
            FsmFloat speed = action.Values[3].Item2 as FsmFloat;
            FsmBool debug = action.Values[4].Item2 as FsmBool;
            FsmColor debugLineColor = action.Values[5].Item2 as FsmColor;
        }
    }
}