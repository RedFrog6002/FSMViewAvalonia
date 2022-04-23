using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetLanguageStringProcessed
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmString sheetName = action.Values[0].Item2 as FsmString;
            FsmString convName = action.Values[1].Item2 as FsmString;
            FsmString storeValue = action.Values[2].Item2 as FsmString;
            FsmEnum fontSource = action.Values[3].Item2 as FsmEnum;
        }
    }
}