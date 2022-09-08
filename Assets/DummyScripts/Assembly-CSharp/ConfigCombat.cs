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
public class ConfigCombat : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17695
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCombatProperty _property; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCombatBeHit _beHit; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCombatLock _combatLock; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigDie _die; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<string, ConfigAttackEvent> _animEvents; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigSummon _summon; // 0x38

	// Properties
	public ConfigCombatProperty property { /* [XID] */ /* 0x0000000189BA5DE0-0x0000000189BA5E00 */ get => default; /* [XID] */ /* 0x0000000189BD7CF0-0x0000000189BD7D10 */ private set {} } // 0x00000001858AF0E0-0x00000001858AF180 0x00000001858AEC00-0x00000001858AECB0
	public ConfigCombatBeHit beHit { /* [XID] */ /* 0x00000001896E5F90-0x00000001896E5FB0 */ get => default; /* [XID] */ /* 0x00000001895EC430-0x00000001895EC450 */ private set {} } // 0x00000001858AF2D0-0x00000001858AF370 0x00000001858AF220-0x00000001858AF2D0
	public ConfigCombatLock combatLock { /* [XID] */ /* 0x0000000189730850-0x0000000189730870 */ get => default; /* [XID] */ /* 0x00000001895FB1B0-0x00000001895FB1D0 */ private set {} } // 0x00000001858AF180-0x00000001858AF220 0x00000001858AFE70-0x00000001858AFF20
	public ConfigDie die { /* [XID] */ /* 0x0000000189760690-0x00000001897606B0 */ get => default; /* [XID] */ /* 0x000000018960A2B0-0x000000018960A2D0 */ private set {} } // 0x00000001858AE100-0x00000001858AE1A0 0x00000001858AF370-0x00000001858AF420
	public Dictionary<string, ConfigAttackEvent> animEvents { /* [XID] */ /* 0x0000000189611A40-0x0000000189611A60 */ get => default; /* [XID] */ /* 0x0000000189619380-0x00000001896193A0 */ private set {} } // 0x00000001858AE1A0-0x00000001858AE240 0x00000001858AF9F0-0x00000001858AFAA0
	public ConfigSummon summon { /* [XID] */ /* 0x0000000189620940-0x0000000189620960 */ get => default; /* [XID] */ /* 0x0000000189627E90-0x0000000189627EB0 */ private set {} } // 0x00000001858AF950-0x00000001858AF9F0 0x00000001858AFAA0-0x00000001858AFB50

	// Constructors
	public ConfigCombat() {} // 0x00000001858AFFC0-0x00000001858B0020

	// Methods
	// [XID] // 0x0000000189B9E390-0x0000000189B9E3B0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001858AFB50-0x00000001858AFD30
	// [XID] // 0x0000000189637300-0x0000000189637320
	public void InitEmpty() {} // 0x00000001858AECB0-0x00000001858AEDE0
	[BlackList] // 0x000000018963E800-0x000000018963E840
	// [XID] // 0x000000018963E800-0x000000018963E840
	public bool FromJson(JSONNode node) => default; // 0x00000001858AE880-0x00000001858AEC00
	// [XID] // 0x0000000189649100-0x0000000189649120
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001858AD3E0-0x00000001858ADA90
	// [XID] // 0x0000000189650730-0x0000000189650750
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7811 */, bool useObjectPool = false /* Metadata: 0x00AF7815 */) => default; // 0x00000001858AEDE0-0x00000001858AF0E0
	// [XID] // 0x0000000189658090-0x00000001896580B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7816 */, bool useObjectPool = false /* Metadata: 0x00AF781A */) => default; // 0x00000001858AE240-0x00000001858AE880
	[BlackList] // 0x000000018965F5E0-0x000000018965F620
	// [XID] // 0x000000018965F5E0-0x000000018965F620
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001858ADA90-0x00000001858ADD60
	// [XID] // 0x000000018966A0C0-0x000000018966A0E0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001858AF420-0x00000001858AF950
	[BlackList] // 0x0000000189671D00-0x0000000189671D40
	// [XID] // 0x0000000189671D00-0x0000000189671D40
	public virtual void AutoAllocTypeFields() {} // 0x00000001858ADD60-0x00000001858ADE00
	[BlackList] // 0x000000018967C3A0-0x000000018967C3E0
	// [XID] // 0x000000018967C3A0-0x000000018967C3E0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001858ADE00-0x00000001858AE100
	[BlackList] // 0x0000000189686A10-0x0000000189686A50
	// [XID] // 0x0000000189686A10-0x0000000189686A50
	public virtual void ReturnToObjectPool() {} // 0x00000001858AFF20-0x00000001858AFFC0
	[BlackList] // 0x0000000189691A30-0x0000000189691A70
	// [XID] // 0x0000000189691A30-0x0000000189691A70
	public virtual void OnPoolAllocated() {} // 0x00000001858AFDD0-0x00000001858AFE70
	[BlackList] // 0x000000018969BDE0-0x000000018969BE20
	// [XID] // 0x000000018969BDE0-0x000000018969BE20
	public virtual void OnBeforePoolRecycled() {} // 0x00000001858AFD30-0x00000001858AFDD0
}

