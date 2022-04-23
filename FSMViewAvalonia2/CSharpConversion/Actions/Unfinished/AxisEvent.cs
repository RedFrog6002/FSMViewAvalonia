using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class AxisEvent
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString horizontalAxis = action.Values[0].Item2 as FsmString;
            FsmString verticalAxis = action.Values[1].Item2 as FsmString;
            string leftEvent = action.Values[2].Item2 as string;
            string rightEvent = action.Values[3].Item2 as string;
            string upEvent = action.Values[4].Item2 as string;
            string downEvent = action.Values[5].Item2 as string;
            string anyDirection = action.Values[6].Item2 as string;
            string noDirection = action.Values[7].Item2 as string;
        }
    }
}