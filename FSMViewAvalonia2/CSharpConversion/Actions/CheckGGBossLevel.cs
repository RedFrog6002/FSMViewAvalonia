using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class CheckGGBossLevel
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            string notGG = action.Values[0].Item2 as string;
            string level1 = action.Values[1].Item2 as string;
            string level2 = action.Values[2].Item2 as string;
            string level3 = action.Values[3].Item2 as string;
            if (level1 != "" || level2 != "" || level3 != "")
            {
                state.AddMiddleCode("if (BossSceneController.instance)");
                state.AddMiddleCode("{");
                state.AddMiddleCode("    switch (BossSceneController.Instance.BossLevel)");
                if (level1 != "")
                {
                    string toState = GetToState(data.state.transitions, level1);
                    FsmStateBuilder toStateBuilder = state.classBuilder.GetState(toState);
                    state.AddMiddleCode("        case 0:");
                    state.AddMiddleCodeReturn("            ");
                    state.AddMiddleCode(() => toStateBuilder.IsEnumerator ? ("            StartCoroutine(" + toState + "());") : ("            " + toState + "();"));
                    state.AddMiddleCode(() => toStateBuilder.IsEnumerator ? "            yield break;" : "            return;");
                }
                if (level2 != "")
                {
                    string toState = GetToState(data.state.transitions, level2);
                    FsmStateBuilder toStateBuilder = state.classBuilder.GetState(toState);
                    state.AddMiddleCode("        case 1:");
                    state.AddMiddleCodeReturn("            ");
                    state.AddMiddleCode(() => toStateBuilder.IsEnumerator ? ("            StartCoroutine(" + toState + "());") : ("            " + toState + "();"));
                    state.AddMiddleCode(() => toStateBuilder.IsEnumerator ? "            yield break;" : "            return;");
                }
                if (level3 != "")
                {
                    string toState = GetToState(data.state.transitions, level3);
                    FsmStateBuilder toStateBuilder = state.classBuilder.GetState(toState);
                    state.AddMiddleCode("        case 2:");
                    state.AddMiddleCodeReturn("            ");
                    state.AddMiddleCode(() => toStateBuilder.IsEnumerator ? ("            StartCoroutine(" + toState + "());") : ("            " + toState + "();"));
                    state.AddMiddleCode(() => toStateBuilder.IsEnumerator ? "            yield break;" : "            return;");
                }
                state.AddMiddleCode("}");
            }
            if (notGG != "")
            {
                string toState = GetToState(data.state.transitions, notGG);
                FsmStateBuilder toStateBuilder = state.classBuilder.GetState(toState);
                if (level1 != "" || level2 != "" || level3 != "")
                    state.AddMiddleCode("else");
                else
                    state.AddMiddleCode("if (!BossSceneController.instance)");
                state.AddMiddleCode("{");
                state.AddMiddleCodeReturn("    ");
                state.AddMiddleCode(() => toStateBuilder.IsEnumerator ? ("    StartCoroutine(" + toState + "());") : ("    " + toState + "();"));
                state.AddMiddleCode(() => toStateBuilder.IsEnumerator ? "    yield break;" : "    return;");
                state.AddMiddleCode("}");
            }
        }
    }
}
