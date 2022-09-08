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

public sealed class LevelSceneTreePlugin : LevelScenePropPlugin // TypeDefIndex: 12118
{
	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x00000001899BA0F0-0x00000001899BA110 */ get => default; } // 0x0000000182A9E2E0-0x0000000182A9E380 

	// Constructors
	public LevelSceneTreePlugin() {} // 0x0000000182A9E260-0x0000000182A9E2E0

	// Methods
	// [XID] // 0x00000001899C1C60-0x00000001899C1C80
	public override void Init() {} // 0x0000000182A9D9C0-0x0000000182A9DAD0
	// [XID] // 0x00000001899C9080-0x00000001899C90A0
	protected override void InitCacheList() {} // 0x0000000182A9D210-0x0000000182A9D2B0
	// [XID] // 0x00000001899D0BC0-0x00000001899D0BE0
	public override bool HandleReaction(EvtElementReaction evtEleRct) => default; // 0x0000000182A9DD80-0x0000000182A9DEE0
	// [XID] // 0x00000001899D7F70-0x00000001899D7F90
	public override bool IsObjectUseless(long objId, ElementType type = ElementType.None /* Metadata: 0x00AEB50C */) => default; // 0x0000000182A9D2B0-0x0000000182A9D3D0
	// [IDTag] // 0x00000001899DF580-0x00000001899DF5C0
	// [XID] // 0x00000001899DF580-0x00000001899DF5C0
	public void CheckTreeRange(Vector3 center, float radius, List<CollisionResult> results) {} // 0x0000000182A9E150-0x0000000182A9E260
	// [IDTag] // 0x00000001899E9CF0-0x00000001899E9D30
	// [XID] // 0x00000001899E9CF0-0x00000001899E9D30
	public int CheckTreeRange(Vector3 center, float size, ScenePropBoxInfo[] buffer, uint maxCount) => default; // 0x0000000182A9DFE0-0x0000000182A9E150
	// [XID] // 0x0000000189BA3010-0x0000000189BA3030
	public ScenePropEntity CreateTree(ScenePropBoxInfo info, ref int count) => default; // 0x0000000182A9D4D0-0x0000000182A9D960
	// [XID] // 0x00000001895EB6D0-0x00000001895EB6F0
	private GameObject CreateGO() => default; // 0x0000000182A9D130-0x0000000182A9D210
	// [XID] // 0x0000000189A03410-0x0000000189A03430
	protected override void OnObjDestroy(long id) {} // 0x0000000182A9D030-0x0000000182A9D130
	// [XID] // 0x0000000189A0AAB0-0x0000000189A0AAD0
	protected override void OnPostDestroy(ScenePropEntity entity) {} // 0x0000000182A9DAD0-0x0000000182A9DB80
	// [XID] // 0x0000000189A12220-0x0000000189A12240
	protected override void DeallocateScenePropToPool(ScenePropEntity entity) {} // 0x0000000182A9D3D0-0x0000000182A9D4D0
}

