using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class PlayerDataBoolTrueAndFalse
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString trueBool = action.Values[1].Item2 as FsmString;
            FsmString falseBool = action.Values[2].Item2 as FsmString;
            string isTrue = action.Values[3].Item2 as string;
            string isFalse = action.Values[4].Item2 as string;
        }
    }
}