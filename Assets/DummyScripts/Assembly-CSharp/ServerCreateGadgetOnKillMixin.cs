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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ServerCreateGadgetOnKillMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17104
{
	// Fields
	private SimpleSafeUInt32[] _gadgetIDList; // 0x30
	private SimpleSafeUInt32 campIDRawNum; // 0x38
	private TargetType _campTargetType; // 0x3C
	private bool _randomCreate; // 0x40
	private bool _useOriginOwnerAsGadgetOwner; // 0x41

	// Properties
	public SimpleSafeUInt32[] gadgetIDList { /* [XID] */ /* 0x0000000189819090-0x00000001898190B0 */ get => default; /* [XID] */ /* 0x00000001898208B0-0x00000001898208D0 */ private set {} } // 0x0000000183A0F210-0x0000000183A0F2B0 0x0000000183A10770-0x0000000183A10820
	public uint campID { /* [XID] */ /* 0x0000000189827EC0-0x0000000189827EE0 */ get => default; /* [XID] */ /* 0x000000018982F1C0-0x000000018982F1E0 */ private set {} } // 0x0000000183A10AD0-0x0000000183A10BA0 0x0000000183A0EF00-0x0000000183A0EFE0
	public TargetType campTargetType { /* [XID] */ /* 0x0000000189836A50-0x0000000189836A70 */ get => default; /* [XID] */ /* 0x000000018983DEE0-0x000000018983DF00 */ private set {} } // 0x0000000183A10BA0-0x0000000183A10C40 0x0000000183A114B0-0x0000000183A11560
	public bool randomCreate { /* [XID] */ /* 0x00000001898456F0-0x0000000189845710 */ get => default; /* [XID] */ /* 0x000000018984CC40-0x000000018984CC60 */ private set {} } // 0x0000000183A0F040-0x0000000183A0F0E0 0x0000000183A0F0E0-0x0000000183A0F190
	public bool useOriginOwnerAsGadgetOwner { /* [XID] */ /* 0x0000000189853C40-0x0000000189853C60 */ get => default; /* [XID] */ /* 0x000000018985B6F0-0x000000018985B710 */ private set {} } // 0x0000000183A10D80-0x0000000183A10E20 0x0000000183A112A0-0x0000000183A11350
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001898DE480-0x00000001898DE4A0 */ get => default; } // 0x0000000183A0F820-0x0000000183A0F8C0 

	// Constructors
	public ServerCreateGadgetOnKillMixin() {} // 0x0000000183A11600-0x0000000183A11670

	// Methods
	// [XID] // 0x0000000189862CB0-0x0000000189862CD0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183A11350-0x0000000183A114B0
	// [XID] // 0x000000018986A100-0x000000018986A120
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183A10CA0-0x0000000183A10D80
	// [XID] // 0x0000000189871470-0x0000000189871490
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6363 */) => default; // 0x0000000183A10690-0x0000000183A10770
	// [XID] // 0x0000000189878E10-0x0000000189878E30
	public override int GetHashNum() => default; // 0x0000000183A0EE30-0x0000000183A0EF00
	// [XID] // 0x0000000189880440-0x0000000189880460
	public override void InitEmpty() {} // 0x0000000183A0FFD0-0x0000000183A100E0
	[BlackList] // 0x0000000189887960-0x00000001898879A0
	// [XID] // 0x0000000189887960-0x00000001898879A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183A0F8C0-0x0000000183A0FC40
	// [XID] // 0x0000000189891BC0-0x0000000189891BE0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183A0E330-0x0000000183A0E8C0
	[BlackList] // 0x00000001898994B0-0x00000001898994F0
	// [XID] // 0x00000001898994B0-0x00000001898994F0
	public static new ServerCreateGadgetOnKillMixin ParseFromJson(JSONNode node) => default; // 0x0000000183A10880-0x0000000183A10AD0
	// [XID] // 0x00000001898A37C0-0x00000001898A37E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6364 */, bool useObjectPool = false /* Metadata: 0x00AF6368 */) => default; // 0x0000000183A102B0-0x0000000183A105B0
	// [XID] // 0x00000001898AAC00-0x00000001898AAC20
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6369 */, bool useObjectPool = false /* Metadata: 0x00AF636D */) => default; // 0x0000000183A0F2B0-0x0000000183A0F720
	// [XID] // 0x00000001898B24F0-0x00000001898B2510
	public static new ServerCreateGadgetOnKillMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF636E */, bool useObjectPool = false /* Metadata: 0x00AF6372 */) => default; // 0x0000000183A0FCB0-0x0000000183A0FED0
	[BlackList] // 0x00000001898BA300-0x00000001898BA340
	// [XID] // 0x00000001898BA300-0x00000001898BA340
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183A0E8C0-0x0000000183A0EB90
	// [XID] // 0x00000001898C47C0-0x00000001898C47E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183A10E20-0x0000000183A112A0
	[BlackList] // 0x00000001898CBDB0-0x00000001898CBDF0
	// [XID] // 0x00000001898CBDB0-0x00000001898CBDF0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183A101C0-0x0000000183A102B0
	// [XID] // 0x00000001898D67E0-0x00000001898D6800
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183A105B0-0x0000000183A10690
	[BlackList] // 0x00000001898E5C60-0x00000001898E5CA0
	// [XID] // 0x00000001898E5C60-0x00000001898E5CA0
	public override void AutoAllocTypeFields() {} // 0x0000000183A0EB90-0x0000000183A0EC30
	[BlackList] // 0x00000001898F0540-0x00000001898F0580
	// [XID] // 0x00000001898F0540-0x00000001898F0580
	public override void AutoRecycleTypeFields() {} // 0x0000000183A0EC30-0x0000000183A0ED10
	[BlackList] // 0x00000001898FABC0-0x00000001898FAC00
	// [XID] // 0x00000001898FABC0-0x00000001898FAC00
	public override void ReturnToObjectPool() {} // 0x0000000183A11560-0x0000000183A11600
}

