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
public class ConfigGlobalLockTarget : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18110
{
	// Fields
	private SimpleSafeFloat lockWeightOutCameraParamRawNum; // 0x10
	private SimpleSafeFloat lockWeightRelockParamRawNum; // 0x14
	private SimpleSafeFloat clearLockTargetOutCombatRawNum; // 0x18
	private SimpleSafeFloat clearLockTargetInCombatRawNum; // 0x1C
	private SimpleSafeFloat forceLockTargetInCombatRawNum; // 0x20

	// Properties
	public float lockWeightOutCameraParam { /* [XID] */ /* 0x0000000189B53800-0x0000000189B53820 */ get => default; /* [XID] */ /* 0x0000000189B5B030-0x0000000189B5B050 */ private set {} } // 0x0000000181FB6560-0x0000000181FB6640 0x0000000181FB6480-0x0000000181FB6560
	public float lockWeightRelockParam { /* [XID] */ /* 0x0000000189B624D0-0x0000000189B624F0 */ get => default; /* [XID] */ /* 0x0000000189B6A110-0x0000000189B6A130 */ private set {} } // 0x0000000181FB4AB0-0x0000000181FB4B90 0x0000000181FB6100-0x0000000181FB61E0
	public float clearLockTargetOutCombat { /* [XID] */ /* 0x000000018969AFF0-0x000000018969B010 */ get => default; /* [XID] */ /* 0x0000000189B78CE0-0x0000000189B78D00 */ private set {} } // 0x0000000181FB5200-0x0000000181FB52E0 0x0000000181FB5740-0x0000000181FB5820
	public float clearLockTargetInCombat { /* [XID] */ /* 0x0000000189B80150-0x0000000189B80170 */ get => default; /* [XID] */ /* 0x0000000189B87C20-0x0000000189B87C40 */ private set {} } // 0x0000000181FB5C40-0x0000000181FB5D20 0x0000000181FB52E0-0x0000000181FB53C0
	public float forceLockTargetInCombat { /* [XID] */ /* 0x000000018993EF30-0x000000018993EF50 */ get => default; /* [XID] */ /* 0x0000000189B962E0-0x0000000189B96300 */ private set {} } // 0x0000000181FB40F0-0x0000000181FB41D0 0x0000000181FB4B90-0x0000000181FB4C70

	// Constructors
	public ConfigGlobalLockTarget() {} // 0x0000000181FB66E0-0x0000000181FB67D0

	// Methods
	// [XID] // 0x0000000189B9D800-0x0000000189B9D820
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181FB61E0-0x0000000181FB6340
	// [XID] // 0x0000000189BA5290-0x0000000189BA52B0
	public void InitEmpty() {} // 0x0000000181FB5820-0x0000000181FB5940
	[BlackList] // 0x0000000189BAC430-0x0000000189BAC470
	// [XID] // 0x0000000189BAC430-0x0000000189BAC470
	public bool FromJson(JSONNode node) => default; // 0x0000000181FB53C0-0x0000000181FB5740
	// [XID] // 0x0000000189BB6A30-0x0000000189BB6A50
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181FB41D0-0x0000000181FB47E0
	// [XID] // 0x0000000189BBE090-0x0000000189BBE0B0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B63 */, bool useObjectPool = false /* Metadata: 0x00AF8B67 */) => default; // 0x0000000181FB5940-0x0000000181FB5C40
	// [XID] // 0x0000000189BC5D60-0x0000000189BC5D80
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B68 */, bool useObjectPool = false /* Metadata: 0x00AF8B6C */) => default; // 0x0000000181FB4E30-0x0000000181FB5200
	[BlackList] // 0x0000000189BCD7E0-0x0000000189BCD820
	// [XID] // 0x0000000189BCD7E0-0x0000000189BCD820
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181FB47E0-0x0000000181FB4AB0
	// [XID] // 0x0000000189BD7BD0-0x0000000189BD7BF0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181FB5D20-0x0000000181FB6100
	[BlackList] // 0x0000000189BDF800-0x0000000189BDF840
	// [XID] // 0x0000000189BDF800-0x0000000189BDF840
	public virtual void AutoAllocTypeFields() {} // 0x0000000181FB4C70-0x0000000181FB4D10
	[BlackList] // 0x00000001895EF1A0-0x00000001895EF1E0
	// [XID] // 0x00000001895EF1A0-0x00000001895EF1E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181FB4D10-0x0000000181FB4E30
	[BlackList] // 0x00000001895F9940-0x00000001895F9980
	// [XID] // 0x00000001895F9940-0x00000001895F9980
	public virtual void ReturnToObjectPool() {} // 0x0000000181FB6640-0x0000000181FB66E0
	[BlackList] // 0x0000000189604250-0x0000000189604290
	// [XID] // 0x0000000189604250-0x0000000189604290
	public virtual void OnPoolAllocated() {} // 0x0000000181FB63E0-0x0000000181FB6480
	[BlackList] // 0x000000018960EA60-0x000000018960EAA0
	// [XID] // 0x000000018960EA60-0x000000018960EAA0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181FB6340-0x0000000181FB63E0
}

