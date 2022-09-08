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
public class ByCurTeamWeaponTypeSort : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17298
{
	// Fields
	private SimpleSafeUInt32 numberRawNum; // 0x18
	private RelationalOperator _logic; // 0x1C

	// Properties
	public uint number { /* [XID] */ /* 0x00000001896BEDD0-0x00000001896BEDF0 */ get => default; /* [XID] */ /* 0x00000001896C6770-0x00000001896C6790 */ private set {} } // 0x0000000185295F60-0x0000000185296030 0x00000001852976E0-0x00000001852977C0
	public RelationalOperator logic { /* [XID] */ /* 0x00000001896CDD10-0x00000001896CDD30 */ get => default; /* [XID] */ /* 0x00000001896D5300-0x00000001896D5320 */ private set {} } // 0x00000001852972E0-0x0000000185297380 0x0000000185296AE0-0x0000000185296B90

	// Constructors
	public ByCurTeamWeaponTypeSort() {} // 0x0000000185297CE0-0x0000000185297D40

	// Methods
	// [XID] // 0x00000001896DC860-0x00000001896DC880
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000185297B30-0x0000000185297C40
	// [XID] // 0x00000001896E41F0-0x00000001896E4210
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000185297630-0x00000001852976E0
	// [XID] // 0x00000001896EB660-0x00000001896EB680
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF69BB */) => default; // 0x00000001852971A0-0x0000000185297280
	// [XID] // 0x00000001896F2A70-0x00000001896F2A90
	public override int GetHashNum() => default; // 0x0000000185295DB0-0x0000000185295E80
	// [XID] // 0x00000001896FA2F0-0x00000001896FA310
	public override void InitEmpty() {} // 0x0000000185296C00-0x0000000185296CD0
	[BlackList] // 0x0000000189701A40-0x0000000189701A80
	// [XID] // 0x0000000189701A40-0x0000000189701A80
	public override bool FromJson(JSONNode node) => default; // 0x0000000185296540-0x00000001852968C0
	// [XID] // 0x000000018970C150-0x000000018970C170
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000185295500-0x0000000185295840
	[BlackList] // 0x0000000189713B40-0x0000000189713B80
	// [XID] // 0x0000000189713B40-0x0000000189713B80
	public static new ByCurTeamWeaponTypeSort ParseFromJson(JSONNode node) => default; // 0x0000000185297380-0x00000001852975D0
	// [XID] // 0x000000018971E180-0x000000018971E1A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF69BC */, bool useObjectPool = false /* Metadata: 0x00AF69C0 */) => default; // 0x0000000185296EA0-0x00000001852971A0
	// [XID] // 0x0000000189725700-0x0000000189725720
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF69C1 */, bool useObjectPool = false /* Metadata: 0x00AF69C5 */) => default; // 0x0000000185296030-0x0000000185296310
	// [XID] // 0x000000018972CC20-0x000000018972CC40
	public static new ByCurTeamWeaponTypeSort ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF69C6 */, bool useObjectPool = false /* Metadata: 0x00AF69CA */) => default; // 0x00000001852968C0-0x0000000185296AE0
	[BlackList] // 0x0000000189734430-0x0000000189734470
	// [XID] // 0x0000000189734430-0x0000000189734470
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000185295840-0x0000000185295B10
	// [XID] // 0x000000018973F240-0x000000018973F260
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000185297870-0x0000000185297B30
	[BlackList] // 0x0000000189746500-0x0000000189746540
	// [XID] // 0x0000000189746500-0x0000000189746540
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000185296DB0-0x0000000185296EA0
	// [XID] // 0x0000000189750C60-0x0000000189750C80
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000185296310-0x0000000185296440
	[BlackList] // 0x0000000189758070-0x00000001897580B0
	// [XID] // 0x0000000189758070-0x00000001897580B0
	public override void AutoAllocTypeFields() {} // 0x0000000185295B10-0x0000000185295BB0
	[BlackList] // 0x0000000189762AF0-0x0000000189762B30
	// [XID] // 0x0000000189762AF0-0x0000000189762B30
	public override void AutoRecycleTypeFields() {} // 0x0000000185295BB0-0x0000000185295C90
	[BlackList] // 0x000000018976D0C0-0x000000018976D100
	// [XID] // 0x000000018976D0C0-0x000000018976D100
	public override void ReturnToObjectPool() {} // 0x0000000185297C40-0x0000000185297CE0
}

