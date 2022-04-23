using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetMeshRendererBounds
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmFloat width = action.Values[1].Item2 as FsmFloat;
            FsmFloat height = action.Values[2].Item2 as FsmFloat;
            FsmFloat widthMax = action.Values[3].Item2 as FsmFloat;
            FsmFloat heightMax = action.Values[4].Item2 as FsmFloat;
        }
    }
}