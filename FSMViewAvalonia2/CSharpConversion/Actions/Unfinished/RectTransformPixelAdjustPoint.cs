using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class RectTransformPixelAdjustPoint
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject canvas = action.Values[1].Item2 as FsmGameObject;
            FsmVector2 screenPoint = action.Values[2].Item2 as FsmVector2;
            FsmVector2 pixelPoint = action.Values[3].Item2 as FsmVector2;
            bool everyFrame = (bool)action.Values[4].Item2;
            FrameUpdateSelector updateType = action.Values[5].Item2 as FrameUpdateSelector;
        }
    }
}