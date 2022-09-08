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
public class CircleBarrageMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17143
{
	// Fields
	private SimpleSafeUInt32 bulletIDRawNum; // 0x30
	private SimpleSafeFloat innerRadiusRawNum; // 0x34
	private SimpleSafeInt32 cutNumRawNum; // 0x38
	private SimpleSafeInt32 waveNumRawNum; // 0x3C
	private SimpleSafeFloat waveCDRawNum; // 0x40
	private SimpleSafeInt32 wavebulletNumRawNum; // 0x44
	private SimpleSafeFloat waveangleRawNum; // 0x48
	private SimpleSafeFloat triggerCDRawNum; // 0x4C
	private string _shootPoint; // 0x50

	// Properties
	public uint bulletID { /* [XID] */ /* 0x0000000189B746F0-0x0000000189B74710 */ get => default; /* [XID] */ /* 0x0000000189B7BD50-0x0000000189B7BD70 */ private set {} } // 0x000000018579A930-0x000000018579AA00 0x000000018579B1B0-0x000000018579B290
	public float innerRadius { /* [XID] */ /* 0x0000000189B835E0-0x0000000189B83600 */ get => default; /* [XID] */ /* 0x0000000189B8AA10-0x0000000189B8AA30 */ private set {} } // 0x000000018579CCF0-0x000000018579CDD0 0x000000018579E100-0x000000018579E1E0
	public int cutNum { /* [XID] */ /* 0x0000000189B92000-0x0000000189B92020 */ get => default; /* [XID] */ /* 0x0000000189B99500-0x0000000189B99520 */ private set {} } // 0x000000018579CC20-0x000000018579CCF0 0x000000018579D760-0x000000018579D840
	public int waveNum { /* [XID] */ /* 0x0000000189BA09F0-0x0000000189BA0A10 */ get => default; /* [XID] */ /* 0x0000000189BA80F0-0x0000000189BA8110 */ private set {} } // 0x000000018579BAE0-0x000000018579BBB0 0x000000018579D920-0x000000018579DA00
	public float waveCD { /* [XID] */ /* 0x0000000189BAF580-0x0000000189BAF5A0 */ get => default; /* [XID] */ /* 0x0000000189BB6C30-0x0000000189BB6C50 */ private set {} } // 0x000000018579E3B0-0x000000018579E490 0x000000018579C9F0-0x000000018579CAD0
	public int wavebulletNum { /* [XID] */ /* 0x0000000189BBE2D0-0x0000000189BBE2F0 */ get => default; /* [XID] */ /* 0x0000000189BC5F60-0x0000000189BC5F80 */ private set {} } // 0x000000018579BA10-0x000000018579BAE0 0x000000018579D540-0x000000018579D620
	public float waveangle { /* [XID] */ /* 0x0000000189BCDA20-0x0000000189BCDA40 */ get => default; /* [XID] */ /* 0x0000000189BD4F10-0x0000000189BD4F30 */ private set {} } // 0x000000018579C2C0-0x000000018579C3A0 0x000000018579D840-0x000000018579D920
	public float triggerCD { /* [XID] */ /* 0x0000000189BDCAC0-0x0000000189BDCAE0 */ get => default; /* [XID] */ /* 0x00000001895E9330-0x00000001895E9350 */ private set {} } // 0x000000018579C3A0-0x000000018579C480 0x000000018579BBB0-0x000000018579BC90
	public string shootPoint { /* [XID] */ /* 0x00000001895F0AE0-0x00000001895F0B00 */ get => default; /* [XID] */ /* 0x00000001895F84D0-0x00000001895F84F0 */ private set {} } // 0x000000018579BD10-0x000000018579BDB0 0x000000018579ACD0-0x000000018579AD80
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x000000018967C520-0x000000018967C540 */ get => default; } // 0x000000018579BE30-0x000000018579BED0 

	// Constructors
	public CircleBarrageMixin() {} // 0x000000018579E530-0x000000018579E640

	// Methods
	// [XID] // 0x00000001895FF9B0-0x00000001895FF9D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018579E1E0-0x000000018579E3B0
	// [XID] // 0x0000000189607160-0x0000000189607180
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018579D680-0x000000018579D760
	// [XID] // 0x000000018960EBA0-0x000000018960EBC0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6491 */) => default; // 0x000000018579D1B0-0x000000018579D290
	// [XID] // 0x0000000189616180-0x00000001896161A0
	public override int GetHashNum() => default; // 0x000000018579B0E0-0x000000018579B1B0
	// [XID] // 0x000000018961D9D0-0x000000018961D9F0
	public override void InitEmpty() {} // 0x000000018579C7A0-0x000000018579C970
	[BlackList] // 0x0000000189624E30-0x0000000189624E70
	// [XID] // 0x0000000189624E30-0x0000000189624E70
	public override bool FromJson(JSONNode node) => default; // 0x000000018579BED0-0x000000018579C250
	// [XID] // 0x000000018962F8A0-0x000000018962F8C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000185799F30-0x000000018579A930
	[BlackList] // 0x00000001896373E0-0x0000000189637420
	// [XID] // 0x00000001896373E0-0x0000000189637420
	public static new CircleBarrageMixin ParseFromJson(JSONNode node) => default; // 0x000000018579D2F0-0x000000018579D540
	// [XID] // 0x0000000189641860-0x0000000189641880
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6492 */, bool useObjectPool = false /* Metadata: 0x00AF6496 */) => default; // 0x000000018579CDD0-0x000000018579D0D0
	// [XID] // 0x00000001896492C0-0x00000001896492E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6497 */, bool useObjectPool = false /* Metadata: 0x00AF649B */) => default; // 0x000000018579B370-0x000000018579BA10
	// [XID] // 0x0000000189650890-0x00000001896508B0
	public static new CircleBarrageMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF649C */, bool useObjectPool = false /* Metadata: 0x00AF64A0 */) => default; // 0x000000018579C480-0x000000018579C6A0
	[BlackList] // 0x00000001896580F0-0x0000000189658130
	// [XID] // 0x00000001896580F0-0x0000000189658130
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018579AA00-0x000000018579ACD0
	// [XID] // 0x0000000189662620-0x0000000189662640
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018579DA00-0x000000018579E100
	[BlackList] // 0x000000018966A1C0-0x000000018966A200
	// [XID] // 0x000000018966A1C0-0x000000018966A200
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018579CB30-0x000000018579CC20
	// [XID] // 0x0000000189674C70-0x0000000189674C90
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x000000018579D0D0-0x000000018579D1B0
	[BlackList] // 0x0000000189683B30-0x0000000189683B70
	// [XID] // 0x0000000189683B30-0x0000000189683B70
	public override void AutoAllocTypeFields() {} // 0x000000018579AD80-0x000000018579AE20
	[BlackList] // 0x000000018968E9F0-0x000000018968EA30
	// [XID] // 0x000000018968E9F0-0x000000018968EA30
	public override void AutoRecycleTypeFields() {} // 0x000000018579AE20-0x000000018579AFC0
	[BlackList] // 0x00000001896990C0-0x0000000189699100
	// [XID] // 0x00000001896990C0-0x0000000189699100
	public override void ReturnToObjectPool() {} // 0x000000018579E490-0x000000018579E530
}

