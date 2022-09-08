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

public sealed class LevelSceneBushPlugin : LevelScenePropPlugin // TypeDefIndex: 12076
{
	// Properties
	public override int metaTypeID { /* [XID] */ /* 0x000000018999AB70-0x000000018999AB90 */ get => default; } // 0x00000001838F2B60-0x00000001838F2C00 

	// Constructors
	public LevelSceneBushPlugin() {} // 0x00000001838F2AE0-0x00000001838F2B60

	// Methods
	// [XID] // 0x00000001899A22F0-0x00000001899A2310
	public override void Init() {} // 0x00000001838F1C70-0x00000001838F1D80
	// [XID] // 0x00000001899A9B00-0x00000001899A9B20
	protected override void InitCacheList() {} // 0x00000001838F16D0-0x00000001838F1770
	// [XID] // 0x00000001899B1500-0x00000001899B1520
	public override bool HandleReaction(EvtElementReaction evtEleRct) => default; // 0x00000001838F22A0-0x00000001838F2400
	// [XID] // 0x00000001899B8980-0x00000001899B89A0
	public override bool HandleReactionType(ElementReactionType elementReactionType, uint reactorID) => default; // 0x00000001838F1EC0-0x00000001838F2010
	// [XID] // 0x00000001899C0250-0x00000001899C0270
	public override bool IsObjectUseless(long objId, ElementType type = ElementType.None /* Metadata: 0x00AEB478 */) => default; // 0x00000001838F19F0-0x00000001838F1B10
	// [IDTag] // 0x00000001899C7AB0-0x00000001899C7AF0
	// [XID] // 0x00000001899C7AB0-0x00000001899C7AF0
	public void CheckBushRange(Vector3 center, float radius, List<CollisionResult> results) {} // 0x00000001838F1770-0x00000001838F1880
	// [IDTag] // 0x00000001899D2090-0x00000001899D20D0
	// [XID] // 0x00000001899D2090-0x00000001899D20D0
	public int CheckBushRange(Vector3 center, float size, ScenePropBoxInfo[] buffer, uint maxCount) => default; // 0x00000001838F1880-0x00000001838F19F0
	// [XID] // 0x00000001899DC640-0x00000001899DC660
	public ScenePropEntity CreateBush(ScenePropBoxInfo info, ref int count) => default; // 0x00000001838F2500-0x00000001838F2AE0
	// [XID] // 0x00000001899E3E80-0x00000001899E3EA0
	private GameObject CreateGO() => default; // 0x00000001838F1630-0x00000001838F16D0
	// [XID] // 0x00000001899EB3F0-0x00000001899EB410
	protected override void OnObjDestroy(long id) {} // 0x00000001838F1530-0x00000001838F1630
	// [XID] // 0x00000001899F3080-0x00000001899F30A0
	protected override void OnPostDestroy(ScenePropEntity entity) {} // 0x00000001838F1D80-0x00000001838F1EC0
	// [XID] // 0x00000001899FA730-0x00000001899FA750
	protected override void DeallocateScenePropToPool(ScenePropEntity entity) {} // 0x00000001838F1B10-0x00000001838F1C10
}

