using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class uGuiInputFieldScreenToLocal
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmVector2 screen = action.Values[1].Item2 as FsmVector2;
            FsmVector2 local = action.Values[2].Item2 as FsmVector2;
            bool everyFrame = (bool)action.Values[3].Item2;
        }
    }
}