using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FlingObjectsFromGlobalPoolVel
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject gameObject = action.Values[0].Item2 as FsmGameObject;
            FsmGameObject spawnPoint = action.Values[1].Item2 as FsmGameObject;
            FsmVector3 position = action.Values[2].Item2 as FsmVector3;
            FsmInt spawnMin = action.Values[3].Item2 as FsmInt;
            FsmInt spawnMax = action.Values[4].Item2 as FsmInt;
            FsmFloat speedMinX = action.Values[5].Item2 as FsmFloat;
            FsmFloat speedMaxX = action.Values[6].Item2 as FsmFloat;
            FsmFloat speedMinY = action.Values[7].Item2 as FsmFloat;
            FsmFloat speedMaxY = action.Values[8].Item2 as FsmFloat;
            FsmFloat originVariationX = action.Values[9].Item2 as FsmFloat;
            FsmFloat originVariationY = action.Values[10].Item2 as FsmFloat;
        }
    }
}