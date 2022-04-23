using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class iTweenFadeTo
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString id = action.Values[1].Item2 as FsmString;
            FsmFloat alpha = action.Values[2].Item2 as FsmFloat;
            FsmBool includeChildren = action.Values[3].Item2 as FsmBool;
            FsmString namedValueColor = action.Values[4].Item2 as FsmString;
            FsmFloat time = action.Values[5].Item2 as FsmFloat;
            FsmFloat delay = action.Values[6].Item2 as FsmFloat;
            EaseType easeType = action.Values[7].Item2 as EaseType;
            LoopType loopType = action.Values[8].Item2 as LoopType;
            string startEvent = action.Values[9].Item2 as string;
            string finishEvent = action.Values[10].Item2 as string;
            FsmBool realTime = action.Values[11].Item2 as FsmBool;
            FsmBool stopOnExit = action.Values[12].Item2 as FsmBool;
            FsmBool loopDontFinish = action.Values[13].Item2 as FsmBool;
        }
    }
}