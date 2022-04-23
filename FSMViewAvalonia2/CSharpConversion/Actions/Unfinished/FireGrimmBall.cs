using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FireGrimmBall
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject storedObject = action.Values[0].Item2 as FsmGameObject;
            FsmFloat tweenY = action.Values[1].Item2 as FsmFloat;
            FsmFloat force = action.Values[2].Item2 as FsmFloat;
        }
    }
}