using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class ScreenSetResolution
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmBool fullScreen = action.Values[0].Item2 as FsmBool;
            FsmInt width = action.Values[1].Item2 as FsmInt;
            FsmInt height = action.Values[2].Item2 as FsmInt;
            FsmInt preferedRefreshRate = action.Values[3].Item2 as FsmInt;
            FsmVector3 orResolution = action.Values[4].Item2 as FsmVector3;
        }
    }
}