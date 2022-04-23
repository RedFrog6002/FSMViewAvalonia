using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetInvincible
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault target = action.Values[0].Item2 as FsmOwnerDefault;
            FsmBool Invincible = action.Values[1].Item2 as FsmBool;
            FsmInt InvincibleFromDirection = action.Values[2].Item2 as FsmInt;
        }
    }
}