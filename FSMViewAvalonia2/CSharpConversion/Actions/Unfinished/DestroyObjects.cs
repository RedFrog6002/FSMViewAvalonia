using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class DestroyObjects
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmArray gameObjects = action.Values[0].Item2 as FsmArray;
            FsmFloat delay = action.Values[1].Item2 as FsmFloat;
            FsmBool detachChildren = action.Values[2].Item2 as FsmBool;
        }
    }
}