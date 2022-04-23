using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetRaycastAllInfo
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmArray storeHitObjects = action.Values[0].Item2 as FsmArray;
            FsmArray points = action.Values[1].Item2 as FsmArray;
            FsmArray normals = action.Values[2].Item2 as FsmArray;
            FsmArray distances = action.Values[3].Item2 as FsmArray;
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}