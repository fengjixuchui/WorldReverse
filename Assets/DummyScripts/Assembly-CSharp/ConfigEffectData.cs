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
public class ConfigEffectData : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17931
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigElementView _elementView; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigBeHitEffect _beHit; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigRecoverEnergyEffect[] _recoverEnergy; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigEffectPool _effectPool; // 0x28
	private Dictionary<string, string> _scenePropShakeAnim; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigEffectLOD _effectLOD; // 0x38
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigSkipUnindexedEffectCreation> _skipUnindexedEffectCreation; // 0x40
	private Dictionary<string, TokenForceEnqueueReason> _tokenForceEnqueueMap; // 0x48
	public HashSet<int> useDistanceLODEntityTypeHashSet; // 0x50

	// Properties
	public ConfigElementView elementView { /* [XID] */ /* 0x0000000189977180-0x00000001899771A0 */ get => default; /* [XID] */ /* 0x000000018997E520-0x000000018997E540 */ private set {} } // 0x0000000181FDA510-0x0000000181FDA5B0 0x0000000181FDA8F0-0x0000000181FDA9A0
	public ConfigBeHitEffect beHit { /* [XID] */ /* 0x0000000189985FB0-0x0000000189985FD0 */ get => default; /* [XID] */ /* 0x000000018998DC00-0x000000018998DC20 */ private set {} } // 0x0000000181FD9DD0-0x0000000181FD9E70 0x0000000181FD9B20-0x0000000181FD9BD0
	public ConfigRecoverEnergyEffect[] recoverEnergy { /* [XID] */ /* 0x00000001899956F0-0x0000000189995710 */ get => default; /* [XID] */ /* 0x000000018999D0F0-0x000000018999D110 */ private set {} } // 0x0000000181FD8950-0x0000000181FD89F0 0x0000000181FD9D20-0x0000000181FD9DD0
	public ConfigEffectPool effectPool { /* [XID] */ /* 0x0000000189AB2570-0x0000000189AB2590 */ get => default; /* [XID] */ /* 0x00000001899AC510-0x00000001899AC530 */ private set {} } // 0x0000000181FD9570-0x0000000181FD9610 0x0000000181FD9C70-0x0000000181FD9D20
	public Dictionary<string, string> scenePropShakeAnim { /* [XID] */ /* 0x00000001899B3CA0-0x00000001899B3CC0 */ get => default; /* [XID] */ /* 0x00000001899BB0B0-0x00000001899BB0D0 */ private set {} } // 0x0000000181FD9150-0x0000000181FD91F0 0x0000000181FD9A70-0x0000000181FD9B20
	public ConfigEffectLOD effectLOD { /* [XID] */ /* 0x00000001899C2A80-0x00000001899C2AA0 */ get => default; /* [XID] */ /* 0x00000001899CA100-0x00000001899CA120 */ private set {} } // 0x0000000181FD8760-0x0000000181FD8800 0x0000000181FD88A0-0x0000000181FD8950
	public Dictionary<string, ConfigSkipUnindexedEffectCreation> skipUnindexedEffectCreation { /* [XID] */ /* 0x0000000189BAB990-0x0000000189BAB9B0 */ get => default; /* [XID] */ /* 0x00000001899D8E70-0x00000001899D8E90 */ private set {} } // 0x0000000181FD9BD0-0x0000000181FD9C70 0x0000000181FD86B0-0x0000000181FD8760
	public Dictionary<string, TokenForceEnqueueReason> tokenForceEnqueueMap { /* [XID] */ /* 0x00000001899E0460-0x00000001899E0480 */ get => default; /* [XID] */ /* 0x00000001899E7FC0-0x00000001899E7FE0 */ private set {} } // 0x0000000181FD8800-0x0000000181FD88A0 0x0000000181FDA9A0-0x0000000181FDAA50

	// Constructors
	public ConfigEffectData() {} // 0x0000000181FDAAF0-0x0000000181FDAB50

	// Methods
	// [XID] // 0x00000001899EF490-0x00000001899EF4B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181FDA5B0-0x0000000181FDA7B0
	// [XID] // 0x00000001899F6DB0-0x00000001899F6DD0
	public void InitEmpty() {} // 0x0000000181FD9610-0x0000000181FD9770
	[BlackList] // 0x00000001899FE610-0x00000001899FE650
	// [XID] // 0x00000001899FE610-0x00000001899FE650
	public bool FromJson(JSONNode node) => default; // 0x0000000181FD91F0-0x0000000181FD9570
	// [XID] // 0x0000000189A08AB0-0x0000000189A08AD0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181FD7860-0x0000000181FD80A0
	// [XID] // 0x0000000189A10050-0x0000000189A10070
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8267 */, bool useObjectPool = false /* Metadata: 0x00AF826B */) => default; // 0x0000000181FD9770-0x0000000181FD9A70
	// [XID] // 0x0000000189835D30-0x0000000189835D50
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF826C */, bool useObjectPool = false /* Metadata: 0x00AF8270 */) => default; // 0x0000000181FD89F0-0x0000000181FD9150
	[BlackList] // 0x0000000189A1EC50-0x0000000189A1EC90
	// [XID] // 0x0000000189A1EC50-0x0000000189A1EC90
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181FD80A0-0x0000000181FD8370
	// [XID] // 0x0000000189A290C0-0x0000000189A290E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181FD9E70-0x0000000181FDA510
	[BlackList] // 0x0000000189A306F0-0x0000000189A30730
	// [XID] // 0x0000000189A306F0-0x0000000189A30730
	public virtual void AutoAllocTypeFields() {} // 0x0000000181FD8370-0x0000000181FD8410
	[BlackList] // 0x0000000189A3ADE0-0x0000000189A3AE20
	// [XID] // 0x0000000189A3ADE0-0x0000000189A3AE20
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181FD8410-0x0000000181FD86B0
	[BlackList] // 0x0000000189A457A0-0x0000000189A457E0
	// [XID] // 0x0000000189A457A0-0x0000000189A457E0
	public virtual void ReturnToObjectPool() {} // 0x0000000181FDAA50-0x0000000181FDAAF0
	[BlackList] // 0x0000000189A4FEE0-0x0000000189A4FF20
	// [XID] // 0x0000000189A4FEE0-0x0000000189A4FF20
	public virtual void OnPoolAllocated() {} // 0x0000000181FDA850-0x0000000181FDA8F0
	[BlackList] // 0x0000000189A5A570-0x0000000189A5A5B0
	// [XID] // 0x0000000189A5A570-0x0000000189A5A5B0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181FDA7B0-0x0000000181FDA850
}

