using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetVectorLength
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmVector3 vector3 = action.Values[0].Item2 as FsmVector3;
            FsmFloat storeLength = action.Values[1].Item2 as FsmFloat;
        }
    }
}