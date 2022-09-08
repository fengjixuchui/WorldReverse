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
public class UrgentHotFixMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17137
{
	// Fields
	private SimpleSafeUInt32 logicIdRawNum; // 0x30
	private SimpleSafeFloat thinkIntervalRawNum; // 0x34
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityAction[] _actionList; // 0x38

	// Properties
	public uint logicId { /* [XID] */ /* 0x0000000189851330-0x0000000189851350 */ get => default; /* [XID] */ /* 0x00000001898587E0-0x0000000189858800 */ private set {} } // 0x00000001851DB0C0-0x00000001851DB190 0x00000001851DC1A0-0x00000001851DC280
	public float thinkInterval { /* [XID] */ /* 0x000000018985F8D0-0x000000018985F8F0 */ get => default; /* [XID] */ /* 0x00000001898670D0-0x00000001898670F0 */ private set {} } // 0x00000001851DA1B0-0x00000001851DA290 0x00000001851DBD50-0x00000001851DBE30
	public ConfigAbilityAction[] actionList { /* [XID] */ /* 0x000000018986E8F0-0x000000018986E910 */ get => default; /* [XID] */ /* 0x0000000189875DE0-0x0000000189875E00 */ private set {} } // 0x00000001851DA870-0x00000001851DA910 0x00000001851DA6C0-0x00000001851DA770
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001898F9650-0x00000001898F9670 */ get => default; } // 0x00000001851DA910-0x00000001851DA9B0 

	// Constructors
	public UrgentHotFixMixin() {} // 0x00000001851DC450-0x00000001851DC4B0

	// Methods
	// [XID] // 0x000000018987D9E0-0x000000018987DA00
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001851DC280-0x00000001851DC3B0
	// [XID] // 0x00000001898848D0-0x00000001898848F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001851DBC70-0x00000001851DBD50
	// [XID] // 0x000000018988BF00-0x000000018988BF20
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6461 */) => default; // 0x00000001851DB880-0x00000001851DB960
	// [XID] // 0x0000000189893590-0x00000001898935B0
	public override int GetHashNum() => default; // 0x00000001851DA080-0x00000001851DA150
	// [XID] // 0x000000018989AC50-0x000000018989AC70
	public override void InitEmpty() {} // 0x00000001851DB190-0x00000001851DB2D0
	[BlackList] // 0x00000001898A1F80-0x00000001898A1FC0
	// [XID] // 0x00000001898A1F80-0x00000001898A1FC0
	public override bool FromJson(JSONNode node) => default; // 0x00000001851DA9B0-0x00000001851DAD30
	// [XID] // 0x00000001898AC6A0-0x00000001898AC6C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001851D9660-0x00000001851D9AD0
	[BlackList] // 0x00000001898B3C00-0x00000001898B3C40
	// [XID] // 0x00000001898B3C00-0x00000001898B3C40
	public static new UrgentHotFixMixin ParseFromJson(JSONNode node) => default; // 0x00000001851DB9C0-0x00000001851DBC10
	// [XID] // 0x00000001898BE520-0x00000001898BE540
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6462 */, bool useObjectPool = false /* Metadata: 0x00AF6466 */) => default; // 0x00000001851DB4A0-0x00000001851DB7A0
	// [XID] // 0x00000001898C5D10-0x00000001898C5D30
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6467 */, bool useObjectPool = false /* Metadata: 0x00AF646B */) => default; // 0x00000001851DA310-0x00000001851DA6C0
	// [XID] // 0x00000001898CD520-0x00000001898CD540
	public static new UrgentHotFixMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF646C */, bool useObjectPool = false /* Metadata: 0x00AF6470 */) => default; // 0x00000001851DADA0-0x00000001851DAFC0
	[BlackList] // 0x00000001898D4F30-0x00000001898D4F70
	// [XID] // 0x00000001898D4F30-0x00000001898D4F70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001851D9AD0-0x00000001851D9DA0
	// [XID] // 0x00000001898DFBE0-0x00000001898DFC00
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001851DBE30-0x00000001851DC1A0
	[BlackList] // 0x00000001898E7630-0x00000001898E7670
	// [XID] // 0x00000001898E7630-0x00000001898E7670
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001851DB3B0-0x00000001851DB4A0
	// [XID] // 0x00000001898F1DB0-0x00000001898F1DD0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001851DB7A0-0x00000001851DB880
	[BlackList] // 0x0000000189901070-0x00000001899010B0
	// [XID] // 0x0000000189901070-0x00000001899010B0
	public override void AutoAllocTypeFields() {} // 0x00000001851D9DA0-0x00000001851D9E40
	[BlackList] // 0x000000018990B4F0-0x000000018990B530
	// [XID] // 0x000000018990B4F0-0x000000018990B530
	public override void AutoRecycleTypeFields() {} // 0x00000001851D9E40-0x00000001851D9F60
	[BlackList] // 0x0000000189915E20-0x0000000189915E60
	// [XID] // 0x0000000189915E20-0x0000000189915E60
	public override void ReturnToObjectPool() {} // 0x00000001851DC3B0-0x00000001851DC450
}

