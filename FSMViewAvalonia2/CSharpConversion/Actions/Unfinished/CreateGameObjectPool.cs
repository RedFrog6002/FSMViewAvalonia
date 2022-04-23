using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class CreateGameObjectPool
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject prefab = action.Values[0].Item2 as FsmGameObject;
            FsmInt amount = action.Values[1].Item2 as FsmInt;
            FsmBool useExisting = action.Values[2].Item2 as FsmBool;
        }
    }
}