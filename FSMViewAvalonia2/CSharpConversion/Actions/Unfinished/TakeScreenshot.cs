using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class TakeScreenshot
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            Destination destination = action.Values[0].Item2 as Destination;
            FsmString customPath = action.Values[1].Item2 as FsmString;
            FsmString filename = action.Values[2].Item2 as FsmString;
            FsmBool autoNumber = action.Values[3].Item2 as FsmBool;
            FsmInt superSize = action.Values[4].Item2 as FsmInt;
            FsmBool debugLog = action.Values[5].Item2 as FsmBool;
        }
    }
}