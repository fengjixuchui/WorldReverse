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
using MoleMole.Config;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class EffectData // TypeDefIndex: 19489
{
	// Properties
	public static ConfigEffectData effectData { /* [XID] */ /* 0x0000000189974010-0x0000000189974050 */ get; /* [XID] */ /* 0x000000018997E260-0x000000018997E2A0 */ private set; } // 0x0000000182875820-0x0000000182875880 0x00000001828749D0-0x0000000182874A30
	public static ConfigEffectPath effectPath { /* [XID] */ /* 0x0000000189989240-0x0000000189989280 */ get; /* [XID] */ /* 0x0000000189993E30-0x0000000189993E70 */ private set; } // 0x0000000182874B00-0x0000000182874B70 0x0000000182874960-0x00000001828749D0

	// Methods
	// [XID] // 0x000000018999E830-0x000000018999E850
	public static void ReloadFromFile() {} // 0x0000000182874A30-0x0000000182874B00
	[DebuggerHidden] // 0x00000001899A61F0-0x00000001899A6230
	// [XID] // 0x00000001899A61F0-0x00000001899A6230
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFC918 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x0000000182874B70-0x0000000182874C60
	// [XID] // 0x0000000189817FE0-0x0000000189818000
	private static void LoadFromFile(ConfigMetaConfig metaConfig) {} // 0x0000000182874C60-0x0000000182875250
	// [XID] // 0x0000000189808FF0-0x0000000189809010
	private static void CheckEffectLoaded() {} // 0x0000000182875460-0x0000000182875660
	// [XID] // 0x00000001899BF990-0x00000001899BF9B0
	public static string GetRecoverEnergyEffectName(ElementType type, float changeValue) => default; // 0x00000001828743C0-0x0000000182874630
	// [XID] // 0x00000001899C7210-0x00000001899C7230
	public static ulong GetEffectPath(string effectName) => default; // 0x0000000182875660-0x0000000182875820
	// [XID] // 0x00000001899CE700-0x00000001899CE720
	public static uint GetEffectPreinstantiateNumWhenPreload(string effectName) => default; // 0x0000000182874630-0x0000000182874830
	// [XID] // 0x00000001899D5DD0-0x00000001899D5DF0
	public static uint GetEffectMaxUsedSize(string effectName) => default; // 0x0000000182875250-0x0000000182875460
	// [XID] // 0x00000001899DD2E0-0x00000001899DD300
	public static Dictionary<string, ulong> GetAllEffectPaths() => default; // 0x00000001828742C0-0x00000001828743C0
	// [XID] // 0x0000000189A35BC0-0x0000000189A35BE0
	public static bool UseDistanceLOD(BaseEntity effectOwner) => default; // 0x0000000182874830-0x0000000182874960
}

