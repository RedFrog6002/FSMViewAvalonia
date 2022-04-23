using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetLastPointerDataInfo
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmInt clickCount = action.Values[0].Item2 as FsmInt;
            FsmFloat clickTime = action.Values[1].Item2 as FsmFloat;
            FsmVector2 delta = action.Values[2].Item2 as FsmVector2;
            FsmBool dragging = action.Values[3].Item2 as FsmBool;
            FsmBool eligibleForClick = action.Values[4].Item2 as FsmBool;
            FsmGameObject enterEventCamera = action.Values[5].Item2 as FsmGameObject;
            FsmGameObject pressEventCamera = action.Values[6].Item2 as FsmGameObject;
            FsmBool isPointerMoving = action.Values[7].Item2 as FsmBool;
            FsmBool isScrolling = action.Values[8].Item2 as FsmBool;
            FsmGameObject lastPress = action.Values[9].Item2 as FsmGameObject;
            FsmGameObject pointerDrag = action.Values[10].Item2 as FsmGameObject;
            FsmGameObject pointerEnter = action.Values[11].Item2 as FsmGameObject;
            FsmInt pointerId = action.Values[12].Item2 as FsmInt;
            FsmGameObject pointerPress = action.Values[13].Item2 as FsmGameObject;
            FsmVector2 position = action.Values[14].Item2 as FsmVector2;
            FsmVector2 pressPosition = action.Values[15].Item2 as FsmVector2;
            FsmGameObject rawPointerPress = action.Values[16].Item2 as FsmGameObject;
            FsmVector2 scrollDelta = action.Values[17].Item2 as FsmVector2;
            FsmBool used = action.Values[18].Item2 as FsmBool;
            FsmBool useDragThreshold = action.Values[19].Item2 as FsmBool;
            FsmVector3 worldNormal = action.Values[20].Item2 as FsmVector3;
            FsmVector3 worldPosition = action.Values[21].Item2 as FsmVector3;
        }
    }
}