using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class AddForce
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmVector3 atPosition = action.Values[1].Item2 as FsmVector3;
            FsmVector3 vector = action.Values[2].Item2 as FsmVector3;
            FsmFloat x = action.Values[3].Item2 as FsmFloat;
            FsmFloat y = action.Values[4].Item2 as FsmFloat;
            FsmFloat z = action.Values[5].Item2 as FsmFloat;
            Space space = action.Values[6].Item2 as Space;
            ForceMode forceMode = action.Values[7].Item2 as ForceMode;
            bool everyFrame = (bool)action.Values[8].Item2;
        }
    }
}