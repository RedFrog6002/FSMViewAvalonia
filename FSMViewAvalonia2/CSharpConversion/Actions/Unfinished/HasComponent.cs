using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class HasComponent
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString component = action.Values[1].Item2 as FsmString;
            FsmBool removeOnExit = action.Values[2].Item2 as FsmBool;
            string trueEvent = action.Values[3].Item2 as string;
            string falseEvent = action.Values[4].Item2 as string;
            FsmBool store = action.Values[5].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[6].Item2;
        }
    }
}