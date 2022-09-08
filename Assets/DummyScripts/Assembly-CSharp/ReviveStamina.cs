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
public class ReviveStamina : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16817
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _value; // 0x68

	// Properties
	public DynamicFloat value { /* [XID] */ /* 0x00000001897C08C0-0x00000001897C08E0 */ get => default; /* [XID] */ /* 0x00000001897C8210-0x00000001897C8230 */ private set {} } // 0x00000001850CA240-0x00000001850CA2E0 0x00000001850CA110-0x00000001850CA1C0
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018984B530-0x000000018984B550 */ get => default; } // 0x00000001850CB2A0-0x00000001850CB340 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189852640-0x0000000189852660 */ get => default; } // 0x00000001850CA8F0-0x00000001850CA990 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x000000018985A070-0x000000018985A090 */ get => default; } // 0x00000001850C9B10-0x00000001850C9BB0 

	// Constructors
	public ReviveStamina() {} // 0x00000001850CB980-0x00000001850CBA10

	// Methods
	// [XID] // 0x00000001897CF5B0-0x00000001897CF5D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001850CB800-0x00000001850CB8E0
	// [XID] // 0x00000001897D6E40-0x00000001897D6E60
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001850CB410-0x00000001850CB4F0
	// [XID] // 0x00000001897DE4D0-0x00000001897DE4F0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF4736 */) => default; // 0x00000001850CAF10-0x00000001850CAFF0
	// [XID] // 0x00000001897E5F90-0x00000001897E5FB0
	public override int GetHashNum() => default; // 0x00000001850C9A40-0x00000001850C9B10
	// [XID] // 0x00000001897ED910-0x00000001897ED930
	public override void InitEmpty() {} // 0x00000001850CA990-0x00000001850CAA30
	[BlackList] // 0x00000001897F5110-0x00000001897F5150
	// [XID] // 0x00000001897F5110-0x00000001897F5150
	public override bool FromJson(JSONNode node) => default; // 0x00000001850CA2E0-0x00000001850CA660
	// [XID] // 0x00000001897FF990-0x00000001897FF9B0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001850C9200-0x00000001850C9410
	[BlackList] // 0x0000000189807070-0x00000001898070B0
	// [XID] // 0x0000000189807070-0x00000001898070B0
	public static new ReviveStamina ParseFromJson(JSONNode node) => default; // 0x00000001850CB050-0x00000001850CB2A0
	// [XID] // 0x0000000189811640-0x0000000189811660
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4737 */, bool useObjectPool = false /* Metadata: 0x00AF473B */) => default; // 0x00000001850CAC10-0x00000001850CAF10
	// [XID] // 0x00000001898191B0-0x00000001898191D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF473C */, bool useObjectPool = false /* Metadata: 0x00AF4740 */) => default; // 0x00000001850C9D00-0x00000001850C9F70
	// [XID] // 0x0000000189820950-0x0000000189820970
	public static new ReviveStamina ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4741 */, bool useObjectPool = false /* Metadata: 0x00AF4745 */) => default; // 0x00000001850CA660-0x00000001850CA880
	[BlackList] // 0x0000000189827F20-0x0000000189827F60
	// [XID] // 0x0000000189827F20-0x0000000189827F60
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001850C9410-0x00000001850C96E0
	// [XID] // 0x00000001898322B0-0x00000001898322D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001850CB5D0-0x00000001850CB800
	[BlackList] // 0x0000000189839920-0x0000000189839960
	// [XID] // 0x0000000189839920-0x0000000189839960
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001850CAB10-0x00000001850CAC10
	// [XID] // 0x00000001898440E0-0x0000000189844100
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001850C9F70-0x00000001850CA090
	[BlackList] // 0x0000000189861210-0x0000000189861250
	// [XID] // 0x0000000189861210-0x0000000189861250
	public override void AutoAllocTypeFields() {} // 0x00000001850C96E0-0x00000001850C9780
	[BlackList] // 0x000000018986BA20-0x000000018986BA60
	// [XID] // 0x000000018986BA20-0x000000018986BA60
	public override void AutoRecycleTypeFields() {} // 0x00000001850C9780-0x00000001850C98B0
	[BlackList] // 0x0000000189875E60-0x0000000189875EA0
	// [XID] // 0x0000000189875E60-0x0000000189875EA0
	public override void ReturnToObjectPool() {} // 0x00000001850CB8E0-0x00000001850CB980
}

