using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class IsKinematic2d
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            string trueEvent = action.Values[1].Item2 as string;
            string falseEvent = action.Values[2].Item2 as string;
            FsmBool store = action.Values[3].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[4].Item2;
        }
    }
}