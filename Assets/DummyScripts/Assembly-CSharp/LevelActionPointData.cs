/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class LevelActionPointData // TypeDefIndex: 19512
{
	// Fields
	private static Dictionary<uint, Dictionary<ActionPointType, List<LevelActionPoint>>> _staticLevelPoints; // 0x00
	private static Dictionary<ActionPointType, Dictionary<int, LevelActionPoint>> _dynamicEntityPoints; // 0x08
	private static List<LevelActionPoint> _tempPoints1; // 0x10
	private static List<LevelActionPoint> _tempPoints2; // 0x18
	private static List<LevelActionPoint> _tempPoints3; // 0x20

	// Constructors
	static LevelActionPointData() {} // 0x0000000183B8A2B0-0x0000000183B8A410

	// Methods
	// [XID] // 0x000000018986F980-0x000000018986F9A0
	public static void ReloadFromFile() {} // 0x0000000183B88060-0x0000000183B887E0
	[DebuggerHidden] // 0x0000000189877050-0x0000000189877090
	// [XID] // 0x0000000189877050-0x0000000189877090
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFCA68 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x0000000183B887E0-0x0000000183B88920
	// [XID] // 0x0000000189881700-0x0000000189881720
	public static void AddDynamicPoint(ActionPointType type, int gameObjectInstanceID, Vector3 position, int capacity, float inner, float outer, int freestyle, bool faceCenter) {} // 0x0000000183B88920-0x0000000183B88C80
	// [XID] // 0x0000000189888C60-0x0000000189888C80
	public static void RemoveDynamicPoint(ActionPointType type, int gameObjectInstanceID) {} // 0x0000000183B8A130-0x0000000183B8A2B0
	// [XID] // 0x000000018994ACF0-0x000000018994AD10
	public static List<LevelActionPoint> GetAllActionPoints(uint sceneID, bool includeDynamic = true /* Metadata: 0x00AFCA6C */) => default; // 0x0000000183B89AB0-0x0000000183B8A130
	// [IDTag] // 0x0000000189897580-0x00000001898975C0
	// [XID] // 0x0000000189897580-0x00000001898975C0
	public static List<LevelActionPoint> GetActionPoints(ActionPointType pointType, uint sceneID, bool includeDynamic = true /* Metadata: 0x00AFCA6D */) => default; // 0x0000000183B89280-0x0000000183B89810
	// [IDTag] // 0x00000001898A1BC0-0x00000001898A1C00
	// [XID] // 0x00000001898A1BC0-0x00000001898A1C00
	public static List<LevelActionPoint> GetActionPoints(ActionPointType pointType, uint sceneID, HashSet<uint> pointIds, bool includeDynamic = true /* Metadata: 0x00AFCA6E */) => default; // 0x0000000183B88C80-0x0000000183B89280
	// [IDTag] // 0x00000001898AC200-0x00000001898AC240
	// [XID] // 0x00000001898AC200-0x00000001898AC240
	public static LevelActionPoint GetActionPoint(uint sceneID, uint actionPointID, bool includeDynamicPoints = true /* Metadata: 0x00AFCA6F */) => default; // 0x0000000183B87E60-0x0000000183B88060
	// [IDTag] // 0x00000001898B6930-0x00000001898B6970
	// [XID] // 0x00000001898B6930-0x00000001898B6970
	public static LevelActionPoint GetActionPoint(ActionPointType pointType, uint sceneID, uint pointID, bool includeDynamicPoints = true /* Metadata: 0x00AFCA70 */) => default; // 0x0000000183B87C40-0x0000000183B87E60
	// [XID] // 0x00000001898C1260-0x00000001898C1280
	public static LevelActionPoint GetActionPointNearest(ActionPointType pointType, uint sceneID, Vector3 currentPos) => default; // 0x0000000183B89810-0x0000000183B89AB0
}

