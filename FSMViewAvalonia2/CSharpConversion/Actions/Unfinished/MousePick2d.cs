using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class MousePick2d
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmBool storeDidPickObject = action.Values[0].Item2 as FsmBool;
            FsmGameObject storeGameObject = action.Values[1].Item2 as FsmGameObject;
            FsmVector2 storePoint = action.Values[2].Item2 as FsmVector2;
            FsmInt[] layerMask = action.Values[3].Item2 as FsmInt[];
            FsmBool invertMask = action.Values[4].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[5].Item2;
        }
    }
}