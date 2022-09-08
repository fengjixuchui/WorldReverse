/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class AudioFeatureToggles // TypeDefIndex: 10945
{
	// Fields
	private static AudioFeatureBitmask _enabledFeatures; // 0x00

	// Constructors
	static AudioFeatureToggles() {} // 0x000000018357D9E0-0x000000018357DA40

	// Methods
	// [XID] // 0x0000000189880D30-0x0000000189880D50
	public static void EnableAll() {} // 0x000000018357D5F0-0x000000018357D6B0
	// [XID] // 0x00000001898880A0-0x00000001898880C0
	public static void DisableAll() {} // 0x000000018357D780-0x000000018357D840
	// [XID] // 0x00000001896BE120-0x00000001896BE140
	public static void Enable(AudioFeatureBitmask feature) {} // 0x000000018357D6B0-0x000000018357D780
	// [XID] // 0x00000001896DBD20-0x00000001896DBD40
	public static void Disable(AudioFeatureBitmask feature) {} // 0x000000018357D910-0x000000018357D9E0
	// [XID] // 0x00000001896CD080-0x00000001896CD0A0
	public static bool IsEnabled(AudioFeatureBitmask feature) => default; // 0x000000018357D840-0x000000018357D910
}

