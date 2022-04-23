using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SwipeGestureEvent
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat minSwipeDistance = action.Values[0].Item2 as FsmFloat;
            string swipeLeftEvent = action.Values[1].Item2 as string;
            string swipeRightEvent = action.Values[2].Item2 as string;
            string swipeUpEvent = action.Values[3].Item2 as string;
            string swipeDownEvent = action.Values[4].Item2 as string;
        }
    }
}