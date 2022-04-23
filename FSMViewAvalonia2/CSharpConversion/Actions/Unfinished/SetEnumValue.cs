using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetEnumValue
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmEnum enumVariable = action.Values[0].Item2 as FsmEnum;
            FsmEnum enumValue = action.Values[1].Item2 as FsmEnum;
            bool everyFrame = (bool)action.Values[2].Item2;
        }
    }
}