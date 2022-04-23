using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetEventData
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmGameObject setGameObjectData = action.Values[0].Item2 as FsmGameObject;
            FsmInt setIntData = action.Values[1].Item2 as FsmInt;
            FsmFloat setFloatData = action.Values[2].Item2 as FsmFloat;
            FsmString setStringData = action.Values[3].Item2 as FsmString;
            FsmBool setBoolData = action.Values[4].Item2 as FsmBool;
            FsmVector2 setVector2Data = action.Values[5].Item2 as FsmVector2;
            FsmVector3 setVector3Data = action.Values[6].Item2 as FsmVector3;
            FsmRect setRectData = action.Values[7].Item2 as FsmRect;
            FsmQuaternion setQuaternionData = action.Values[8].Item2 as FsmQuaternion;
            FsmColor setColorData = action.Values[9].Item2 as FsmColor;
            FsmMaterial setMaterialData = action.Values[10].Item2 as FsmMaterial;
            FsmTexture setTextureData = action.Values[11].Item2 as FsmTexture;
            FsmObject setObjectData = action.Values[12].Item2 as FsmObject;
        }
    }
}