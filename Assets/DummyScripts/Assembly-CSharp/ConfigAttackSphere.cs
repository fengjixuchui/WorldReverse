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
public class ConfigAttackSphere : ConfigSimpleAttackPattern, IAutoAllocRecycle // TypeDefIndex: 17544
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _radius; // 0x40

	// Properties
	public DynamicFloat radius { /* [XID] */ /* 0x00000001896C9D50-0x00000001896C9D70 */ get => default; /* [XID] */ /* 0x0000000189B9D8E0-0x0000000189B9D900 */ private set {} } // 0x0000000182384D30-0x0000000182384DD0 0x00000001823850E0-0x0000000182385190

	// Constructors
	public ConfigAttackSphere() {} // 0x0000000182385230-0x0000000182385290

	// Methods
	// [XID] // 0x0000000189BA5370-0x0000000189BA5390
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182385000-0x00000001823850E0
	// [XID] // 0x0000000189BAC470-0x0000000189BAC490
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182384C50-0x0000000182384D30
	// [XID] // 0x0000000189BB3D90-0x0000000189BB3DB0
	public override ConfigBaseAttackPattern Clone(bool useObjectPool = false /* Metadata: 0x00AF7259 */) => default; // 0x0000000182384860-0x0000000182384940
	// [XID] // 0x0000000189BBB390-0x0000000189BBB3B0
	public override int GetHashNum() => default; // 0x0000000182383760-0x0000000182383830
	// [XID] // 0x0000000189BC3190-0x0000000189BC31B0
	public override void InitEmpty() {} // 0x00000001823842C0-0x0000000182384390
	[BlackList] // 0x0000000189BCA9F0-0x0000000189BCAA30
	// [XID] // 0x0000000189BCA9F0-0x0000000189BCAA30
	public override bool FromJson(JSONNode node) => default; // 0x0000000182383CB0-0x0000000182384030
	// [XID] // 0x0000000189BD4DF0-0x0000000189BD4E10
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182382F60-0x00000001823831A0
	[BlackList] // 0x0000000189BDC940-0x0000000189BDC980
	// [XID] // 0x0000000189BDC940-0x0000000189BDC980
	public static new ConfigAttackSphere ParseFromJson(JSONNode node) => default; // 0x00000001823849A0-0x0000000182384BF0
	// [XID] // 0x00000001895EC4B0-0x00000001895EC4D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF725A */, bool useObjectPool = false /* Metadata: 0x00AF725E */) => default; // 0x0000000182384560-0x0000000182384860
	// [XID] // 0x00000001895F3910-0x00000001895F3930
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF725F */, bool useObjectPool = false /* Metadata: 0x00AF7263 */) => default; // 0x0000000182383910-0x0000000182383BB0
	// [XID] // 0x00000001895FB210-0x00000001895FB230
	public static new ConfigAttackSphere ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7264 */, bool useObjectPool = false /* Metadata: 0x00AF7268 */) => default; // 0x0000000182384030-0x0000000182384250
	[BlackList] // 0x00000001896029D0-0x0000000189602A10
	// [XID] // 0x00000001896029D0-0x0000000189602A10
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001823831A0-0x0000000182383470
	// [XID] // 0x000000018960D240-0x000000018960D260
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182384DD0-0x0000000182385000
	[BlackList] // 0x0000000189614940-0x0000000189614980
	// [XID] // 0x0000000189614940-0x0000000189614980
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182384470-0x0000000182384560
	[BlackList] // 0x000000018961F2A0-0x000000018961F2E0
	// [XID] // 0x000000018961F2A0-0x000000018961F2E0
	public override void AutoAllocTypeFields() {} // 0x0000000182383470-0x0000000182383510
	[BlackList] // 0x0000000189629950-0x0000000189629990
	// [XID] // 0x0000000189629950-0x0000000189629990
	public override void AutoRecycleTypeFields() {} // 0x0000000182383510-0x0000000182383640
	[BlackList] // 0x0000000189634170-0x00000001896341B0
	// [XID] // 0x0000000189634170-0x00000001896341B0
	public override void ReturnToObjectPool() {} // 0x0000000182385190-0x0000000182385230
}

