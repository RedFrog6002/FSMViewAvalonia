using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class DeviceOrientationEvent
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            DeviceOrientation orientation = action.Values[0].Item2 as DeviceOrientation;
            string sendEvent = action.Values[1].Item2 as string;
            bool everyFrame = (bool)action.Values[2].Item2;
        }
    }
}