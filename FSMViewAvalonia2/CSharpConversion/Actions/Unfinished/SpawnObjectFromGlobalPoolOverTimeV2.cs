using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SpawnObjectFromGlobalPoolOverTimeV2
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject gameObject = action.Values[0].Item2 as FsmGameObject;
            FsmGameObject spawnPoint = action.Values[1].Item2 as FsmGameObject;
            FsmVector3 position = action.Values[2].Item2 as FsmVector3;
            FsmVector3 rotation = action.Values[3].Item2 as FsmVector3;
            FsmFloat frequency = action.Values[4].Item2 as FsmFloat;
            FsmFloat scaleMin = action.Values[5].Item2 as FsmFloat;
            FsmFloat scaleMax = action.Values[6].Item2 as FsmFloat;
        }
    }
}