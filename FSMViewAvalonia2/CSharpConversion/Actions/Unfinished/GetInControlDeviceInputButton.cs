using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetInControlDeviceInputButton
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmInt deviceIndex = action.Values[0].Item2 as FsmInt;
            InputControlType axis = action.Values[1].Item2 as InputControlType;
            FsmBool storeResult = action.Values[2].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[3].Item2;
        }
    }
}