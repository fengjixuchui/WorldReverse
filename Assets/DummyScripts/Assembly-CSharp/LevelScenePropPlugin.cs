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

public class LevelScenePropPlugin : BaseComponentPlugin // TypeDefIndex: 12110
{
	// Fields
	protected const int INVALID_RANGE = 500; // Metadata: 0x00AEB4F8
	protected Dictionary<long, ScenePropEntity> _objEntities; // 0x58
	protected Dictionary<uint, long> _entityId2ObjectId; // 0x60
	protected HashSet<long> _needToBeDestroyObject; // 0x68
	protected Dictionary<long, ulong> _objId2CheckTime; // 0x70
	protected List<long> _objIdList; // 0x78
	protected GameObject _sceneObjectHelperRoot; // 0x80
	protected ObjectPoolWithConfigID<ScenePropEntity> _scenePropEntityPool; // 0x88
	protected Dictionary<long, SceneObjState> _objId2States; // 0x90
	private SliceFrameWatch _destroySW; // 0x98
	public Action<EvtElementReaction> onScenePropElementReaction; // 0xA0
	public Action<long> destroyObjectCallback; // 0xA8
	protected static Action<EvtEntityReadyPost> _onEntityReadyPostCallback; // 0x00
	private const float MAX_DESTROY_INTERVAL = 1f; // Metadata: 0x00AEB4FC
	private const ulong CHECK_INTERVAL = 5000; // Metadata: 0x00AEB500
	private int iterIndex; // 0xB0
	private List<ClientMassiveEntity> _syncToServerEntityCreatedList; // 0xB8
	private List<ClientMassiveEntity> _syncToServerEntityRemovedList; // 0xC0
	private List<MassiveEntityState> _syncToServerEntityStateList; // 0xC8

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189699770-0x0000000189699790 */ get => default; } // 0x00000001829FB320-0x00000001829FB3C0 
	public Dictionary<long, ScenePropEntity> objEntities { /* [XID] */ /* 0x00000001896A0BE0-0x00000001896A0C00 */ get => default; } // 0x00000001829FA1A0-0x00000001829FA240 

	// Constructors
	public LevelScenePropPlugin() {} // 0x00000001829FB090-0x00000001829FB320
	static LevelScenePropPlugin() {} // 0x00000001829FAFC0-0x00000001829FB090

	// Methods
	// [XID] // 0x00000001896A8190-0x00000001896A81B0
	protected static void OnEntityReadyPostCallback(EvtEntityReadyPost evt) {} // 0x00000001829F8320-0x00000001829F8420
	// [XID] // 0x00000001896AF520-0x00000001896AF540
	public override void Init() {} // 0x00000001829F9350-0x00000001829F94E0
	// [XID] // 0x00000001896B6BC0-0x00000001896B6BE0
	public virtual bool HandleReaction(EvtElementReaction evtEleRct) => default; // 0x00000001829FA530-0x00000001829FA600
	// [XID] // 0x00000001896BDDE0-0x00000001896BDE00
	public virtual bool HandleReactionType(ElementReactionType elementReactionType, uint reactorID) => default; // 0x00000001829F95A0-0x00000001829F9670
	// [XID] // 0x00000001896C56F0-0x00000001896C5710
	public virtual bool HandleReactionHandler(ElementReactionSourceType reactionSourceType, ElementType sourceElementType, uint sourceElementCasterID, ElementType reactorElementType, ElementReactionType elementReactionType, uint reactorID) => default; // 0x00000001829F8F00-0x00000001829F9090
	// [XID] // 0x00000001896CCD20-0x00000001896CCD40
	protected virtual void InitCacheList() {} // 0x00000001829F73F0-0x00000001829F7490
	// [XID] // 0x00000001896D3F80-0x00000001896D3FA0
	public override void Tick(float deltaTime) {} // 0x00000001829FAEF0-0x00000001829FAFC0
	// [XID] // 0x00000001896DB8E0-0x00000001896DB900
	public SceneObjState GetObjectState(long id) => default; // 0x00000001829FAA00-0x00000001829FAB00
	// [XID] // 0x00000001896E3080-0x00000001896E30A0
	public override void Destroy() {} // 0x00000001829F7B60-0x00000001829F7EA0
	// [XID] // 0x00000001896EA640-0x00000001896EA660
	private void ReleaseScenePropPreloaded(ScenePropEntity entity) {} // 0x00000001829F7FF0-0x00000001829F8110
	// [XID] // 0x00000001896F1630-0x00000001896F1650
	public virtual void ScenePropElementReaction(long objId, SceneObjState type, bool syncFromServer = false /* Metadata: 0x00AEB4F2 */) {} // 0x00000001829F9670-0x00000001829F9820
	// [XID] // 0x00000001896F9000-0x00000001896F9020
	public virtual bool IsObjectUseless(long objId, ElementType type = ElementType.None /* Metadata: 0x00AEB4F3 */) => default; // 0x00000001829F77A0-0x00000001829F7870
	// [XID] // 0x0000000189700A10-0x0000000189700A30
	private float XZDistacneSqr(Vector3 pos1, Vector3 pos2) => default; // 0x00000001829F8420-0x00000001829F8550
	// [XID] // 0x0000000189708080-0x00000001897080A0
	public void CheckObjRange(Vector3 center, float radius, List<CollisionResult> results) {} // 0x00000001829F9D80-0x00000001829FA1A0
	// [XID] // 0x000000018970FB30-0x000000018970FB50
	public ScenePropCreateByType GetCreatedType() => default; // 0x00000001829F7A50-0x00000001829F7B60
	// [XID] // 0x0000000189716CF0-0x0000000189716D10
	public virtual ScenePropEntity CreateMassiveEntityFromServer(ServerMassiveEntity massiveEntity) => default; // 0x00000001829FAE40-0x00000001829FAEF0
	// [XID] // 0x000000018971E740-0x000000018971E760
	public void CreateMassiveEntityNotify(ServerMassiveEntity massiveEntity) {} // 0x00000001829F9090-0x00000001829F9350
	// [XID] // 0x0000000189725EE0-0x0000000189725F00
	protected void CreateObject(long objId, ScenePropEntity objEntity, bool isCreatedByClient = true /* Metadata: 0x00AEB4F7 */) {} // 0x00000001829F70A0-0x00000001829F7340
	// [XID] // 0x0000000189835BD0-0x0000000189835BF0
	protected virtual void CheckEnterWeathers(GadgetEntity entity) {} // 0x00000001829FA900-0x00000001829FAA00
	// [XID] // 0x0000000189734B10-0x0000000189734B30
	protected void DestroyObject(long objId) {} // 0x00000001829F7490-0x00000001829F77A0
	// [XID] // 0x000000018973C700-0x000000018973C720
	protected virtual void OnObjDestroy(long id) {} // 0x00000001829F7340-0x00000001829F73F0
	// [XID] // 0x0000000189743C20-0x0000000189743C40
	protected virtual void OnPostDestroy(ScenePropEntity entity) {} // 0x00000001829F94E0-0x00000001829F95A0
	// [XID] // 0x000000018974B770-0x000000018974B790
	private void CheckExitWeathers(GadgetEntity obj) {} // 0x00000001829F8550-0x00000001829F8650
	// [XID] // 0x0000000189752BB0-0x0000000189752BD0
	public SceneObjState GetSceneObjState(long id) => default; // 0x00000001829F7950-0x00000001829F7A50
	// [XID] // 0x0000000189759F20-0x0000000189759F40
	protected void TickDestroy() {} // 0x00000001829FA600-0x00000001829FA900
	// [XID] // 0x0000000189761CA0-0x0000000189761CC0
	protected virtual bool CanBeDestroy(long id, BaseEntity sceneEntity, Vector3 pos) => default; // 0x00000001829F8110-0x00000001829F8320
	// [XID] // 0x0000000189768FB0-0x0000000189768FD0
	protected void CheckRemoveObj(long id, Vector3 pos) {} // 0x00000001829FAB00-0x00000001829FAE40
	// [XID] // 0x0000000189770750-0x0000000189770770
	protected ScenePropEntity AllocateScenePropFromPool(ref bool isNew, uint? key = default) => default; // 0x00000001829F7870-0x00000001829F7950
	// [XID] // 0x0000000189777EF0-0x0000000189777F10
	protected virtual void DeallocateScenePropToPool(ScenePropEntity entity) {} // 0x00000001829F7EA0-0x00000001829F7F70
	// [XID] // 0x000000018991B400-0x000000018991B420
	public void AddToSyncCreatedList(ScenePropEntity scenePropEntity, uint configId) {} // 0x00000001829F8650-0x00000001829F8F00
	// [XID] // 0x0000000189786E40-0x0000000189786E60
	public void AddToSyncRemovedList(ScenePropEntity scenePropEntity) {} // 0x00000001829F6E30-0x00000001829F70A0
	// [XID] // 0x000000018978E480-0x000000018978E4A0
	public void AddToSyncStateList(EntityType entityType, long objId, SceneObjState state) {} // 0x00000001829FA2B0-0x00000001829FA530
	// [XID] // 0x0000000189795BC0-0x0000000189795BE0
	protected void TickSyncToServer() {} // 0x00000001829F9880-0x00000001829F9D80
}

