using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetNextPreSpawnedGameObject
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmArray storedArray = action.Values[0].Item2 as FsmArray;
            FsmVector3 spawnPosition = action.Values[1].Item2 as FsmVector3;
            FsmGameObject storeObject = action.Values[2].Item2 as FsmGameObject;
            FsmInt currentIndex = action.Values[3].Item2 as FsmInt;
        }
    }
}