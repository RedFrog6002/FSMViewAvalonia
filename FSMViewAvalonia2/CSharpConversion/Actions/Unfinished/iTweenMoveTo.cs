using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class iTweenMoveTo
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmOwnerDefault gameObject = action.Values[0].Item2 as FsmOwnerDefault;
            FsmString id = action.Values[1].Item2 as FsmString;
            FsmGameObject transformPosition = action.Values[2].Item2 as FsmGameObject;
            FsmVector3 vectorPosition = action.Values[3].Item2 as FsmVector3;
            FsmFloat time = action.Values[4].Item2 as FsmFloat;
            FsmFloat delay = action.Values[5].Item2 as FsmFloat;
            FsmFloat speed = action.Values[6].Item2 as FsmFloat;
            Space space = action.Values[7].Item2 as Space;
            EaseType easeType = action.Values[8].Item2 as EaseType;
            LoopType loopType = action.Values[9].Item2 as LoopType;
            FsmBool orientToPath = action.Values[10].Item2 as FsmBool;
            FsmGameObject lookAtObject = action.Values[11].Item2 as FsmGameObject;
            FsmVector3 lookAtVector = action.Values[12].Item2 as FsmVector3;
            FsmFloat lookTime = action.Values[13].Item2 as FsmFloat;
            AxisRestriction axis = action.Values[14].Item2 as AxisRestriction;
            FsmBool moveToPath = action.Values[15].Item2 as FsmBool;
            FsmFloat lookAhead = action.Values[16].Item2 as FsmFloat;
            FsmGameObject[] transforms = action.Values[17].Item2 as FsmGameObject[];
            FsmVector3[] vectors = action.Values[18].Item2 as FsmVector3[];
            FsmBool reverse = action.Values[19].Item2 as FsmBool;
            string startEvent = action.Values[20].Item2 as string;
            string finishEvent = action.Values[21].Item2 as string;
            FsmBool realTime = action.Values[22].Item2 as FsmBool;
            FsmBool stopOnExit = action.Values[23].Item2 as FsmBool;
            FsmBool loopDontFinish = action.Values[24].Item2 as FsmBool;
        }
    }
}