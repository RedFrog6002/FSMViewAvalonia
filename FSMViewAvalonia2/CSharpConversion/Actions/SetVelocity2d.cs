using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class SetVelocity2d
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmVector2 vector2 = action.Values[1].Item2 as FsmVector2;
            FsmFloat x = action.Values[2].Item2 as FsmFloat;
            FsmFloat y = action.Values[3].Item2 as FsmFloat;
            int xMode = 0;
            int yMode = 0;
            float xvalue = 0f;
            float yvalue = 0f;
            if (vector2.useVariable)
            {
                if (string.IsNullOrEmpty(vector2.name))
                {
                    xMode = 2;
                    yMode = 2;
                }
                else
                {
                    xMode = 3;
                    yMode = 3;
                }
            }
            else
            {
                xvalue = vector2.value.x;
                yvalue = vector2.value.y;
            }
            if (x.useVariable && !string.IsNullOrEmpty(x.name))
            {
                xMode = 1;
            }
            else if (!x.useVariable)
            {
                xMode = 0;
                xvalue = x.value;
            }
            if (y.useVariable && !string.IsNullOrEmpty(y.name))
            {
                yMode = 1;
            }
            else if (!y.useVariable)
            {
                yMode = 0;
                yvalue = y.value;
            }
            if (xMode == 2 && yMode == 2)
                return;
            string vectorText;
            if (xMode == 3 && yMode == 3)
            {
                vectorText = vector2.name;
            }
            else
            {
                vectorText = "new Vector2(";
                switch (xMode)
                {
                    case 0:
                        vectorText += xvalue + "f";
                        break;
                    case 1:
                        vectorText += x.name;
                        break;
                    case 2:
                        vectorText += "rb2d.velocity.x";
                        break;
                    case 3:
                        vectorText += vector2.name + ".x";
                        break;
                }
                vectorText += ", ";
                switch (yMode)
                {
                    case 0:
                        vectorText += yvalue + "f";
                        break;
                    case 1:
                        vectorText += y.name;
                        break;
                    case 2:
                        vectorText += "rb2d.velocity.y";
                        break;
                    case 3:
                        vectorText += vector2.name + ".y";
                        break;
                }
                vectorText += ")";
            }
            if ((bool)action.Values[4].Item2)
            {
                state.AddBeginningCode("Coroutine SetVelocity2DEveryFrame = null;");
                state.AddMiddleCode("IEnumerator SetVelocity2DEveryFrameRoutine()");
                state.AddMiddleCode("{");
                state.AddMiddleCode("    Rigidbody2D rb2d = " + GetOwnerDefaultString(action.Values[0].Item2 as FsmOwnerDefault) + ".GetComponent<Rigidbody2D>();");
                state.AddMiddleCode("    while (true)");
                state.AddMiddleCode("    {");
                state.AddMiddleCode("        rb2d.velocity = " + vectorText + ";");
                state.AddMiddleCode("        yield return null;");
                state.AddMiddleCode("    }");
                state.AddMiddleCode("}");
                state.AddMiddleCode("SetVelocity2DEveryFrame = StartCoroutine(SetVelocity2DEveryFrameRoutine());");
                state.AddReturnCode("StopCoroutine(SetVelocity2DEveryFrame);");
            }
            else
            {
                if (xMode == 2 || yMode == 2)
                {
                    state.AddMiddleCode("Rigidbody2D rb2d = " + GetOwnerDefaultString(action.Values[0].Item2 as FsmOwnerDefault) + ".GetComponent<Rigidbody2D>();");
                    state.AddMiddleCode("rb2d.velocity = " + vectorText + ";");
                }
                else
                    state.AddMiddleCode(GetOwnerDefaultString(action.Values[0].Item2 as FsmOwnerDefault) + ".GetComponent<Rigidbody2D>().velocity = " + vectorText + ";");
            }
        }
    }
}
