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

public static class FaceAnimationData // TypeDefIndex: 19817
{
	// Fields
	private static Dictionary<string, ConfigFaceAnimation> _dictFaceAnimation; // 0x00
	private static List<uint> _handles; // 0x08

	// Constructors
	static FaceAnimationData() {} // 0x000000018312D150-0x000000018312D210

	// Methods
	// [XID] // 0x00000001897CAA30-0x00000001897CAA50
	public static void ReloadFromFile() {} // 0x000000018312CA60-0x000000018312CED0
	[DebuggerHidden] // 0x00000001897D2010-0x00000001897D2050
	// [XID] // 0x00000001897D2010-0x00000001897D2050
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFCEF8 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x000000018312D010-0x000000018312D150
	// [XID] // 0x00000001897DC830-0x00000001897DC850
	public static ConfigFaceAnimation GetFaceAnimation(string name) => default; // 0x000000018312CED0-0x000000018312D010
}

