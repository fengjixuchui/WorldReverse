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

public sealed class LevelSceneGrassPlugin : LevelScenePropPlugin // TypeDefIndex: 12082
{
	// Fields
	private LevelSceneSurfacePlugin _surfacePlugin; // 0xD0
	public Action<uint, SceneObjState, Bounds> onGrassStateChanged; // 0xD8
	public Action<uint> onGrassRemoved; // 0xE0

	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x0000000189B3BE30-0x0000000189B3BE50 */ get => default; } // 0x0000000181DBDF00-0x0000000181DBDFA0 

	// Constructors
	public LevelSceneGrassPlugin() {} // 0x0000000181DBDE80-0x0000000181DBDF00

	// Methods
	// [XID] // 0x0000000189B43A40-0x0000000189B43A60
	public override void Destroy() {} // 0x0000000181DBC090-0x0000000181DBC130
	// [XID] // 0x0000000189B4B040-0x0000000189B4B060
	public override void Init() {} // 0x0000000181DBC8C0-0x0000000181DBCA00
	// [XID] // 0x0000000189B528C0-0x0000000189B528E0
	protected override void InitCacheList() {} // 0x0000000181DBBC10-0x0000000181DBBE90
	// [XID] // 0x0000000189B5A280-0x0000000189B5A2A0
	public void DestroyGrassOnSuddenRemove(uint grassId) {} // 0x0000000181DBBE90-0x0000000181DBBF70
	// [XID] // 0x0000000189B61740-0x0000000189B61760
	public override bool HandleReaction(EvtElementReaction evtEleRct) => default; // 0x0000000181DBD3B0-0x0000000181DBD520
	// [XID] // 0x0000000189B692D0-0x0000000189B692F0
	public override bool HandleReactionType(ElementReactionType elementReactionType, uint reactorID) => default; // 0x0000000181DBCB80-0x0000000181DBCCD0
	// [XID] // 0x0000000189B707D0-0x0000000189B707F0
	public override void ScenePropElementReaction(long objId, SceneObjState type, bool syncFromServer = false /* Metadata: 0x00AEB4B4 */) {} // 0x0000000181DBCD60-0x0000000181DBCF40
	// [XID] // 0x0000000189B77C80-0x0000000189B77CA0
	public void SetSceneMassiveGrassStateNormal() {} // 0x0000000181DBD720-0x0000000181DBDA00
	// [XID] // 0x0000000189B7F2C0-0x0000000189B7F2E0
	public override bool IsObjectUseless(long objId, ElementType type = ElementType.None /* Metadata: 0x00AEB4B5 */) => default; // 0x0000000181DBBF70-0x0000000181DBC090
	// [XID] // 0x0000000189B86E30-0x0000000189B86E50
	public void CreateGrassCallBack(uint id) {} // 0x0000000181DBDA00-0x0000000181DBDB30
	// [XID] // 0x0000000189A6BC40-0x0000000189A6BC60
	public bool CheckGrass(Vector3 pos) => default; // 0x0000000181DBD2D0-0x0000000181DBD3B0
	// [XID] // 0x00000001897C1010-0x00000001897C1030
	private void RegisterGrassSuddenCallback(GrassEntity grassEntity) {} // 0x0000000181DBD130-0x0000000181DBD1E0
	// [XID] // 0x0000000189B9CB10-0x0000000189B9CB30
	public void FilterAllTerrainGrasses() {} // 0x0000000181DBBB70-0x0000000181DBBC10
	// [XID] // 0x0000000189BA41C0-0x0000000189BA41E0
	public bool HasGrassOnAvatarPos() => default; // 0x0000000181DBC720-0x0000000181DBC860
	// [XID] // 0x000000018961CC40-0x000000018961CC60
	public void CheckGrassRange(Vector3 center, float radius, List<CollisionResult> results) {} // 0x0000000181DBD5A0-0x0000000181DBD720
	// [XID] // 0x0000000189BB2D70-0x0000000189BB2D90
	public ScenePropEntity CreateGrass(MiHoYoGrassInfo grassInfo, ref int count) => default; // 0x0000000181DBC5E0-0x0000000181DBC720
	// [XID] // 0x0000000189709C20-0x0000000189709C40
	public ScenePropEntity DoCreateGrass(MiHoYoGrassInfo grassInfo, ref int count, ScenePropCreateByType createdType) => default; // 0x0000000181DBB120-0x0000000181DBB920
	// [XID] // 0x0000000189BC2260-0x0000000189BC2280
	public override ScenePropEntity CreateMassiveEntityFromServer(ServerMassiveEntity massiveEntity) => default; // 0x0000000181DBDB30-0x0000000181DBDE80
	// [XID] // 0x0000000189BC97B0-0x0000000189BC97D0
	protected override void OnObjDestroy(long id) {} // 0x0000000181DBB920-0x0000000181DBBA30
	// [XID] // 0x0000000189BD0F90-0x0000000189BD0FB0
	protected override void OnPostDestroy(ScenePropEntity entity) {} // 0x0000000181DBCA00-0x0000000181DBCB80
	// [XID] // 0x0000000189BD85C0-0x0000000189BD85E0
	private void InitGrassModifier(ScenePropEntity entity) {} // 0x0000000181DBC1E0-0x0000000181DBC370
	// [XID] // 0x0000000189718A80-0x0000000189718AA0
	private GameObject CreateGO() => default; // 0x0000000181DBBAD0-0x0000000181DBBB70
	// [XID] // 0x00000001895ECB80-0x00000001895ECBA0
	protected override bool CanBeDestroy(long id, BaseEntity sceneEntity, Vector3 pos) => default; // 0x0000000181DBC370-0x0000000181DBC5E0
}

