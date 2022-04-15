using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class FloatCompare
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmFloat float1 = action.Values[0].Item2 as FsmFloat;
            FsmFloat float2 = action.Values[1].Item2 as FsmFloat;
            FsmFloat tolerance = action.Values[2].Item2 as FsmFloat;
            string equal = action.Values[3].Item2 as string;
            string lessThan = action.Values[4].Item2 as string;
            string greaterThan = action.Values[5].Item2 as string;
            string float1String;
            string float2String;
            string toleranceString;
            if (float1.useVariable && !string.IsNullOrEmpty(float1.name))
                float1String = float1.name;
            else
                float1String = float1.value.ToString();
            if (float2.useVariable && !string.IsNullOrEmpty(float2.name))
                float2String = float2.name;
            else
                float2String = float2.value.ToString();
            if (tolerance.useVariable && !string.IsNullOrEmpty(tolerance.name))
                toleranceString = tolerance.name;
            else
                toleranceString = tolerance.value.ToString();
            if ((bool)action.Values[6].Item2)
            {
                state.AddBeginningCode("Coroutine FloatCompareEveryFrame = null;");
                state.AddMiddleCode("IEnumerator FloatCompareEveryFrameRoutine()");
                state.AddMiddleCode("{");
                state.AddMiddleCode("    while (true)");
                state.AddMiddleCode("    {");
                if (!string.IsNullOrEmpty(equal))
                {
                    string toState = GetToState(data.state.transitions, equal);
                    FsmStateBuilder toStateBuilder = state.classBuilder.GetState(toState);
                    state.AddMiddleCode("        if (Mathf.Abs(" + float1String + " - " + float2String + ") <= " + toleranceString + ")");
                    state.AddMiddleCode("        {");
                    state.AddMiddleCodeReturn("            ");
                    state.AddMiddleCode(() => toStateBuilder.IsEnumerator ? ("            StartCoroutine(" + toState + "());") : ("            " + toState + "();"));
                    state.AddMiddleCode("            yield break;");
                    state.AddMiddleCode("        }");
                }
                if (!string.IsNullOrEmpty(lessThan))
                {
                    string toState = GetToState(data.state.transitions, lessThan);
                    FsmStateBuilder toStateBuilder = state.classBuilder.GetState(toState);
                    state.AddMiddleCode("        if (" + float1String + " < " + float2String + ")");
                    state.AddMiddleCode("        {");
                    state.AddMiddleCodeReturn("            ");
                    state.AddMiddleCode(() => toStateBuilder.IsEnumerator ? ("            StartCoroutine(" + toState + "());") : ("            " + toState + "();"));
                    state.AddMiddleCode("            yield break;");
                    state.AddMiddleCode("        }");
                }
                if (!string.IsNullOrEmpty(greaterThan))
                {
                    string toState = GetToState(data.state.transitions, greaterThan);
                    FsmStateBuilder toStateBuilder = state.classBuilder.GetState(toState);
                    state.AddMiddleCode("        if (" + float1String + " > " + float2String + ")");
                    state.AddMiddleCode("        {");
                    state.AddMiddleCodeReturn("            ");
                    state.AddMiddleCode(() => toStateBuilder.IsEnumerator ? ("            StartCoroutine(" + toState + "());") : ("            " + toState + "();"));
                    state.AddMiddleCode("            yield break;");
                    state.AddMiddleCode("        }");
                }
                state.AddMiddleCode("        yield return null;");
                state.AddMiddleCode("    }");
                state.AddMiddleCode("}");
                state.AddMiddleCode("FloatCompareEveryFrame = StartCoroutine(FloatCompareEveryFrameRoutine());");
                state.AddReturnCode("StopCoroutine(FloatCompareEveryFrame);");
            }
            else
            {
                if (!string.IsNullOrEmpty(equal))
                {
                    string toState = GetToState(data.state.transitions, equal);
                    FsmStateBuilder toStateBuilder = state.classBuilder.GetState(toState);
                    state.AddMiddleCode("if (Mathf.Abs(" + float1String + " - " + float2String + ") <= " + toleranceString + ")");
                    state.AddMiddleCode("{");
                    state.AddMiddleCodeReturn("    ");
                    state.AddMiddleCode(() => toStateBuilder.IsEnumerator ? ("    StartCoroutine(" + toState + "());") : ("    " + toState + "();"));
                    state.AddMiddleCode(() => state.IsEnumerator ? "    yield break;" : "    return;");
                    state.AddMiddleCode("}");
                }
                if (!string.IsNullOrEmpty(lessThan))
                {
                    string toState = GetToState(data.state.transitions, lessThan);
                    FsmStateBuilder toStateBuilder = state.classBuilder.GetState(toState);
                    state.AddMiddleCode("if (" + float1String + " < " + float2String + ")");
                    state.AddMiddleCode("{");
                    state.AddMiddleCodeReturn("    ");
                    state.AddMiddleCode(() => toStateBuilder.IsEnumerator ? ("    StartCoroutine(" + toState + "());") : ("    " + toState + "();"));
                    state.AddMiddleCode(() => state.IsEnumerator ? "    yield break;" : "    return;");
                    state.AddMiddleCode("}");
                }
                if (!string.IsNullOrEmpty(greaterThan))
                {
                    string toState = GetToState(data.state.transitions, greaterThan);
                    FsmStateBuilder toStateBuilder = state.classBuilder.GetState(toState);
                    state.AddMiddleCode("if (" + float1String + " > " + float2String + ")");
                    state.AddMiddleCode("{");
                    state.AddMiddleCodeReturn("    ");
                    state.AddMiddleCode(() => toStateBuilder.IsEnumerator ? ("    StartCoroutine(" + toState + "());") : ("    " + toState + "();"));
                    state.AddMiddleCode(() => state.IsEnumerator ? "    yield break;" : "    return;");
                    state.AddMiddleCode("}");
                }
            }
        }
    }
}
