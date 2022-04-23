using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetPersistentBoolFromSaveData
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault Target = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString SceneName = action.Values[1].Item2 as FsmString;
            FsmString ID = action.Values[2].Item2 as FsmString;
            FsmBool StoreValue = action.Values[3].Item2 as FsmBool;
        }
    }
}