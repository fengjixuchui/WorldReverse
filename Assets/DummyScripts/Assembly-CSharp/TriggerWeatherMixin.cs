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
public class TriggerWeatherMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16981
{
	// Fields
	private TriggerWeatherType _type; // 0x30
	private SimpleSafeUInt32 areaIdRawNum; // 0x34
	private string _weatherPattern; // 0x38
	private SimpleSafeFloat transDurationRawNum; // 0x40
	private SimpleSafeFloat durationRawNum; // 0x44

	// Properties
	public TriggerWeatherType type { /* [XID] */ /* 0x0000000189A81C50-0x0000000189A81C70 */ get => default; /* [XID] */ /* 0x0000000189A896B0-0x0000000189A896D0 */ private set {} } // 0x0000000184752BD0-0x0000000184752C70 0x0000000184752490-0x0000000184752540
	public uint areaId { /* [XID] */ /* 0x0000000189A90E70-0x0000000189A90E90 */ get => default; /* [XID] */ /* 0x0000000189A986A0-0x0000000189A986C0 */ private set {} } // 0x00000001847517F0-0x00000001847518C0 0x0000000184750330-0x0000000184750410
	public string weatherPattern { /* [XID] */ /* 0x0000000189A9FAB0-0x0000000189A9FAD0 */ get => default; /* [XID] */ /* 0x0000000189AA7220-0x0000000189AA7240 */ private set {} } // 0x00000001847506E0-0x0000000184750780 0x0000000184750860-0x0000000184750910
	public float transDuration { /* [XID] */ /* 0x0000000189AAE920-0x0000000189AAE940 */ get => default; /* [XID] */ /* 0x0000000189AB6280-0x0000000189AB62A0 */ private set {} } // 0x0000000184750E60-0x0000000184750F40 0x0000000184752990-0x0000000184752A70
	public float duration { /* [XID] */ /* 0x0000000189ABDCB0-0x0000000189ABDCD0 */ get => default; /* [XID] */ /* 0x0000000189AC5830-0x0000000189AC5850 */ private set {} } // 0x00000001847504B0-0x0000000184750590 0x0000000184750D80-0x0000000184750E60
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189B495A0-0x0000000189B495C0 */ get => default; } // 0x0000000184751040-0x00000001847510E0 

	// Constructors
	public TriggerWeatherMixin() {} // 0x0000000184752D10-0x0000000184752DC0

	// Methods
	// [XID] // 0x0000000189ACCD00-0x0000000189ACCD20
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184752A70-0x0000000184752BD0
	// [XID] // 0x0000000189AD4A20-0x0000000189AD4A40
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001847523B0-0x0000000184752490
	// [XID] // 0x0000000189ADC380-0x0000000189ADC3A0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5F6B */) => default; // 0x0000000184751FC0-0x00000001847520A0
	// [XID] // 0x0000000189AE3D70-0x0000000189AE3D90
	public override int GetHashNum() => default; // 0x0000000184750610-0x00000001847506E0
	// [XID] // 0x0000000189AEB5B0-0x0000000189AEB5D0
	public override void InitEmpty() {} // 0x00000001847518C0-0x0000000184751A10
	[BlackList] // 0x0000000189AF2F10-0x0000000189AF2F50
	// [XID] // 0x0000000189AF2F10-0x0000000189AF2F50
	public override bool FromJson(JSONNode node) => default; // 0x00000001847510E0-0x0000000184751460
	// [XID] // 0x0000000189AFD350-0x0000000189AFD370
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018474F860-0x000000018474FE90
	[BlackList] // 0x0000000189B04B80-0x0000000189B04BC0
	// [XID] // 0x0000000189B04B80-0x0000000189B04BC0
	public static new TriggerWeatherMixin ParseFromJson(JSONNode node) => default; // 0x0000000184752100-0x0000000184752350
	// [XID] // 0x0000000189B0F330-0x0000000189B0F350
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F6C */, bool useObjectPool = false /* Metadata: 0x00AF5F70 */) => default; // 0x0000000184751BE0-0x0000000184751EE0
	// [XID] // 0x0000000189B16650-0x0000000189B16670
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F71 */, bool useObjectPool = false /* Metadata: 0x00AF5F75 */) => default; // 0x0000000184750910-0x0000000184750D80
	// [XID] // 0x0000000189B1DD10-0x0000000189B1DD30
	public static new TriggerWeatherMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5F76 */, bool useObjectPool = false /* Metadata: 0x00AF5F7A */) => default; // 0x00000001847514D0-0x00000001847516F0
	[BlackList] // 0x0000000189B25520-0x0000000189B25560
	// [XID] // 0x0000000189B25520-0x0000000189B25560
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018474FE90-0x0000000184750160
	// [XID] // 0x0000000189B2F750-0x0000000189B2F770
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184752540-0x0000000184752990
	[BlackList] // 0x0000000189B37010-0x0000000189B37050
	// [XID] // 0x0000000189B37010-0x0000000189B37050
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184751AF0-0x0000000184751BE0
	// [XID] // 0x0000000189B41C10-0x0000000189B41C30
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000184751EE0-0x0000000184751FC0
	[BlackList] // 0x0000000189B50C00-0x0000000189B50C40
	// [XID] // 0x0000000189B50C00-0x0000000189B50C40
	public override void AutoAllocTypeFields() {} // 0x0000000184750160-0x0000000184750200
	[BlackList] // 0x0000000189B5B310-0x0000000189B5B350
	// [XID] // 0x0000000189B5B310-0x0000000189B5B350
	public override void AutoRecycleTypeFields() {} // 0x0000000184750200-0x0000000184750330
	[BlackList] // 0x0000000189B65AC0-0x0000000189B65B00
	// [XID] // 0x0000000189B65AC0-0x0000000189B65B00
	public override void ReturnToObjectPool() {} // 0x0000000184752C70-0x0000000184752D10
}

