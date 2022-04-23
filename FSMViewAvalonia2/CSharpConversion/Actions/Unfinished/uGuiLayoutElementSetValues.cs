using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class uGuiLayoutElementSetValues
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmFloat minWidth = action.Values[1].Item2 as FsmFloat;
            FsmFloat minHeight = action.Values[2].Item2 as FsmFloat;
            FsmFloat preferredWidth = action.Values[3].Item2 as FsmFloat;
            FsmFloat preferredHeight = action.Values[4].Item2 as FsmFloat;
            FsmFloat flexibleWidth = action.Values[5].Item2 as FsmFloat;
            FsmFloat flexibleHeight = action.Values[6].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[7].Item2;
        }
    }
}