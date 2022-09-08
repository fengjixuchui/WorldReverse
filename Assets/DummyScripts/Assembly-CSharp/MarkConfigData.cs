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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class MarkConfigData // TypeDefIndex: 19247
{
	// Fields
	private static ConfigMarkGlobal _globalConfig; // 0x00

	// Properties
	private static string CONFIG_DATA_PATH { /* [XID] */ /* 0x0000000189A3C310-0x0000000189A3C330 */ get; } // 0x0000000183E6D380-0x0000000183E6D420 
	public static MarkIconType[] pinMarkIcons { /* [XID] */ /* 0x0000000189A6C580-0x0000000189A6C5A0 */ get; } // 0x0000000183E6CC50-0x0000000183E6CD60 
	public static MarkIconType[] customMarkIcons { /* [XID] */ /* 0x0000000189A73DB0-0x0000000189A73DD0 */ get; } // 0x0000000183E6DDE0-0x0000000183E6DEF0 

	// Constructors
	static MarkConfigData() {} // 0x0000000183E6DEF0-0x0000000183E6DF50

	// Methods
	// [XID] // 0x0000000189A43EB0-0x0000000189A43ED0
	public static void ReloadFromFile() {} // 0x0000000183E6CD60-0x0000000183E6CFC0
	[DebuggerHidden] // 0x0000000189A4B3A0-0x0000000189A4B3E0
	// [XID] // 0x0000000189A4B3A0-0x0000000189A4B3E0
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFC64A */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x0000000183E6D630-0x0000000183E6D770
	// [XID] // 0x0000000189A55CA0-0x0000000189A55CC0
	public static ConfigMark GetMarkConfig(MarkType markType) => default; // 0x0000000183E6D8A0-0x0000000183E6DB50
	// [XID] // 0x00000001898C7F80-0x00000001898C7FA0
	public static ConfigMarkIcon GetMarkIconConfig(MarkIconType markIconType) => default; // 0x0000000183E6CFC0-0x0000000183E6D380
	// [XID] // 0x0000000189A64E20-0x0000000189A64E40
	public static bool IsValidPinMarkIcon(MarkIconType iconType) => default; // 0x0000000183E6D770-0x0000000183E6D8A0
	// [XID] // 0x00000001895EFCC0-0x00000001895EFCE0
	public static bool TryGetSceneBuildingMark(SceneBuildingType buildingType, out MarkIconType iconType) {
		iconType = default;
		return default;
	} // 0x0000000183E6D420-0x0000000183E6D630
	// [XID] // 0x0000000189A83040-0x0000000189A83060
	public static int GetMarkLayer(ConfigMarkIcon configMarkIcon) => default; // 0x0000000183E6DB50-0x0000000183E6DDE0
}

