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

public class SCameraMoveSetData // TypeDefIndex: 19479
{
	// Fields
	private static Dictionary<string, ConfigCameraMove> _cameraMoveSetDic; // 0x00

	// Properties
	private static string _configPath { /* [XID] */ /* 0x00000001897CF070-0x00000001897CF090 */ get => default; } // 0x00000001837363C0-0x0000000183736460 

	// Constructors
	public SCameraMoveSetData() {} // 0x00000001837364F0-0x0000000183736550
	static SCameraMoveSetData() {} // 0x0000000183736460-0x00000001837364F0

	// Methods
	// [XID] // 0x00000001897D6800-0x00000001897D6820
	public static void ReloadFromFile() {} // 0x0000000183736040-0x0000000183736100
	[DebuggerHidden] // 0x00000001897DE010-0x00000001897DE050
	// [XID] // 0x00000001897DE010-0x00000001897DE050
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFC8E0 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x0000000183736100-0x0000000183736240
	// [XID] // 0x00000001897E89F0-0x00000001897E8A10
	private static void LoadCameraMoveSetConfig() {} // 0x0000000183735BA0-0x0000000183736040
	// [XID] // 0x00000001897F0620-0x00000001897F0640
	public static ConfigCameraMove GetCameraMoveConfig(string keyName) => default; // 0x0000000183736240-0x00000001837363C0
}

