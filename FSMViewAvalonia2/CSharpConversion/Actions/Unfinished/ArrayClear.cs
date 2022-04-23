using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ArrayClear
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmArray array = action.Values[0].Item2 as FsmArray;
            FsmVar resetValue = action.Values[1].Item2 as FsmVar;
        }
    }
}