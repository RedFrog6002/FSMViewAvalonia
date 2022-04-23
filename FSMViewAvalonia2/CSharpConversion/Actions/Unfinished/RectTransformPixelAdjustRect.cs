using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class RectTransformPixelAdjustRect
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject canvas = action.Values[1].Item2 as FsmGameObject;
            FsmRect pixelRect = action.Values[2].Item2 as FsmRect;
            bool everyFrame = (bool)action.Values[3].Item2;
            FrameUpdateSelector updateType = action.Values[4].Item2 as FrameUpdateSelector;
        }
    }
}