using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SpawnFromPool
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject pool = action.Values[0].Item2 as FsmGameObject;
            FsmVector3 adjustPosition = action.Values[1].Item2 as FsmVector3;
            FsmInt spawnMin = action.Values[2].Item2 as FsmInt;
            FsmInt spawnMax = action.Values[3].Item2 as FsmInt;
            FsmFloat speedMin = action.Values[4].Item2 as FsmFloat;
            FsmFloat speedMax = action.Values[5].Item2 as FsmFloat;
            FsmFloat angleMin = action.Values[6].Item2 as FsmFloat;
            FsmFloat angleMax = action.Values[7].Item2 as FsmFloat;
        }
    }
}