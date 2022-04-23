using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FlingObjects
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject containerObject = action.Values[0].Item2 as FsmGameObject;
            FsmVector3 adjustPosition = action.Values[1].Item2 as FsmVector3;
            FsmBool randomisePosition = action.Values[2].Item2 as FsmBool;
            FsmFloat speedMin = action.Values[3].Item2 as FsmFloat;
            FsmFloat speedMax = action.Values[4].Item2 as FsmFloat;
            FsmFloat angleMin = action.Values[5].Item2 as FsmFloat;
            FsmFloat angleMax = action.Values[6].Item2 as FsmFloat;
        }
    }
}