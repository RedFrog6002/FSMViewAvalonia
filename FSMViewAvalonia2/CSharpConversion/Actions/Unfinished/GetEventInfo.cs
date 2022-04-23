using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetEventInfo
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject sentByGameObject = action.Values[0].Item2 as FsmGameObject;
            FsmString fsmName = action.Values[1].Item2 as FsmString;
            FsmBool getBoolData = action.Values[2].Item2 as FsmBool;
            FsmInt getIntData = action.Values[3].Item2 as FsmInt;
            FsmFloat getFloatData = action.Values[4].Item2 as FsmFloat;
            FsmVector2 getVector2Data = action.Values[5].Item2 as FsmVector2;
            FsmVector3 getVector3Data = action.Values[6].Item2 as FsmVector3;
            FsmString getStringData = action.Values[7].Item2 as FsmString;
            FsmGameObject getGameObjectData = action.Values[8].Item2 as FsmGameObject;
            FsmRect getRectData = action.Values[9].Item2 as FsmRect;
            FsmQuaternion getQuaternionData = action.Values[10].Item2 as FsmQuaternion;
            FsmMaterial getMaterialData = action.Values[11].Item2 as FsmMaterial;
            FsmTexture getTextureData = action.Values[12].Item2 as FsmTexture;
            FsmColor getColorData = action.Values[13].Item2 as FsmColor;
            FsmObject getObjectData = action.Values[14].Item2 as FsmObject;
        }
    }
}