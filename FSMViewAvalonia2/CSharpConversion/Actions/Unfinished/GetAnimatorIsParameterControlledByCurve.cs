using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetAnimatorIsParameterControlledByCurve
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString parameterName = action.Values[1].Item2 as FsmString;
            FsmBool isControlledByCurve = action.Values[2].Item2 as FsmBool;
            string isControlledByCurveEvent = action.Values[3].Item2 as string;
            string isNotControlledByCurveEvent = action.Values[4].Item2 as string;
        }
    }
}