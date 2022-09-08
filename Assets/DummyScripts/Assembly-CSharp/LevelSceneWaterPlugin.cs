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

public sealed class LevelSceneWaterPlugin : LevelScenePropPlugin // TypeDefIndex: 12119
{
	// Fields
	private const float MAX_CHECK_RANGE = 5f; // Metadata: 0x00AEB515
	private const int waterBoundLen = 1; // Metadata: 0x00AEB519
	private Vector3 waterBoundExtents; // 0xD0
	private Dictionary<long, WaterData> _waterId2ChangedStates; // 0xE0
	private LevelSceneIcePlugin _sceneIcePlugin; // 0xE8
	private uint waterFieldIdCount; // 0xF0
	private Dictionary<uint, WaterField> _fieldDict; // 0xF8
	private Dictionary<long, uint> _waterId2FieldId; // 0x100
	private List<uint> _connectWaterFieldIds; // 0x108

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189A196D0-0x0000000189A196F0 */ get => default; } // 0x00000001831C8A10-0x00000001831C8AB0 

	// Nested types
	public struct WaterData // TypeDefIndex: 12120
	{
		// Fields
		public SceneObjState state; // 0x00
		public Vector3 center; // 0x04
		public Vector3 size; // 0x10
		public Vector3 colliderCenter; // 0x1C
		public bool discontinuous; // 0x28
	}

	public class WaterField // TypeDefIndex: 12121
	{
		// Fields
		public uint fieldId; // 0x10
		public readonly Dictionary<long, bool> waterEntities; // 0x18
		private Dictionary<long, bool> boundaryEntities; // 0x20
		private Dictionary<int, float> durabilityDict; // 0x28

		// Constructors
		public WaterField() {} // Dummy constructor
		public WaterField(uint id) {} // 0x00000001831E6EA0-0x00000001831E6F50

		// Methods
		~WaterField() {} // 0x00000001831E6BE0-0x00000001831E6D00
		// [XID] // 0x0000000189B0FA30-0x0000000189B0FA50
		public float GetDurabilityByType(ElementType type) => default; // 0x00000001831E6D00-0x00000001831E6DD0
		// [XID] // 0x00000001896064B0-0x00000001896064D0
		public void SetDurabilityByType(ElementType type, float durability, bool isAdd) {} // 0x00000001831E6550-0x00000001831E66B0
		// [XID] // 0x00000001897D0030-0x00000001897D0050
		public bool IsConnectEntity(long objId) => default; // 0x00000001831E6DD0-0x00000001831E6EA0
		// [XID] // 0x0000000189B25D60-0x0000000189B25D80
		public void AddEntity(long objId, int x, int y) {} // 0x00000001831E6960-0x00000001831E6BE0
		// [XID] // 0x0000000189B2D090-0x0000000189B2D0B0
		public void RemoveEntity(long objId, int x, int y) {} // 0x00000001831E66B0-0x00000001831E6960
		// [IDTag] // 0x0000000189B34570-0x0000000189B345B0
		// [XID] // 0x0000000189B34570-0x0000000189B345B0
		private void UpdateBoundary(long id) {} // 0x00000001831E6150-0x00000001831E6240
		// [IDTag] // 0x0000000189B3F150-0x0000000189B3F190
		// [XID] // 0x0000000189B3F150-0x0000000189B3F190
		private void UpdateBoundary(long id, int x, int y) {} // 0x00000001831E6240-0x00000001831E6550
		// [XID] // 0x00000001896240E0-0x0000000189624100
		public void AddField(WaterField wf) {} // 0x00000001831E5A10-0x00000001831E6150
	}

	// Constructors
	public LevelSceneWaterPlugin() {} // 0x00000001831C88A0-0x00000001831C8A10

	// Methods
	// [XID] // 0x0000000189A20D50-0x0000000189A20D70
	public override void Init() {} // 0x00000001831C6E70-0x00000001831C6FF0
	// [XID] // 0x0000000189A28080-0x0000000189A280A0
	public override void Destroy() {} // 0x00000001831C5870-0x00000001831C5940
	// [XID] // 0x0000000189A2F7B0-0x0000000189A2F7D0
	protected override void InitCacheList() {} // 0x00000001831C5540-0x00000001831C5720
	// [XID] // 0x0000000189A371E0-0x0000000189A37200
	public override void Tick(float inDeltaTime) {} // 0x00000001831C87E0-0x00000001831C88A0
	// [XID] // 0x0000000189A3E870-0x0000000189A3E890
	public override void LateTick(float inDeltaTime) {} // 0x00000001831C8010-0x00000001831C8130
	// [XID] // 0x0000000189A45FA0-0x0000000189A45FC0
	public void TickBreakIce() {} // 0x00000001831C5E60-0x00000001831C60E0
	// [XID] // 0x0000000189A4D6D0-0x0000000189A4D6F0
	private void BreakIcesByPos(Vector3 pos) {} // 0x00000001831C60E0-0x00000001831C6290
	// [XID] // 0x0000000189A54F50-0x0000000189A54F70
	private void MeltIceByPos(long id) {} // 0x00000001831C4C00-0x00000001831C4F00
	// [XID] // 0x0000000189A5C860-0x0000000189A5C880
	public override bool HandleReaction(EvtElementReaction evtEleRct) => default; // 0x00000001831C8390-0x00000001831C84F0
	// [XID] // 0x0000000189A64150-0x0000000189A64170
	public override bool HandleReactionType(ElementReactionType elementReactionType, uint reactorID) => default; // 0x00000001831C70A0-0x00000001831C71F0
	// [XID] // 0x0000000189A6BB00-0x0000000189A6BB20
	public override void ScenePropElementReaction(long objId, SceneObjState type, bool syncFromServer = false /* Metadata: 0x00AEB510 */) {} // 0x00000001831C7280-0x00000001831C7510
	// [XID] // 0x0000000189A732A0-0x0000000189A732C0
	public override bool IsObjectUseless(long objId, ElementType type = ElementType.None /* Metadata: 0x00AEB511 */) => default; // 0x00000001831C5720-0x00000001831C57F0
	// [IDTag] // 0x0000000189A7AD70-0x0000000189A7ADB0
	// [XID] // 0x0000000189A7AD70-0x0000000189A7ADB0
	public void CheckWaterRange(Vector3 center, float radius, List<CollisionResult> results) {} // 0x00000001831C7F00-0x00000001831C8010
	// [IDTag] // 0x0000000189A853F0-0x0000000189A85430
	// [XID] // 0x0000000189A853F0-0x0000000189A85430
	public int CheckWaterRange(Vector3 center, float size, ScenePropBoundsInfo[] buffer, uint maxCount) => default; // 0x00000001831C7B90-0x00000001831C7F00
	// [XID] // 0x0000000189A8FDD0-0x0000000189A8FDF0
	public ScenePropEntity CreateWater(long waterId, ref int count) => default; // 0x00000001831C4F00-0x00000001831C4FF0
	// [XID] // 0x0000000189A973B0-0x0000000189A973D0
	public ScenePropEntity DoCreateWater(long waterId, ref int count, ScenePropCreateByType createdType) => default; // 0x00000001831C59F0-0x00000001831C5E60
	// [XID] // 0x0000000189A9E750-0x0000000189A9E770
	public override ScenePropEntity CreateMassiveEntityFromServer(ServerMassiveEntity massiveEntity) => default; // 0x00000001831C86F0-0x00000001831C87E0
	// [XID] // 0x0000000189AA6140-0x0000000189AA6160
	public void RemoveWaterNotify(ClientMassiveEntity massiveEntity) {} // 0x00000001831C8620-0x00000001831C86F0
	// [XID] // 0x0000000189AAD760-0x0000000189AAD780
	protected override void CheckEnterWeathers(GadgetEntity entity) {} // 0x00000001831C84F0-0x00000001831C85A0
	// [XID] // 0x0000000189AB4FE0-0x0000000189AB5000
	private GameObject CreateGO() => default; // 0x00000001831C54A0-0x00000001831C5540
	// [XID] // 0x0000000189ABCC60-0x0000000189ABCC80
	protected override void OnObjDestroy(long id) {} // 0x00000001831C4FF0-0x00000001831C52B0
	// [XID] // 0x0000000189AC45F0-0x0000000189AC4610
	protected override void OnPostDestroy(ScenePropEntity entity) {} // 0x00000001831C6FF0-0x00000001831C70A0
	// [XID] // 0x0000000189ACBC30-0x0000000189ACBC50
	protected override bool CanBeDestroy(long id, BaseEntity sceneEntity, Vector3 pos) => default; // 0x00000001831C6440-0x00000001831C66A0
	// [XID] // 0x0000000189AD3630-0x0000000189AD3650
	public static Vector3 id2pos(long id) => default; // 0x00000001831C5350-0x00000001831C54A0
	// [XID] // 0x0000000189636680-0x00000001896366A0
	public static long pos2id(Vector3 vec) => default; // 0x00000001831C8220-0x00000001831C8390
	// [XID] // 0x0000000189AE27A0-0x0000000189AE27C0
	private void ConnectField(uint id1, uint id2) {} // 0x00000001831C7860-0x00000001831C7B10
	// [XID] // 0x0000000189AEA2D0-0x0000000189AEA2F0
	private void UpdateWaterField(long objId, int x, int y) {} // 0x00000001831C66A0-0x00000001831C6BC0
	// [XID] // 0x0000000189AF1DF0-0x0000000189AF1E10
	private void DestroyWaterField(long objId, int x, int y) {} // 0x00000001831C7510-0x00000001831C76F0
	// [XID] // 0x0000000189AF97A0-0x0000000189AF97C0
	public float GetDurabilityByEntityId(long waterId, ElementType type) => default; // 0x00000001831C4AA0-0x00000001831C4C00
	// [XID] // 0x00000001897B8EC0-0x00000001897B8EE0
	public void SetDurabilityByEntityId(long waterId, ElementType type, float durability, bool isAdd) {} // 0x00000001831C6BC0-0x00000001831C6D90
	// [XID] // 0x0000000189B081D0-0x0000000189B081F0
	public void DestroyDurabilityByEntityId(long waterId, ElementType type) {} // 0x00000001831C6290-0x00000001831C63C0
}

