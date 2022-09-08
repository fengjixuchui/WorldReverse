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
public class EnableCameraDof : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16695
{
	// Fields
	private bool _enableDof; // 0x68

	// Properties
	public bool enableDof { /* [XID] */ /* 0x0000000189880540-0x0000000189880560 */ get => default; /* [XID] */ /* 0x0000000189887A60-0x0000000189887A80 */ private set {} } // 0x00000001845A2850-0x00000001845A28F0 0x00000001845A1A20-0x00000001845A1AD0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001899132C0-0x00000001899132E0 */ get => default; } // 0x00000001845A2BA0-0x00000001845A2C40 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018991AA50-0x000000018991AA70 */ get => default; } // 0x00000001845A2150-0x00000001845A21F0 

	// Constructors
	public EnableCameraDof() {} // 0x00000001845A3260-0x00000001845A32C0

	// Methods
	// [XID] // 0x000000018988ED60-0x000000018988ED80
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001845A3030-0x00000001845A3120
	// [XID] // 0x00000001898962E0-0x0000000189896300
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001845A2CA0-0x00000001845A2D50
	// [XID] // 0x000000018989D960-0x000000018989D980
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF435E */) => default; // 0x00000001845A2770-0x00000001845A2850
	// [XID] // 0x00000001898A52A0-0x00000001898A52C0
	public override int GetHashNum() => default; // 0x00000001845A1370-0x00000001845A1440
	// [XID] // 0x00000001898AC800-0x00000001898AC820
	public override void InitEmpty() {} // 0x00000001845A21F0-0x00000001845A2290
	[BlackList] // 0x00000001898B3D00-0x00000001898B3D40
	// [XID] // 0x00000001898B3D00-0x00000001898B3D40
	public override bool FromJson(JSONNode node) => default; // 0x00000001845A1AD0-0x00000001845A1E50
	// [XID] // 0x00000001898BE640-0x00000001898BE660
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001845A0BC0-0x00000001845A0DC0
	[BlackList] // 0x00000001898C5DF0-0x00000001898C5E30
	// [XID] // 0x00000001898C5DF0-0x00000001898C5E30
	public static new EnableCameraDof ParseFromJson(JSONNode node) => default; // 0x00000001845A2950-0x00000001845A2BA0
	// [XID] // 0x00000001898D0840-0x00000001898D0860
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF435F */, bool useObjectPool = false /* Metadata: 0x00AF4363 */) => default; // 0x00000001845A2470-0x00000001845A2770
	// [XID] // 0x00000001898D7F00-0x00000001898D7F20
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4364 */, bool useObjectPool = false /* Metadata: 0x00AF4368 */) => default; // 0x00000001845A1590-0x00000001845A17C0
	// [XID] // 0x00000001898DFD00-0x00000001898DFD20
	public static new EnableCameraDof ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4369 */, bool useObjectPool = false /* Metadata: 0x00AF436D */) => default; // 0x00000001845A1E50-0x00000001845A2070
	[BlackList] // 0x00000001898E7770-0x00000001898E77B0
	// [XID] // 0x00000001898E7770-0x00000001898E77B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001845A0DC0-0x00000001845A1090
	// [XID] // 0x00000001898F1EB0-0x00000001898F1ED0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001845A2E30-0x00000001845A3030
	[BlackList] // 0x00000001898F9730-0x00000001898F9770
	// [XID] // 0x00000001898F9730-0x00000001898F9770
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001845A2370-0x00000001845A2470
	// [XID] // 0x0000000189904010-0x0000000189904030
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001845A3120-0x00000001845A31C0
	// [XID] // 0x000000018990B5D0-0x000000018990B5F0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001845A17C0-0x00000001845A1920
	[BlackList] // 0x00000001899222E0-0x0000000189922320
	// [XID] // 0x00000001899222E0-0x0000000189922320
	public override void AutoAllocTypeFields() {} // 0x00000001845A1090-0x00000001845A1130
	[BlackList] // 0x000000018992C6E0-0x000000018992C720
	// [XID] // 0x000000018992C6E0-0x000000018992C720
	public override void AutoRecycleTypeFields() {} // 0x00000001845A1130-0x00000001845A11E0
	[BlackList] // 0x0000000189936B90-0x0000000189936BD0
	// [XID] // 0x0000000189936B90-0x0000000189936BD0
	public override void ReturnToObjectPool() {} // 0x00000001845A31C0-0x00000001845A3260
}

