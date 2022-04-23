using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class CreateUIMsgGetItem
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject gameObject = action.Values[0].Item2 as FsmGameObject;
            FsmGameObject storeObject = action.Values[1].Item2 as FsmGameObject;
            FsmObject sprite = action.Values[2].Item2 as FsmObject;
        }
    }
}