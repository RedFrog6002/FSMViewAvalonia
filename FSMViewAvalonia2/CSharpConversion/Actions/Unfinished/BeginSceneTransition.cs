using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class BeginSceneTransition
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString sceneName = action.Values[0].Item2 as FsmString;
            FsmString entryGateName = action.Values[1].Item2 as FsmString;
            FsmFloat entryDelay = action.Values[2].Item2 as FsmFloat;
            FsmEnum visualization = action.Values[3].Item2 as FsmEnum;
            bool preventCameraFadeOut = (bool)action.Values[4].Item2;
        }
    }
}