using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetObjectValue
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmObject objectVariable = action.Values[0].Item2 as FsmObject;
            FsmObject objectValue = action.Values[1].Item2 as FsmObject;
            bool everyFrame = (bool)action.Values[2].Item2;
        }
    }
}