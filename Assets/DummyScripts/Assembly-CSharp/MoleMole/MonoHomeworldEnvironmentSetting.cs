/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
	public class MonoHomeworldEnvironmentSetting : MonoBehaviour // TypeDefIndex: 20387
	{
		// Fields
		public Transform roomRoot; // 0x18
		public Transform boundTransform; // 0x20
		public Transform wallRoot; // 0x28
		public GameObject ciel; // 0x30
		public GameObject floor; // 0x38
		public GameObject chandelier; // 0x40
		public GameObject[] doors; // 0x48
		public GameObject[] stairs; // 0x50
		public GameObject grid; // 0x58
		public GameObject wallGrid; // 0x60
		public GameObject boarder; // 0x68
		public GameObject deploySurface; // 0x70
		public Transform gridCenter; // 0x78
		private HashSet<int> showDoorSlots; // 0x80
		public Vector3 cameraBound; // 0x88
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public List<int> doorIndexs; // 0x98
		public FurnitureDeployType deployType; // 0xA0
		public int roomID; // 0xA4
		public HomeworldEditCameraSetting[] cameraSettings; // 0xA8
		public Bounds roomBound; // 0xB0
		public List<HomeworldInteriorCompSetting> wallSettings; // 0xC8
		public HomeworldInteriorCompSetting ceilSetting; // 0xD0
		public float deactiveAngle; // 0xD8
		public float cielActiveAngle; // 0xDC
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public List<FurnitureDataInternal> envFurnitureData; // 0xE0
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public List<FurnitureDataInternal> envNPCFurnitureData; // 0xE8
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public List<FurnitureDataInternal> envAnimalFurnitureData; // 0xF0
		protected HomeworldEditCameraSetting _curCamSetting; // 0xF8
		protected MeshRenderer[] _emptyRender; // 0x100
		protected List<GadgetEntity> _persistentEntites; // 0x108
		protected List<MeshRenderer[]> _persistentEntityRenders; // 0x110
		protected Dictionary<uint, HomeworldNPCInstanceInfo> _envNPCID2InoMap; // 0x118
		protected Dictionary<GadgetEntity, FurnitureDataInternal> _gadget2InternalDataMap; // 0x120
		[Space] // 0x00000001898E0F50-0x00000001898E0F60
		public bool forceShowEdit; // 0x128
		public uint editCameraIndex; // 0x12C
		public bool isUnlock; // 0x130
		// [Header] // 0x00000001897B6CE0-0x00000001897B6D10
		public bool refreshCamera; // 0x131
		public Vector3 overrideAnchorPos; // 0x134
		public Vector3 overrideCameraPos; // 0x140
		protected bool _wallDataDirty; // 0x14C
		protected GadgetEntity _wallEntity; // 0x150
		protected SECTR_VirtualPatternObj _wallSectrObj; // 0x158
		protected bool _cieldDirty; // 0x160
		public GadgetEntity cielGadget; // 0x168
		public HashSet<FurnitureSuiteDataInternal> furnitureSuiteSet; // 0x170
		protected bool _isDirty; // 0x178
		public int typeLimit; // 0x17C
		public int cost; // 0x180
		public int[] costArray; // 0x188
	
		// Properties
		public Transform MangetCenter { /* [XID] */ /* 0x00000001897C0440-0x00000001897C0460 */ get => default; } // 0x0000000184B782A0-0x0000000184B78390 
		public List<GadgetEntity> persistentEntites { /* [XID] */ /* 0x00000001897D6720-0x00000001897D6740 */ get => default; } // 0x0000000184B784F0-0x0000000184B785A0 
		public Dictionary<uint, HomeworldNPCInstanceInfo> envNPCID2InoMap { /* [XID] */ /* 0x00000001897DDEB0-0x00000001897DDED0 */ get => default; } // 0x0000000184B78390-0x0000000184B78440 
		public bool isDirty { /* [XID] */ /* 0x00000001898B5020-0x00000001898B5040 */ get => default; /* [XID] */ /* 0x00000001898BCAD0-0x00000001898BCAF0 */ set {} } // 0x0000000184B78440-0x0000000184B784F0 0x0000000184B785A0-0x0000000184B78650
	
		// Constructors
		public MonoHomeworldEnvironmentSetting() {} // 0x0000000184B78000-0x0000000184B782A0
	
		// Methods
		// [XID] // 0x00000001897C7CB0-0x00000001897C7CD0
		public void UpdateRoomDoorSlot(MonoHomeworldEnvironmentSetting[] envSettings) {} // 0x0000000184B77D40-0x0000000184B78000
		// [XID] // 0x00000001897CEF20-0x00000001897CEF40
		public bool ContainsDoor(int roomID) => default; // 0x0000000184B75260-0x0000000184B75330
		// [XID] // 0x00000001897E5960-0x00000001897E5980
		private void Awake() {} // 0x0000000184B74640-0x0000000184B74CF0
		// [XID] // 0x00000001897ED450-0x00000001897ED470
		public bool IsPositionInBound(Vector3 worldPosition) => default; // 0x0000000184B75DA0-0x0000000184B75F00
		// [XID] // 0x00000001897F4C10-0x00000001897F4C30
		public float DistanceSqrtToRoom(Vector3 worldPosition) => default; // 0x0000000184B75330-0x0000000184B754B0
		// [XID] // 0x00000001897FC680-0x00000001897FC6A0
		public void EnterEnvironmentSetting() {} // 0x0000000184B754B0-0x0000000184B75570
		// [XID] // 0x0000000189803C30-0x0000000189803C50
		public void ExitEnvironmentSetting(bool skipWallSetting = false /* Metadata: 0x00AFD83E */) {} // 0x0000000184B75570-0x0000000184B756E0
		// [XID] // 0x000000018980B0B0-0x000000018980B0D0
		public void SetGridActive(bool active, bool isWall) {} // 0x0000000184B76F00-0x0000000184B77090
		// [XID] // 0x0000000189812700-0x0000000189812720
		public void SetEnvironmentActive(bool active, bool isEdit) {} // 0x0000000184B769D0-0x0000000184B76F00
		// [XID] // 0x000000018981A3A0-0x000000018981A3C0
		private Vector3 LocalToWorld(Vector3 local) => default; // 0x0000000184B75F00-0x0000000184B76260
		// [XID] // 0x0000000189821A50-0x0000000189821A70
		public void AddNewNPC(uint excelID, uint runtimeID) {} // 0x0000000184B74440-0x0000000184B74640
		// [XID] // 0x0000000189829020-0x0000000189829040
		public HomeworldNPCInstanceInfo GetNPCInstanceInfo(uint excelID) => default; // 0x0000000184B757D0-0x0000000184B758C0
		// [XID] // 0x0000000189830550-0x0000000189830570
		public void RemoveNPC(uint excelID) {} // 0x0000000184B76900-0x0000000184B769D0
		// [XID] // 0x0000000189837BD0-0x0000000189837BF0
		public void SetPersistentEntityCount(int count) {} // 0x0000000184B772B0-0x0000000184B773E0
		// [XID] // 0x000000018983F350-0x000000018983F370
		public void SetPersistentEntity(PersistentFurnitureType furnitureType, GadgetEntity entity) {} // 0x0000000184B773E0-0x0000000184B776A0
		// [XID] // 0x00000001898469D0-0x00000001898469F0
		protected void OnNewPersistentEntityLoaded(BaseEntity entity) {} // 0x0000000184B76260-0x0000000184B76410
		// [XID] // 0x000000018984DFC0-0x000000018984DFE0
		public void UpdatePersistentMeshRender() {} // 0x0000000184B77B40-0x0000000184B77D40
		// [XID] // 0x0000000189855010-0x0000000189855030
		public int GetPersistentGadgetIndex(PersistentFurnitureType furnitureType) => default; // 0x0000000184B75AC0-0x0000000184B75B70
		// [XID] // 0x000000018985C770-0x000000018985C790
		public GadgetEntity GetPersistentEntity(PersistentFurnitureType furnitureType) => default; // 0x0000000184B759C0-0x0000000184B75AC0
		// [XID] // 0x00000001898640D0-0x00000001898640F0
		public MeshRenderer[] GetPersistentEntityRenderers(PersistentFurnitureType furnType) => default; // 0x0000000184B758C0-0x0000000184B759C0
		// [XID] // 0x000000018986B4C0-0x000000018986B4E0
		public void UpdateCollectRoomInfos() {} // 0x0000000184B776A0-0x0000000184B779E0
		// [XID] // 0x0000000189872830-0x0000000189872850
		public void CollectRoomWalls(Transform wallDataRoot) {} // 0x0000000184B74CF0-0x0000000184B75260
		// [XID] // 0x000000018987A4C0-0x000000018987A4E0
		public void AddFurnitureDataToRoom(FurnitureDataInternal furnData) {} // 0x0000000184B74280-0x0000000184B74440
		// [XID] // 0x00000001898815C0-0x00000001898815E0
		public void RemoveFurnitureDataFromRoom(FurnitureDataInternal furnData) {} // 0x0000000184B767A0-0x0000000184B76900
		// [XID] // 0x0000000189888B40-0x0000000189888B60
		public void UpdateEntityToWallComp(FurnitureDataInternal furnData) {} // 0x0000000184B779E0-0x0000000184B77B40
		// [XID] // 0x000000018988FF20-0x000000018988FF40
		private void RemoveEntityFromWallComp(FurnitureDataInternal furnData) {} // 0x0000000184B75B70-0x0000000184B75CD0
		// [XID] // 0x00000001898974A0-0x00000001898974C0
		public FurnitureDataInternal GetFunitureInternalDataByEntity(GadgetEntity entity) => default; // 0x0000000184B756E0-0x0000000184B757D0
		// [XID] // 0x000000018989E980-0x000000018989E9A0
		public bool IsBelongToEnv(GadgetEntity entity) => default; // 0x0000000184B75CD0-0x0000000184B75DA0
		// [XID] // 0x00000001898A6460-0x00000001898A6480
		public void RemoveAllFurniture() {} // 0x0000000184B76410-0x0000000184B767A0
		// [XID] // 0x00000001898ADB10-0x00000001898ADB30
		public void SetNPCAnimalFurnitureActive(bool active) {} // 0x0000000184B77090-0x0000000184B772B0
	}
}
