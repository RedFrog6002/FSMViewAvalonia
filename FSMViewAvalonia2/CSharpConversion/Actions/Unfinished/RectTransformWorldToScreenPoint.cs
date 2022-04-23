using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class RectTransformWorldToScreenPoint
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmOwnerDefault camera = action.Values[1].Item2 as FsmOwnerDefault;
            FsmVector3 screenPoint = action.Values[2].Item2 as FsmVector3;
            FsmFloat screenX = action.Values[3].Item2 as FsmFloat;
            FsmFloat screenY = action.Values[4].Item2 as FsmFloat;
            FsmBool normalize = action.Values[5].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[6].Item2;
            FrameUpdateSelector updateType = action.Values[7].Item2 as FrameUpdateSelector;
        }
    }
}