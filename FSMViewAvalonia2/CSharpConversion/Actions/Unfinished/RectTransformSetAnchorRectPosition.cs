using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class RectTransformSetAnchorRectPosition
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            AnchorReference anchorReference = action.Values[1].Item2 as AnchorReference;
            FsmBool normalized = action.Values[2].Item2 as FsmBool;
            FsmVector2 anchor = action.Values[3].Item2 as FsmVector2;
            FsmFloat x = action.Values[4].Item2 as FsmFloat;
            FsmFloat y = action.Values[5].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[6].Item2;
            FrameUpdateSelector updateType = action.Values[7].Item2 as FrameUpdateSelector;
        }
    }
}