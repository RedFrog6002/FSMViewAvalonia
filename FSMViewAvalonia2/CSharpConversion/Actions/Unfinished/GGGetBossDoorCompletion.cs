using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GGGetBossDoorCompletion
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString playerDataVariable = action.Values[0].Item2 as FsmString;
            FsmBool unlocked = action.Values[1].Item2 as FsmBool;
            FsmBool completed = action.Values[2].Item2 as FsmBool;
            FsmBool allBindings = action.Values[3].Item2 as FsmBool;
            FsmBool noHits = action.Values[4].Item2 as FsmBool;
            FsmBool boundNail = action.Values[5].Item2 as FsmBool;
            FsmBool boundShell = action.Values[6].Item2 as FsmBool;
            FsmBool boundCharms = action.Values[7].Item2 as FsmBool;
            FsmBool boundSoul = action.Values[8].Item2 as FsmBool;
        }
    }
}