/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using MihoyoOptimization;
using miHoYoThread;
using MoleMole;
using UnityEngine;
using UnityEngine.Scripting;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SECTR_Manager : GlobalManager, IWorldShiftAgent // TypeDefIndex: 20274
{
	// Fields
	private Vector3 _viewDirection; // 0x10
	private Vector3 _lastViewDirection; // 0x1C
	private bool useViewDirection; // 0x28
	private const float UPDATE_LAYER_VIEW_THRESHOLD = 0.5f; // Metadata: 0x00AFD523
	public const int MAX_MAGNITUDE = 99999; // Metadata: 0x00AFD527
	private Dictionary<SECTR_GUID, GameObject> _objCache; // 0x30
	private Dictionary<int, CachedGameObjectGuidInfo> _cachedGameObjectGuidDict; // 0x38
	private Dictionary<int, CachedByteArrayGuidInfo> _cachedByteArrayGuidDict; // 0x40
	private IndexAssetReceiver<GameObject> _gameobjectResultHandler; // 0x48
	private IndexBinDataReceiver.IndexResultHandler _byteArrayResultHandler; // 0x50
	private List<SECTR_GUID> _objCacheKeys; // 0x58
	private bool _isSceneLoading; // 0x60
	private bool _isAsyncLoad; // 0x61
	private bool _initialized; // 0x62
	private FixedStack<bool> _isAsyncLoadStack; // 0x68
	private FixedStack<bool> _isSceneLoadingStack; // 0x70
	private int cachedGameObjectIndex; // 0x78
	private int cachedByteArrayIndex; // 0x7C
	public bool enableDebug; // 0x80
	public bool filterLOD; // 0x81
	public bool filterHLOD; // 0x82
	public bool filterVO; // 0x83
	public bool filterTerrain; // 0x84
	private Dictionary<SECTR_BaseObject, GameObject> _cacheDebugObjs; // 0x88
	private Dictionary<int, SECTR_TerrainLayerProxy> _terrainIndex2Layers; // 0x90
	private const int MAX_TERRAIN_COUNT = 1000; // Metadata: 0x00AFD52B
	public static int GROUP_COLLIDER_NUM; // 0x00
	public static int GROUP_LOD_NUM; // 0x04
	private SECTR_ThreadContext[] _groupColliderContexts; // 0x98
	private SECTR_ThreadContext[] _groupLodContexts; // 0xA0
	private SECTR_ThreadContext _workThreadContext; // 0xA8
	private SECTR_ThreadContext _mainThreadContext; // 0xB0
	private bool[] _needUpdateLODList; // 0xB8
	private bool[] _needUpdateColliderList; // 0xC0
	private Dictionary<SECTR_BaseLayerProxy, bool> _layerVisDict; // 0xC8
	private List<SECTR_BaseLayerProxy> _loadingLayers; // 0xD0
	private Dictionary<string, SECTR_World> _worldDict; // 0xD8
	private List<int> _requestCachePosIDs; // 0xE0
	private List<Vector3> _requestCachePosVecs; // 0xE8
	private List<int> _requestRemoveCachePosID; // 0xF0
	private string _curWorldName; // 0xF8
	private const string DefaultWorldName = "Default_World"; // Metadata: 0x00AFD52F
	private SliceFrameWatch _initLoadWatcher; // 0x100
	private List<bool> _stopStreamSectorList; // 0x108
	private bool _loadingViewObjs; // 0x110
	private bool _stopStreamSector; // 0x111
	public static Vector3 InvalidPos; // 0x08
	public List<ISECTR_BaseGroup> activitingGroups; // 0x118
	public List<ISECTR_LayerLoader> activitingLoaders; // 0x120
	public List<ISECTR_LayerLoader> loadingLayerLoaders; // 0x128
	public List<SECTR_BaseLayerProxy> loadedLayers; // 0x130
	private List<string> _world2Destroy; // 0x138
	private Dictionary<ulong, int> _reloadCount; // 0x140
	private const int MAX_RELOAD_COUNT = 3; // Metadata: 0x00AFD540
	private Coroutine _loadStreamWorldCoroutine; // 0x148
	public const string PreloadConfigPath = "Data/LevelStreamingConfig/PreloadConfig/StreamPreloadConfig"; // Metadata: 0x00AFD544
	private List<string> _preloadWorldPaths; // 0x150
	private List<string> _preloadWorldNames; // 0x158
	private HashSet<string> _preloadedWorld; // 0x160
	private List<uint> _preloadWorldHandles; // 0x168
	private List<GameObject> _preloadWorldGameObjects; // 0x170
	public bool isPreloading; // 0x178
	public static Dictionary<int, int> runtime2Shift; // 0x18
	public static Dictionary<int, uint> runtime2Mask; // 0x20
	public static bool bUseComputeThread; // 0x28
	public static bool bJobType; // 0x29
	public static int ONE_TIME_TICK_COUNT; // 0x2C
	public static float ONE_TIME_LIMIT_TIME; // 0x30
	private static float LAYER_UPDATE_THRESHOLD; // 0x34
	private static float LOD_UPDATE_THRESHOLD; // 0x38
	private Vector3 _curAvatarPos; // 0x17C
	private Vector3 _lastSectorPos; // 0x188
	private Vector3 _lastLodPos; // 0x194
	private SliceFrameWatch _swLoaderInterval; // 0x1A0
	private SectrStreamColliderData[] _groupColliderDatas; // 0x1A8
	private SectrStreamLodData[] _groupLodDatas; // 0x1B0
	private SectrStreamSplitTask _sectrSplitJob; // 0x1B8
	private SectrStreamFlushTask _sectrFlushJob; // 0x1C0
	private AllocGuidTask _allocGUIDTask; // 0x1C8
	private IGroup[] _taskGroups; // 0x1D0
	private IWRRHandle _wrrSectrUnityThreadWork; // 0x1D8
	private SliceFrameWatch _amortizeWatch; // 0x1E0
	public static bool forceForbidStreaming; // 0x3C
	private bool _overrideMainStreamPoint; // 0x1E9
	private Vector3 _overridePointPosition; // 0x1EC
	private List<ISECTR_BaseVolume> _deactiveVolumeList; // 0x1F8
	private List<ISECTR_BaseVolume> _activeVolumeList; // 0x200
	private List<ISECTR_BaseVolume> _tryToRemoveLayerVolumeList; // 0x208
	private List<ISECTR_BaseVolume> _doActiveVolumeList; // 0x210
	private List<ISECTR_BaseVolume> _doDectiveVolumeList; // 0x218
	private Dictionary<uint, ISECTR_BaseVolume> _serverVolumeDict; // 0x220
	public GameObject _debugRoot; // 0x228

	// Properties
	public bool[] NeedUpdateLODList { /* [XID] */ /* 0x000000018988FFA0-0x000000018988FFC0 */ get => default; } // 0x00000001819959C0-0x0000000181995A70 
	public bool[] NeedUpdateColliderList { /* [XID] */ /* 0x0000000189897500-0x0000000189897520 */ get => default; } // 0x000000018198E0A0-0x000000018198E150 
	public SECTR_World defaultWorld { /* [XID] */ /* 0x000000018989E9E0-0x000000018989EA00 */ get => default; } // 0x000000018199F420-0x000000018199F510 
	public bool bHandlingRequest { /* [XID] */ /* 0x0000000189ACB0A0-0x0000000189ACB0E0 */ get; /* [XID] */ /* 0x0000000189AD5F40-0x0000000189AD5F80 */ private set; } // 0x000000018198F150-0x000000018198F1B0 0x000000018199AA50-0x000000018199AAC0
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public List<ISECTR_BaseVolume> deactiveVolumeList { /* [XID] */ /* 0x0000000189BB0BB0-0x0000000189BB0BD0 */ get => default; } // 0x000000018199D780-0x000000018199D830 
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	public List<ISECTR_BaseVolume> activeVolumeList { /* [XID] */ /* 0x0000000189BB7E20-0x0000000189BB7E40 */ get => default; } // 0x000000018198C730-0x000000018198C7E0 

	// Nested types
	[RecycleType] // 0x00000001898422C0-0x00000001898422E0
	public class CachedByteArrayGuidInfo : BaseCachedGuidInfo, IAutoAllocRecycle // TypeDefIndex: 20275
	{
		// Fields
		public LoadByteArrayCallBack cb; // 0x18

		// Constructors
		public CachedByteArrayGuidInfo() {} // 0x0000000181FCF610-0x0000000181FCF6B0

		// Methods
		[BlackList] // 0x000000018967A650-0x000000018967A690
		// [XID] // 0x000000018967A650-0x000000018967A690
		public virtual void AutoAllocTypeFields() {} // 0x0000000181FCF230-0x0000000181FCF2D0
		[BlackList] // 0x0000000189684E40-0x0000000189684E80
		// [XID] // 0x0000000189684E40-0x0000000189684E80
		public virtual void AutoRecycleTypeFields() {} // 0x0000000181FCF2D0-0x0000000181FCF370
		[BlackList] // 0x000000018968FC60-0x000000018968FCA0
		// [XID] // 0x000000018968FC60-0x000000018968FCA0
		public virtual void ReturnToObjectPool() {} // 0x0000000181FCF570-0x0000000181FCF610
		// [XID] // 0x000000018969A210-0x000000018969A230
		public override void OnPoolAllocated() {} // 0x0000000181FCF470-0x0000000181FCF510
		// [XID] // 0x00000001896A1A80-0x00000001896A1AA0
		public override void OnBeforePoolRecycled() {} // 0x0000000181FCF3D0-0x0000000181FCF470
	}

	[RecycleType] // 0x00000001898422C0-0x00000001898422E0
	public class CachedGameObjectGuidInfo : BaseCachedGuidInfo, IAutoAllocRecycle // TypeDefIndex: 20276
	{
		// Fields
		public Transform parent; // 0x18
		public LoadGameObjectCallBack cb; // 0x20

		// Constructors
		public CachedGameObjectGuidInfo() {} // 0x0000000181FD0350-0x0000000181FD03F0

		// Methods
		[BlackList] // 0x00000001896AFFF0-0x00000001896B0030
		// [XID] // 0x00000001896AFFF0-0x00000001896B0030
		public virtual void AutoAllocTypeFields() {} // 0x0000000181FCFF70-0x0000000181FD0010
		[BlackList] // 0x00000001896BA610-0x00000001896BA650
		// [XID] // 0x00000001896BA610-0x00000001896BA650
		public virtual void AutoRecycleTypeFields() {} // 0x0000000181FD0010-0x0000000181FD00B0
		[BlackList] // 0x00000001896C4A80-0x00000001896C4AC0
		// [XID] // 0x00000001896C4A80-0x00000001896C4AC0
		public virtual void ReturnToObjectPool() {} // 0x0000000181FD02B0-0x0000000181FD0350
		// [XID] // 0x00000001896CF340-0x00000001896CF360
		public override void OnPoolAllocated() {} // 0x0000000181FD01B0-0x0000000181FD0250
		// [XID] // 0x00000001896D65C0-0x00000001896D65E0
		public override void OnBeforePoolRecycled() {} // 0x0000000181FD0110-0x0000000181FD01B0
	}

	public enum AsyncLoadStackType // TypeDefIndex: 20277
	{
		Default = 0,
		Cache = 1,
		Unload = 2,
		Init = 3,
		Iter = 4,
		Editor = 5,
		Count = 6
	}

	public class BaseCachedGuidInfo // TypeDefIndex: 20278
	{
		// Fields
		public SECTR_GUID guid; // 0x10

		// Constructors
		public BaseCachedGuidInfo() {} // 0x0000000181FCE890-0x0000000181FCE8F0

		// Methods
		// [XID] // 0x00000001896DDC80-0x00000001896DDCA0
		public virtual void OnPoolAllocated() {} // 0x0000000181FCE7F0-0x0000000181FCE890
		// [XID] // 0x00000001896E52D0-0x00000001896E52F0
		public virtual void OnBeforePoolRecycled() {} // 0x0000000181FCE750-0x0000000181FCE7F0
	}

	public delegate void LoadGameObjectCallBack(SECTR_GUID guid, GameObject obj); // TypeDefIndex: 20279; 0x0000000181FD04F0-0x0000000181FD07A0

	public delegate void LoadByteArrayCallBack(SECTR_GUID guid, ByteArray obj); // TypeDefIndex: 20280; 0x0000000181FCF880-0x0000000181FCFB30

	public enum TreeType // TypeDefIndex: 20281
	{
		Normal = 0,
		City = 1,
		Collider = 2,
		Fog = 3,
		Navmesh = 4,
		Grass = 5,
		Water = 6
	}

	public enum ProgressType // TypeDefIndex: 20282
	{
		Loading = 0,
		Finish = 1
	}

	public enum LODPriority // TypeDefIndex: 20283
	{
		Sector = 0,
		Layer = 1,
		NearObject = 2,
		MiddleObject = 3,
		FarObject = 4,
		Count = 5
	}

	public enum StopStreamType // TypeDefIndex: 20284
	{
		Cutscene = 0,
		Enviro = 1,
		Clock = 2,
		Count = 3
	}

	public enum RuntimeIDType // TypeDefIndex: 20285
	{
		Sector = 0,
		Group = 1,
		Layer = 2
	}

	public enum SectorTaskType // TypeDefIndex: 20286
	{
		COLLIDER = 0,
		SECTR_LOD = 1,
		LAYER_LOD = 2,
		OBJ_LOD = 3,
		COUNT = 4
	}

	// Constructors
	public SECTR_Manager() {} // 0x00000001819A0060-0x00000001819A0840
	static SECTR_Manager() {} // 0x000000018199FE20-0x00000001819A0060

	// Methods
	// [XID] // 0x000000018970A580-0x000000018970A5A0
	public string GetSectorNameByPosition(Vector3 inPos) => default; // 0x0000000181992FD0-0x0000000181993340
	// [XID] // 0x0000000189712050-0x0000000189712070
	private void SetViewDirection(Vector3 dir) {} // 0x0000000181991780-0x0000000181991870
	// [XID] // 0x00000001897195F0-0x0000000189719610
	public Vector3 GetSharedViewDirection() => default; // 0x000000018199D830-0x000000018199D910
	// [XID] // 0x0000000189720BB0-0x0000000189720BD0
	public Bounds AdaptiveFilter(Bounds bounds, Vector3 pos) => default; // 0x000000018198E730-0x000000018198E900
	// [XID] // 0x0000000189728210-0x0000000189728230
	private float ComputeAdaptiveScale(Vector3 pos) => default; // 0x000000018198F620-0x000000018198F810
	// [XID] // 0x000000018972F910-0x000000018972F930
	private bool UpdateLayerByView() => default; // 0x000000018198C5B0-0x000000018198C730
	// [XID] // 0x0000000189737340-0x0000000189737360
	public bool IsInitialized() => default; // 0x000000018198DD90-0x000000018198DE30
	// [XID] // 0x000000018973EE40-0x000000018973EE60
	public int GetCacheObjCount() => default; // 0x00000001819907A0-0x0000000181990860
	// [XID] // 0x0000000189746080-0x00000001897460A0
	public override void Init() {} // 0x0000000181998D20-0x0000000181998F50
	// [XID] // 0x000000018974DB50-0x000000018974DB70
	public override void Destroy() {} // 0x0000000181990E90-0x0000000181990F50
	// [XID] // 0x00000001897551E0-0x0000000189755200
	public void InitGlobal() {} // 0x000000018199A7B0-0x000000018199A870
	// [XID] // 0x000000018975C3B0-0x000000018975C3D0
	public void InitInLevel() {} // 0x0000000181994E60-0x0000000181995050
	// [XID] // 0x0000000189763D80-0x0000000189763DA0
	public void InitAfterRootLoad(Camera camera) {} // 0x000000018199E850-0x000000018199E930
	// [XID] // 0x000000018976B540-0x000000018976B560
	public void ResetConfig() {} // 0x000000018199F360-0x000000018199F420
	// [XID] // 0x0000000189772B80-0x0000000189772BA0
	public override void ClearOnLevelDestroy() {} // 0x000000018198FC30-0x000000018198FDA0
	// [XID] // 0x000000018977A2A0-0x000000018977A2C0
	public override void ClearOnBackHome(bool forceClear = true /* Metadata: 0x00AFD51A */) {} // 0x000000018198FB80-0x000000018198FC30
	// [XID] // 0x0000000189781E80-0x0000000189781EA0
	private void ClearCacheObjs() {} // 0x000000018198E270-0x000000018198E560
	// [XID] // 0x0000000189789260-0x0000000189789280
	private void ClearLoadingLists() {} // 0x000000018199AD40-0x000000018199AE50
	// [XID] // 0x0000000189790870-0x0000000189790890
	private void DestroyPool() {} // 0x000000018198E640-0x000000018198E730
	// [XID] // 0x00000001897981C0-0x00000001897981E0
	public void GameSceneLoadBegin(bool isAsyncLoad, AsyncLoadStackType stackType) {} // 0x000000018198ECE0-0x000000018198EE50
	// [XID] // 0x00000001897A0030-0x00000001897A0050
	public void GameSceneLoadEnd(AsyncLoadStackType stackType) {} // 0x0000000181999210-0x0000000181999340
	// [XID] // 0x00000001897A75A0-0x00000001897A75C0
	public void EnterGameSceneLoad() {} // 0x0000000181997050-0x0000000181997100
	// [XID] // 0x00000001897AF050-0x00000001897AF070
	public void FinishGameSceneLoad() {} // 0x000000018199D910-0x000000018199DA10
	// [XID] // 0x00000001897B6D10-0x00000001897B6D30
	public bool IsSceneLoading() => default; // 0x000000018198EFC0-0x000000018198F060
	// [XID] // 0x00000001897BED30-0x00000001897BED50
	public bool IsAsyncLoad() => default; // 0x0000000181994970-0x0000000181994A10
	// [XID] // 0x00000001897C6290-0x00000001897C62B0
	public bool IsSceneLoadValid() => default; // 0x000000018199A500-0x000000018199A5C0
	// [XID] // 0x00000001897CDAC0-0x00000001897CDAE0
	public bool HasCachedGUIDGameObject(SECTR_GUID inGUID, out GameObject cachedGameObject) {
		cachedGameObject = default;
		return default;
	} // 0x0000000181991C50-0x0000000181991D40
	// [XID] // 0x00000001897D5010-0x00000001897D5030
	private void GameObjectRequestHandler(int index, ulong pathHash, bool loadSucceeded, uint handle, GameObject prefab) {} // 0x0000000181996090-0x00000001819964A0
	// [XID] // 0x00000001897DC7D0-0x00000001897DC7F0
	public void CreateGameObjectAsyncUnityThread(SECTR_GUID cacheKey, Transform parent, LoadGameObjectCallBack lgoCallBack, AssetJobPriority priority) {} // 0x000000018198C190-0x000000018198C5B0
	// [XID] // 0x00000001897E41B0-0x00000001897E41D0
	private void ByteArrayRequestHandler(int index, ulong pathHash, bool loadSucceeded, byte[] packedBinary) {} // 0x000000018198D720-0x000000018198D980
	// [XID] // 0x00000001897EBCA0-0x00000001897EBCC0
	public void CreateByteArrayAsyncUnityThread(SECTR_GUID cacheKey, LoadByteArrayCallBack lbyteCallBack, AssetJobPriority priority) {} // 0x000000018198DE30-0x000000018198E0A0
	// [XID] // 0x00000001897F3630-0x00000001897F3650
	private void UnLoadGameObjectImediately(GameObject obj, SECTR_GUID guid) {} // 0x000000018199BDD0-0x000000018199BEA0
	// [XID] // 0x00000001897FAFF0-0x00000001897FB010
	public void CacheGameObject(SECTR_GUID key, GameObject obj) {} // 0x00000001819997B0-0x0000000181999990
	// [XID] // 0x0000000189802470-0x0000000189802490
	public GameObject GetCacheGameObject(SECTR_GUID key) => default; // 0x00000001819947B0-0x00000001819948A0
	// [XID] // 0x0000000189809900-0x0000000189809920
	public void UnLoadGameObject(SECTR_GUID guid) {} // 0x0000000181997100-0x0000000181997230
	// [XID] // 0x0000000189811070-0x0000000189811090
	public SECTR_GUID Allocate_GUID(ulong path, ISECTR_Base b) => default; // 0x000000018199CF40-0x000000018199D0D0
	// [XID] // 0x0000000189818BD0-0x0000000189818BF0
	public void Recycle_GUID(SECTR_GUID guid) {} // 0x000000018198BF70-0x000000018198C040
	// [IDTag] // 0x00000001898203F0-0x0000000189820430
	// [XID] // 0x00000001898203F0-0x0000000189820430
	public bool RefreshFinInfo(List<SECTR_LODFinInfo> infos) => default; // 0x000000018199C2C0-0x000000018199C4F0
	// [XID] // 0x000000018982A8D0-0x000000018982A8F0
	public bool RefreshLODPattern(List<SECTR_LODPattern> infos) => default; // 0x00000001819975A0-0x00000001819977E0
	// [IDTag] // 0x0000000189831D20-0x0000000189831D60
	// [XID] // 0x0000000189831D20-0x0000000189831D60
	public bool RefreshFinInfo(List<SECTR_HLODFinInfo> infos) => default; // 0x000000018199C4F0-0x000000018199C710
	[Preserve] // 0x000000018983C470-0x000000018983C4B0
	// [XID] // 0x000000018983C470-0x000000018983C4B0
	public override string Dump(string tag) => default; // 0x0000000181990F50-0x00000001819916C0
	// [XID] // 0x0000000189846A30-0x0000000189846A50
	private string DumpLayersInfo() => default; // 0x00000001819904B0-0x00000001819906C0
	// [XID] // 0x000000018984E020-0x000000018984E040
	public void ReportCurrentInfo(string tag = "" /* Metadata: 0x00AFD51B */) {} // 0x00000001819988D0-0x00000001819989F0
	// [XID] // 0x0000000189855070-0x0000000189855090
	private Color GetColorByLod(int lod, bool isHLOD = false /* Metadata: 0x00AFD51F */) => default; // 0x0000000181997C10-0x0000000181997DD0
	// [XID] // 0x000000018985C7D0-0x000000018985C7F0
	public GameObject FilterGameObject(SECTR_BaseObject lodObj, GameObject obj) => default; // 0x0000000181999DF0-0x000000018199A500
	// [XID] // 0x0000000189864130-0x0000000189864150
	public bool CreateQuateTree(TreeType type, SECTR_BaseLayerProxy layer, ref int treeLevel) => default; // 0x000000018198C7E0-0x000000018198C8E0
	// [XID] // 0x000000018986B4E0-0x000000018986B500
	public SECTR_LayerConfig Layer2Config(string layerName) => default; // 0x000000018199D330-0x000000018199D400
	// [XID] // 0x0000000189872890-0x00000001898728B0
	public void RemoveQuateTree(SECTR_BaseLayerProxy layer) {} // 0x00000001819948A0-0x0000000181994970
	// [XID] // 0x000000018987A520-0x000000018987A540
	public void InitTerrain(int indexWidth, int indexHeight, SECTR_TerrainLayerProxy layer) {} // 0x0000000181994B00-0x0000000181994E60
	// [XID] // 0x0000000189881640-0x0000000189881660
	public void RemoveTerrain(int indexWidth, int indexHeight, SECTR_TerrainLayerProxy layer) {} // 0x000000018199CB60-0x000000018199CC60
	// [XID] // 0x0000000189888BC0-0x0000000189888BE0
	public void ClearTerrainIndex() {} // 0x000000018198EC20-0x000000018198ECE0
	// [XID] // 0x00000001898A6480-0x00000001898A64A0
	public SECTR_World GetCurWorld() => default; // 0x0000000181992010-0x0000000181992100
	// [XID] // 0x00000001898ADB70-0x00000001898ADB90
	public SECTR_ThreadContext GetMainThreadContext() => default; // 0x000000018198D3A0-0x000000018198D450
	// [XID] // 0x00000001898B5080-0x00000001898B50A0
	private void InitSECTRLoader() {} // 0x000000018198D450-0x000000018198D720
	// [XID] // 0x00000001898BCB70-0x00000001898BCB90
	private LODPriority GetLODPriorityByDistance(float dis) => default; // 0x0000000181993670-0x0000000181993720
	// [IDTag] // 0x00000001898C42A0-0x00000001898C42E0
	// [XID] // 0x00000001898C42A0-0x00000001898C42E0
	public SECTR_LinkedListNode<ISECTR_LODLoader> RegisterLODLoader(float distance, ISECTR_LODLoader loader) => default; // 0x00000001819954C0-0x00000001819955A0
	// [XID] // 0x00000001898CE830-0x00000001898CE850
	private uint GetLodLoaderIndex(LODPriority priority, ISECTR_LODLoader loader) => default; // 0x000000018199F930-0x000000018199FAE0
	// [IDTag] // 0x00000001898D6240-0x00000001898D6280
	// [XID] // 0x00000001898D6240-0x00000001898D6280
	public SECTR_LinkedListNode<ISECTR_LODLoader> RegisterLODLoader(LODPriority priority, ISECTR_LODLoader loader) => default; // 0x0000000181995150-0x00000001819954C0
	// [XID] // 0x00000001898E0F30-0x00000001898E0F50
	public void UnregisterLODLoader(LODPriority priority, SECTR_LinkedListNode<ISECTR_LODLoader> loader) {} // 0x0000000181998470-0x00000001819988D0
	// [XID] // 0x00000001898E89E0-0x00000001898E8A00
	private void ResetLODLoadEndNode() {} // 0x000000018198CF20-0x000000018198D3A0
	// [XID] // 0x00000001898F0100-0x00000001898F0120
	public void RefreshAllLODPattern() {} // 0x0000000181996EA0-0x0000000181997050
	// [XID] // 0x00000001898F7AB0-0x00000001898F7AD0
	private uint GetColliderLoaderIndex(ISECTR_ColliderLoader loader) => default; // 0x0000000181995050-0x0000000181995150
	// [XID] // 0x00000001898FF0F0-0x00000001898FF110
	public SECTR_LinkedListNode<ISECTR_ColliderLoader> RegisterColliderLoader(ISECTR_ColliderLoader loader) => default; // 0x0000000181997230-0x00000001819975A0
	// [XID] // 0x0000000189906870-0x0000000189906890
	public void UnregisterColliderLoader(SECTR_LinkedListNode<ISECTR_ColliderLoader> loader) {} // 0x000000018198F940-0x000000018198FB80
	// [XID] // 0x000000018990E3D0-0x000000018990E3F0
	public void RegisterLayerLoader(ISECTR_LayerLoader inLayerLoader) {} // 0x000000018199B160-0x000000018199B230
	// [XID] // 0x0000000189915AE0-0x0000000189915B00
	public void UnRegisterLayerLoader(ISECTR_LayerLoader inLayerLoader) {} // 0x000000018199D260-0x000000018199D330
	// [XID] // 0x000000018991D4B0-0x000000018991D4D0
	public void RegisterLoadingLayerLoader(ISECTR_LayerLoader inLayerLoader) {} // 0x000000018199B630-0x000000018199B720
	// [XID] // 0x0000000189924D80-0x0000000189924DA0
	public void UnregisterLoadingLayerLoader(ISECTR_LayerLoader inLayerLoader) {} // 0x000000018199E620-0x000000018199E6F0
	// [XID] // 0x000000018992C2E0-0x000000018992C300
	public void RegisterAcitveLayerLoader(ISECTR_LayerLoader inLayerLoader) {} // 0x0000000181994A10-0x0000000181994B00
	// [XID] // 0x0000000189933780-0x00000001899337A0
	public void UnregisterAcitveLayerLoader(ISECTR_LayerLoader inLayerLoader) {} // 0x0000000181995FC0-0x0000000181996090
	// [XID] // 0x000000018993B3F0-0x000000018993B410
	public void RegisterAcitveLayerGroup(ISECTR_BaseGroup inGroup) {} // 0x00000001819945C0-0x00000001819946B0
	// [XID] // 0x0000000189942530-0x0000000189942550
	public void UnregisterAcitveLayerGroup(ISECTR_BaseGroup inGroup) {} // 0x000000018199BEA0-0x000000018199BF70
	// [XID] // 0x0000000189949E60-0x0000000189949E80
	public void StopStreamSector(StopStreamType type, bool enable) {} // 0x0000000181999030-0x0000000181999210
	// [XID] // 0x00000001899519C0-0x00000001899519E0
	public void CheckMemoryBudget() {} // 0x000000018199BCE0-0x000000018199BDD0
	// [XID] // 0x0000000189958ED0-0x0000000189958EF0
	public void ResetLoadRatio() {} // 0x000000018199E6F0-0x000000018199E850
	// [IDTag] // 0x0000000189960660-0x00000001899606A0
	// [XID] // 0x0000000189960660-0x00000001899606A0
	public bool NeedReload() => default; // 0x000000018199B3E0-0x000000018199B4B0
	[DebuggerHidden] // 0x000000018996AD40-0x000000018996AD80
	// [XID] // 0x000000018996AD40-0x000000018996AD80
	public IEnumerator InitIter(Vector3 position, Action<ProgressType, float> finalProgress = null) => default; // 0x000000018198E150-0x000000018198E270
	// [XID] // 0x00000001899756F0-0x0000000189975710
	public void AddLayer(SECTR_BaseLayerProxy layer) {} // 0x0000000181998F50-0x0000000181999030
	// [XID] // 0x000000018997C850-0x000000018997C870
	public void RemoveLayer(SECTR_BaseLayerProxy layer) {} // 0x0000000181992100-0x0000000181992250
	// [XID] // 0x00000001899845F0-0x0000000189984610
	private void ClearLoadedLayers() {} // 0x000000018198EE50-0x000000018198EFC0
	// [XID] // 0x000000018998C030-0x000000018998C050
	public void CreateDefaultWorld() {} // 0x00000001819967A0-0x0000000181996930
	// [XID] // 0x0000000189993D50-0x0000000189993D70
	public void ClearDefaultWorld() {} // 0x000000018199B310-0x000000018199B3E0
	// [XID] // 0x000000018999B5A0-0x000000018999B5C0
	public bool HasMultiLoadPoint(SECTR_ThreadContext context) => default; // 0x00000001819906C0-0x00000001819907A0
	// [XID] // 0x00000001899A2CF0-0x00000001899A2D10
	private float WeightDistance(Vector3 pos, Vector3 center, Vector3 weight) => default; // 0x000000018198D980-0x000000018198DB20
	// [XID] // 0x00000001899AA7A0-0x00000001899AA7C0
	public float DistanceToViewPoint(Vector3 pos, Vector3 center, Vector3 weight, SECTR_ThreadContext context) => default; // 0x0000000181994010-0x0000000181994280
	// [XID] // 0x00000001899B2120-0x00000001899B2140
	public void LoadCachePos(int id, Vector3 pos) {} // 0x000000018199C170-0x000000018199C2C0
	// [XID] // 0x00000001899B9540-0x00000001899B9560
	private void RemoveCachePos(int id) {} // 0x0000000181999630-0x00000001819997B0
	// [XID] // 0x00000001899C0F50-0x00000001899C0F70
	private void HandleForceCacheRequest() {} // 0x000000018198F1B0-0x000000018198F620
	// [XID] // 0x00000001899C8550-0x00000001899C8570
	public void TryRemoveCachePos(int id) {} // 0x000000018199BBF0-0x000000018199BCE0
	// [XID] // 0x00000001899CFF70-0x00000001899CFF90
	public void RefreshLayers() {} // 0x000000018199E050-0x000000018199E1D0
	// [XID] // 0x00000001899D7450-0x00000001899D7470
	private void LoadSectorByPos(Vector3 position, bool forceLod = false /* Metadata: 0x00AFD520 */) {} // 0x0000000181991870-0x0000000181991A70
	// [XID] // 0x00000001899DE830-0x00000001899DE850
	public void ForceUpdateAll(Vector3 curPos, Action<int> func = null) {} // 0x000000018198E900-0x000000018198EC20
	// [XID] // 0x00000001899E6530-0x00000001899E6550
	public bool IsStreamWorld() => default; // 0x00000001819964A0-0x0000000181996570
	// [XID] // 0x00000001899EDA80-0x00000001899EDAA0
	public void InitRoot(SECTR_StreamerRoot root) {} // 0x00000001819980A0-0x0000000181998390
	// [XID] // 0x00000001899F5490-0x00000001899F54B0
	public void InitWorld(string name) {} // 0x0000000181999CB0-0x0000000181999DF0
	// [XID] // 0x00000001899FCAF0-0x00000001899FCB10
	public void AddSectorProxy(string name, SECTR_SectorProxy sectorProxy) {} // 0x000000018199D400-0x000000018199D570
	// [XID] // 0x0000000189A03FA0-0x0000000189A03FC0
	public void RefreshBinIndx(string worldName) {} // 0x000000018199CC60-0x000000018199CDD0
	// [XID] // 0x0000000189A0B630-0x0000000189A0B650
	public void LoadOneSector(string worldName, string sectorName) {} // 0x0000000181992250-0x0000000181992860
	// [XID] // 0x0000000189A12E30-0x0000000189A12E50
	public SECTR_SectorProxy LoadSectorByPath(string worldName, string binPath, Transform trans, int groupId) => default; // 0x000000018199EC20-0x000000018199F360
	// [XID] // 0x0000000189A1A210-0x0000000189A1A230
	public bool HasStreamRoot() => default; // 0x000000018199F720-0x000000018199F810
	// [XID] // 0x0000000189A21730-0x0000000189A21750
	public void SetCurWorld(SECTR_StreamerRoot root) {} // 0x00000001819989F0-0x0000000181998B70
	// [XID] // 0x0000000189A28CF0-0x0000000189A28D10
	public void DestroyWorld(string name) {} // 0x0000000181998B70-0x0000000181998D20
	// [XID] // 0x0000000189A30350-0x0000000189A30370
	public void ClearWorld(string name) {} // 0x000000018199D0D0-0x000000018199D260
	// [XID] // 0x0000000189A37D90-0x0000000189A37DB0
	public void ClearAllSectors(string name) {} // 0x0000000181999990-0x0000000181999AD0
	// [XID] // 0x0000000189A3F4C0-0x0000000189A3F4E0
	public void ReleaseAllSectors(string name) {} // 0x000000018199D570-0x000000018199D6B0
	// [XID] // 0x0000000189A46AF0-0x0000000189A46B10
	public void DestroyAllWorlds() {} // 0x00000001819902D0-0x00000001819904B0
	// [XID] // 0x0000000189A4E2F0-0x0000000189A4E310
	public void RemoveStreamRoot(string worldName) {} // 0x000000018199D6B0-0x000000018199D780
	// [XID] // 0x0000000189A55B60-0x0000000189A55B80
	private void ClearWorlds() {} // 0x000000018198C8E0-0x000000018198CA40
	// [IDTag] // 0x0000000189A5D380-0x0000000189A5D3C0
	// [XID] // 0x0000000189A5D380-0x0000000189A5D3C0
	public bool NeedReload(SECTR_GUID guid) => default; // 0x000000018199B4B0-0x000000018199B630
	// [XID] // 0x0000000189A68030-0x0000000189A68050
	public void LoadStreamWorld(Vector3 worldPos, Action<ProgressType, float> finalProgress = null) {} // 0x000000018198C040-0x000000018198C190
	// [XID] // 0x0000000189A6F460-0x0000000189A6F480
	private void ClearLocalTrans() {} // 0x00000001819946B0-0x00000001819947B0
	// [XID] // 0x0000000189A76C60-0x0000000189A76C80
	public void ResetRoot() {} // 0x000000018198F810-0x000000018198F940
	// [XID] // 0x0000000189A7E600-0x0000000189A7E620
	public override void ReloadRes() {} // 0x000000018199FAE0-0x000000018199FB80
	[DebuggerHidden] // 0x0000000189A85F10-0x0000000189A85F50
	// [XID] // 0x0000000189A85F10-0x0000000189A85F50
	public IEnumerator PreloadConfig() => default; // 0x000000018199AAC0-0x000000018199AB90
	[DebuggerHidden] // 0x0000000189A909F0-0x0000000189A90A30
	// [XID] // 0x0000000189A909F0-0x0000000189A90A30
	public IEnumerator PreloadBigworlds(Action<float> progressCB = null) => default; // 0x0000000181998390-0x0000000181998470
	[DebuggerHidden] // 0x0000000189A9B120-0x0000000189A9B160
	// [XID] // 0x0000000189A9B120-0x0000000189A9B160
	public IEnumerator PreloadBigworld(string worldName, string prefabPath, Action<float> progressCB = null) => default; // 0x000000018199DF30-0x000000018199E050
	// [XID] // 0x0000000189AA5520-0x0000000189AA5540
	private void DestroyPreload() {} // 0x0000000181995750-0x00000001819959C0
	// [XID] // 0x0000000189AACD40-0x0000000189AACD60
	public bool HasPreload(string worldName) => default; // 0x000000018198DB20-0x000000018198DBF0
	// [XID] // 0x0000000189AB4630-0x0000000189AB4650
	public uint GetRuntimeTypeID(int nameHash, RuntimeIDType type) => default; // 0x000000018199BF70-0x000000018199C170
	// [XID] // 0x0000000189ABC360-0x0000000189ABC380
	public uint GenRuntimeID(uint fatherID, string name, RuntimeIDType type) => default; // 0x000000018198DBF0-0x000000018198DCF0
	// [XID] // 0x0000000189AC3C20-0x0000000189AC3C40
	public bool IsInProxy(uint runtimeID, uint idType, RuntimeIDType type) => default; // 0x000000018199AC10-0x000000018199AD40
	// [XID] // 0x0000000189AE09E0-0x0000000189AE0A00
	public SECTR_LinkedListNode<ISECTR_ColliderLoader> UpdateColliderByGroup(Vector3 avatarPos, SECTR_LinkedListNode<ISECTR_ColliderLoader> curColliderNode, SECTR_LinkedListNode<ISECTR_ColliderLoader> lastColliderNode, SECTR_ThreadContext context, Stopwatch stopWatch) => default; // 0x000000018199E1D0-0x000000018199E620
	// [XID] // 0x0000000189AE7E70-0x0000000189AE7E90
	public void FlushColliderGroup(int index, SECTR_LinkedListNode<ISECTR_ColliderLoader> curColliderNode) {} // 0x0000000181994280-0x00000001819945C0
	// [XID] // 0x0000000189AEFBE0-0x0000000189AEFC00
	public SECTR_LinkedListNode<ISECTR_LODLoader> UpdateLodByGroup(Vector3 avatarPos, SECTR_LinkedListNode<ISECTR_LODLoader> curLODLinkNode, SECTR_LinkedListNode<ISECTR_LODLoader> lastLODLinkNode, SECTR_ThreadContext context, Stopwatch stopWatch) => default; // 0x000000018199C710-0x000000018199CB60
	// [XID] // 0x0000000189AF7160-0x0000000189AF7180
	public void FlushLodGroup(int index, SECTR_LinkedListNode<ISECTR_LODLoader> curLODLinkNode) {} // 0x0000000181992A20-0x0000000181992D60
	// [XID] // 0x0000000189AFE790-0x0000000189AFE7B0
	public void UpdateLayerLoaders(SECTR_ThreadContext context) {} // 0x0000000181993340-0x0000000181993670
	// [XID] // 0x0000000189B05FE0-0x0000000189B06000
	public void UpdateLayerByPos(Vector3 position, bool forceLoad, SECTR_ThreadContext context, bool bFromUnityThread) {} // 0x000000018198CA40-0x000000018198CF20
	// [XID] // 0x0000000189B0D710-0x0000000189B0D730
	public void UpdateLayerLoadersByJob(SECTR_ThreadContext context) {} // 0x00000001819955A0-0x0000000181995750
	// [XID] // 0x0000000189B14BF0-0x0000000189B14C10
	public bool UpdateActivatingObjectsUnityThread(SliceFrameWatch inSW) => default; // 0x0000000181990860-0x0000000181990A10
	// [XID] // 0x0000000189B1C4F0-0x0000000189B1C510
	public void OverrideMainStreamPointOneFrame(Vector3 pos) {} // 0x000000018199B230-0x000000018199B310
	// [XID] // 0x0000000189B23B00-0x0000000189B23B20
	private void UpdateStreamMainPoint() {} // 0x00000001819977E0-0x0000000181997C10
	// [XID] // 0x0000000189B2AE00-0x0000000189B2AE20
	public void SetLastUpdatePos(Vector3 pos) {} // 0x000000018198F060-0x000000018198F150
	// [XID] // 0x0000000189B32340-0x0000000189B32360
	public bool NeedLoadScene(Vector3 pos) => default; // 0x0000000181992860-0x0000000181992A20
	// [XID] // 0x0000000189B39CB0-0x0000000189B39CD0
	public Vector3 LastLodPos() => default; // 0x000000018198E560-0x000000018198E640
	// [XID] // 0x0000000189B41530-0x0000000189B41550
	public static bool IsInRealComputeThreadMode(bool bFromUnityThread) => default; // 0x000000018199F670-0x000000018199F720
	// [XID] // 0x0000000189B48F40-0x0000000189B48F60
	public static bool ShouldUseAsyncRequest(bool bFromUnityThread) => default; // 0x0000000181996570-0x0000000181996610
	// [XID] // 0x0000000189B50540-0x0000000189B50560
	private bool ContainsCachePos(int id) => default; // 0x000000018199E930-0x000000018199EB70
	// [XID] // 0x0000000189B57E10-0x0000000189B57E30
	private bool SetCachePos(int id, Vector3 pos) => default; // 0x0000000181997DD0-0x00000001819980A0
	// [XID] // 0x0000000189B5F7D0-0x0000000189B5F7F0
	private bool HasCachePos() => default; // 0x00000001819916C0-0x0000000181991780
	private IGroup AddGroup<GroupNodeType>(SectorTaskType taskType)
		where GroupNodeType : IGroupNode, new() => default;
	// [XID] // 0x0000000189B66E80-0x0000000189B66EA0
	private void CreateComputeThreadTask() {} // 0x0000000181993720-0x0000000181993E50
	// [XID] // 0x0000000189B6E1E0-0x0000000189B6E200
	private void SetCurWorldToThread(SECTR_World world) {} // 0x0000000181999AD0-0x0000000181999CB0
	// [XID] // 0x0000000189B75A10-0x0000000189B75A30
	private void InitThread() {} // 0x000000018198FFF0-0x00000001819902D0
	// [XID] // 0x0000000189B7CE50-0x0000000189B7CE70
	private void DestroyComputeThreadTask() {} // 0x0000000181996930-0x0000000181996EA0
	// [XID] // 0x0000000189B84D50-0x0000000189B84D70
	private void DestroyThread() {} // 0x0000000181991D40-0x0000000181992010
	// [XID] // 0x0000000189B8BB00-0x0000000189B8BB20
	public Vector3 GetSharedPosition() => default; // 0x0000000181991B70-0x0000000181991C50
	// [XID] // 0x0000000189B93350-0x0000000189B93370
	public bool ShouldTick() => default; // 0x0000000181995ED0-0x0000000181995FC0
	// [XID] // 0x0000000189B9A880-0x0000000189B9A8A0
	public void ProcessAmortizedJobsUnityThread() {} // 0x000000018199B860-0x000000018199BBF0
	// [XID] // 0x0000000189BA2010-0x0000000189BA2030
	public void HandleAllRequestBeforeDestroy() {} // 0x000000018199F810-0x000000018199F8D0
	// [XID] // 0x0000000189BA93E0-0x0000000189BA9400
	private void ForceHandleAllRequest() {} // 0x000000018199AE50-0x000000018199B160
	// [IDTag] // 0x0000000189BBF530-0x0000000189BBF570
	// [XID] // 0x0000000189BBF530-0x0000000189BBF570
	public void AddServerLimitRegion(uint id, Vector3 pos, float radius) {} // 0x0000000181995A70-0x0000000181995C50
	// [IDTag] // 0x0000000189BCA6B0-0x0000000189BCA6F0
	// [XID] // 0x0000000189BCA6B0-0x0000000189BCA6F0
	public void AddServerLimitRegion(uint id, Vector3 pos, Vector3 size) {} // 0x0000000181995C50-0x0000000181995E50
	// [XID] // 0x0000000189BD4A50-0x0000000189BD4A70
	public void RemoveServerLimitRegion(uint id) {} // 0x000000018199EB70-0x000000018199EC20
	// [XID] // 0x0000000189BDC540-0x0000000189BDC560
	private void ClearAllServerRegions() {} // 0x000000018199A5C0-0x000000018199A7B0
	// [XID] // 0x00000001895E8E10-0x00000001895E8E30
	public void AddVolume(ISECTR_BaseVolume volume, bool deactive = true /* Metadata: 0x00AFD521 */) {} // 0x0000000181991A70-0x0000000181991B70
	// [XID] // 0x00000001895F0660-0x00000001895F0680
	public void RemoveVolume(ISECTR_BaseVolume volume) {} // 0x000000018199F510-0x000000018199F670
	// [XID] // 0x00000001895F80B0-0x00000001895F80D0
	private void ClearVolumeLists() {} // 0x000000018199B720-0x000000018199B860
	// [XID] // 0x00000001895FF4D0-0x00000001895FF4F0
	private bool IsInVolume(ISECTR_BaseVolume volume, Vector3 pos) => default; // 0x000000018199DA10-0x000000018199DB90
	// [XID] // 0x0000000189606D60-0x0000000189606D80
	public bool VolumeFilterLod(ISECTR_LODLoader lod, SECTR_BaseVolume.LODType type) => default; // 0x0000000181993E50-0x0000000181994010
	// [XID] // 0x000000018960E680-0x000000018960E6A0
	private bool VolumeFilterLayer(SECTR_BaseLayerProxy layer) => default; // 0x0000000181996610-0x00000001819967A0
	// [XID] // 0x0000000189615D40-0x0000000189615D60
	private bool VolumeRemoveLayer(SECTR_BaseLayerProxy layer) => default; // 0x000000018199CDD0-0x000000018199CF40
	// [XID] // 0x000000018961D550-0x000000018961D570
	private void UpdateRemoveLoadedLayers() {} // 0x000000018198DCF0-0x000000018198DD90
	// [XID] // 0x0000000189624A50-0x0000000189624A70
	private void DrawCurSizeTile(Vector3 pos, int tileSize) {} // 0x000000018199DB90-0x000000018199DF30
	// [XID] // 0x000000018962C1B0-0x000000018962C1D0
	private Vector3 GetVolumeFixedPos(Vector3 pos) => default; // 0x000000018198FDA0-0x000000018198FFF0
	// [XID] // 0x0000000189633D10-0x0000000189633D30
	private void UpdateVolumesInUnityThread() {} // 0x000000018199A870-0x000000018199AA50
	// [XID] // 0x000000018963B510-0x000000018963B530
	private void CheckVolumeByPos(Vector3 pos, bool isUnityThread = false /* Metadata: 0x00AFD522 */) {} // 0x0000000181990A10-0x0000000181990E90
	// [XID] // 0x0000000189642D60-0x0000000189642D80
	private void DebugShift(Vector3 newShift, Vector3 oldShift) {} // 0x0000000181999340-0x0000000181999630
	// [XID] // 0x000000018964A3B0-0x000000018964A3D0
	public bool ShiftWorld(Vector3 offset, Vector3 oldOffset) => default; // 0x000000018199FB80-0x000000018199FE20
	// [XID] // 0x0000000189651B00-0x0000000189651B20
	private void WorldShiftOnLevelDestroy() {} // 0x0000000181992D60-0x0000000181992FD0
}

