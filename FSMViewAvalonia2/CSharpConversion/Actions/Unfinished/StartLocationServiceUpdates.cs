using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class StartLocationServiceUpdates
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat maxWait = action.Values[0].Item2 as FsmFloat;
            FsmFloat desiredAccuracy = action.Values[1].Item2 as FsmFloat;
            FsmFloat updateDistance = action.Values[2].Item2 as FsmFloat;
            string successEvent = action.Values[3].Item2 as string;
            string failedEvent = action.Values[4].Item2 as string;
        }
    }
}