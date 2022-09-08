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

public static class SECTR_Utils // TypeDefIndex: 31912
{
	// Fields
	public const string AUTO_BUILD_LODCONFIG_FOLDER = "Build/LevelStreaming/Config/LODConfig/"; // Metadata: 0x00B13872
	public const string DATA_PLATFORM_CONFIG_FOLDER = "Data/LevelStreamingConfig/PlatformConfig/"; // Metadata: 0x00B1389C
	public const string DATA_SPLIT_CONFIG_FOLDER = "Data/LevelStreamingConfig/SplitterConfig/"; // Metadata: 0x00B138C9
	public const string DATA_SCENEPROP_CONFIG_FOLDER = "Data/LevelStreamingConfig/SceneProp/"; // Metadata: 0x00B138F6
	public const string DATA_PROFILE_RATIO_CONFIG_FOLDER = "Data/LevelStreamingConfig/ProfileRatioConfig/"; // Metadata: 0x00B1391E
	public static bool useColliderLayer; // 0x00
	public static LODType forceLOD; // 0x04
	public static bool showDebugDisableUnloadRatio; // 0x08
	public static bool showDebugMono; // 0x09
	public static bool showDebugConTree; // 0x0A
	public static bool showDebugUseRootTrans; // 0x0B
	public static int allLoadedLayerCount; // 0x0C
	public static int allLoadedObjCount; // 0x10
	public static List<string> festivalNams; // 0x18
	public static bool forceReset; // 0x20
	public static bool useLodDistanceMode; // 0x21
	private static SECTR_StreamingProfileRatioConfig _curStreamProfileRatioConfig; // 0x28
	public static SECTR_StreamingProfileRatioConfig DefaultStreamProfileRatioConfig; // 0x30
	private static SECTR_StreamingProfile _curStreamProfile; // 0x38
	private static uint _curStreamProfileHandle; // 0x40
	public static IObjectPoolCluster SECTRObjectPoolCluster; // 0x48
	private static string _lastStreamProfileName; // 0x50
	private static string _lastRefreshStreamProfileName; // 0x58
	public static SECTR_LODConfig _lodConfig; // 0x60
	private static uint _lodConfigHandle; // 0x68
	public static SECTR_LodFinMap _lodFinInfoMap; // 0x70
	private static uint _lodFinInfoMapHandle; // 0x78
	public static SECTR_HLodFinMap _hlodFinInfoMap; // 0x80
	private static uint _hlodFinInfoMapHandle; // 0x88
	public static SECTR_VoFinMap _voFinInfoMap; // 0x90
	private static uint _voFinInfoMapHandle; // 0x98
	public const string openWorldSplitConfigPath = "Data/LevelStreamingConfig/SplitterConfig/BigWorldConfig"; // Metadata: 0x00B1394F
	public const string dungeonSplitConfigPath = "Data/LevelStreamingConfig/SplitterConfig/DungeonConfig"; // Metadata: 0x00B1398A
	public const string homeSplitConfigPath = "Data/LevelStreamingConfig/SplitterConfig/HomeWorldConfig"; // Metadata: 0x00B139C4
	public static string curSplitConfigPath; // 0xA0
	private static SECTR_SceneSplitterConfig _streamSplitSettings; // 0xA8
	private static SECTR_SceneSplitterConfig EmptyStreamSplitSettings; // 0xB0
	private static uint _streamSplitSettingsHandle; // 0xB8
	public static bool LoadObjectOnInit; // 0xBC
	public static bool _runtimeMode; // 0xBD
	public static Vector3 MaxLoadSize; // 0xC0
	public static VirtualLODType[] groupTypes; // 0xD0
	public static VirtualLODType[] notSplitTypes; // 0xD8
	public static float fieldOfViewRad; // 0xE0
	public static int objCount; // 0xE4
	public static int layerHlodCount; // 0xE8
	public static int sectorHlodCount; // 0xEC
	public static int colliderCount; // 0xF0
	public static int lod9Count; // 0xF4
	public static int lod0Count; // 0xF8
	public static int lod1Count; // 0xFC
	public static int lod2pCount; // 0x100
	public static int cullingCount; // 0x104
	public static int guidCount; // 0x108
	public static bool bNeedSetForceLODIndexForMat; // 0x10C
	private static string _lastLodConfigName; // 0x110
	private static string _lastLodFinConfigName; // 0x118
	private static string _lastHLodFinConfigName; // 0x120
	private static string _lastVoFinConfigName; // 0x128
	private static List<ulong> cacheSectrErrorLog; // 0x130

	// Properties
	public static SECTR_StreamingProfileRatioConfig curProfileRatioConfig { /* [XID] */ /* 0x0000000189733850-0x0000000189733870 */ get; } // 0x0000000184AC1540-0x0000000184AC16B0 
	public static SECTR_StreamingProfile curProfile { /* [XID] */ /* 0x0000000189742950-0x0000000189742970 */ get; } // 0x0000000184AC1C90-0x0000000184AC1F10 
	public static SECTR_LODConfig lodConfig { /* [XID] */ /* 0x0000000189751790-0x00000001897517B0 */ get; } // 0x0000000184AC4730-0x0000000184AC4980 
	public static SECTR_LodFinMap lodFinInfoMap { /* [XID] */ /* 0x0000000189758CE0-0x0000000189758D00 */ get; } // 0x0000000184ABFAF0-0x0000000184ABFD40 
	public static SECTR_HLodFinMap hlodFinInfoMap { /* [XID] */ /* 0x00000001897609B0-0x00000001897609D0 */ get; } // 0x0000000184AC04D0-0x0000000184AC0730 
	public static SECTR_VoFinMap voFinInfoMap { /* [XID] */ /* 0x0000000189767C60-0x0000000189767C80 */ get; } // 0x0000000184AC0730-0x0000000184AC0990 
	public static SECTR_SceneSplitterConfig streamSplitSettings { /* [XID] */ /* 0x000000018976F260-0x000000018976F280 */ get; } // 0x0000000184AC4980-0x0000000184AC4B60 
	public static bool RuntimeMode { /* [XID] */ /* 0x00000001897A3E20-0x00000001897A3E40 */ get; /* [XID] */ /* 0x00000001897AB2F0-0x00000001897AB310 */ set; } // 0x0000000184AC4B60-0x0000000184AC4C30 0x0000000184AC1470-0x0000000184AC1540

	// Constructors
	static SECTR_Utils() {} // 0x0000000184AC4DF0-0x0000000184AC5270

	// Methods
	// [XID] // 0x0000000189724920-0x0000000189724940
	public static int GetHashCode(string name) => default; // 0x0000000184AC16B0-0x0000000184AC1760
	// [XID] // 0x000000018972C1E0-0x000000018972C200
	public static void InitObjectPool() {} // 0x0000000184AC4D20-0x0000000184AC4DF0
	// [XID] // 0x000000018973AFC0-0x000000018973AFE0
	public static void SetProfileRatioConfig(SECTR_StreamingProfileRatioConfig config) {} // 0x0000000184AC0BB0-0x0000000184AC0C80
	// [XID] // 0x000000018974A620-0x000000018974A640
	public static void SetStreamProfile(string name) {} // 0x0000000184ABF230-0x0000000184ABF7C0
	// [XID] // 0x0000000189776C60-0x0000000189776C80
	public static void ResetSpliterConfig(string path) {} // 0x0000000184AC2270-0x0000000184AC2610
	// [XID] // 0x000000018977E370-0x000000018977E390
	public static string GetSectorFilePath(string configName, string worldName, string objName) => default; // 0x0000000184ABFD40-0x0000000184ABFE40
	// [XID] // 0x0000000189785A80-0x0000000189785AA0
	public static string GetBinPath(string configName, string worldName, string objName) => default; // 0x0000000184AC1B90-0x0000000184AC1C90
	// [XID] // 0x000000018978D140-0x000000018978D160
	public static string GetHashPath(string configName, string worldName, string objName) => default; // 0x0000000184AC4580-0x0000000184AC4680
	// [XID] // 0x00000001897944F0-0x0000000189794510
	public static string GetVolumeFileFolder(string configName, string worldName) => default; // 0x0000000184ABFE40-0x0000000184ABFF30
	// [XID] // 0x000000018979C940-0x000000018979C960
	public static string GetClusterFileFolder(string configName, string worldName) => default; // 0x0000000184AC42F0-0x0000000184AC43E0
	// [XID] // 0x00000001897B31B0-0x00000001897B31D0
	public static void InitCamera(Camera renderCamera) {} // 0x0000000184ABE500-0x0000000184ABE670
	// [XID] // 0x00000001897BB090-0x00000001897BB0B0
	public static void OnPreFrameStart() {} // 0x0000000184AC4C30-0x0000000184AC4D20
	// [XID] // 0x00000001897C2850-0x00000001897C2870
	public static void InitLodConfig(string name = "LODConfig" /* Metadata: 0x00B13830 */) {} // 0x0000000184AC1960-0x0000000184AC1B90
	// [XID] // 0x00000001897CA050-0x00000001897CA070
	public static void InitLodInfoMap(string name = "LODFinInfoMap" /* Metadata: 0x00B1383D */) {} // 0x0000000184AC2E60-0x0000000184AC3090
	// [XID] // 0x00000001897D1750-0x00000001897D1770
	public static void InitHLodInfoMap(string name = "HLODFinInfoMap" /* Metadata: 0x00B1384E */) {} // 0x0000000184AC31D0-0x0000000184AC3410
	// [XID] // 0x00000001897D94F0-0x00000001897D9510
	public static void InitVoInfoMap(string name = "VOFinInfoMap" /* Metadata: 0x00B13860 */) {} // 0x0000000184AC1230-0x0000000184AC1470
	// [XID] // 0x00000001897E08D0-0x00000001897E08F0
	public static void InitRuntimeUtil() {} // 0x0000000184AC4480-0x0000000184AC4580
	// [XID] // 0x00000001897E7FD0-0x00000001897E7FF0
	public static void RefreshUtilConfig() {} // 0x0000000184ABE670-0x0000000184ABE960
	// [XID] // 0x00000001897EFB80-0x00000001897EFBA0
	private static string GetStreamProfileName() => default; // 0x0000000184AC2610-0x0000000184AC2BC0
	// [XID] // 0x00000001897F7400-0x00000001897F7420
	public static void InitUtilConfig() {} // 0x0000000184AC41E0-0x0000000184AC42F0
	// [XID] // 0x00000001897FEAC0-0x00000001897FEAE0
	public static void ReleaseUtil() {} // 0x0000000184ABEBC0-0x0000000184ABF230
	// [XID] // 0x0000000189806220-0x0000000189806240
	public static void LogPrefabIsNull(SECTR_GUID guid, bool force = false /* Metadata: 0x00B13870 */) {} // 0x0000000184AC0C80-0x0000000184AC0F00
	// [XID] // 0x000000018980D8D0-0x000000018980D8F0
	public static GameObject SECTR_CreateGameObject(SECTR_GUID guid, Transform parent) => default; // 0x0000000184AC1760-0x0000000184AC1960
	// [XID] // 0x0000000189814FC0-0x0000000189814FE0
	public static ByteArray SECTR_CreateByteArray(SECTR_GUID guid) => default; // 0x0000000184ABF8E0-0x0000000184ABFAF0
	// [XID] // 0x000000018981CAC0-0x000000018981CAE0
	public static AsyncJob SECTR_LoadGameObjectAsync(SECTR_GUID guid, int index, AssetJobPriority priority, IndexAssetReceiver<GameObject> onResult) => default; // 0x0000000184ABEA60-0x0000000184ABEBC0
	// [XID] // 0x0000000189823F50-0x0000000189823F70
	public static void SECTR_LoadByteArrayAsync(SECTR_GUID guid, int index, AssetJobPriority priority, IndexBinDataReceiver.IndexResultHandler onResult) {} // 0x0000000184AC1F10-0x0000000184AC2150
	// [XID] // 0x000000018982B990-0x000000018982B9B0
	public static void SECTR_UnloadGameObject(GameObject obj) {} // 0x0000000184ABE960-0x0000000184ABEA60
	// [XID] // 0x0000000189832F50-0x0000000189832F70
	public static string GetScenePostfix() => default; // 0x0000000184AC0F00-0x0000000184AC0FA0
	// [XID] // 0x000000018983A440-0x000000018983A460
	public static string GetChunkPostfix() => default; // 0x0000000184AC43E0-0x0000000184AC4480
	// [XID] // 0x0000000189841990-0x00000001898419B0
	public static Bounds TransBounds(Bounds boundBox, Transform transform) => default; // 0x0000000184AC00A0-0x0000000184AC04D0
	// [XID] // 0x0000000189848E30-0x0000000189848E50
	public static Vector3 TransVector(Vector3 vector, Transform transform) => default; // 0x0000000184AC0FA0-0x0000000184AC1230
	// [XID] // 0x0000000189850670-0x0000000189850690
	public static string GetTransformPath(Transform trans, Transform parent = null) => default; // 0x0000000184AC2BC0-0x0000000184AC2E60
	// [XID] // 0x0000000189857A20-0x0000000189857A40
	public static int SizeType2Size(SECTR_LayerSizeType type) => default; // 0x0000000184AC4680-0x0000000184AC4730
	// [XID] // 0x000000018985EB30-0x000000018985EB50
	public static ulong GenerateLayerUID(ulong layerType, ulong layerSize, ulong layerHeight, long width, long height, long longth) => default; // 0x0000000184AC3090-0x0000000184AC31D0
	// [XID] // 0x0000000189866270-0x0000000189866290
	public static Bounds GetBounds(GameObject gobj, bool isClassifyObject = true /* Metadata: 0x00B13871 */) => default; // 0x0000000184AC3410-0x0000000184AC41E0
	// [XID] // 0x000000018986DBE0-0x000000018986DC00
	public static Vector3 GetSectorVectorSize(float size, float height) => default; // 0x0000000184ABF7C0-0x0000000184ABF8E0
	// [XID] // 0x0000000189874ED0-0x0000000189874EF0
	public static void AddDebugCom(GameObject obj, SECTR_BaseObject bobj) {} // 0x0000000184ABFF30-0x0000000184AC00A0
	// [XID] // 0x000000018987CBA0-0x000000018987CBC0
	public static SECTR_BaseObject LoadGameObjectByStaticObj(int index, SECTR_StreamObject obj, Transform trans) => default; // 0x0000000184AC0990-0x0000000184AC0BB0
	// [XID] // 0x0000000189883B30-0x0000000189883B50
	public static void UnLoadGameObjectByStaticObj(SECTR_BaseObject obj) {} // 0x0000000184AC2150-0x0000000184AC2270
}

