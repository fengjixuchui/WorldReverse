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
public class MusicEnemySettings : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17596
{
	// Fields
	private SimpleSafeUInt32 entityIdRawNum; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _mainStateValue; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _auxStateGroup; // 0x20
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _defaultAuxStateValue; // 0x28
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private MusicEnemyCombatPhaseState[] _combatPhaseStates; // 0x30

	// Properties
	public uint entityId { /* [XID] */ /* 0x0000000189BA98E0-0x0000000189BA9900 */ get => default; /* [XID] */ /* 0x0000000189BB1070-0x0000000189BB1090 */ private set {} } // 0x00000001828CF2D0-0x00000001828CF3A0 0x00000001828CF0A0-0x00000001828CF180
	public ConfigWwiseString mainStateValue { /* [XID] */ /* 0x0000000189BB8220-0x0000000189BB8240 */ get => default; /* [XID] */ /* 0x0000000189BBF910-0x0000000189BBF930 */ private set {} } // 0x00000001828CF230-0x00000001828CF2D0 0x00000001828CFCC0-0x00000001828CFD70
	public ConfigWwiseString auxStateGroup { /* [XID] */ /* 0x0000000189BC7580-0x0000000189BC75A0 */ get => default; /* [XID] */ /* 0x0000000189BCF270-0x0000000189BCF290 */ private set {} } // 0x00000001828CEAD0-0x00000001828CEB70 0x00000001828CF180-0x00000001828CF230
	public ConfigWwiseString defaultAuxStateValue { /* [XID] */ /* 0x00000001896600C0-0x00000001896600E0 */ get => default; /* [XID] */ /* 0x0000000189BDE180-0x0000000189BDE1A0 */ private set {} } // 0x00000001828CFD70-0x00000001828CFE10 0x00000001828CFC10-0x00000001828CFCC0
	public MusicEnemyCombatPhaseState[] combatPhaseStates { /* [XID] */ /* 0x00000001895EAC50-0x00000001895EAC70 */ get => default; /* [XID] */ /* 0x00000001895F2130-0x00000001895F2150 */ private set {} } // 0x00000001828CEA30-0x00000001828CEAD0 0x00000001828CF3A0-0x00000001828CF450

	// Constructors
	public MusicEnemySettings() {} // 0x00000001828D0610-0x00000001828D06D0

	// Methods
	// [XID] // 0x00000001895F9A60-0x00000001895F9A80
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001828D02A0-0x00000001828D0430
	// [XID] // 0x00000001896011E0-0x0000000189601200
	public void InitEmpty() {} // 0x00000001828CF7D0-0x00000001828CF910
	[BlackList] // 0x0000000189608BF0-0x0000000189608C30
	// [XID] // 0x0000000189608BF0-0x0000000189608C30
	public bool FromJson(JSONNode node) => default; // 0x00000001828CF450-0x00000001828CF7D0
	// [XID] // 0x00000001896130E0-0x0000000189613100
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001828CDE60-0x00000001828CE460
	// [XID] // 0x000000018961A900-0x000000018961A920
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7433 */, bool useObjectPool = false /* Metadata: 0x00AF7437 */) => default; // 0x00000001828CF910-0x00000001828CFC10
	// [XID] // 0x0000000189621F40-0x0000000189621F60
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7438 */, bool useObjectPool = false /* Metadata: 0x00AF743C */) => default; // 0x00000001828CEB70-0x00000001828CF0A0
	[BlackList] // 0x0000000189629910-0x0000000189629950
	// [XID] // 0x0000000189629910-0x0000000189629950
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001828CE460-0x00000001828CE730
	// [XID] // 0x0000000189634150-0x0000000189634170
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001828CFE10-0x00000001828D02A0
	[BlackList] // 0x000000018963B9A0-0x000000018963B9E0
	// [XID] // 0x000000018963B9A0-0x000000018963B9E0
	public virtual void AutoAllocTypeFields() {} // 0x00000001828CE730-0x00000001828CE7D0
	[BlackList] // 0x0000000189645FA0-0x0000000189645FE0
	// [XID] // 0x0000000189645FA0-0x0000000189645FE0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001828CE7D0-0x00000001828CEA30
	[BlackList] // 0x00000001896507B0-0x00000001896507F0
	// [XID] // 0x00000001896507B0-0x00000001896507F0
	public virtual void ReturnToObjectPool() {} // 0x00000001828D0570-0x00000001828D0610
	[BlackList] // 0x000000018965B090-0x000000018965B0D0
	// [XID] // 0x000000018965B090-0x000000018965B0D0
	public virtual void OnPoolAllocated() {} // 0x00000001828D04D0-0x00000001828D0570
	[BlackList] // 0x0000000189665550-0x0000000189665590
	// [XID] // 0x0000000189665550-0x0000000189665590
	public virtual void OnBeforePoolRecycled() {} // 0x00000001828D0430-0x00000001828D04D0
}

