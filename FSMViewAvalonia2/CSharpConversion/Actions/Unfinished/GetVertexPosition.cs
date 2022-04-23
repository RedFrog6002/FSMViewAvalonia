using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetVertexPosition
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmInt vertexIndex = action.Values[1].Item2 as FsmInt;
            Space space = action.Values[2].Item2 as Space;
            FsmVector3 storePosition = action.Values[3].Item2 as FsmVector3;
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}