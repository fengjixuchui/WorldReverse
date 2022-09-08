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
public class ConfigLevelMonsterData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18496
{
	// Fields
	private SimpleSafeUInt32 sceneIdRawNum; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigLevelMonsterUnit[] _monsters; // 0x18

	// Properties
	public uint sceneId { /* [XID] */ /* 0x000000018980FCB0-0x000000018980FCD0 */ get => default; /* [XID] */ /* 0x0000000189817340-0x0000000189817360 */ private set {} } // 0x0000000185198220-0x00000001851982F0 0x00000001851985F0-0x00000001851986D0
	public ConfigLevelMonsterUnit[] monsters { /* [XID] */ /* 0x000000018981ECA0-0x000000018981ECC0 */ get => default; /* [XID] */ /* 0x0000000189826190-0x00000001898261B0 */ private set {} } // 0x0000000185198A20-0x0000000185198AC0 0x00000001851986D0-0x0000000185198780

	// Constructors
	public ConfigLevelMonsterData() {} // 0x0000000185198DB0-0x0000000185198E30

	// Methods
	// [XID] // 0x000000018982D740-0x000000018982D760
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185198AC0-0x0000000185198BD0
	// [XID] // 0x0000000189834EF0-0x0000000189834F10
	public void InitEmpty() {} // 0x0000000185198120-0x0000000185198220
	[BlackList] // 0x000000018983C670-0x000000018983C6B0
	// [XID] // 0x000000018983C670-0x000000018983C6B0
	public bool FromJson(JSONNode node) => default; // 0x0000000185197DA0-0x0000000185198120
	// [XID] // 0x0000000189846BD0-0x0000000189846BF0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000185197380-0x0000000185197680
	// [XID] // 0x000000018984E220-0x000000018984E240
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F6D */, bool useObjectPool = false /* Metadata: 0x00AF9F71 */) => default; // 0x00000001851982F0-0x00000001851985F0
	// [XID] // 0x00000001898552D0-0x00000001898552F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9F72 */, bool useObjectPool = false /* Metadata: 0x00AF9F76 */) => default; // 0x0000000185197AD0-0x0000000185197DA0
	[BlackList] // 0x000000018985C990-0x000000018985C9D0
	// [XID] // 0x000000018985C990-0x000000018985C9D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000185197680-0x0000000185197950
	// [XID] // 0x0000000189866E90-0x0000000189866EB0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185198780-0x0000000185198A20
	[BlackList] // 0x000000018986E630-0x000000018986E670
	// [XID] // 0x000000018986E630-0x000000018986E670
	public virtual void AutoAllocTypeFields() {} // 0x0000000185197950-0x00000001851979F0
	[BlackList] // 0x0000000189878BF0-0x0000000189878C30
	// [XID] // 0x0000000189878BF0-0x0000000189878C30
	public virtual void AutoRecycleTypeFields() {} // 0x00000001851979F0-0x0000000185197AD0
	[BlackList] // 0x0000000189882CB0-0x0000000189882CF0
	// [XID] // 0x0000000189882CB0-0x0000000189882CF0
	public virtual void ReturnToObjectPool() {} // 0x0000000185198D10-0x0000000185198DB0
	[BlackList] // 0x000000018988D2E0-0x000000018988D320
	// [XID] // 0x000000018988D2E0-0x000000018988D320
	public virtual void OnPoolAllocated() {} // 0x0000000185198C70-0x0000000185198D10
	[BlackList] // 0x00000001898977C0-0x0000000189897800
	// [XID] // 0x00000001898977C0-0x0000000189897800
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185198BD0-0x0000000185198C70
}

