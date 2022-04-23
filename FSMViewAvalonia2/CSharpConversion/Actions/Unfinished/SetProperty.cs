using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetProperty
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmProperty targetProperty = action.Values[0].Item2 as FsmProperty;
            bool everyFrame = (bool)action.Values[1].Item2;
        }
    }
}