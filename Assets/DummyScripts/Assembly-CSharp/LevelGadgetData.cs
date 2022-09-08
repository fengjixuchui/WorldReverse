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

public class LevelGadgetData // TypeDefIndex: 19519
{
	// Fields
	private static Dictionary<uint, ConfigLevelGadgetData> _scenes; // 0x00
	private static Dictionary<GadgetConfigIdentifier, LevelGadget> _gadgetIndexing; // 0x08

	// Nested types
	public struct GadgetConfigIdentifier // TypeDefIndex: 19520
	{
		// Properties
		public uint sceneId { /* [XID] */ /* 0x00000001899D74D0-0x00000001899D7510 */ get; /* [XID] */ /* 0x00000001899E1E20-0x00000001899E1E60 */ set; } // 0x0000000182740030-0x0000000182740090 0x0000000182740090-0x00000001827400F0
		public uint groupId { /* [XID] */ /* 0x00000001899EC290-0x00000001899EC2D0 */ get; /* [XID] */ /* 0x00000001899F6BF0-0x00000001899F6C30 */ set; } // 0x00000001827400F0-0x0000000182740150 0x0000000182740150-0x00000001827401B0
		public uint mapInstId { /* [XID] */ /* 0x0000000189A00E10-0x0000000189A00E50 */ get; /* [XID] */ /* 0x0000000189A0B6D0-0x0000000189A0B710 */ set; } // 0x000000018273FFD0-0x0000000182740030 0x000000018273FF10-0x000000018273FFD0
	}

	public class GadgetConfigIdentifierEqualityComparer : IEqualityComparer<GadgetConfigIdentifier> // TypeDefIndex: 19521
	{
		// Constructors
		public GadgetConfigIdentifierEqualityComparer() {} // 0x00000001827408E0-0x0000000182740940

		// Methods
		// [XID] // 0x0000000189A15D40-0x0000000189A15D60
		public bool Equals(GadgetConfigIdentifier x, GadgetConfigIdentifier y) => default; // 0x0000000182740550-0x0000000182740760
		// [XID] // 0x0000000189A1D1F0-0x0000000189A1D210
		public int GetHashCode(GadgetConfigIdentifier obj) => default; // 0x0000000182740760-0x00000001827408E0
	}

	// Constructors
	static LevelGadgetData() {} // 0x0000000182754270-0x0000000182754360
	public LevelGadgetData() {} // 0x0000000182754360-0x00000001827543C0

	// Methods
	// [XID] // 0x0000000189720180-0x00000001897201A0
	public static LevelGadget FindGadgetConfig(uint sceneId, uint groupId, uint mapInstId) => default; // 0x00000001827538F0-0x0000000182753AF0
	// [XID] // 0x000000018999E810-0x000000018999E830
	public static void ReloadFromFile() {} // 0x0000000182753D40-0x0000000182754130
	[DebuggerHidden] // 0x00000001899A61B0-0x00000001899A61F0
	// [XID] // 0x00000001899A61B0-0x00000001899A61F0
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFCA85 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x0000000182754130-0x0000000182754270
	// [XID] // 0x00000001899B0B70-0x00000001899B0B90
	private static void RegisterGadgets(LevelGadget[] list, uint sceneId) {} // 0x0000000182753AF0-0x0000000182753D40
}

