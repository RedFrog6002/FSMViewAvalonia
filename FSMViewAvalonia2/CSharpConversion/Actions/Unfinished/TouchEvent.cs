using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class TouchEvent
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmInt fingerId = action.Values[0].Item2 as FsmInt;
            TouchPhase touchPhase = action.Values[1].Item2 as TouchPhase;
            string sendEvent = action.Values[2].Item2 as string;
            FsmInt storeFingerId = action.Values[3].Item2 as FsmInt;
        }
    }
}