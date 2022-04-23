using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class RandomInt
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmInt min = action.Values[0].Item2 as FsmInt;
            FsmInt max = action.Values[1].Item2 as FsmInt;
            FsmInt storeResult = action.Values[2].Item2 as FsmInt;
            bool inclusiveMax = (bool)action.Values[3].Item2;
        }
    }
}