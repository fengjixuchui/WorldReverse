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
public class ConfigAbilityStateToActions : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 16868
{
	// Fields
	private AbilityState _abilityState; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _actions; // 0x18

	// Properties
	public AbilityState abilityState { /* [XID] */ /* 0x00000001897BBE10-0x00000001897BBE30 */ get => default; /* [XID] */ /* 0x00000001897C3650-0x00000001897C3670 */ private set {} } // 0x000000018320A480-0x000000018320A520 0x000000018320A000-0x000000018320A0B0
	public ConfigAbilityAction[] actions { /* [XID] */ /* 0x00000001897CAE70-0x00000001897CAE90 */ get => default; /* [XID] */ /* 0x00000001897D2530-0x00000001897D2550 */ private set {} } // 0x000000018320A520-0x000000018320A5C0 0x0000000183209930-0x00000001832099E0

	// Constructors
	public ConfigAbilityStateToActions() {} // 0x000000018320AB20-0x000000018320AB80

	// Methods
	// [XID] // 0x00000001897DA210-0x00000001897DA230
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018320A830-0x000000018320A940
	// [XID] // 0x00000001897E1680-0x00000001897E16A0
	public void InitEmpty() {} // 0x000000018320A0B0-0x000000018320A180
	[BlackList] // 0x00000001897E8EF0-0x00000001897E8F30
	// [XID] // 0x00000001897E8EF0-0x00000001897E8F30
	public bool FromJson(JSONNode node) => default; // 0x0000000183209C80-0x000000018320A000
	// [XID] // 0x00000001897F3B10-0x00000001897F3B30
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183209250-0x0000000183209510
	// [XID] // 0x00000001897FB510-0x00000001897FB530
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5BDF */, bool useObjectPool = false /* Metadata: 0x00AF5BE3 */) => default; // 0x000000018320A180-0x000000018320A480
	// [XID] // 0x00000001898029A0-0x00000001898029C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5BE4 */, bool useObjectPool = false /* Metadata: 0x00AF5BE8 */) => default; // 0x00000001832099E0-0x0000000183209C80
	[BlackList] // 0x0000000189809F90-0x0000000189809FD0
	// [XID] // 0x0000000189809F90-0x0000000189809FD0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183209510-0x00000001832097E0
	// [XID] // 0x00000001898144B0-0x00000001898144D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018320A5C0-0x000000018320A830
	[BlackList] // 0x000000018981BFA0-0x000000018981BFE0
	// [XID] // 0x000000018981BFA0-0x000000018981BFE0
	public virtual void AutoAllocTypeFields() {} // 0x00000001832097E0-0x0000000183209880
	[BlackList] // 0x0000000189826510-0x0000000189826550
	// [XID] // 0x0000000189826510-0x0000000189826550
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183209880-0x0000000183209930
	[BlackList] // 0x0000000189830B40-0x0000000189830B80
	// [XID] // 0x0000000189830B40-0x0000000189830B80
	public virtual void ReturnToObjectPool() {} // 0x000000018320AA80-0x000000018320AB20
	[BlackList] // 0x000000018983B080-0x000000018983B0C0
	// [XID] // 0x000000018983B080-0x000000018983B0C0
	public virtual void OnPoolAllocated() {} // 0x000000018320A9E0-0x000000018320AA80
	[BlackList] // 0x0000000189845730-0x0000000189845770
	// [XID] // 0x0000000189845730-0x0000000189845770
	public virtual void OnBeforePoolRecycled() {} // 0x000000018320A940-0x000000018320A9E0
}

