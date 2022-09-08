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

public sealed class StageManager : InLevelManager // TypeDefIndex: 21008
{
	// Fields
	public const uint DEFAULT_STAGE = 1; // Metadata: 0x00AFEC8B
	private List<StageInfo> _stages; // 0x10
	private uint _skyboxMaterialHandle; // 0x18
	private GameObject _environment; // 0x20
	private uint _environmentPrefabHandle; // 0x28
	private GameObject _sssProfiles; // 0x30
	private uint _sssProfilesPrefabHandle; // 0x38
	private List<uint> _lightmapHandles; // 0x40
	private const string WATERMESH_PATH = "Build/LevelStreaming/SectorMesh/"; // Metadata: 0x00AFEC8F
	public string reflectMeshPath; // 0x48
	private GameObject reflectMeshObj; // 0x50
	private uint reflectWaterHandle; // 0x58
	private bool isLoading; // 0x5C
	private int sectorWidth; // 0x60
	private int sectorHeight; // 0x64
	public const uint DEFAULT_ROOM = 0; // Metadata: 0x00AFECB3
	public const uint DEFAULT_LOBBY = 1; // Metadata: 0x00AFECB7
	private List<LCLoadingDoor> _loadingDoorList; // 0x68
	public Action<uint, uint> onDoorOpenAction; // 0x70
	private uint _curRoom; // 0x78
	private List<uint> _activeRoomList; // 0x80
	private uint _avatarEntityID; // 0x88

	// Properties
	public GameObject environment { /* [XID] */ /* 0x000000018963FBB0-0x000000018963FBD0 */ get => default; } // 0x0000000182162F50-0x0000000182162FF0 
	public uint curRoom { /* [XID] */ /* 0x0000000189636600-0x0000000189636620 */ get => default; } // 0x0000000182163100-0x00000001821631A0 
	public List<uint> activeRoomList { /* [XID] */ /* 0x00000001896C62B0-0x00000001896C62D0 */ get => default; } // 0x0000000182163050-0x0000000182163100 

	// Nested types
	public class StageInfo // TypeDefIndex: 21009
	{
		// Fields
		public uint id; // 0x10
		public uint stagePrefabHandle; // 0x14
		public GameObject stage; // 0x18
		public uint lightProbeHandle; // 0x20
		public LightProbes lightProbes; // 0x28
		public string navmeshPath; // 0x30
		public List<GameObject> navmeshes; // 0x38
		public List<uint> navmeshPrefabHandles; // 0x40
		public Bounds bounds; // 0x48
		public List<int> refCount; // 0x60

		// Constructors
		public StageInfo() {} // 0x0000000182169BA0-0x0000000182169C00
	}

	// Constructors
	private StageManager() {} // 0x0000000182165770-0x0000000182165870

	// Methods
	// [XID] // 0x0000000189647390-0x00000001896473B0
	public override void Init() {} // 0x00000001821637D0-0x0000000182163870
	// [XID] // 0x000000018964EAC0-0x000000018964EAE0
	public override void Tick() {} // 0x00000001821656D0-0x0000000182165770
	// [XID] // 0x00000001896563B0-0x00000001896563D0
	public override void Destroy() {} // 0x0000000182162450-0x0000000182162C40
	// [XID] // 0x000000018965DB10-0x000000018965DB30
	public void CreateStage(SceneScriptData levelCreateData, string overloadedDefaultWeatherProfile = null) {} // 0x0000000182161E50-0x00000001821623A0
	// [XID] // 0x0000000189665160-0x0000000189665180
	private void InitSceneGraphicsSetting(SceneScriptData levelCreateData) {} // 0x00000001821654D0-0x00000001821656D0
	// [XID] // 0x000000018966C880-0x000000018966C8A0
	public void PostInitStage(SceneScriptData levelCreateData) {} // 0x00000001821623A0-0x0000000182162450
	// [XID] // 0x00000001896746B0-0x00000001896746D0
	public void CreateStagePrefab(string prefabPath, string navmeshPath, uint id = 1 /* Metadata: 0x00AFEC83 */) {} // 0x0000000182163560-0x00000001821637D0
	// [XID] // 0x000000018967BFE0-0x000000018967C000
	public void SetEnvironment(string environmentPath) {} // 0x0000000182164010-0x00000001821642C0
	// [XID] // 0x0000000189683590-0x00000001896835B0
	private void LoadSSSProfiles(string sssProfilesPath) {} // 0x00000001821631A0-0x0000000182163410
	// [XID] // 0x000000018968B1D0-0x000000018968B1F0
	public void SetSkyboxMaterial(string materialPath) {} // 0x0000000182163DA0-0x0000000182163E90
	// [XID] // 0x0000000189692ED0-0x0000000189692EF0
	public void InitNavmesh() {} // 0x0000000182161310-0x0000000182161440
	// [XID] // 0x000000018969A130-0x000000018969A150
	public void LoadNavmesh() {} // 0x00000001821618F0-0x0000000182161E50
	// [XID] // 0x00000001896A1980-0x00000001896A19A0
	public void ResetNavmesh(int mainIndex) {} // 0x0000000182161440-0x0000000182161600
	// [XID] // 0x00000001896A8E60-0x00000001896A8E80
	public GameObject GetStage() => default; // 0x0000000182163AB0-0x0000000182163BA0
	// [XID] // 0x00000001896AFF10-0x00000001896AFF30
	public void LoadWaterMesh(Vector3 pos, Action<GameObject> callback = null, int lod = 0 /* Metadata: 0x00AFEC87 */) {} // 0x0000000182160CF0-0x0000000182161140
	// [XID] // 0x00000001896B7840-0x00000001896B7860
	public void UnloadWaterMesh() {} // 0x0000000182163410-0x0000000182163560
	// [XID] // 0x00000001896CD8B0-0x00000001896CD8D0
	public void ResetRoom() {} // 0x00000001821643D0-0x0000000182164490
	// [XID] // 0x00000001896D4D60-0x00000001896D4D80
	public void InitRoom() {} // 0x0000000182164490-0x0000000182164630
	// [XID] // 0x0000000189848A80-0x0000000189848AA0
	private int GetRoomIndex(uint id) => default; // 0x0000000182163870-0x00000001821639A0
	// [XID] // 0x00000001896E3BD0-0x00000001896E3BF0
	private void CreateLoadingDoors() {} // 0x0000000182164F90-0x00000001821654D0
	// [XID] // 0x00000001896EAF80-0x00000001896EAFA0
	private void LoadAllRooms() {} // 0x0000000182164730-0x0000000182164A40
	// [IDTag] // 0x00000001896F2390-0x00000001896F23D0
	// [XID] // 0x00000001896F2390-0x00000001896F23D0
	public void EnterRoom(Vector3 pos) {} // 0x0000000182164E00-0x0000000182164F90
	// [IDTag] // 0x00000001896FCF50-0x00000001896FCF90
	// [XID] // 0x00000001896FCF50-0x00000001896FCF90
	public void EnterRoom(uint id) {} // 0x0000000182164C80-0x0000000182164E00
	// [XID] // 0x00000001897074E0-0x0000000189707500
	public void ShowRoom(uint id, int visitor) {} // 0x0000000182162C40-0x0000000182162F50
	// [XID] // 0x000000018970EDA0-0x000000018970EDC0
	public void HideRoom(uint id, int visitor) {} // 0x0000000182161600-0x00000001821618F0
	// [IDTag] // 0x00000001897161C0-0x0000000189716200
	// [XID] // 0x00000001897161C0-0x0000000189716200
	private bool IsInRoom(Vector3 pos, StageInfo stageInfo) => default; // 0x0000000182164A40-0x0000000182164B40
	// [IDTag] // 0x0000000189720AB0-0x0000000189720AF0
	// [XID] // 0x0000000189720AB0-0x0000000189720AF0
	public bool IsInRoom(Vector3 pos, uint id) => default; // 0x0000000182164B40-0x0000000182164C80
	// [XID] // 0x0000000189857600-0x0000000189857620
	public bool IsRoomVisiable(uint id) => default; // 0x0000000182164630-0x0000000182164730
	// [XID] // 0x0000000189BD6ED0-0x0000000189BD6EF0
	public uint GetRoomID(Vector3 pos) => default; // 0x0000000182163E90-0x0000000182164010
	// [XID] // 0x00000001898503A0-0x00000001898503C0
	public bool GetRoomBounds(uint id, ref Bounds bounds) => default; // 0x00000001821642C0-0x00000001821643D0
	// [XID] // 0x00000001897419A0-0x00000001897419C0
	public static Bounds GetBounds(GameObject go) => default; // 0x0000000182163BA0-0x0000000182163DA0
	// [XID] // 0x00000001897492C0-0x00000001897492E0
	public static Vector3 GetLocalAvatarStandingPos() => default; // 0x0000000182161140-0x0000000182161310
	// [XID] // 0x0000000189A10AE0-0x0000000189A10B00
	public void OnDoorOpen(uint doorId) {} // 0x00000001821639A0-0x0000000182163AB0
}

