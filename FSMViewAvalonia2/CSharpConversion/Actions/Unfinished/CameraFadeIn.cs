using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class CameraFadeIn
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmColor color = action.Values[0].Item2 as FsmColor;
            FsmFloat time = action.Values[1].Item2 as FsmFloat;
            string finishEvent = action.Values[2].Item2 as string;
            bool realTime = (bool)action.Values[3].Item2;
        }
    }
}