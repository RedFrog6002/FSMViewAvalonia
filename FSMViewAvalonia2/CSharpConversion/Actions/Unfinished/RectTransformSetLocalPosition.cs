using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class RectTransformSetLocalPosition
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmVector2 position2d = action.Values[1].Item2 as FsmVector2;
            FsmVector3 position = action.Values[2].Item2 as FsmVector3;
            FsmFloat x = action.Values[3].Item2 as FsmFloat;
            FsmFloat y = action.Values[4].Item2 as FsmFloat;
            FsmFloat z = action.Values[5].Item2 as FsmFloat;
            bool everyFrame = (bool)action.Values[6].Item2;
            FrameUpdateSelector updateType = action.Values[7].Item2 as FrameUpdateSelector;
        }
    }
}