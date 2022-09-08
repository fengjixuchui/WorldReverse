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
public class ConfigCutsceneIndex : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17786
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigCutsceneContext _normal; // 0x10
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private Dictionary<int, ConfigCutsceneContext> _platform; // 0x18

	// Properties
	public ConfigCutsceneContext normal { /* [XID] */ /* 0x0000000189AA8400-0x0000000189AA8420 */ get => default; /* [XID] */ /* 0x0000000189AB0120-0x0000000189AB0140 */ private set {} } // 0x00000001832EC150-0x00000001832EC1F0 0x00000001832ECD10-0x00000001832ECDC0
	public Dictionary<int, ConfigCutsceneContext> platform { /* [XID] */ /* 0x0000000189AB7870-0x0000000189AB7890 */ get => default; /* [XID] */ /* 0x0000000189ABF270-0x0000000189ABF290 */ private set {} } // 0x00000001832EC0B0-0x00000001832EC150 0x00000001832EC960-0x00000001832ECA10

	// Constructors
	public ConfigCutsceneIndex() {} // 0x00000001832ED340-0x00000001832ED3A0

	// Methods
	// [XID] // 0x0000000189AC6C80-0x0000000189AC6CA0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001832ED050-0x00000001832ED160
	// [XID] // 0x0000000189ACE4B0-0x0000000189ACE4D0
	public void InitEmpty() {} // 0x00000001832EC870-0x00000001832EC960
	[BlackList] // 0x0000000189AD6300-0x0000000189AD6340
	// [XID] // 0x0000000189AD6300-0x0000000189AD6340
	public bool FromJson(JSONNode node) => default; // 0x00000001832EC4F0-0x00000001832EC870
	// [XID] // 0x0000000189AE0CC0-0x0000000189AE0CE0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001832EB900-0x00000001832EBBF0
	// [XID] // 0x0000000189AE81B0-0x0000000189AE81D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7C1F */, bool useObjectPool = false /* Metadata: 0x00AF7C23 */) => default; // 0x00000001832ECA10-0x00000001832ECD10
	// [XID] // 0x0000000189AF0030-0x0000000189AF0050
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7C24 */, bool useObjectPool = false /* Metadata: 0x00AF7C28 */) => default; // 0x00000001832EC1F0-0x00000001832EC4F0
	[BlackList] // 0x0000000189AF74E0-0x0000000189AF7520
	// [XID] // 0x0000000189AF74E0-0x0000000189AF7520
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001832EBBF0-0x00000001832EBEC0
	// [XID] // 0x0000000189B01B90-0x0000000189B01BB0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001832ECDC0-0x00000001832ED050
	[BlackList] // 0x0000000189B09150-0x0000000189B09190
	// [XID] // 0x0000000189B09150-0x0000000189B09190
	public virtual void AutoAllocTypeFields() {} // 0x00000001832EBEC0-0x00000001832EBF60
	[BlackList] // 0x0000000189B137B0-0x0000000189B137F0
	// [XID] // 0x0000000189B137B0-0x0000000189B137F0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001832EBF60-0x00000001832EC0B0
	[BlackList] // 0x0000000189B1DBF0-0x0000000189B1DC30
	// [XID] // 0x0000000189B1DBF0-0x0000000189B1DC30
	public virtual void ReturnToObjectPool() {} // 0x00000001832ED2A0-0x00000001832ED340
	[BlackList] // 0x0000000189B282D0-0x0000000189B28310
	// [XID] // 0x0000000189B282D0-0x0000000189B28310
	public virtual void OnPoolAllocated() {} // 0x00000001832ED200-0x00000001832ED2A0
	[BlackList] // 0x0000000189B32780-0x0000000189B327C0
	// [XID] // 0x0000000189B32780-0x0000000189B327C0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001832ED160-0x00000001832ED200
}

