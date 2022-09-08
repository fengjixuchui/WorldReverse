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
public class DoWatcherSystemAction : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16747
{
	// Fields
	private SimpleSafeUInt32 watcherIdRawNum; // 0x68
	private bool _authorityOnly; // 0x6C
	private bool _inThreatListOnly; // 0x6D

	// Properties
	public uint watcherId { /* [XID] */ /* 0x000000018960A490-0x000000018960A4B0 */ get => default; /* [XID] */ /* 0x0000000189611C60-0x0000000189611C80 */ private set {} } // 0x0000000183157C90-0x0000000183157D60 0x0000000183157150-0x0000000183157230
	public bool authorityOnly { /* [XID] */ /* 0x0000000189619520-0x0000000189619540 */ get => default; /* [XID] */ /* 0x0000000189620AC0-0x0000000189620AE0 */ private set {} } // 0x0000000183159220-0x00000001831592C0 0x0000000183157D60-0x0000000183157E10
	public bool inThreatListOnly { /* [XID] */ /* 0x0000000189628070-0x0000000189628090 */ get => default; /* [XID] */ /* 0x000000018962F900-0x000000018962F920 */ private set {} } // 0x0000000183159180-0x0000000183159220 0x0000000183157600-0x00000001831576B0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001896B3550-0x00000001896B3570 */ get => default; } // 0x0000000183158A80-0x0000000183158B20 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001896BACF0-0x00000001896BAD10 */ get => default; } // 0x00000001831580A0-0x0000000183158140 

	// Constructors
	public DoWatcherSystemAction() {} // 0x0000000183159360-0x00000001831593D0

	// Methods
	// [XID] // 0x00000001896374A0-0x00000001896374C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183159050-0x0000000183159180
	// [XID] // 0x000000018963EA40-0x000000018963EA60
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183158B80-0x0000000183158C30
	// [XID] // 0x0000000189646180-0x00000001896461A0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF44FE */) => default; // 0x00000001831586F0-0x00000001831587D0
	// [XID] // 0x000000018964D9A0-0x000000018964D9C0
	public override int GetHashNum() => default; // 0x0000000183156FB0-0x0000000183157080
	// [XID] // 0x0000000189655120-0x0000000189655140
	public override void InitEmpty() {} // 0x0000000183158140-0x0000000183158210
	[BlackList] // 0x000000018965C9C0-0x000000018965CA00
	// [XID] // 0x000000018965C9C0-0x000000018965CA00
	public override bool FromJson(JSONNode node) => default; // 0x0000000183157910-0x0000000183157C90
	// [XID] // 0x0000000189667150-0x0000000189667170
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183156600-0x00000001831569D0
	[BlackList] // 0x000000018966E8A0-0x000000018966E8E0
	// [XID] // 0x000000018966E8A0-0x000000018966E8E0
	public static new DoWatcherSystemAction ParseFromJson(JSONNode node) => default; // 0x0000000183158830-0x0000000183158A80
	// [XID] // 0x00000001896796F0-0x0000000189679710
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF44FF */, bool useObjectPool = false /* Metadata: 0x00AF4503 */) => default; // 0x00000001831583F0-0x00000001831586F0
	// [XID] // 0x0000000189680E60-0x0000000189680E80
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4504 */, bool useObjectPool = false /* Metadata: 0x00AF4508 */) => default; // 0x00000001831572B0-0x0000000183157600
	// [XID] // 0x0000000189688880-0x00000001896888A0
	public static new DoWatcherSystemAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4509 */, bool useObjectPool = false /* Metadata: 0x00AF450D */) => default; // 0x0000000183157E10-0x0000000183158030
	[BlackList] // 0x0000000189690280-0x00000001896902C0
	// [XID] // 0x0000000189690280-0x00000001896902C0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001831569D0-0x0000000183156CA0
	// [XID] // 0x000000018969A6B0-0x000000018969A6D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183158D10-0x0000000183159050
	[BlackList] // 0x00000001896A2020-0x00000001896A2060
	// [XID] // 0x00000001896A2020-0x00000001896A2060
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001831582F0-0x00000001831583F0
	// [XID] // 0x00000001896AC2B0-0x00000001896AC2D0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001831576B0-0x0000000183157810
	[BlackList] // 0x00000001896C1E00-0x00000001896C1E40
	// [XID] // 0x00000001896C1E00-0x00000001896C1E40
	public override void AutoAllocTypeFields() {} // 0x0000000183156CA0-0x0000000183156D40
	[BlackList] // 0x00000001896CC550-0x00000001896CC590
	// [XID] // 0x00000001896CC550-0x00000001896CC590
	public override void AutoRecycleTypeFields() {} // 0x0000000183156D40-0x0000000183156E20
	[BlackList] // 0x00000001896D6B20-0x00000001896D6B60
	// [XID] // 0x00000001896D6B20-0x00000001896D6B60
	public override void ReturnToObjectPool() {} // 0x00000001831592C0-0x0000000183159360
}

