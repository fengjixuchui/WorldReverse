/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigLevelPolygons : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18500
{
	// Fields
	private SimpleSafeUInt32 sceneIdRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigLevelPolygon[] _polygons; // 0x18

	// Properties
	public uint sceneId { /* [XID] */ /* 0x0000000189989380-0x00000001899893A0 */ get => default; /* [XID] */ /* 0x0000000189990B90-0x0000000189990BB0 */ private set {} } // 0x00000001837C8D50-0x00000001837C8E20 0x00000001837C9120-0x00000001837C9200
	public ConfigLevelPolygon[] polygons { /* [XID] */ /* 0x0000000189998610-0x0000000189998630 */ get => default; /* [XID] */ /* 0x000000018999FE90-0x000000018999FEB0 */ private set {} } // 0x00000001837C84B0-0x00000001837C8550 0x00000001837C8820-0x00000001837C88D0

	// Constructors
	public ConfigLevelPolygons() {} // 0x00000001837C9790-0x00000001837C97F0

	// Methods
	// [XID] // 0x00000001899A7AA0-0x00000001899A7AC0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001837C94A0-0x00000001837C95B0
	// [XID] // 0x00000001899AF2D0-0x00000001899AF2F0
	public void InitEmpty() {} // 0x00000001837C8C50-0x00000001837C8D50
	[BlackList] // 0x00000001899B66B0-0x00000001899B66F0
	// [XID] // 0x00000001899B66B0-0x00000001899B66F0
	public bool FromJson(JSONNode node) => default; // 0x00000001837C88D0-0x00000001837C8C50
	// [XID] // 0x00000001899C11D0-0x00000001899C11F0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001837C7D60-0x00000001837C8060
	// [XID] // 0x00000001899C87C0-0x00000001899C87E0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F95 */, bool useObjectPool = false /* Metadata: 0x00AF9F99 */) => default; // 0x00000001837C8E20-0x00000001837C9120
	// [XID] // 0x00000001899D01D0-0x00000001899D01F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F9A */, bool useObjectPool = false /* Metadata: 0x00AF9F9E */) => default; // 0x00000001837C8550-0x00000001837C8820
	[BlackList] // 0x00000001899D7650-0x00000001899D7690
	// [XID] // 0x00000001899D7650-0x00000001899D7690
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001837C8060-0x00000001837C8330
	// [XID] // 0x00000001899E1F40-0x00000001899E1F60
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001837C9200-0x00000001837C94A0
	[BlackList] // 0x00000001899E9440-0x00000001899E9480
	// [XID] // 0x00000001899E9440-0x00000001899E9480
	public virtual void AutoAllocTypeFields() {} // 0x00000001837C8330-0x00000001837C83D0
	[BlackList] // 0x00000001899F4050-0x00000001899F4090
	// [XID] // 0x00000001899F4050-0x00000001899F4090
	public virtual void AutoRecycleTypeFields() {} // 0x00000001837C83D0-0x00000001837C84B0
	[BlackList] // 0x00000001899FE410-0x00000001899FE450
	// [XID] // 0x00000001899FE410-0x00000001899FE450
	public virtual void ReturnToObjectPool() {} // 0x00000001837C96F0-0x00000001837C9790
	[BlackList] // 0x0000000189A08910-0x0000000189A08950
	// [XID] // 0x0000000189A08910-0x0000000189A08950
	public virtual void OnPoolAllocated() {} // 0x00000001837C9650-0x00000001837C96F0
	[BlackList] // 0x0000000189A130A0-0x0000000189A130E0
	// [XID] // 0x0000000189A130A0-0x0000000189A130E0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001837C95B0-0x00000001837C9650
}

