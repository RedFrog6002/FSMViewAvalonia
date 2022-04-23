using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GameObjectExists
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString objectName = action.Values[0].Item2 as FsmString;
            FsmString withTag = action.Values[1].Item2 as FsmString;
            FsmBool result = action.Values[2].Item2 as FsmBool;
        }
    }
}