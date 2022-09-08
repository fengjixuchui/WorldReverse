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
public class EnableRocketJump : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16455
{
	// Fields
	private RocketJumpType _type; // 0x68
	private bool _enable; // 0x6C
	private RocketJumpExt _extention; // 0x70

	// Properties
	public RocketJumpType type { /* [XID] */ /* 0x00000001898E7830-0x00000001898E7850 */ get => default; /* [XID] */ /* 0x00000001898EEF80-0x00000001898EEFA0 */ private set {} } // 0x000000018274E820-0x000000018274E8C0 0x000000018274E030-0x000000018274E0E0
	public bool enable { /* [XID] */ /* 0x00000001898F6860-0x00000001898F6880 */ get => default; /* [XID] */ /* 0x00000001898FDFC0-0x00000001898FDFE0 */ private set {} } // 0x000000018274CF00-0x000000018274CFA0 0x000000018274DDD0-0x000000018274DE80
	public RocketJumpExt extention { /* [XID] */ /* 0x00000001899057E0-0x0000000189905800 */ get => default; /* [XID] */ /* 0x000000018990D0D0-0x000000018990D0F0 */ private set {} } // 0x000000018274E780-0x000000018274E820 0x000000018274D270-0x000000018274D320
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001899A0450-0x00000001899A0470 */ get => default; } // 0x000000018274DE80-0x000000018274DF20 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001899A7FA0-0x00000001899A7FC0 */ get => default; } // 0x000000018274D400-0x000000018274D4A0 

	// Constructors
	public EnableRocketJump() {} // 0x000000018274EA00-0x000000018274EA70

	// Methods
	// [XID] // 0x0000000189914820-0x0000000189914840
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018274E640-0x000000018274E780
	// [XID] // 0x000000018991C440-0x000000018991C460
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018274DF80-0x000000018274E030
	// [XID] // 0x0000000189923B60-0x0000000189923B80
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3BF4 */) => default; // 0x000000018274DA40-0x000000018274DB20
	// [XID] // 0x000000018992B1C0-0x000000018992B1E0
	public override int GetHashNum() => default; // 0x000000018274C3C0-0x000000018274C490
	// [XID] // 0x0000000189932800-0x0000000189932820
	public override void InitEmpty() {} // 0x000000018274D4A0-0x000000018274D570
	[BlackList] // 0x000000018993A230-0x000000018993A270
	// [XID] // 0x000000018993A230-0x000000018993A270
	public override bool FromJson(JSONNode node) => default; // 0x000000018274CB80-0x000000018274CF00
	// [XID] // 0x00000001899446A0-0x00000001899446C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018274BA60-0x000000018274BE10
	[BlackList] // 0x000000018994BCE0-0x000000018994BD20
	// [XID] // 0x000000018994BCE0-0x000000018994BD20
	public static new EnableRocketJump ParseFromJson(JSONNode node) => default; // 0x000000018274DB80-0x000000018274DDD0
	// [XID] // 0x0000000189956280-0x00000001899562A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3BF5 */, bool useObjectPool = false /* Metadata: 0x00AF3BF9 */) => default; // 0x000000018274D740-0x000000018274DA40
	// [XID] // 0x000000018995DDB0-0x000000018995DDD0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3BFA */, bool useObjectPool = false /* Metadata: 0x00AF3BFE */) => default; // 0x000000018274C5E0-0x000000018274C920
	// [XID] // 0x00000001899655B0-0x00000001899655D0
	public static new EnableRocketJump ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3BFF */, bool useObjectPool = false /* Metadata: 0x00AF3C03 */) => default; // 0x000000018274D050-0x000000018274D270
	[BlackList] // 0x000000018996CBB0-0x000000018996CBF0
	// [XID] // 0x000000018996CBB0-0x000000018996CBF0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018274BE10-0x000000018274C0E0
	// [XID] // 0x0000000189977620-0x0000000189977640
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018274E1C0-0x000000018274E4F0
	[BlackList] // 0x000000018997E900-0x000000018997E940
	// [XID] // 0x000000018997E900-0x000000018997E940
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018274D650-0x000000018274D740
	// [XID] // 0x00000001899897E0-0x0000000189989800
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018274E8C0-0x000000018274E960
	// [XID] // 0x0000000189991070-0x0000000189991090
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018274C920-0x000000018274CA80
	// [XID] // 0x0000000189998B30-0x0000000189998B50
	public override bool GetDebugOutput(ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref string output) => default; // 0x000000018274E4F0-0x000000018274E640
	[BlackList] // 0x00000001899AF610-0x00000001899AF650
	// [XID] // 0x00000001899AF610-0x00000001899AF650
	public override void AutoAllocTypeFields() {} // 0x000000018274C0E0-0x000000018274C180
	[BlackList] // 0x00000001899B9AD0-0x00000001899B9B10
	// [XID] // 0x00000001899B9AD0-0x00000001899B9B10
	public override void AutoRecycleTypeFields() {} // 0x000000018274C180-0x000000018274C230
	[BlackList] // 0x00000001899C46A0-0x00000001899C46E0
	// [XID] // 0x00000001899C46A0-0x00000001899C46E0
	public override void ReturnToObjectPool() {} // 0x000000018274E960-0x000000018274EA00
}

