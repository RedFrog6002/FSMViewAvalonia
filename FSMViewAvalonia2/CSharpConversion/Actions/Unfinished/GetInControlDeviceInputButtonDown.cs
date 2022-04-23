using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetInControlDeviceInputButtonDown
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmInt deviceIndex = action.Values[0].Item2 as FsmInt;
            InputControlType axis = action.Values[1].Item2 as InputControlType;
            string sendEvent = action.Values[2].Item2 as string;
            FsmBool storeResult = action.Values[3].Item2 as FsmBool;
        }
    }
}