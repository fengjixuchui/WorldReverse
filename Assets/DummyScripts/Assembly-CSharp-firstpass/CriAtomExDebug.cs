/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public static class CriAtomExDebug // TypeDefIndex: 7219
{
	// Nested types
	public struct ResourcesInfo // TypeDefIndex: 7220
	{
		// Fields
		public CriAtomEx.ResourceUsage virtualVoiceUsage; // 0x00
		public CriAtomEx.ResourceUsage sequenceUsage; // 0x08
		public CriAtomEx.ResourceUsage sequenceTrackUsage; // 0x10
		public CriAtomEx.ResourceUsage sequenceTrackItemUsage; // 0x18
	}

	// Methods
	public static void GetResourcesInfo(out ResourcesInfo resourcesInfo) {
		resourcesInfo = default;
	} // 0x00000001877A7310-0x00000001877A7380
	private static extern void criAtomExDebug_GetResourcesInfo(out ResourcesInfo resourcesInfo); // 0x00000001877A7380-0x00000001877A7490
}

