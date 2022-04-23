using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ShowBossDoorChallengeUI
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault targetDoor = action.Values[0].Item2 as FsmOwnerDefault;
            FsmGameObject prefab = action.Values[1].Item2 as FsmGameObject;
            string cancelEvent = action.Values[2].Item2 as string;
            string challengeEvent = action.Values[3].Item2 as string;
        }
    }
}