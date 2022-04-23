using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetInControlDeviceInputAxis
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmInt deviceIndex = action.Values[0].Item2 as FsmInt;
            InputControlType axis = action.Values[1].Item2 as InputControlType;
            FsmFloat multiplier = action.Values[2].Item2 as FsmFloat;
            FsmFloat store = action.Values[3].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}