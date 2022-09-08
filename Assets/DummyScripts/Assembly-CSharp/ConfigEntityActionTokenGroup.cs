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
public class ConfigEntityActionTokenGroup : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16322
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAbilityActionToken _lowEntityToken; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigAbilityActionToken _otherEntityToken; // 0x18

	// Properties
	public ConfigAbilityActionToken lowEntityToken { /* [XID] */ /* 0x00000001896221C0-0x00000001896221E0 */ get => default; /* [XID] */ /* 0x0000000189629B10-0x0000000189629B30 */ private set {} } // 0x0000000181790960-0x0000000181790A00 0x00000001817908B0-0x0000000181790960
	public ConfigAbilityActionToken otherEntityToken { /* [XID] */ /* 0x0000000189631380-0x00000001896313A0 */ get => default; /* [XID] */ /* 0x0000000189638D30-0x0000000189638D50 */ private set {} } // 0x0000000181790A00-0x0000000181790AA0 0x000000018178FCD0-0x000000018178FD80

	// Constructors
	public ConfigEntityActionTokenGroup() {} // 0x0000000181791770-0x00000001817917D0

	// Methods
	// [XID] // 0x00000001896401D0-0x00000001896401F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181791490-0x0000000181791590
	// [XID] // 0x0000000189647A10-0x0000000189647A30
	public void InitEmpty() {} // 0x0000000181790E20-0x0000000181790F10
	[BlackList] // 0x000000018964F080-0x000000018964F0C0
	// [XID] // 0x000000018964F080-0x000000018964F0C0
	public bool FromJson(JSONNode node) => default; // 0x0000000181790AA0-0x0000000181790E20
	// [XID] // 0x00000001896598F0-0x0000000189659910
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018178FD80-0x0000000181790080
	// [XID] // 0x0000000189661070-0x0000000189661090
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF37DE */, bool useObjectPool = false /* Metadata: 0x00AF37E2 */) => default; // 0x0000000181790F10-0x0000000181791210
	// [XID] // 0x0000000189668AA0-0x0000000189668AC0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF37E3 */, bool useObjectPool = false /* Metadata: 0x00AF37E7 */) => default; // 0x0000000181790590-0x00000001817908B0
	[BlackList] // 0x0000000189670650-0x0000000189670690
	// [XID] // 0x0000000189670650-0x0000000189670690
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181790080-0x0000000181790350
	// [XID] // 0x000000018967AC00-0x000000018967AC20
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181791210-0x0000000181791490
	[BlackList] // 0x0000000189682530-0x0000000189682570
	// [XID] // 0x0000000189682530-0x0000000189682570
	public virtual void AutoAllocTypeFields() {} // 0x0000000181790350-0x00000001817903F0
	[BlackList] // 0x000000018968CF00-0x000000018968CF40
	// [XID] // 0x000000018968CF00-0x000000018968CF40
	public virtual void AutoRecycleTypeFields() {} // 0x00000001817903F0-0x0000000181790590
	[BlackList] // 0x0000000189697CC0-0x0000000189697D00
	// [XID] // 0x0000000189697CC0-0x0000000189697D00
	public virtual void ReturnToObjectPool() {} // 0x00000001817916D0-0x0000000181791770
	[BlackList] // 0x00000001896A2180-0x00000001896A21C0
	// [XID] // 0x00000001896A2180-0x00000001896A21C0
	public virtual void OnPoolAllocated() {} // 0x0000000181791630-0x00000001817916D0
	[BlackList] // 0x00000001896AC370-0x00000001896AC3B0
	// [XID] // 0x00000001896AC370-0x00000001896AC3B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181791590-0x0000000181791630
}

