using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FsmStateActionAdvanced
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            bool everyFrame = (bool)action.Values[0].Item2;
            FrameUpdateSelector updateType = action.Values[1].Item2 as FrameUpdateSelector;
        }
    }
}