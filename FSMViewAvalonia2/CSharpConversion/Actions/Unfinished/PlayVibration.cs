using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class PlayVibration
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmEnum lowFidelityVibration = action.Values[0].Item2 as FsmEnum;
            FsmObject highFidelityVibration = action.Values[1].Item2 as FsmObject;
            FsmEnum motors = action.Values[2].Item2 as FsmEnum;
            FsmFloat loopTime = action.Values[3].Item2 as FsmFloat;
            FsmBool isLooping = action.Values[4].Item2 as FsmBool;
            FsmString tag = action.Values[5].Item2 as FsmString;
            FsmObject gamepadVibration = action.Values[6].Item2 as FsmObject;
        }
    }
}