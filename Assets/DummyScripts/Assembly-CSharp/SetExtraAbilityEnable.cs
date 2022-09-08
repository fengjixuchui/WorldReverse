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
public class SetExtraAbilityEnable : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16781
{
	// Fields
	private bool _enable; // 0x68

	// Properties
	public bool enable { /* [XID] */ /* 0x00000001898A2000-0x00000001898A2020 */ get => default; /* [XID] */ /* 0x00000001898A97B0-0x00000001898A97D0 */ private set {} } // 0x000000018283B210-0x000000018283B2B0 0x000000018283BEF0-0x000000018283BFA0
	protected override bool MuteAuthority { /* [XID] */ /* 0x000000018992E0D0-0x000000018992E0F0 */ get => default; } // 0x000000018283BFA0-0x000000018283C040 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189935490-0x00000001899354B0 */ get => default; } // 0x000000018283B540-0x000000018283B5E0 

	// Constructors
	public SetExtraAbilityEnable() {} // 0x000000018283C5C0-0x000000018283C620

	// Methods
	// [XID] // 0x00000001898B1040-0x00000001898B1060
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018283C430-0x000000018283C520
	// [XID] // 0x00000001898B87C0-0x00000001898B87E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018283C0A0-0x000000018283C150
	// [XID] // 0x00000001898BFEE0-0x00000001898BFF00
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF460E */) => default; // 0x000000018283BB60-0x000000018283BC40
	// [XID] // 0x00000001898C77E0-0x00000001898C7800
	public override int GetHashNum() => default; // 0x000000018283A7E0-0x000000018283A8B0
	// [XID] // 0x00000001898CEE70-0x00000001898CEE90
	public override void InitEmpty() {} // 0x000000018283B5E0-0x000000018283B680
	[BlackList] // 0x00000001898D68C0-0x00000001898D6900
	// [XID] // 0x00000001898D68C0-0x00000001898D6900
	public override bool FromJson(JSONNode node) => default; // 0x000000018283AE90-0x000000018283B210
	// [XID] // 0x00000001898E14D0-0x00000001898E14F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018283A030-0x000000018283A230
	[BlackList] // 0x00000001898E8EE0-0x00000001898E8F20
	// [XID] // 0x00000001898E8EE0-0x00000001898E8F20
	public static new SetExtraAbilityEnable ParseFromJson(JSONNode node) => default; // 0x000000018283BCA0-0x000000018283BEF0
	// [XID] // 0x00000001898F3640-0x00000001898F3660
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF460F */, bool useObjectPool = false /* Metadata: 0x00AF4613 */) => default; // 0x000000018283B860-0x000000018283BB60
	// [XID] // 0x00000001898FACA0-0x00000001898FACC0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4614 */, bool useObjectPool = false /* Metadata: 0x00AF4618 */) => default; // 0x000000018283AA00-0x000000018283AC30
	// [XID] // 0x0000000189902800-0x0000000189902820
	public static new SetExtraAbilityEnable ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4619 */, bool useObjectPool = false /* Metadata: 0x00AF461D */) => default; // 0x000000018283B2B0-0x000000018283B4D0
	[BlackList] // 0x0000000189909E00-0x0000000189909E40
	// [XID] // 0x0000000189909E00-0x0000000189909E40
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018283A230-0x000000018283A500
	// [XID] // 0x0000000189914760-0x0000000189914780
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018283C230-0x000000018283C430
	[BlackList] // 0x000000018991C320-0x000000018991C360
	// [XID] // 0x000000018991C320-0x000000018991C360
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018283B760-0x000000018283B860
	// [XID] // 0x0000000189926AE0-0x0000000189926B00
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018283AC30-0x000000018283AD90
	[BlackList] // 0x000000018993D030-0x000000018993D070
	// [XID] // 0x000000018993D030-0x000000018993D070
	public override void AutoAllocTypeFields() {} // 0x000000018283A500-0x000000018283A5A0
	[BlackList] // 0x00000001899474A0-0x00000001899474E0
	// [XID] // 0x00000001899474A0-0x00000001899474E0
	public override void AutoRecycleTypeFields() {} // 0x000000018283A5A0-0x000000018283A650
	[BlackList] // 0x0000000189951D90-0x0000000189951DD0
	// [XID] // 0x0000000189951D90-0x0000000189951DD0
	public override void ReturnToObjectPool() {} // 0x000000018283C520-0x000000018283C5C0
}

