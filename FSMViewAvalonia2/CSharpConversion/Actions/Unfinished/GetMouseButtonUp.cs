using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetMouseButtonUp
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            MouseButton button = action.Values[0].Item2 as MouseButton;
            string sendEvent = action.Values[1].Item2 as string;
            FsmBool storeResult = action.Values[2].Item2 as FsmBool;
            bool inUpdateOnly = (bool)action.Values[3].Item2;
        }
    }
}