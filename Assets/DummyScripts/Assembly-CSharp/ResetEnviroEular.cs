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
public class ResetEnviroEular : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16657
{
	// Fields
	private MoleMole.Config.Vector _eularAngles; // 0x68

	// Properties
	public MoleMole.Config.Vector eularAngles { /* [XID] */ /* 0x0000000189B0C410-0x0000000189B0C430 */ get => default; /* [XID] */ /* 0x0000000189B139B0-0x0000000189B139D0 */ private set {} } // 0x0000000182A68B80-0x0000000182A68C60 0x0000000182A66BA0-0x0000000182A66C70
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189B96580-0x0000000189B965A0 */ get => default; } // 0x0000000182A688F0-0x0000000182A68990 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189B9DA40-0x0000000189B9DA60 */ get => default; } // 0x0000000182A67F10-0x0000000182A67FB0 

	// Constructors
	public ResetEnviroEular() {} // 0x0000000182A69050-0x0000000182A690B0

	// Methods
	// [XID] // 0x0000000189B1B020-0x0000000189B1B040
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182A68EC0-0x0000000182A68FB0
	// [XID] // 0x0000000189B22710-0x0000000189B22730
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182A689F0-0x0000000182A68AA0
	// [XID] // 0x0000000189B29CC0-0x0000000189B29CE0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF423A */) => default; // 0x0000000182A68560-0x0000000182A68640
	// [XID] // 0x0000000189B31270-0x0000000189B31290
	public override int GetHashNum() => default; // 0x0000000182A67230-0x0000000182A67300
	// [XID] // 0x0000000189B38890-0x0000000189B388B0
	public override void InitEmpty() {} // 0x0000000182A67FB0-0x0000000182A68080
	[BlackList] // 0x0000000189B40220-0x0000000189B40260
	// [XID] // 0x0000000189B40220-0x0000000189B40260
	public override bool FromJson(JSONNode node) => default; // 0x0000000182A67900-0x0000000182A67C80
	// [XID] // 0x0000000189B4AB30-0x0000000189B4AB50
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182A66980-0x0000000182A66BA0
	[BlackList] // 0x0000000189B52180-0x0000000189B521C0
	// [XID] // 0x0000000189B52180-0x0000000189B521C0
	public static new ResetEnviroEular ParseFromJson(JSONNode node) => default; // 0x0000000182A686A0-0x0000000182A688F0
	// [XID] // 0x0000000189B5CC10-0x0000000189B5CC30
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF423B */, bool useObjectPool = false /* Metadata: 0x00AF423F */) => default; // 0x0000000182A68260-0x0000000182A68560
	// [XID] // 0x0000000189B64270-0x0000000189B64290
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4240 */, bool useObjectPool = false /* Metadata: 0x00AF4244 */) => default; // 0x0000000182A67450-0x0000000182A676A0
	// [XID] // 0x0000000189B6B930-0x0000000189B6B950
	public static new ResetEnviroEular ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4245 */, bool useObjectPool = false /* Metadata: 0x00AF4249 */) => default; // 0x0000000182A67C80-0x0000000182A67EA0
	[BlackList] // 0x0000000189B73030-0x0000000189B73070
	// [XID] // 0x0000000189B73030-0x0000000189B73070
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182A66C70-0x0000000182A66F40
	// [XID] // 0x0000000189B7D4E0-0x0000000189B7D500
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182A68C60-0x0000000182A68EC0
	[BlackList] // 0x0000000189B851F0-0x0000000189B85230
	// [XID] // 0x0000000189B851F0-0x0000000189B85230
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182A68160-0x0000000182A68260
	// [XID] // 0x0000000189B8F0B0-0x0000000189B8F0D0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182A676A0-0x0000000182A67800
	[BlackList] // 0x0000000189BA5450-0x0000000189BA5490
	// [XID] // 0x0000000189BA5450-0x0000000189BA5490
	public override void AutoAllocTypeFields() {} // 0x0000000182A66F40-0x0000000182A66FE0
	[BlackList] // 0x0000000189BAF6C0-0x0000000189BAF700
	// [XID] // 0x0000000189BAF6C0-0x0000000189BAF700
	public override void AutoRecycleTypeFields() {} // 0x0000000182A66FE0-0x0000000182A670A0
	[BlackList] // 0x0000000189BB9BE0-0x0000000189BB9C20
	// [XID] // 0x0000000189BB9BE0-0x0000000189BB9C20
	public override void ReturnToObjectPool() {} // 0x0000000182A68FB0-0x0000000182A69050
}

