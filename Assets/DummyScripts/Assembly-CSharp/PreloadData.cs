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

public static class PreloadData // TypeDefIndex: 19551
{
	// Fields
	private static MappedFullPreloadData _preloadData; // 0x00

	// Nested types
	private class Data // TypeDefIndex: 19552
	{
		// Fields
		private string[] create; // 0x10
		private string[] combat; // 0x18

		// Constructors
		public Data() {} // 0x0000000182C91500-0x0000000182C91560

		// Methods
		// [XID] // 0x00000001899CCEF0-0x00000001899CCF10
		public void SetData(ConfigPreloadType type, string[] data) {} // 0x0000000182C91430-0x0000000182C91500
		// [XID] // 0x00000001899D4490-0x00000001899D44B0
		public string[] GetData(ConfigPreloadType type) => default; // 0x0000000182C91370-0x0000000182C91430
	}

	private class MappedPreloadData // TypeDefIndex: 19553
	{
		// Fields
		private Data effects; // 0x10
		private Data abilities; // 0x18
		private Data gadgets; // 0x20
		private Data cameras; // 0x28
		private Data animEventPatterns; // 0x30
		private Data skillIcons; // 0x38

		// Constructors
		public MappedPreloadData() {} // Dummy constructor
		public MappedPreloadData(ConfigPreload preloadData, Dictionary<ConfigPreloadType, ConfigPreloadType[]> mapping) {} // 0x0000000184774250-0x00000001847743A0

		// Methods
		// [XID] // 0x00000001899DBBD0-0x00000001899DBBF0
		public string[] GetEffectsData(ConfigPreloadType type) => default; // 0x0000000184774190-0x0000000184774250
		// [XID] // 0x00000001899E3550-0x00000001899E3570
		public string[] GetAbilitiesData(ConfigPreloadType type) => default; // 0x00000001847740D0-0x0000000184774190
		// [XID] // 0x00000001899EA8E0-0x00000001899EA900
		public string[] GetGadgetsData(ConfigPreloadType type) => default; // 0x00000001847737D0-0x0000000184773890
		// [XID] // 0x00000001897BC950-0x00000001897BC970
		public string[] GetCamerasData(ConfigPreloadType type) => default; // 0x0000000184773A20-0x0000000184773AE0
		// [XID] // 0x00000001899F9A70-0x00000001899F9A90
		public string[] GetAnimEventPatternData(ConfigPreloadType type) => default; // 0x0000000184773710-0x00000001847737D0
		// [XID] // 0x0000000189BBD580-0x0000000189BBD5A0
		public string[] getSkillIconsData(ConfigPreloadType typ) => default; // 0x0000000184773890-0x0000000184773950
		// [XID] // 0x0000000189A08750-0x0000000189A08770
		private void CheckData(ref Data data) {} // 0x0000000184773950-0x0000000184773A20
		// [XID] // 0x0000000189A0FD70-0x0000000189A0FD90
		private Data GetMappedPreloadData(Dictionary<ConfigPreloadType, string[]> preloads, Dictionary<ConfigPreloadType, ConfigPreloadType[]> mapping) => default; // 0x0000000184773AE0-0x00000001847740D0
	}

	private class MappedFullPreloadData // TypeDefIndex: 19554
	{
		// Fields
		public MappedPreloadData commonPreload; // 0x10
		public Dictionary<uint, MappedPreloadData> entitiesPreload; // 0x18

		// Constructors
		public MappedFullPreloadData() {} // Dummy constructor
		public MappedFullPreloadData(ConfigFullPreload preloadData) {} // 0x0000000182C91060-0x0000000182C91370
	}

	// Methods
	// [XID] // 0x000000018996F280-0x000000018996F2A0
	public static void ReloadFromFile() {} // 0x0000000184793A90-0x0000000184793B60
	[DebuggerHidden] // 0x0000000189976F40-0x0000000189976F80
	// [XID] // 0x0000000189976F40-0x0000000189976F80
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFCAC9 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x0000000184793EA0-0x0000000184793F90
	// [XID] // 0x0000000189981900-0x0000000189981920
	private static void LoadFromFile(ConfigMetaConfig metaConfig) {} // 0x0000000184794060-0x0000000184794370
	// [XID] // 0x0000000189989220-0x0000000189989240
	public static string[] GetCommonPreloadEffectNames(ConfigPreloadType preloadType) => default; // 0x0000000184794500-0x00000001847946A0
	// [XID] // 0x0000000189606570-0x0000000189606590
	public static string[] GetEntityPreloadEffectNames(BaseEntity entity, ConfigPreloadType preloadType) => default; // 0x0000000184793B60-0x0000000184793C30
	// [XID] // 0x0000000189998470-0x0000000189998490
	public static string[] GetEntityPreloadAbilityPaths(BaseEntity entity, ConfigPreloadType preloadType) => default; // 0x0000000184793D00-0x0000000184793DD0
	// [XID] // 0x0000000189B22FB0-0x0000000189B22FD0
	public static string[] GetEntityPreloadGadgetPaths(BaseEntity entity, ConfigPreloadType preloadType) => default; // 0x0000000184793F90-0x0000000184794060
	// [XID] // 0x00000001899A7920-0x00000001899A7940
	public static string[] GetEntityPreloadCameraPaths(BaseEntity entity, ConfigPreloadType preloadType) => default; // 0x0000000184793C30-0x0000000184793D00
	// [XID] // 0x00000001899AF190-0x00000001899AF1B0
	public static string[] GetEntityPreloadAnimEventPatterns(BaseEntity entity, ConfigPreloadType preloadType) => default; // 0x0000000184794430-0x0000000184794500
	// [XID] // 0x00000001899B64F0-0x00000001899B6510
	public static string[] GetEntityPreloadSkillIconNames(BaseEntity entity, ConfigPreloadType preloadType) => default; // 0x0000000184793DD0-0x0000000184793EA0
	// [XID] // 0x00000001899BE0F0-0x00000001899BE110
	private static MappedPreloadData GetCommonPreloadData() => default; // 0x0000000184794370-0x0000000184794430
	// [XID] // 0x00000001899C58D0-0x00000001899C58F0
	private static MappedPreloadData GetEntityPreloadData(BaseEntity entity) => default; // 0x0000000184793910-0x0000000184793A90
}

