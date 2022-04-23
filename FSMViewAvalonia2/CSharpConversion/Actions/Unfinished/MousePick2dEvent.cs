using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class MousePick2dEvent
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault GameObject = action.Values[0].Item2 as FsmOwnerDefault;
            string mouseOver = action.Values[1].Item2 as string;
            string mouseDown = action.Values[2].Item2 as string;
            string mouseUp = action.Values[3].Item2 as string;
            string mouseOff = action.Values[4].Item2 as string;
            FsmInt[] layerMask = action.Values[5].Item2 as FsmInt[];
            FsmBool invertMask = action.Values[6].Item2 as FsmBool;
            bool everyFrame = (bool)action.Values[7].Item2;
        }
    }
}