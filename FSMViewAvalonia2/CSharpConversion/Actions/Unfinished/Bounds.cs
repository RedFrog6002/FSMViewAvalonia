using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class Bounds
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject1 = action.Values[0].Item2 as FsmOwnerDefault;
            FsmVector3 scale = action.Values[1].Item2 as FsmVector3;
            bool global = (bool)action.Values[2].Item2;
            bool everyFrame = (bool)action.Values[3].Item2;
        }
    }
}