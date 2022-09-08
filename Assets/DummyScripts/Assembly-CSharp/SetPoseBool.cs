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
public class SetPoseBool : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16539
{
	// Fields
	private string _boolID; // 0x68
	private bool _value; // 0x70

	// Properties
	public string boolID { /* [XID] */ /* 0x0000000189984A10-0x0000000189984A30 */ get => default; /* [XID] */ /* 0x000000018998C5D0-0x000000018998C5F0 */ private set {} } // 0x00000001832EA6B0-0x00000001832EA750 0x00000001832E9F80-0x00000001832EA030
	public bool value { /* [XID] */ /* 0x00000001899942D0-0x00000001899942F0 */ get => default; /* [XID] */ /* 0x000000018999BB20-0x000000018999BB40 */ private set {} } // 0x00000001832E97C0-0x00000001832E9860 0x00000001832E9690-0x00000001832E9740
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189A26500-0x0000000189A26520 */ get => default; } // 0x00000001832EAA00-0x00000001832EAAA0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189A2D7F0-0x0000000189A2D810 */ get => default; } // 0x00000001832E9EE0-0x00000001832E9F80 

	// Constructors
	public SetPoseBool() {} // 0x00000001832EB1A0-0x00000001832EB200

	// Methods
	// [XID] // 0x00000001899A32D0-0x00000001899A32F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001832EAF50-0x00000001832EB060
	// [XID] // 0x00000001899AAD80-0x00000001899AADA0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001832EAB00-0x00000001832EABE0
	// [XID] // 0x00000001899B2870-0x00000001899B2890
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3E96 */) => default; // 0x00000001832EA5D0-0x00000001832EA6B0
	// [XID] // 0x00000001899B9A90-0x00000001899B9AB0
	public override int GetHashNum() => default; // 0x00000001832E8FB0-0x00000001832E9080
	// [XID] // 0x00000001899C15D0-0x00000001899C15F0
	public override void InitEmpty() {} // 0x00000001832EA030-0x00000001832EA100
	[BlackList] // 0x00000001899C8B60-0x00000001899C8BA0
	// [XID] // 0x00000001899C8B60-0x00000001899C8BA0
	public override bool FromJson(JSONNode node) => default; // 0x00000001832E9860-0x00000001832E9BE0
	// [XID] // 0x00000001899D33F0-0x00000001899D3410
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001832E8710-0x00000001832E8A00
	[BlackList] // 0x00000001899DA940-0x00000001899DA980
	// [XID] // 0x00000001899DA940-0x00000001899DA980
	public static new SetPoseBool ParseFromJson(JSONNode node) => default; // 0x00000001832EA7B0-0x00000001832EAA00
	// [XID] // 0x00000001899E5500-0x00000001899E5520
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E97 */, bool useObjectPool = false /* Metadata: 0x00AF3E9B */) => default; // 0x00000001832EA2D0-0x00000001832EA5D0
	// [XID] // 0x00000001899EC7F0-0x00000001899EC810
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3E9C */, bool useObjectPool = false /* Metadata: 0x00AF3EA0 */) => default; // 0x00000001832E91D0-0x00000001832E94B0
	// [XID] // 0x00000001899F44D0-0x00000001899F44F0
	public static new SetPoseBool ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3EA1 */, bool useObjectPool = false /* Metadata: 0x00AF3EA5 */) => default; // 0x00000001832E9BE0-0x00000001832E9E00
	[BlackList] // 0x00000001899FBAD0-0x00000001899FBB10
	// [XID] // 0x00000001899FBAD0-0x00000001899FBB10
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001832E8A00-0x00000001832E8CD0
	// [XID] // 0x0000000189A06010-0x0000000189A06030
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001832EACC0-0x00000001832EAF50
	[BlackList] // 0x0000000189A0D4C0-0x0000000189A0D500
	// [XID] // 0x0000000189A0D4C0-0x0000000189A0D500
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001832EA1E0-0x00000001832EA2D0
	// [XID] // 0x0000000189A17810-0x0000000189A17830
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001832EB060-0x00000001832EB100
	// [XID] // 0x0000000189A1EEB0-0x0000000189A1EED0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001832E94B0-0x00000001832E9610
	[BlackList] // 0x0000000189A35410-0x0000000189A35450
	// [XID] // 0x0000000189A35410-0x0000000189A35450
	public override void AutoAllocTypeFields() {} // 0x00000001832E8CD0-0x00000001832E8D70
	[BlackList] // 0x0000000189A3FA60-0x0000000189A3FAA0
	// [XID] // 0x0000000189A3FA60-0x0000000189A3FAA0
	public override void AutoRecycleTypeFields() {} // 0x00000001832E8D70-0x00000001832E8E20
	[BlackList] // 0x0000000189A49EC0-0x0000000189A49F00
	// [XID] // 0x0000000189A49EC0-0x0000000189A49F00
	public override void ReturnToObjectPool() {} // 0x00000001832EB100-0x00000001832EB1A0
}

