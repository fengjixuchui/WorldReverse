/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class MemoryUtil // TypeDefIndex: 31574
{
	// Fields
	private static Dictionary<E_AssetType, MemoryAssetDetailInfo> _assetOverviewDict; // 0x00
	private static Dictionary<System.Type, System.Type[]> _assetFilterOut; // 0x08
	private static E_AssetType[] _additionalAssetType; // 0x10
	private static System.Type[] _additionalAssetObjectType; // 0x18
	private static int _lastDoProfileAllFrameIdx; // 0x20
	private static uint _lastEAssetTotalMemory; // 0x24
	private static int _lastGetMemoryStatInfoFrameIdx; // 0x28
	private static List<MemoryTCA> _lastMemoryTCAList; // 0x30
	public const string STATID_SYSTEMTOTAL = "SystemTotal"; // Metadata: 0x00B132D5
	public const string STATID_GFXTOTAL = "GfxReserved"; // Metadata: 0x00B132E4
	public const string STATID_OVERHEAD = "overhead"; // Metadata: 0x00B132F3
	private static bool _bInited; // 0x38

	// Nested types
	public enum E_AssetType // TypeDefIndex: 31575
	{
		None = 0,
		Textures = 1,
		RenderTextures = 2,
		Meshes = 3,
		AnimationClips = 4,
		Materials = 5,
		GameObject = 6,
		MonoHeap = 7,
		MonoUsed = 8,
		ExtraAssetTypeStart = 9,
		AnimatorController = 10,
		ParticleSystem = 11,
		TerrainData = 12,
		NavMeshData = 13,
		SkinnedMeshRenderer = 14,
		ExtraAssetTypeEnd = 15,
		LUA = 16,
		Wwise = 17
	}

	public class E_AssetTypeEqualityComparer : IEqualityComparer<E_AssetType> // TypeDefIndex: 31576
	{
		// Constructors
		public E_AssetTypeEqualityComparer() {} // 0x0000000181EC01D0-0x0000000181EC0230

		// Methods
		// [XID] // 0x0000000189A77ED0-0x0000000189A77EF0
		public bool Equals(E_AssetType x, E_AssetType y) => default; // 0x0000000181EC0050-0x0000000181EC0120
		// [XID] // 0x0000000189A7F4B0-0x0000000189A7F4D0
		public int GetHashCode(E_AssetType obj) => default; // 0x0000000181EC0120-0x0000000181EC01D0
	}

	public class EnumAssetTypeComparer : IEqualityComparer<E_AssetType> // TypeDefIndex: 31577
	{
		// Constructors
		public EnumAssetTypeComparer() {} // 0x0000000181EBFEE0-0x0000000181EBFF40

		// Methods
		// [XID] // 0x0000000189A871E0-0x0000000189A87200
		public bool Equals(E_AssetType x, E_AssetType y) => default; // 0x0000000181EBFD60-0x0000000181EBFE30
		// [XID] // 0x0000000189A8EA20-0x0000000189A8EA40
		public int GetHashCode(E_AssetType obj) => default; // 0x0000000181EBFE30-0x0000000181EBFEE0
	}

	// Constructors
	static MemoryUtil() {} // 0x0000000181ED5490-0x0000000181ED57D0

	// Methods
	// [XID] // 0x000000018999C5F0-0x000000018999C610
	public static Dictionary<E_AssetType, MemoryAssetDetailInfo> GetAssetDict() => default; // 0x0000000181ED3EC0-0x0000000181ED3F90
	// [XID] // 0x00000001899A4080-0x00000001899A40A0
	private static MemoryAssetDetailInfo DoProfileByDetailType(E_AssetType targetProfileType, E_AssetType detailProfileType) => default; // 0x0000000181ED2240-0x0000000181ED2330
	// [XID] // 0x00000001899ABA50-0x00000001899ABA70
	public static Dictionary<E_AssetType, MemoryAssetDetailInfo> DoProfilerAll(out uint totalMemory, E_AssetType detailType) {
		totalMemory = default;
		return default;
	} // 0x0000000181ED1A90-0x0000000181ED2080
	// [XID] // 0x00000001899BDA40-0x00000001899BDA60
	public static string GenTotalGfxOverheadText() => default; // 0x0000000181ED4890-0x0000000181ED4DC0
	// [XID] // 0x0000000189A38DD0-0x0000000189A38DF0
	public static List<MemoryTCA> GetMemoryStatInfo() => default; // 0x0000000181ED33A0-0x0000000181ED3EC0
	// [XID] // 0x00000001899CC830-0x00000001899CC850
	public static string GetDumpLog() => default; // 0x0000000181ED3F90-0x0000000181ED43A0
	// [XID] // 0x00000001899D3F00-0x00000001899D3F20
	public static MemoryAssetDetailInfo DoProfilerByType(E_AssetType assetType, bool bDetailAssetList, bool bDisableDetailTrim = false /* Metadata: 0x00B132D3 */) => default; // 0x0000000181ED5360-0x0000000181ED5490
	// [XID] // 0x000000018976F100-0x000000018976F120
	public static uint GetMonoHeapSize() => default; // 0x0000000181ED4720-0x0000000181ED47F0
	// [XID] // 0x00000001899D2380-0x00000001899D23A0
	public static uint GetMonoUsedSize() => default; // 0x0000000181ED2F00-0x0000000181ED2FD0
	// [XID] // 0x00000001899EA230-0x00000001899EA250
	public static float GetUnityAndProfileReservedMemoryLong() => default; // 0x0000000181ED2330-0x0000000181ED2410
	// [XID] // 0x00000001899F1C80-0x00000001899F1CA0
	private static void StatResourcesByAssetType(System.Type assetType, MemoryAssetDetailInfo inDetailInfo, bool bDetailMode) {} // 0x0000000181ED4F80-0x0000000181ED51E0
	// [XID] // 0x00000001899F94A0-0x00000001899F94C0
	private static void Internal_DoProfilerByType(E_AssetType assetType, bool bDetailAssetList, bool bDisableDetailTrim = false /* Metadata: 0x00B132D4 */) {} // 0x0000000181ED4DC0-0x0000000181ED4F80
	// [XID] // 0x0000000189A00780-0x0000000189A007A0
	private static void ClearMemoryNum() {} // 0x0000000181ED4440-0x0000000181ED44D0
	// [XID] // 0x0000000189A080C0-0x0000000189A080E0
	private static void Init() {} // 0x0000000181ED26C0-0x0000000181ED2F00
	// [XID] // 0x0000000189BA5E00-0x0000000189BA5E20
	public static uint BytesToMegaBytes(uint _bytes) => default; // 0x0000000181ED43A0-0x0000000181ED4440
	// [XID] // 0x0000000189A16B60-0x0000000189A16B80
	public static uint BytesToKiloBytes(uint _bytes) => default; // 0x0000000181ED47F0-0x0000000181ED4890
	// [IDTag] // 0x0000000189A1E160-0x0000000189A1E1A0
	// [XID] // 0x0000000189A1E160-0x0000000189A1E1A0
	public static float BytesToMegaBytesFloat(long _bytes) => default; // 0x0000000181ED19D0-0x0000000181ED1A90
	// [XID] // 0x0000000189A286E0-0x0000000189A28700
	public static int BytesToMegaBytesInt(long _bytes) => default; // 0x0000000181ED2410-0x0000000181ED24C0
	// [IDTag] // 0x0000000189A2FD10-0x0000000189A2FD50
	// [XID] // 0x0000000189A2FD10-0x0000000189A2FD50
	public static float BytesToMegaBytesFloat(uint _bytes) => default; // 0x0000000181ED1910-0x0000000181ED19D0
	// [IDTag] // 0x0000000189A3A4D0-0x0000000189A3A510
	// [XID] // 0x0000000189A3A4D0-0x0000000189A3A510
	public static float BytesToKiloBytesFloat(long _bytes) => default; // 0x0000000181ED51E0-0x0000000181ED52A0
	// [XID] // 0x0000000189A44C10-0x0000000189A44C30
	public static float KiloBytesToMegaBytesFloat(long _bytes) => default; // 0x0000000181ED44D0-0x0000000181ED45A0
	// [IDTag] // 0x0000000189A4C440-0x0000000189A4C480
	// [XID] // 0x0000000189A4C440-0x0000000189A4C480
	public static float BytesToKiloBytesFloat(uint _bytes) => default; // 0x0000000181ED52A0-0x0000000181ED5360
	// [XID] // 0x0000000189A69270-0x0000000189A69290
	public static List<MemoryAssetList.AssetItem> StatMeshesOnPrefab() => default; // 0x0000000181ED2FD0-0x0000000181ED33A0
	// [XID] // 0x0000000189A70640-0x0000000189A70660
	public static List<MemoryAssetList.AssetItem> StatTexturesOnPrefab() => default; // 0x0000000181ED2080-0x0000000181ED2240

	// Extension methods
	// [XID] // 0x00000001899B3410-0x00000001899B3450
	public static MemoryTCA ToMemoryTCA(this Dictionary<E_AssetType, MemoryAssetDetailInfo> dict, E_AssetType inType) => default; // 0x0000000181ED45A0-0x0000000181ED4720
	// [XID] // 0x0000000189A56B50-0x0000000189A56B90
	public static string GenTransformPath(this Transform inTrans, int depth) => default; // 0x0000000181ED24C0-0x0000000181ED26C0
	private static void AddAsset<T>(this Dictionary<T, MemoryAssetList.AssetItem> inMap, T inAsset, Transform inTransform)
		where T : UnityEngine.Object {}
}

