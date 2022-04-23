using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SelectRandomGameObject
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject[] gameObjects = action.Values[0].Item2 as FsmGameObject[];
            FsmFloat[] weights = action.Values[1].Item2 as FsmFloat[];
            FsmGameObject storeGameObject = action.Values[2].Item2 as FsmGameObject;
        }
    }
}