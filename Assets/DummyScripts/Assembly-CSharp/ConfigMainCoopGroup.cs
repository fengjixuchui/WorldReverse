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
public class ConfigMainCoopGroup : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17763
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<uint, ConfigCoopInteractionGroup> _coopInteractionMap; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<uint, CoopSubStartPoint> _subStartPointMap; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<uint, CoopSavePoint> _savePointMap; // 0x20
	private uint _confidenceValue; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<CoopTemperamentType, CoopTemperament> _temperamentMap; // 0x30
	private Dictionary<uint, uint> _tempValueMap; // 0x38
	private bool _useConfidence; // 0x40
	private bool _useTemperament; // 0x41

	// Properties
	public Dictionary<uint, ConfigCoopInteractionGroup> coopInteractionMap { /* [XID] */ /* 0x00000001896D14C0-0x00000001896D14E0 */ get => default; /* [XID] */ /* 0x0000000189B72E70-0x0000000189B72E90 */ private set {} } // 0x00000001835AD330-0x00000001835AD3D0 0x00000001835ACE20-0x00000001835ACED0
	public Dictionary<uint, CoopSubStartPoint> subStartPointMap { /* [XID] */ /* 0x0000000189B7A3D0-0x0000000189B7A3F0 */ get => default; /* [XID] */ /* 0x0000000189B81B90-0x0000000189B81BB0 */ private set {} } // 0x00000001835AC590-0x00000001835AC630 0x00000001835AD1D0-0x00000001835AD280
	public Dictionary<uint, CoopSavePoint> savePointMap { /* [XID] */ /* 0x0000000189B89290-0x0000000189B892B0 */ get => default; /* [XID] */ /* 0x0000000189B90830-0x0000000189B90850 */ private set {} } // 0x00000001835ADE50-0x00000001835ADEF0 0x00000001835ACC50-0x00000001835ACD00
	public uint confidenceValue { /* [XID] */ /* 0x0000000189B97CE0-0x0000000189B97D00 */ get => default; /* [XID] */ /* 0x0000000189B9F0F0-0x0000000189B9F110 */ private set {} } // 0x00000001835AC630-0x00000001835AC6D0 0x00000001835AD3D0-0x00000001835AD480
	public Dictionary<CoopTemperamentType, CoopTemperament> temperamentMap { /* [XID] */ /* 0x0000000189BA6960-0x0000000189BA6980 */ get => default; /* [XID] */ /* 0x0000000189BADB80-0x0000000189BADBA0 */ private set {} } // 0x00000001835ABE30-0x00000001835ABED0 0x00000001835ACAF0-0x00000001835ACBA0
	public Dictionary<uint, uint> tempValueMap { /* [XID] */ /* 0x0000000189BB5310-0x0000000189BB5330 */ get => default; /* [XID] */ /* 0x0000000189BBCA70-0x0000000189BBCA90 */ private set {} } // 0x00000001835AD480-0x00000001835AD520 0x00000001835ACBA0-0x00000001835ACC50
	public bool useConfidence { /* [XID] */ /* 0x0000000189BC4740-0x0000000189BC4760 */ get => default; /* [XID] */ /* 0x0000000189BCC080-0x0000000189BCC0A0 */ private set {} } // 0x00000001835ABED0-0x00000001835ABF70 0x00000001835ADEF0-0x00000001835ADFA0
	public bool useTemperament { /* [XID] */ /* 0x0000000189BD3650-0x0000000189BD3670 */ get => default; /* [XID] */ /* 0x0000000189BDAFA0-0x0000000189BDAFC0 */ private set {} } // 0x00000001835ACA50-0x00000001835ACAF0 0x00000001835AD280-0x00000001835AD330

	// Constructors
	public ConfigMainCoopGroup() {} // 0x00000001835AE040-0x00000001835AE0B0

	// Methods
	// [XID] // 0x00000001895E7910-0x00000001895E7930
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001835ADB60-0x00000001835ADD10
	// [XID] // 0x00000001895EF280-0x00000001895EF2A0
	public void InitEmpty() {} // 0x00000001835ACD00-0x00000001835ACE20
	[BlackList] // 0x00000001895F6CA0-0x00000001895F6CE0
	// [XID] // 0x00000001895F6CA0-0x00000001895F6CE0
	public bool FromJson(JSONNode node) => default; // 0x00000001835AC6D0-0x00000001835ACA50
	// [XID] // 0x0000000189601140-0x0000000189601160
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001835AB220-0x00000001835AB9A0
	// [XID] // 0x0000000189608B50-0x0000000189608B70
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B57 */, bool useObjectPool = false /* Metadata: 0x00AF7B5B */) => default; // 0x00000001835ACED0-0x00000001835AD1D0
	// [XID] // 0x0000000189610370-0x0000000189610390
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7B5C */, bool useObjectPool = false /* Metadata: 0x00AF7B60 */) => default; // 0x00000001835ABF70-0x00000001835AC590
	[BlackList] // 0x00000001896175F0-0x0000000189617630
	// [XID] // 0x00000001896175F0-0x0000000189617630
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001835AB9A0-0x00000001835ABC70
	// [XID] // 0x0000000189621EA0-0x0000000189621EC0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001835AD520-0x00000001835ADB60
	[BlackList] // 0x00000001896298B0-0x00000001896298F0
	// [XID] // 0x00000001896298B0-0x00000001896298F0
	public virtual void AutoAllocTypeFields() {} // 0x00000001835ABC70-0x00000001835ABD10
	[BlackList] // 0x00000001896340D0-0x0000000189634110
	// [XID] // 0x00000001896340D0-0x0000000189634110
	public virtual void AutoRecycleTypeFields() {} // 0x00000001835ABD10-0x00000001835ABE30
	[BlackList] // 0x000000018963E7C0-0x000000018963E800
	// [XID] // 0x000000018963E7C0-0x000000018963E800
	public virtual void ReturnToObjectPool() {} // 0x00000001835ADFA0-0x00000001835AE040
	[BlackList] // 0x00000001896490A0-0x00000001896490E0
	// [XID] // 0x00000001896490A0-0x00000001896490E0
	public virtual void OnPoolAllocated() {} // 0x00000001835ADDB0-0x00000001835ADE50
	[BlackList] // 0x00000001896536E0-0x0000000189653720
	// [XID] // 0x00000001896536E0-0x0000000189653720
	public virtual void OnBeforePoolRecycled() {} // 0x00000001835ADD10-0x00000001835ADDB0
}

