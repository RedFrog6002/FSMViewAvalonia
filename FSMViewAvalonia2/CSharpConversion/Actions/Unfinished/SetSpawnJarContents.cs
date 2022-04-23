using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetSpawnJarContents
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject storedObject = action.Values[0].Item2 as FsmGameObject;
            FsmGameObject enemyPrefab = action.Values[1].Item2 as FsmGameObject;
            FsmInt enemyHealth = action.Values[2].Item2 as FsmInt;
        }
    }
}