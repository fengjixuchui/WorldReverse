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

public static class StageAudioData // TypeDefIndex: 19396
{
	// Fields
	private static readonly Dictionary<int, ConfigAudioStageEvents> _lut; // 0x00

	// Constructors
	static StageAudioData() {} // 0x0000000184820990-0x0000000184820A30

	// Methods
	// [XID] // 0x0000000189A14720-0x0000000189A14740
	public static void ReloadFromFile() {} // 0x0000000184820410-0x00000001848205F0
	[DebuggerHidden] // 0x0000000189A1BA70-0x0000000189A1BAB0
	// [XID] // 0x0000000189A1BA70-0x0000000189A1BAB0
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFC807 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x0000000184820850-0x0000000184820990
	// [XID] // 0x0000000189A26090-0x0000000189A260B0
	public static ConfigAudioStageEvents GetConfigById(int id) => default; // 0x0000000184820310-0x0000000184820410
	// [XID] // 0x0000000189A2D3B0-0x0000000189A2D3D0
	private static void LoadConfigFile(ConfigMetaConfig.PathHash filePathHash) {} // 0x00000001848205F0-0x0000000184820850
}

