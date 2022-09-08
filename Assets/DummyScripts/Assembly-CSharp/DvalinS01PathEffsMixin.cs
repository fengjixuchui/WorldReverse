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
public class DvalinS01PathEffsMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17035
{
	// Fields
	private SimpleSafeInt32 effectStartRawNum; // 0x30
	private SimpleSafeInt32 effectEndRawNum; // 0x34
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private DvalinS01PathEffsInfo[] _effInfos; // 0x38

	// Properties
	public int effectStart { /* [XID] */ /* 0x00000001899DBFB0-0x00000001899DBFD0 */ get => default; /* [XID] */ /* 0x00000001899E3910-0x00000001899E3930 */ private set {} } // 0x0000000184EB4A90-0x0000000184EB4B60 0x0000000184EB3950-0x0000000184EB3A30
	public int effectEnd { /* [XID] */ /* 0x00000001899EACE0-0x00000001899EAD00 */ get => default; /* [XID] */ /* 0x00000001899F2960-0x00000001899F2980 */ private set {} } // 0x0000000184EB33F0-0x0000000184EB34C0 0x0000000184EB53A0-0x0000000184EB5480
	public DvalinS01PathEffsInfo[] effInfos { /* [XID] */ /* 0x00000001899F9E70-0x00000001899F9E90 */ get => default; /* [XID] */ /* 0x0000000189A01290-0x0000000189A012B0 */ private set {} } // 0x0000000184EB55B0-0x0000000184EB5650 0x0000000184EB4F50-0x0000000184EB5000
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189A84C80-0x0000000189A84CA0 */ get => default; } // 0x0000000184EB3B30-0x0000000184EB3BD0 

	// Constructors
	public DvalinS01PathEffsMixin() {} // 0x0000000184EB56F0-0x0000000184EB5770

	// Methods
	// [XID] // 0x0000000189A08C30-0x0000000189A08C50
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184EB5480-0x0000000184EB55B0
	// [XID] // 0x0000000189A10110-0x0000000189A10130
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184EB4E70-0x0000000184EB4F50
	// [XID] // 0x0000000189A176B0-0x0000000189A176D0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6113 */) => default; // 0x0000000184EB49B0-0x0000000184EB4A90
	// [XID] // 0x0000000189A1EDD0-0x0000000189A1EDF0
	public override int GetHashNum() => default; // 0x0000000184EB3320-0x0000000184EB33F0
	// [XID] // 0x0000000189A26440-0x0000000189A26460
	public override void InitEmpty() {} // 0x0000000184EB42E0-0x0000000184EB4400
	[BlackList] // 0x0000000189A2D710-0x0000000189A2D750
	// [XID] // 0x0000000189A2D710-0x0000000189A2D750
	public override bool FromJson(JSONNode node) => default; // 0x0000000184EB3BD0-0x0000000184EB3F50
	// [XID] // 0x0000000189A381F0-0x0000000189A38210
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184EB2940-0x0000000184EB2D90
	[BlackList] // 0x0000000189A3F940-0x0000000189A3F980
	// [XID] // 0x0000000189A3F940-0x0000000189A3F980
	public static new DvalinS01PathEffsMixin ParseFromJson(JSONNode node) => default; // 0x0000000184EB4BC0-0x0000000184EB4E10
	// [XID] // 0x0000000189A49E00-0x0000000189A49E20
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6114 */, bool useObjectPool = false /* Metadata: 0x00AF6118 */) => default; // 0x0000000184EB45D0-0x0000000184EB48D0
	// [XID] // 0x0000000189A517F0-0x0000000189A51810
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6119 */, bool useObjectPool = false /* Metadata: 0x00AF611D */) => default; // 0x0000000184EB35A0-0x0000000184EB3950
	// [XID] // 0x0000000189A58FC0-0x0000000189A58FE0
	public static new DvalinS01PathEffsMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF611E */, bool useObjectPool = false /* Metadata: 0x00AF6122 */) => default; // 0x0000000184EB3FC0-0x0000000184EB41E0
	[BlackList] // 0x0000000189A608E0-0x0000000189A60920
	// [XID] // 0x0000000189A608E0-0x0000000189A60920
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184EB2D90-0x0000000184EB3060
	// [XID] // 0x0000000189A6B330-0x0000000189A6B350
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184EB5000-0x0000000184EB53A0
	[BlackList] // 0x0000000189A72B40-0x0000000189A72B80
	// [XID] // 0x0000000189A72B40-0x0000000189A72B80
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184EB44E0-0x0000000184EB45D0
	// [XID] // 0x0000000189A7D490-0x0000000189A7D4B0
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000184EB48D0-0x0000000184EB49B0
	[BlackList] // 0x0000000189A8C610-0x0000000189A8C650
	// [XID] // 0x0000000189A8C610-0x0000000189A8C650
	public override void AutoAllocTypeFields() {} // 0x0000000184EB3060-0x0000000184EB3100
	[BlackList] // 0x0000000189A96BE0-0x0000000189A96C20
	// [XID] // 0x0000000189A96BE0-0x0000000189A96C20
	public override void AutoRecycleTypeFields() {} // 0x0000000184EB3100-0x0000000184EB3200
	[BlackList] // 0x0000000189AA0F20-0x0000000189AA0F60
	// [XID] // 0x0000000189AA0F20-0x0000000189AA0F60
	public override void ReturnToObjectPool() {} // 0x0000000184EB5650-0x0000000184EB56F0
}

