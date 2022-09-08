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
public class EnableHeadControl : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16583
{
	// Fields
	private bool _enable; // 0x68
	private bool _blend; // 0x69

	// Properties
	public bool enable { /* [XID] */ /* 0x00000001899AF5F0-0x00000001899AF610 */ get => default; /* [XID] */ /* 0x00000001899B6B30-0x00000001899B6B50 */ private set {} } // 0x0000000182B4AE70-0x0000000182B4AF10 0x0000000182B4BC50-0x0000000182B4BD00
	public bool blend { /* [XID] */ /* 0x00000001899BE610-0x00000001899BE630 */ get => default; /* [XID] */ /* 0x00000001899C5DF0-0x00000001899C5E10 */ private set {} } // 0x0000000182B4B130-0x0000000182B4B1D0 0x0000000182B4C220-0x0000000182B4C2D0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A500A0-0x0000000189A500C0 */ get => default; } // 0x0000000182B4BD00-0x0000000182B4BDA0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A57670-0x0000000189A57690 */ get => default; } // 0x0000000182B4B2B0-0x0000000182B4B350 

	// Constructors
	public EnableHeadControl() {} // 0x0000000182B4C520-0x0000000182B4C590

	// Methods
	// [XID] // 0x00000001899CD530-0x00000001899CD550
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182B4C2D0-0x0000000182B4C3E0
	// [XID] // 0x00000001899D4A30-0x00000001899D4A50
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182B4BE00-0x0000000182B4BEB0
	// [XID] // 0x00000001899DC030-0x00000001899DC050
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3FEA */) => default; // 0x0000000182B4B8C0-0x0000000182B4B9A0
	// [XID] // 0x00000001899E39B0-0x00000001899E39D0
	public override int GetHashNum() => default; // 0x0000000182B4A3D0-0x0000000182B4A4A0
	// [XID] // 0x00000001899EADE0-0x00000001899EAE00
	public override void InitEmpty() {} // 0x0000000182B4B350-0x0000000182B4B3F0
	[BlackList] // 0x00000001899F29E0-0x00000001899F2A20
	// [XID] // 0x00000001899F29E0-0x00000001899F2A20
	public override bool FromJson(JSONNode node) => default; // 0x0000000182B4AAF0-0x0000000182B4AE70
	// [XID] // 0x00000001899FCFF0-0x00000001899FD010
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182B49B50-0x0000000182B49E20
	[BlackList] // 0x0000000189A04490-0x0000000189A044D0
	// [XID] // 0x0000000189A04490-0x0000000189A044D0
	public static new EnableHeadControl ParseFromJson(JSONNode node) => default; // 0x0000000182B4BA00-0x0000000182B4BC50
	// [XID] // 0x0000000189A0EA90-0x0000000189A0EAB0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3FEB */, bool useObjectPool = false /* Metadata: 0x00AF3FEF */) => default; // 0x0000000182B4B5C0-0x0000000182B4B8C0
	// [XID] // 0x0000000189A161C0-0x0000000189A161E0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3FF0 */, bool useObjectPool = false /* Metadata: 0x00AF3FF4 */) => default; // 0x0000000182B4A5F0-0x0000000182B4A890
	// [XID] // 0x0000000189A1D760-0x0000000189A1D780
	public static new EnableHeadControl ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3FF5 */, bool useObjectPool = false /* Metadata: 0x00AF3FF9 */) => default; // 0x0000000182B4AF10-0x0000000182B4B130
	[BlackList] // 0x0000000189A24AF0-0x0000000189A24B30
	// [XID] // 0x0000000189A24AF0-0x0000000189A24B30
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182B49E20-0x0000000182B4A0F0
	// [XID] // 0x0000000189A2F270-0x0000000189A2F290
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182B4BF90-0x0000000182B4C220
	[BlackList] // 0x0000000189A36CD0-0x0000000189A36D10
	// [XID] // 0x0000000189A36CD0-0x0000000189A36D10
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182B4B4D0-0x0000000182B4B5C0
	// [XID] // 0x0000000189A41310-0x0000000189A41330
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000182B4C3E0-0x0000000182B4C480
	// [XID] // 0x0000000189A48930-0x0000000189A48950
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182B4A890-0x0000000182B4A9F0
	[BlackList] // 0x0000000189A5F190-0x0000000189A5F1D0
	// [XID] // 0x0000000189A5F190-0x0000000189A5F1D0
	public override void AutoAllocTypeFields() {} // 0x0000000182B4A0F0-0x0000000182B4A190
	[BlackList] // 0x0000000189A69E10-0x0000000189A69E50
	// [XID] // 0x0000000189A69E10-0x0000000189A69E50
	public override void AutoRecycleTypeFields() {} // 0x0000000182B4A190-0x0000000182B4A240
	[BlackList] // 0x0000000189A74250-0x0000000189A74290
	// [XID] // 0x0000000189A74250-0x0000000189A74290
	public override void ReturnToObjectPool() {} // 0x0000000182B4C480-0x0000000182B4C520
}

