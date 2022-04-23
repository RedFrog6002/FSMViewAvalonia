using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class uGuiLayoutElementGetValues
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmBool ignoreLayout = action.Values[1].Item2 as FsmBool;
            FsmBool minWidthEnabled = action.Values[2].Item2 as FsmBool;
            FsmFloat minWidth = action.Values[3].Item2 as FsmFloat;
            FsmBool minHeightEnabled = action.Values[4].Item2 as FsmBool;
            FsmFloat minHeight = action.Values[5].Item2 as FsmFloat;
            FsmBool preferredWidthEnabled = action.Values[6].Item2 as FsmBool;
            FsmFloat preferredWidth = action.Values[7].Item2 as FsmFloat;
            FsmBool preferredHeightEnabled = action.Values[8].Item2 as FsmBool;
            FsmFloat preferredHeight = action.Values[9].Item2 as FsmFloat;
            FsmBool flexibleWidthEnabled = action.Values[10].Item2 as FsmBool;
            FsmFloat flexibleWidth = action.Values[11].Item2 as FsmFloat;
            FsmBool flexibleHeightEnabled = action.Values[12].Item2 as FsmBool;
            FsmFloat flexibleHeight = action.Values[13].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[14].Item2;
        }
    }
}