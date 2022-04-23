using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayGet
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmArray array = action.Values[0].Item2 as FsmArray;
            FsmInt index = action.Values[1].Item2 as FsmInt;
            FsmVar storeValue = action.Values[2].Item2 as FsmVar;
            bool everyFrame = (bool)action.Values[3].Item2;
            string indexOutOfRange = action.Values[4].Item2 as string;
        }
    }
}