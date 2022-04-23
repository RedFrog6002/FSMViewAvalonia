using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class DebugDrawShape
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            ShapeType shape = action.Values[1].Item2 as ShapeType;
            FsmColor color = action.Values[2].Item2 as FsmColor;
            FsmFloat radius = action.Values[3].Item2 as FsmFloat;
            FsmVector3 size = action.Values[4].Item2 as FsmVector3;
        }
    }
}