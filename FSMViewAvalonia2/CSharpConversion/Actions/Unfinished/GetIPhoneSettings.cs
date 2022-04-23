using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetIPhoneSettings
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmBool getScreenCanDarken = action.Values[0].Item2 as FsmBool;
            FsmString getUniqueIdentifier = action.Values[1].Item2 as FsmString;
            FsmString getName = action.Values[2].Item2 as FsmString;
            FsmString getModel = action.Values[3].Item2 as FsmString;
            FsmString getSystemName = action.Values[4].Item2 as FsmString;
            FsmString getGeneration = action.Values[5].Item2 as FsmString;
        }
    }
}