using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class PreSpawnGameObjects
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject prefab = action.Values[0].Item2 as FsmGameObject;
            FsmArray storeArray = action.Values[1].Item2 as FsmArray;
            FsmInt spawnAmount = action.Values[2].Item2 as FsmInt;
            FsmInt spawnAmountMultiplier = action.Values[3].Item2 as FsmInt;
        }
    }
}