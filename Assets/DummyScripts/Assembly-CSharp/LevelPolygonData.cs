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

public class LevelPolygonData // TypeDefIndex: 19534
{
	// Fields
	private static Dictionary<uint, Dictionary<uint, LevelPolygon>> _levelGameplayPolygons; // 0x00

	// Constructors
	public LevelPolygonData() {} // 0x0000000183925CE0-0x0000000183925D40
	static LevelPolygonData() {} // 0x0000000183925C50-0x0000000183925CE0

	// Methods
	// [XID] // 0x00000001896747D0-0x00000001896747F0
	public static void ReloadFromFile() {} // 0x0000000183925370-0x0000000183925B10
	[DebuggerHidden] // 0x000000018967C100-0x000000018967C140
	// [XID] // 0x000000018967C100-0x000000018967C140
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFCA9D */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x0000000183925B10-0x0000000183925C50
	// [XID] // 0x0000000189B52B20-0x0000000189B52B40
	public static SimplePolygon? GetPolygon(uint sceneId, uint localPolygonId) => default; // 0x0000000183925150-0x0000000183925370
}

