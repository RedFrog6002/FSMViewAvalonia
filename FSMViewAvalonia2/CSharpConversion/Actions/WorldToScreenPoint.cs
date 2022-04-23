using System;
using System.Collections.Generic;
using System.Text;
using static FSMViewAvalonia2.CSharpConversion.ActionCode;

namespace FSMViewAvalonia2.CSharpConversion.Actions
{
    public static class WorldToScreenPoint
    {
        public static void Build(FsmStateBuilder state, ActionScriptEntry action, FsmStateData data)
        {
            FsmVector3 worldPosition = action.Values[0].Item2 as FsmVector3;
            FsmFloat worldX = action.Values[1].Item2 as FsmFloat;
            FsmFloat worldY = action.Values[2].Item2 as FsmFloat;
            FsmFloat worldZ = action.Values[3].Item2 as FsmFloat;
            FsmVector3 storeScreenPoint = action.Values[4].Item2 as FsmVector3;
            FsmFloat storeScreenX = action.Values[5].Item2 as FsmFloat;
            FsmFloat storeScreenY = action.Values[6].Item2 as FsmFloat;
            FsmBool normalize = action.Values[7].Item2 as FsmBool;

			if ((storeScreenPoint.useVariable && string.IsNullOrEmpty(storeScreenPoint.name)) && (storeScreenX.useVariable && string.IsNullOrEmpty(storeScreenX.name)) && (storeScreenY.useVariable && string.IsNullOrEmpty(storeScreenY.name)))
				return;

            if ((bool)action.Values[8].Item2)
            {
                state.AddBeginningCode("Coroutine SetIntValueEveryFrame = null;");
                state.AddMiddleCode("IEnumerator SetIntValueEveryFrameRoutine()");
                state.AddMiddleCode("{");
                state.AddMiddleCode("    while (true)");
                state.AddMiddleCode("    {");
				state.AddMiddleCode("        if (Camera.main == null)"); ;
				state.AddMiddleCode("            yield break;");
				int xMode = 0;
				int yMode = 0;
				int zMode = 0;
				if (worldPosition.useVariable)
				{
					if (!string.IsNullOrEmpty(worldPosition.name))
					{
						xMode = 1;
						yMode = 1;
						zMode = 1;
					}
				}
				else
				{
					xMode = 2;
					yMode = 2;
					zMode = 2;
				}
				if (worldX.useVariable)
				{
					if (!string.IsNullOrEmpty(worldX.name))
						xMode = 3;
				}
				else
					xMode = 4;
				if (worldY.useVariable)
				{
					if (!string.IsNullOrEmpty(worldY.name))
						yMode = 3;
				}
				else
					yMode = 4;
				if (worldZ.useVariable)
				{
					if (!string.IsNullOrEmpty(worldZ.name))
						zMode = 3;
				}
				else
					zMode = 4;
				string vectorString;
				if (xMode != 1 || yMode != 1 || zMode != 1)
				{
					vectorString = "new Vector3(";
					switch (xMode)
					{
						case 0:
							vectorString += "0f, ";
							break;
						case 1:
							vectorString += worldPosition.name + ".x, ";
							break;
						case 2:
							vectorString += worldPosition.value.x + "f, ";
							break;
						case 3:
							vectorString += worldX.name + ", ";
							break;
						case 4:
							vectorString += worldX.value + "f, ";
							break;
					}
					switch (yMode)
					{
						case 0:
							vectorString += "0f, ";
							break;
						case 1:
							vectorString += worldPosition.name + ".y, ";
							break;
						case 2:
							vectorString += worldPosition.value.y + "f, ";
							break;
						case 3:
							vectorString += worldY.name + ", ";
							break;
						case 4:
							vectorString += worldY.value + "f, ";
							break;
					}
					switch (zMode)
					{
						case 0:
							vectorString += "0f)";
							break;
						case 1:
							vectorString += worldPosition.name + ".z)";
							break;
						case 2:
							vectorString += worldPosition.value.z + "f)";
							break;
						case 3:
							vectorString += worldZ.name + ")";
							break;
						case 4:
							vectorString += worldZ.value + "f)";
							break;
					}
				}
				else
					vectorString = worldPosition.name;
				state.AddMiddleCode("Vector3 vector = Camera.main.WorldToScreenPoint(" + vectorString + ");");
				if (normalize.useVariable)
				{
					if (!string.IsNullOrEmpty(normalize.name))
					{
						state.AddMiddleCode("        if (" + normalize.name + ")");
						state.AddMiddleCode("        {");
						state.AddMiddleCode("            vector.x /= (float)Screen.width;");
						state.AddMiddleCode("            vector.y /= (float)Screen.width;");
						state.AddMiddleCode("        }");
					}
				}
				else if (normalize.value)
				{
					state.AddMiddleCode("        vector.x /= (float)Screen.width;");
					state.AddMiddleCode("        vector.y /= (float)Screen.width;");
				}
				if (storeScreenPoint.useVariable && !string.IsNullOrEmpty(storeScreenPoint.name))
					state.AddMiddleCode("        " + storeScreenPoint.name + " = vector;");
				if (storeScreenX.useVariable && !string.IsNullOrEmpty(storeScreenX.name))
					state.AddMiddleCode("        " + storeScreenX.name + " = vector;");
				if (storeScreenY.useVariable && !string.IsNullOrEmpty(storeScreenY.name))
					state.AddMiddleCode("        " + storeScreenY.name + " = vector;");
				state.AddMiddleCode("        yield return null;");
                state.AddMiddleCode("    }");
                state.AddMiddleCode("}");
                state.AddMiddleCode("SetIntValueEveryFrame = StartCoroutine(SetIntValueEveryFrameRoutine());");
                state.AddReturnCode("StopCoroutine(SetIntValueEveryFrame);");
            }
            else
			{
				state.AddMiddleCode("if (Camera.main == null)"); ;
				state.AddMiddleCode("    return;");
				int xMode = 0;
				int yMode = 0;
				int zMode = 0;
				if (worldPosition.useVariable)
                {
					if (!string.IsNullOrEmpty(worldPosition.name))
					{
						xMode = 1;
						yMode = 1;
						zMode = 1;
					}
				}
				else
                {
					xMode = 2;
					yMode = 2;
					zMode = 2;
                }
				if (worldX.useVariable)
				{
					if (!string.IsNullOrEmpty(worldX.name))
						xMode = 3;
				}
				else
					xMode = 4;
				if (worldY.useVariable)
				{
					if (!string.IsNullOrEmpty(worldY.name))
						yMode = 3;
				}
				else
					yMode = 4;
				if (worldZ.useVariable)
				{
					if (!string.IsNullOrEmpty(worldZ.name))
						zMode = 3;
				}
				else
					zMode = 4;
				string vectorString;
				if (xMode != 1 || yMode != 1 || zMode != 1)
				{
					vectorString = "new Vector3(";
					switch (xMode)
					{
						case 0:
							vectorString += "0f, ";
							break;
						case 1:
							vectorString += worldPosition.name + ".x, ";
							break;
						case 2:
							vectorString += worldPosition.value.x + "f, ";
							break;
						case 3:
							vectorString += worldX.name + ", ";
							break;
						case 4:
							vectorString += worldX.value + "f, ";
							break;
					}
					switch (yMode)
					{
						case 0:
							vectorString += "0f, ";
							break;
						case 1:
							vectorString += worldPosition.name + ".y, ";
							break;
						case 2:
							vectorString += worldPosition.value.y + "f, ";
							break;
						case 3:
							vectorString += worldY.name + ", ";
							break;
						case 4:
							vectorString += worldY.value + "f, ";
							break;
					}
					switch (zMode)
					{
						case 0:
							vectorString += "0f)";
							break;
						case 1:
							vectorString += worldPosition.name + ".z)";
							break;
						case 2:
							vectorString += worldPosition.value.z + "f)";
							break;
						case 3:
							vectorString += worldZ.name + ")";
							break;
						case 4:
							vectorString += worldZ.value + "f)";
							break;
					}
				}
				else
					vectorString = worldPosition.name;
				state.AddMiddleCode("Vector3 vector = Camera.main.WorldToScreenPoint(" + vectorString + ");");
				if (normalize.useVariable)
                {
					if (!string.IsNullOrEmpty(normalize.name))
					{
						state.AddMiddleCode("if (" + normalize.name + ")");
						state.AddMiddleCode("{");
						state.AddMiddleCode("    vector.x /= (float)Screen.width;");
						state.AddMiddleCode("    vector.y /= (float)Screen.width;");
						state.AddMiddleCode("}");
					}
                }
				else if (normalize.value)
				{
					state.AddMiddleCode("vector.x /= (float)Screen.width;");
					state.AddMiddleCode("vector.y /= (float)Screen.width;");
				}
				if (storeScreenPoint.useVariable && !string.IsNullOrEmpty(storeScreenPoint.name))
					state.AddMiddleCode(storeScreenPoint.name + " = vector;");
				if (storeScreenX.useVariable && !string.IsNullOrEmpty(storeScreenX.name))
					state.AddMiddleCode(storeScreenX.name + " = vector;");
				if (storeScreenY.useVariable && !string.IsNullOrEmpty(storeScreenY.name))
					state.AddMiddleCode(storeScreenY.name + " = vector;");
			}
		}
	}
}
