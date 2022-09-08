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

public static class ActionPanelData // TypeDefIndex: 19549
{
	// Fields
	private static Dictionary<PlayModeType, Dictionary<ActionPanelState, ConfigActionPanelState>> _actionPanelConfigs; // 0x00

	// Constructors
	static ActionPanelData() {} // 0x0000000181470640-0x00000001814706E0

	// Methods
	// [XID] // 0x000000018990B1B0-0x000000018990B1D0
	public static void ReloadFromFile() {} // 0x000000018146FC30-0x000000018146FCF0
	[DebuggerHidden] // 0x0000000189912D60-0x0000000189912DA0
	// [XID] // 0x0000000189912D60-0x0000000189912DA0
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFCAC5 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x000000018146FCF0-0x000000018146FE30
	// [XID] // 0x000000018991D510-0x000000018991D530
	public static void LoadActionPanelConfig() {} // 0x000000018146FE30-0x0000000181470430
	// [XID] // 0x0000000189924E40-0x0000000189924E60
	public static ConfigActionPanelState GetLevelEntitytConfig(PlayModeType modeType, ActionPanelState stateType) => default; // 0x0000000181470430-0x0000000181470640
}

