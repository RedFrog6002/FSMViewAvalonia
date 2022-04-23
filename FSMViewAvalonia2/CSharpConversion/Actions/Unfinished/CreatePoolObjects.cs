using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class CreatePoolObjects
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject gameObject = action.Values[0].Item2 as FsmGameObject;
            FsmGameObject pool = action.Values[1].Item2 as FsmGameObject;
            FsmVector3 position = action.Values[2].Item2 as FsmVector3;
            FsmInt amount = action.Values[3].Item2 as FsmInt;
            FsmFloat originVariationX = action.Values[4].Item2 as FsmFloat;
            FsmFloat originVariationY = action.Values[5].Item2 as FsmFloat;
            bool deactivate = (bool)action.Values[6].Item2;
        }
    }
}