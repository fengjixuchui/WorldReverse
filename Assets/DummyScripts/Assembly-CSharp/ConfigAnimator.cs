/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigAnimator : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17519
{
	// Fields
	private Dictionary<int, string[]> _freeStyleStateMap; // 0x10
	private Dictionary<string, ulong> _stateAnimeMap; // 0x18

	// Properties
	public Dictionary<int, string[]> freeStyleStateMap { /* [XID] */ /* 0x00000001899A9300-0x00000001899A9320 */ get => default; /* [XID] */ /* 0x00000001899B0DD0-0x00000001899B0DF0 */ private set {} } // 0x0000000180F804B0-0x0000000180F80550 0x0000000180F80270-0x0000000180F80320
	public Dictionary<string, ulong> stateAnimeMap { /* [XID] */ /* 0x00000001899B8070-0x00000001899B8090 */ get => default; /* [XID] */ /* 0x00000001899BFC30-0x00000001899BFC50 */ private set {} } // 0x0000000180F80410-0x0000000180F804B0 0x0000000180F801C0-0x0000000180F80270

	// Constructors
	public ConfigAnimator() {} // 0x0000000180F80DE0-0x0000000180F80E40

	// Methods
	// [XID] // 0x00000001899C73B0-0x00000001899C73D0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000180F80AF0-0x0000000180F80C00
	// [XID] // 0x00000001899CE940-0x00000001899CE960
	public void InitEmpty() {} // 0x0000000180F80320-0x0000000180F80410
	[BlackList] // 0x00000001899D6110-0x00000001899D6150
	// [XID] // 0x00000001899D6110-0x00000001899D6150
	public bool FromJson(JSONNode node) => default; // 0x0000000180F7FE40-0x0000000180F801C0
	// [XID] // 0x00000001899E0560-0x00000001899E0580
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000180F7F490-0x0000000180F7F760
	// [XID] // 0x00000001899E8120-0x00000001899E8140
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7193 */, bool useObjectPool = false /* Metadata: 0x00AF7197 */) => default; // 0x0000000180F80550-0x0000000180F80850
	// [XID] // 0x00000001899EF5D0-0x00000001899EF5F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7198 */, bool useObjectPool = false /* Metadata: 0x00AF719C */) => default; // 0x0000000180F7FB70-0x0000000180F7FE40
	[BlackList] // 0x00000001899F6E90-0x00000001899F6ED0
	// [XID] // 0x00000001899F6E90-0x00000001899F6ED0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000180F7F760-0x0000000180F7FA30
	// [XID] // 0x0000000189A01150-0x0000000189A01170
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000180F80850-0x0000000180F80AF0
	[BlackList] // 0x0000000189A08B30-0x0000000189A08B70
	// [XID] // 0x0000000189A08B30-0x0000000189A08B70
	public virtual void AutoAllocTypeFields() {} // 0x0000000180F7FA30-0x0000000180F7FAD0
	[BlackList] // 0x0000000189A132A0-0x0000000189A132E0
	// [XID] // 0x0000000189A132A0-0x0000000189A132E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000180F7FAD0-0x0000000180F7FB70
	[BlackList] // 0x0000000189A1D580-0x0000000189A1D5C0
	// [XID] // 0x0000000189A1D580-0x0000000189A1D5C0
	public virtual void ReturnToObjectPool() {} // 0x0000000180F80D40-0x0000000180F80DE0
	[BlackList] // 0x0000000189A27980-0x0000000189A279C0
	// [XID] // 0x0000000189A27980-0x0000000189A279C0
	public virtual void OnPoolAllocated() {} // 0x0000000180F80CA0-0x0000000180F80D40
	[BlackList] // 0x0000000189A31E40-0x0000000189A31E80
	// [XID] // 0x0000000189A31E40-0x0000000189A31E80
	public virtual void OnBeforePoolRecycled() {} // 0x0000000180F80C00-0x0000000180F80CA0
}

