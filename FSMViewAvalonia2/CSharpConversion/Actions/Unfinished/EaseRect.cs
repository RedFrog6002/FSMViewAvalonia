using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class EaseRect
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmRect fromValue = action.Values[0].Item2 as FsmRect;
            FsmRect toValue = action.Values[1].Item2 as FsmRect;
            FsmRect rectVariable = action.Values[2].Item2 as FsmRect;
            FsmFloat time = action.Values[3].Item2 as FsmFloat;
            FsmFloat speed = action.Values[4].Item2 as FsmFloat;
            FsmFloat delay = action.Values[5].Item2 as FsmFloat;
            EaseType easeType = action.Values[6].Item2 as EaseType;
            FsmBool reverse = action.Values[7].Item2 as FsmBool;
            string finishEvent = action.Values[8].Item2 as string;
            bool realTime = (bool)action.Values[9].Item2;
        }
    }
}