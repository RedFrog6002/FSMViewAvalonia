using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using FSMViewAvalonia2.CSharpConversion.Actions;

namespace FSMViewAvalonia2.CSharpConversion
{
    public static class ActionCode
    {
        public static void WriteCodeForAction(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            if (!action.Enabled)
                return;
            switch (action.Name)
            {
                case "CallMethodProper":
                    CallMethodProper.Build(state, action, data);
                    break;
                case "CheckGGBossLevel":
                    CheckGGBossLevel.Build(state, action, data);
                    break;
                case "FindChild":
                    FindChild.Build(state, action, data);
                    break;
                case "FloatCompare":
                    FloatCompare.Build(state, action, data);
                    break;
                case "GetOwner":
                    GetOwner.Build(state, action, data);
                    break;
                case "GetPosition":
                    GetPosition.Build(state, action, data);
                    break;
                case "SetCollider":
                    SetCollider.Build(state, action, data);
                    break;
                case "SetIntValue":
                    SetIntValue.Build(state, action, data);
                    break;
                case "SetMeshRenderer":
                    SetMeshRenderer.Build(state, action, data);
                    break;
                case "SetPlayerDataInt":
                    SetPlayerDataInt.Build(state, action, data);
                    break;
                case "SetVelocity2d":
                    SetVelocity2d.Build(state, action, data);
                    break;
                case "Tk2dPlayAnimation":
                    Tk2dPlayAnimation.Build(state, action, data);
                    break;
                case "Wait":
                    Wait.Build(state, action, data);
                    break;
                default:
                    state.AddMiddleCode(action.Name + ".DoSomething();");
                    break;
            }
        }

        public static string GetOwnerDefaultString(FsmOwnerDefault owner)
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

        public static string GetOnlyValue(FsmVar fsmVar)
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

        public static string GetToState(FsmTransition[] transitions, string fsmEvent)
        {
            return transitions.First(t => t.fsmEvent.name == fsmEvent).toState;
        }
    }
}
