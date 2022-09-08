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
public class ConfigSummon : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17694
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigSummonTag[] _summonTags; // 0x10

	// Properties
	public ConfigSummonTag[] summonTags { /* [XID] */ /* 0x0000000189B17DC0-0x0000000189B17DE0 */ get => default; /* [XID] */ /* 0x0000000189B1F620-0x0000000189B1F640 */ private set {} } // 0x000000018508A800-0x000000018508A8A0 0x000000018508A8A0-0x000000018508A950

	// Constructors
	public ConfigSummon() {} // 0x000000018508AE00-0x000000018508AE60

	// Methods
	// [XID] // 0x0000000189A38D10-0x0000000189A38D30
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018508AB40-0x000000018508AC20
	// [XID] // 0x0000000189B2E050-0x0000000189B2E070
	public void InitEmpty() {} // 0x000000018508A430-0x000000018508A500
	[BlackList] // 0x0000000189B353E0-0x0000000189B35420
	// [XID] // 0x0000000189B353E0-0x0000000189B35420
	public bool FromJson(JSONNode node) => default; // 0x000000018508A0B0-0x000000018508A430
	// [XID] // 0x0000000189B400C0-0x0000000189B400E0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001850898B0-0x0000000185089A90
	// [XID] // 0x0000000189B479A0-0x0000000189B479C0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7807 */, bool useObjectPool = false /* Metadata: 0x00AF780B */) => default; // 0x000000018508A500-0x000000018508A800
	// [XID] // 0x0000000189B4F0D0-0x0000000189B4F0F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF780C */, bool useObjectPool = false /* Metadata: 0x00AF7810 */) => default; // 0x0000000185089EA0-0x000000018508A0B0
	[BlackList] // 0x0000000189B56AD0-0x0000000189B56B10
	// [XID] // 0x0000000189B56AD0-0x0000000189B56B10
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000185089A90-0x0000000185089D60
	// [XID] // 0x0000000189B61190-0x0000000189B611B0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018508A950-0x000000018508AB40
	[BlackList] // 0x0000000189B68940-0x0000000189B68980
	// [XID] // 0x0000000189B68940-0x0000000189B68980
	public virtual void AutoAllocTypeFields() {} // 0x0000000185089D60-0x0000000185089E00
	[BlackList] // 0x0000000189B72E90-0x0000000189B72ED0
	// [XID] // 0x0000000189B72E90-0x0000000189B72ED0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185089E00-0x0000000185089EA0
	[BlackList] // 0x0000000189B7D200-0x0000000189B7D240
	// [XID] // 0x0000000189B7D200-0x0000000189B7D240
	public virtual void ReturnToObjectPool() {} // 0x000000018508AD60-0x000000018508AE00
	[BlackList] // 0x0000000189B87CE0-0x0000000189B87D20
	// [XID] // 0x0000000189B87CE0-0x0000000189B87D20
	public virtual void OnPoolAllocated() {} // 0x000000018508ACC0-0x000000018508AD60
	[BlackList] // 0x0000000189B91F20-0x0000000189B91F60
	// [XID] // 0x0000000189B91F20-0x0000000189B91F60
	public virtual void OnBeforePoolRecycled() {} // 0x000000018508AC20-0x000000018508ACC0
}

