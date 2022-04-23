using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class iTweenPunchScale
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString id = action.Values[1].Item2 as FsmString;
            FsmVector3 vector = action.Values[2].Item2 as FsmVector3;
            FsmFloat time = action.Values[3].Item2 as FsmFloat;
            FsmFloat delay = action.Values[4].Item2 as FsmFloat;
            LoopType loopType = action.Values[5].Item2 as LoopType;
            string startEvent = action.Values[6].Item2 as string;
            string finishEvent = action.Values[7].Item2 as string;
            FsmBool realTime = action.Values[8].Item2 as FsmBool;
            FsmBool stopOnExit = action.Values[9].Item2 as FsmBool;
            FsmBool loopDontFinish = action.Values[10].Item2 as FsmBool;
        }
    }
}