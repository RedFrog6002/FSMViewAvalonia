using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class GetPosition
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            string goName = GetOwnerDefaultString(action.Values[0].Item2 as FsmOwnerDefault);
            FsmVector3 vector = action.Values[1].Item2 as FsmVector3;
            FsmFloat x = action.Values[2].Item2 as FsmFloat;
            FsmFloat y = action.Values[3].Item2 as FsmFloat;
            FsmFloat z = action.Values[4].Item2 as FsmFloat;
            int space = (int)action.Values[5].Item2;
            if ((bool)action.Values[6].Item2)
            {
                state.AddBeginningCode("Coroutine GetPositionEveryFrame = null;");
                state.AddMiddleCode("IEnumerator GetPositionEveryFrameRoutine()");
                state.AddMiddleCode("{");
                state.AddMiddleCode("    while (true)");
                state.AddMiddleCode("    {");
                if (vector.useVariable && !string.IsNullOrEmpty(vector.name))
                    state.AddMiddleCode("        " + vector.name + " = " + goName + ".transform." + (space == 0 ? "position;" : "localPosition;"));
                if (x.useVariable && !string.IsNullOrEmpty(x.name))
                    state.AddMiddleCode("        " + x.name + " = " + goName + ".transform." + (space == 0 ? "position.x;" : "localPosition.x;"));
                if (y.useVariable && !string.IsNullOrEmpty(y.name))
                    state.AddMiddleCode("        " + y.name + " = " + goName + ".transform." + (space == 0 ? "position.y;" : "localPosition.y;"));
                if (z.useVariable && !string.IsNullOrEmpty(z.name))
                    state.AddMiddleCode("        " + z.name + " = " + goName + ".transform." + (space == 0 ? "position.z;" : "localPosition.z;"));
                state.AddMiddleCode("        yield return null;");
                state.AddMiddleCode("    }");
                state.AddMiddleCode("}");
                state.AddMiddleCode("GetPositionEveryFrame = StartCoroutine(GetPositionEveryFrameRoutine());");
                state.AddReturnCode("StopCoroutine(GetPositionEveryFrame);");
            }
            else
            {
                if (vector.useVariable && !string.IsNullOrEmpty(vector.name))
                    state.AddMiddleCode(vector.name + " = " + goName + ".transform." + (space == 0 ? "position;" : "localPosition;"));
                if (x.useVariable && !string.IsNullOrEmpty(x.name))
                    state.AddMiddleCode(x.name + " = " + goName + ".transform." + (space == 0 ? "position.x;" : "localPosition.x;"));
                if (y.useVariable && !string.IsNullOrEmpty(y.name))
                    state.AddMiddleCode(y.name + " = " + goName + ".transform." + (space == 0 ? "position.y;" : "localPosition.y;"));
                if (z.useVariable && !string.IsNullOrEmpty(z.name))
                    state.AddMiddleCode(z.name + " = " + goName + ".transform." + (space == 0 ? "position.z;" : "localPosition.z;"));
            }
        }
    }
}
