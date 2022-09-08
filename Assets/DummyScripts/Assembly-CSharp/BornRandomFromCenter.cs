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
public class BornRandomFromCenter : BornRandom, IAutoAllocRecycle // TypeDefIndex: 17851
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _minRandomRange; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _maxRandomRange; // 0x18

	// Properties
	public DynamicFloat minRandomRange { /* [XID] */ /* 0x0000000189A3B890-0x0000000189A3B8B0 */ get => default; /* [XID] */ /* 0x0000000189AA58E0-0x0000000189AA5900 */ private set {} } // 0x00000001846598C0-0x0000000184659960 0x000000018465A7A0-0x000000018465A850
	public DynamicFloat maxRandomRange { /* [XID] */ /* 0x0000000189AACF40-0x0000000189AACF60 */ get => default; /* [XID] */ /* 0x0000000189AB4850-0x0000000189AB4870 */ private set {} } // 0x00000001846593C0-0x0000000184659460 0x0000000184659D60-0x0000000184659E10

	// Constructors
	public BornRandomFromCenter() {} // 0x000000018465B080-0x000000018465B0E0

	// Methods
	// [XID] // 0x0000000189ABC5A0-0x0000000189ABC5C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018465AED0-0x000000018465AFE0
	// [XID] // 0x0000000189AC3F60-0x0000000189AC3F80
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018465AB00-0x000000018465AC00
	// [XID] // 0x0000000189ACB3F0-0x0000000189ACB410
	public override BornRandom Clone(bool useObjectPool = false /* Metadata: 0x00AF7F09 */) => default; // 0x000000018465A660-0x000000018465A740
	// [XID] // 0x0000000189AD2EA0-0x0000000189AD2EC0
	public override int GetHashNum() => default; // 0x0000000184659290-0x0000000184659360
	// [XID] // 0x0000000189ADA8C0-0x0000000189ADA8E0
	public override void InitEmpty() {} // 0x000000018465A0A0-0x000000018465A190
	[BlackList] // 0x0000000189AE2100-0x0000000189AE2140
	// [XID] // 0x0000000189AE2100-0x0000000189AE2140
	public override bool FromJson(JSONNode node) => default; // 0x00000001846599E0-0x0000000184659D60
	// [XID] // 0x0000000189AECAC0-0x0000000189AECAE0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184658910-0x0000000184658C50
	[BlackList] // 0x0000000189AF4490-0x0000000189AF44D0
	// [XID] // 0x0000000189AF4490-0x0000000189AF44D0
	public static new BornRandomFromCenter ParseFromJson(JSONNode node) => default; // 0x000000018465A850-0x000000018465AAA0
	// [XID] // 0x0000000189AFEBF0-0x0000000189AFEC10
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7F0A */, bool useObjectPool = false /* Metadata: 0x00AF7F0E */) => default; // 0x000000018465A360-0x000000018465A660
	// [XID] // 0x0000000189B06360-0x0000000189B06380
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7F0F */, bool useObjectPool = false /* Metadata: 0x00AF7F13 */) => default; // 0x00000001846594E0-0x0000000184659840
	// [XID] // 0x0000000189B0DAD0-0x0000000189B0DAF0
	public static new BornRandomFromCenter ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7F14 */, bool useObjectPool = false /* Metadata: 0x00AF7F18 */) => default; // 0x0000000184659E10-0x000000018465A030
	[BlackList] // 0x0000000189B14EF0-0x0000000189B14F30
	// [XID] // 0x0000000189B14EF0-0x0000000189B14F30
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184658C50-0x0000000184658F20
	// [XID] // 0x0000000189B1F5C0-0x0000000189B1F5E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018465AC00-0x000000018465AED0
	[BlackList] // 0x0000000189B26E20-0x0000000189B26E60
	// [XID] // 0x0000000189B26E20-0x0000000189B26E60
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018465A270-0x000000018465A360
	[BlackList] // 0x0000000189B30F90-0x0000000189B30FD0
	// [XID] // 0x0000000189B30F90-0x0000000189B30FD0
	public override void AutoAllocTypeFields() {} // 0x0000000184658F20-0x0000000184658FC0
	[BlackList] // 0x0000000189B3B670-0x0000000189B3B6B0
	// [XID] // 0x0000000189B3B670-0x0000000189B3B6B0
	public override void AutoRecycleTypeFields() {} // 0x0000000184658FC0-0x0000000184659170
	[BlackList] // 0x0000000189B462A0-0x0000000189B462E0
	// [XID] // 0x0000000189B462A0-0x0000000189B462E0
	public override void ReturnToObjectPool() {} // 0x000000018465AFE0-0x000000018465B080
}

