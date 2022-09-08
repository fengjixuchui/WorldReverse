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
public class UseSkillEliteSet : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16753
{
	// Fields
	private SimpleSafeUInt8 skillEliteSetIDRawNum; // 0x68

	// Properties
	public byte skillEliteSetID { /* [XID] */ /* 0x0000000189880520-0x0000000189880540 */ get => default; /* [XID] */ /* 0x0000000189887A40-0x0000000189887A60 */ private set {} } // 0x0000000183A5E6F0-0x0000000183A5E7C0 0x0000000183A5E7C0-0x0000000183A5E8A0
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018990B5B0-0x000000018990B5D0 */ get => default; } // 0x0000000183A5F910-0x0000000183A5F9B0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001899132A0-0x00000001899132C0 */ get => default; } // 0x0000000183A5EF30-0x0000000183A5EFD0 

	// Constructors
	public UseSkillEliteSet() {} // 0x0000000183A5FF60-0x0000000183A5FFC0

	// Methods
	// [XID] // 0x000000018988ED40-0x000000018988ED60
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183A5FDD0-0x0000000183A5FEC0
	// [XID] // 0x0000000189896280-0x00000001898962A0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183A5FA10-0x0000000183A5FAC0
	// [XID] // 0x000000018989D940-0x000000018989D960
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF452E */) => default; // 0x0000000183A5F580-0x0000000183A5F660
	// [XID] // 0x00000001898A5280-0x00000001898A52A0
	public override int GetHashNum() => default; // 0x0000000183A5E080-0x0000000183A5E150
	// [XID] // 0x00000001898AC7E0-0x00000001898AC800
	public override void InitEmpty() {} // 0x0000000183A5EFD0-0x0000000183A5F0A0
	[BlackList] // 0x00000001898B3CC0-0x00000001898B3D00
	// [XID] // 0x00000001898B3CC0-0x00000001898B3D00
	public override bool FromJson(JSONNode node) => default; // 0x0000000183A5E920-0x0000000183A5ECA0
	// [XID] // 0x00000001898BE600-0x00000001898BE620
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183A5D840-0x0000000183A5DAA0
	[BlackList] // 0x00000001898C5D90-0x00000001898C5DD0
	// [XID] // 0x00000001898C5D90-0x00000001898C5DD0
	public static new UseSkillEliteSet ParseFromJson(JSONNode node) => default; // 0x0000000183A5F6C0-0x0000000183A5F910
	// [XID] // 0x00000001898D0820-0x00000001898D0840
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF452F */, bool useObjectPool = false /* Metadata: 0x00AF4533 */) => default; // 0x0000000183A5F280-0x0000000183A5F580
	// [XID] // 0x00000001898D7EE0-0x00000001898D7F00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4534 */, bool useObjectPool = false /* Metadata: 0x00AF4538 */) => default; // 0x0000000183A5E2A0-0x0000000183A5E510
	// [XID] // 0x00000001898DFCE0-0x00000001898DFD00
	public static new UseSkillEliteSet ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4539 */, bool useObjectPool = false /* Metadata: 0x00AF453D */) => default; // 0x0000000183A5ECA0-0x0000000183A5EEC0
	[BlackList] // 0x00000001898E7730-0x00000001898E7770
	// [XID] // 0x00000001898E7730-0x00000001898E7770
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183A5DAA0-0x0000000183A5DD70
	// [XID] // 0x00000001898F1E90-0x00000001898F1EB0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183A5FBA0-0x0000000183A5FDD0
	[BlackList] // 0x00000001898F96F0-0x00000001898F9730
	// [XID] // 0x00000001898F96F0-0x00000001898F9730
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183A5F180-0x0000000183A5F280
	// [XID] // 0x0000000189903FF0-0x0000000189904010
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183A5E510-0x0000000183A5E670
	[BlackList] // 0x000000018991AA10-0x000000018991AA50
	// [XID] // 0x000000018991AA10-0x000000018991AA50
	public override void AutoAllocTypeFields() {} // 0x0000000183A5DD70-0x0000000183A5DE10
	[BlackList] // 0x00000001899250C0-0x0000000189925100
	// [XID] // 0x00000001899250C0-0x0000000189925100
	public override void AutoRecycleTypeFields() {} // 0x0000000183A5DE10-0x0000000183A5DEF0
	[BlackList] // 0x000000018992F720-0x000000018992F760
	// [XID] // 0x000000018992F720-0x000000018992F760
	public override void ReturnToObjectPool() {} // 0x0000000183A5FEC0-0x0000000183A5FF60
}

