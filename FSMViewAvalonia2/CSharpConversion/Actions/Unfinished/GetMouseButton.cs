using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetMouseButton
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            MouseButton button = action.Values[0].Item2 as MouseButton;
            FsmBool storeResult = action.Values[1].Item2 as FsmBool;
        }
    }
}