using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ShowBossChallengeUI
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject prefab = action.Values[0].Item2 as FsmGameObject;
            FsmString bossNameSheet = action.Values[1].Item2 as FsmString;
            FsmString bossNameKey = action.Values[2].Item2 as FsmString;
            FsmString descriptionSheet = action.Values[3].Item2 as FsmString;
            FsmString descriptionKey = action.Values[4].Item2 as FsmString;
            string levelSelectedEvent = action.Values[5].Item2 as string;
        }
    }
}