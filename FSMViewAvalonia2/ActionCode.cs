using System;
using System.Collections.Generic;
using System.Text;

namespace FSMViewAvalonia2.CSharpConversion
{
    public static class ActionCode
    {
        public static void WriteCodeForAction(FsmStateBuilder state, ActionScriptEntry action)
        {
            switch (action.Name)
            {
                case "CallMethodProper":
                    string code = GetOwnerDefaultString(action.Values[0].Item2 as FsmOwnerDefault) + ".GetComponent<" + (action.Values[1].Item2 as FsmString).value + ">()." + (action.Values[2].Item2 as FsmString).value + "(";
                    int length = action.Values.Count;
                    for (int i = 4; i < length; i++)
                    {
                        if (i != 4)
                            code += ", ";
                        code += GetOnlyValue(action.Values[i].Item2 as FsmVar);
                    }
                    code += ");";
                    state.AddMiddleCode(code);
                    break;
                case "SetPlayerDataInt":
                    state.AddMiddleCode("PlayerData.instance.SetInt(" + action.Values[0].Item2 + ", " + action.Values[1].Item2 + ");");
                    break;
                default:
                    state.AddMiddleCode(action.Name + ".DoSomething();");
                    break;
            }
        }

        private static string GetOwnerDefaultString(FsmOwnerDefault owner)
        {
            if (owner.ownerOption == OwnerDefaultOption.UseOwner)
                return "gameObject";
            else
            {
                if (owner.gameObject.value.name == "")
                    return owner.gameObject.name;
                else
                    return owner.gameObject.value.name;
            }
        }

        private static string GetOnlyValue(FsmVar fsmVar)
        {
            if (fsmVar.variableName != "")
            {
                return fsmVar.variableName;
            }
            object value = null;
            switch (fsmVar.type)
            {
                case VariableType.Float:
                    value = fsmVar.floatValue;
                    break;
                case VariableType.Int:
                    value = fsmVar.intValue;
                    break;
                case VariableType.Bool:
                    value = fsmVar.boolValue;
                    break;
                case VariableType.String:
                    value = "\"" + fsmVar.stringValue + "\"";
                    break;
                case VariableType.Vector2:
                    value = new Vector2() { x = fsmVar.vector4Value.x, y = fsmVar.vector4Value.y };
                    break;
                case VariableType.Vector3:
                    value = new Vector3() { x = fsmVar.vector4Value.x, y = fsmVar.vector4Value.y, z = fsmVar.vector4Value.z };
                    break;
                case VariableType.Object:
                case VariableType.GameObject:
                case VariableType.Material:
                case VariableType.Texture:
                    value = fsmVar.objectReference;
                    break;
                case VariableType.Color:
                    value = new UnityColor() { r = fsmVar.vector4Value.x, g = fsmVar.vector4Value.y, b = fsmVar.vector4Value.z, a = fsmVar.vector4Value.w };
                    break;
                case VariableType.Rect:
                    value = new UnityRect() { x = fsmVar.vector4Value.x, y = fsmVar.vector4Value.y, width = fsmVar.vector4Value.z, height = fsmVar.vector4Value.w };
                    break;
                case VariableType.Quaternion:
                    value = new Quaternion() { x = fsmVar.vector4Value.x, y = fsmVar.vector4Value.y, z = fsmVar.vector4Value.z, w = fsmVar.vector4Value.w };
                    break;
                case VariableType.Array:
                    value = fsmVar.arrayValue;
                    break;
            }
            if (value != null)
            {
                if (value is NamedAssetPPtr namedPPtr && namedPPtr.name != "")
                    return namedPPtr.name;
                else
                    return value.ToString();
            }
            return "null var";
        }
    }
}
