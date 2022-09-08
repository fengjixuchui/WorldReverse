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
public class SetExtraAbilityState : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16785
{
	// Fields
	private ExtraAbilityState _state; // 0x68

	// Properties
	public ExtraAbilityState state { /* [XID] */ /* 0x0000000189972C10-0x0000000189972C30 */ get => default; /* [XID] */ /* 0x000000018997A5B0-0x000000018997A5D0 */ private set {} } // 0x0000000183B160D0-0x0000000183B16170 0x0000000183B15620-0x0000000183B156D0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001899FE730-0x00000001899FE750 */ get => default; } // 0x0000000183B17390-0x0000000183B17430 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A05F70-0x0000000189A05F90 */ get => default; } // 0x0000000183B169E0-0x0000000183B16A80 

	// Constructors
	public SetExtraAbilityState() {} // 0x0000000183B179B0-0x0000000183B17A10

	// Methods
	// [XID] // 0x0000000189981EC0-0x0000000189981EE0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183B17820-0x0000000183B17910
	// [XID] // 0x00000001899896C0-0x00000001899896E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183B17490-0x0000000183B17540
	// [XID] // 0x0000000189990F70-0x0000000189990F90
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF462A */) => default; // 0x0000000183B17000-0x0000000183B170E0
	// [XID] // 0x00000001899989F0-0x0000000189998A10
	public override int GetHashNum() => default; // 0x0000000183B15C80-0x0000000183B15D50
	// [XID] // 0x00000001899A0330-0x00000001899A0350
	public override void InitEmpty() {} // 0x0000000183B16A80-0x0000000183B16B20
	[BlackList] // 0x00000001899A7EA0-0x00000001899A7EE0
	// [XID] // 0x00000001899A7EA0-0x00000001899A7EE0
	public override bool FromJson(JSONNode node) => default; // 0x0000000183B163D0-0x0000000183B16750
	// [XID] // 0x00000001899B27B0-0x00000001899B27D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183B15400-0x0000000183B15620
	[BlackList] // 0x00000001899B9A30-0x00000001899B9A70
	// [XID] // 0x00000001899B9A30-0x00000001899B9A70
	public static new SetExtraAbilityState ParseFromJson(JSONNode node) => default; // 0x0000000183B17140-0x0000000183B17390
	// [XID] // 0x00000001899C45C0-0x00000001899C45E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF462B */, bool useObjectPool = false /* Metadata: 0x00AF462F */) => default; // 0x0000000183B16D00-0x0000000183B17000
	// [XID] // 0x00000001899CBE20-0x00000001899CBE40
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4630 */, bool useObjectPool = false /* Metadata: 0x00AF4634 */) => default; // 0x0000000183B15EA0-0x0000000183B160D0
	// [XID] // 0x00000001899D3330-0x00000001899D3350
	public static new SetExtraAbilityState ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4635 */, bool useObjectPool = false /* Metadata: 0x00AF4639 */) => default; // 0x0000000183B16750-0x0000000183B16970
	[BlackList] // 0x00000001899DA8C0-0x00000001899DA900
	// [XID] // 0x00000001899DA8C0-0x00000001899DA900
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183B156D0-0x0000000183B159A0
	// [XID] // 0x00000001899E5400-0x00000001899E5420
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183B17620-0x0000000183B17820
	[BlackList] // 0x00000001899EC710-0x00000001899EC750
	// [XID] // 0x00000001899EC710-0x00000001899EC750
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183B16C00-0x0000000183B16D00
	// [XID] // 0x00000001899F6FB0-0x00000001899F6FD0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000183B16170-0x0000000183B162D0
	[BlackList] // 0x0000000189A0D420-0x0000000189A0D460
	// [XID] // 0x0000000189A0D420-0x0000000189A0D460
	public override void AutoAllocTypeFields() {} // 0x0000000183B159A0-0x0000000183B15A40
	[BlackList] // 0x0000000189A17710-0x0000000189A17750
	// [XID] // 0x0000000189A17710-0x0000000189A17750
	public override void AutoRecycleTypeFields() {} // 0x0000000183B15A40-0x0000000183B15AF0
	[BlackList] // 0x0000000189A21E30-0x0000000189A21E70
	// [XID] // 0x0000000189A21E30-0x0000000189A21E70
	public override void ReturnToObjectPool() {} // 0x0000000183B17910-0x0000000183B179B0
}

