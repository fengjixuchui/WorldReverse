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

public class CameraMoveSetData // TypeDefIndex: 19462
{
	// Fields
	private static Dictionary<string, ConfigCameraMove> _cameraMoveSetDic; // 0x00

	// Properties
	private static string _configPath { /* [XID] */ /* 0x00000001899A16B0-0x00000001899A16D0 */ get => default; } // 0x00000001820A29A0-0x00000001820A2A40 

	// Constructors
	public CameraMoveSetData() {} // 0x00000001820A2AD0-0x00000001820A2B30
	static CameraMoveSetData() {} // 0x00000001820A2A40-0x00000001820A2AD0

	// Methods
	// [XID] // 0x00000001899A90A0-0x00000001899A90C0
	public static void ReloadFromFile() {} // 0x00000001820A2620-0x00000001820A26E0
	[DebuggerHidden] // 0x00000001899B0B90-0x00000001899B0BD0
	// [XID] // 0x00000001899B0B90-0x00000001899B0BD0
	public static IEnumerator ReloadFromFileAsync(double progressSpan = 0 /* Metadata: 0x00AFC8AC */, Action<double> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x00000001820A26E0-0x00000001820A2820
	// [XID] // 0x00000001899BAE40-0x00000001899BAE60
	private static void LoadCameraMoveSetConfig() {} // 0x00000001820A2180-0x00000001820A2620
	// [XID] // 0x00000001899C2800-0x00000001899C2820
	public static ConfigCameraMove GetCameraMoveConfig(string keyName) => default; // 0x00000001820A2820-0x00000001820A29A0
}

