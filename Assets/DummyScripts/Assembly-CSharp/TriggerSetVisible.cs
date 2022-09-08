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
public class TriggerSetVisible : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16523
{
	// Fields
	private bool _visible; // 0x68

	// Properties
	public bool visible { /* [XID] */ /* 0x000000018991F060-0x000000018991F080 */ get => default; /* [XID] */ /* 0x0000000189926B40-0x0000000189926B60 */ private set {} } // 0x0000000182B37030-0x0000000182B370D0 0x0000000182B35FF0-0x0000000182B360A0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001899B2890-0x00000001899B28B0 */ get => default; } // 0x0000000182B36AB0-0x0000000182B36B50 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001899B9AB0-0x00000001899B9AD0 */ get => default; } // 0x0000000182B36110-0x0000000182B361B0 

	// Constructors
	public TriggerSetVisible() {} // 0x0000000182B37210-0x0000000182B37270

	// Methods
	// [XID] // 0x000000018992E190-0x000000018992E1B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182B36F40-0x0000000182B37030
	// [XID] // 0x0000000189935570-0x0000000189935590
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182B36BB0-0x0000000182B36C60
	// [XID] // 0x000000018993D0D0-0x000000018993D0F0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3E16 */) => default; // 0x0000000182B36720-0x0000000182B36800
	// [XID] // 0x0000000189944680-0x00000001899446A0
	public override int GetHashNum() => default; // 0x0000000182B35330-0x0000000182B35400
	// [XID] // 0x000000018994BCC0-0x000000018994BCE0
	public override void InitEmpty() {} // 0x0000000182B361B0-0x0000000182B36250
	[BlackList] // 0x0000000189953450-0x0000000189953490
	// [XID] // 0x0000000189953450-0x0000000189953490
	public override bool FromJson(JSONNode node) => default; // 0x0000000182B359E0-0x0000000182B35D60
	// [XID] // 0x000000018995DD70-0x000000018995DD90
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182B34B80-0x0000000182B34D80
	[BlackList] // 0x0000000189965550-0x0000000189965590
	// [XID] // 0x0000000189965550-0x0000000189965590
	public static new TriggerSetVisible ParseFromJson(JSONNode node) => default; // 0x0000000182B36860-0x0000000182B36AB0
	// [XID] // 0x000000018996F8A0-0x000000018996F8C0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E17 */, bool useObjectPool = false /* Metadata: 0x00AF3E1B */) => default; // 0x0000000182B36420-0x0000000182B36720
	// [XID] // 0x00000001899775E0-0x0000000189977600
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E1C */, bool useObjectPool = false /* Metadata: 0x00AF3E20 */) => default; // 0x0000000182B35550-0x0000000182B35780
	// [XID] // 0x000000018997E8A0-0x000000018997E8C0
	public static new TriggerSetVisible ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E21 */, bool useObjectPool = false /* Metadata: 0x00AF3E25 */) => default; // 0x0000000182B35D60-0x0000000182B35F80
	[BlackList] // 0x0000000189986290-0x00000001899862D0
	// [XID] // 0x0000000189986290-0x00000001899862D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182B34D80-0x0000000182B35050
	// [XID] // 0x0000000189991030-0x0000000189991050
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182B36D40-0x0000000182B36F40
	[BlackList] // 0x0000000189998AD0-0x0000000189998B10
	// [XID] // 0x0000000189998AD0-0x0000000189998B10
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182B36330-0x0000000182B36420
	// [XID] // 0x00000001899A32F0-0x00000001899A3310
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000182B370D0-0x0000000182B37170
	// [XID] // 0x00000001899AADA0-0x00000001899AADC0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182B35780-0x0000000182B358E0
	[BlackList] // 0x00000001899C15F0-0x00000001899C1630
	// [XID] // 0x00000001899C15F0-0x00000001899C1630
	public override void AutoAllocTypeFields() {} // 0x0000000182B35050-0x0000000182B350F0
	[BlackList] // 0x00000001899CBEA0-0x00000001899CBEE0
	// [XID] // 0x00000001899CBEA0-0x00000001899CBEE0
	public override void AutoRecycleTypeFields() {} // 0x0000000182B350F0-0x0000000182B351A0
	[BlackList] // 0x00000001899D62F0-0x00000001899D6330
	// [XID] // 0x00000001899D62F0-0x00000001899D6330
	public override void ReturnToObjectPool() {} // 0x0000000182B37170-0x0000000182B37210
}

