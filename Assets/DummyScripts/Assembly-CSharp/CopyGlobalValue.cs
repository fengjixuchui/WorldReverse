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
public class CopyGlobalValue : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16397
{
	// Fields
	private AbilityTargetting _srcTarget; // 0x68
	private AbilityTargetting _dstTarget; // 0x6C
	private string _srcKey; // 0x70
	private string _dstKey; // 0x78

	// Properties
	public AbilityTargetting srcTarget { /* [XID] */ /* 0x00000001898EBE70-0x00000001898EBE90 */ get => default; /* [XID] */ /* 0x00000001898F3760-0x00000001898F3780 */ private set {} } // 0x0000000182255770-0x0000000182255810 0x00000001822556C0-0x0000000182255770
	public AbilityTargetting dstTarget { /* [XID] */ /* 0x00000001898FADE0-0x00000001898FAE00 */ get => default; /* [XID] */ /* 0x00000001899029C0-0x00000001899029E0 */ private set {} } // 0x0000000182256040-0x00000001822560E0 0x0000000182255440-0x00000001822554F0
	public string srcKey { /* [XID] */ /* 0x0000000189909EE0-0x0000000189909F00 */ get => default; /* [XID] */ /* 0x0000000189911780-0x00000001899117A0 */ private set {} } // 0x00000001822544D0-0x0000000182254570 0x0000000182255CE0-0x0000000182255D90
	public string dstKey { /* [XID] */ /* 0x0000000189919300-0x0000000189919320 */ get => default; /* [XID] */ /* 0x0000000189920890-0x00000001899208B0 */ private set {} } // 0x0000000182255220-0x00000001822552C0 0x0000000182254BD0-0x0000000182254C80
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001899AC810-0x00000001899AC830 */ get => default; } // 0x00000001822560E0-0x0000000182256180 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001899B3F80-0x00000001899B3FA0 */ get => default; } // 0x00000001822553A0-0x0000000182255440 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x00000001899BB450-0x00000001899BB470 */ get => default; } // 0x00000001822542E0-0x0000000182254380 

	// Constructors
	public CopyGlobalValue() {} // 0x0000000182256A50-0x0000000182256AC0

	// Methods
	// [XID] // 0x0000000189928250-0x0000000189928270
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001822567C0-0x0000000182256910
	// [XID] // 0x000000018992F7A0-0x000000018992F7C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182256250-0x0000000182256350
	// [XID] // 0x0000000189936C50-0x0000000189936C70
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3A30 */) => default; // 0x0000000182255C00-0x0000000182255CE0
	// [XID] // 0x000000018993E830-0x000000018993E850
	public override int GetHashNum() => default; // 0x0000000182254210-0x00000001822542E0
	// [XID] // 0x0000000189945E20-0x0000000189945E40
	public override void InitEmpty() {} // 0x00000001822554F0-0x00000001822555E0
	[BlackList] // 0x000000018994D330-0x000000018994D370
	// [XID] // 0x000000018994D330-0x000000018994D370
	public override bool FromJson(JSONNode node) => default; // 0x0000000182254C80-0x0000000182255000
	// [XID] // 0x0000000189957C20-0x0000000189957C40
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001822537A0-0x0000000182253C50
	[BlackList] // 0x000000018995F4F0-0x000000018995F530
	// [XID] // 0x000000018995F4F0-0x000000018995F530
	public static new CopyGlobalValue ParseFromJson(JSONNode node) => default; // 0x0000000182255DF0-0x0000000182256040
	// [XID] // 0x0000000189969B80-0x0000000189969BA0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A31 */, bool useObjectPool = false /* Metadata: 0x00AF3A35 */) => default; // 0x0000000182255900-0x0000000182255C00
	// [XID] // 0x0000000189971920-0x0000000189971940
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A36 */, bool useObjectPool = false /* Metadata: 0x00AF3A3A */) => default; // 0x0000000182254570-0x0000000182254970
	// [XID] // 0x00000001899791F0-0x0000000189979210
	public static new CopyGlobalValue ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3A3B */, bool useObjectPool = false /* Metadata: 0x00AF3A3F */) => default; // 0x0000000182255000-0x0000000182255220
	[BlackList] // 0x00000001899802A0-0x00000001899802E0
	// [XID] // 0x00000001899802A0-0x00000001899802E0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182253C50-0x0000000182253F20
	// [XID] // 0x000000018998AEC0-0x000000018998AEE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182256430-0x00000001822567C0
	[BlackList] // 0x00000001899927F0-0x0000000189992830
	// [XID] // 0x00000001899927F0-0x0000000189992830
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182255810-0x0000000182255900
	// [XID] // 0x000000018999D2F0-0x000000018999D310
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000182256910-0x00000001822569B0
	// [XID] // 0x00000001899A4C70-0x00000001899A4C90
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182254970-0x0000000182254AD0
	[BlackList] // 0x00000001899C2F40-0x00000001899C2F80
	// [XID] // 0x00000001899C2F40-0x00000001899C2F80
	public override void AutoAllocTypeFields() {} // 0x0000000182253F20-0x0000000182253FC0
	[BlackList] // 0x00000001899CD570-0x00000001899CD5B0
	// [XID] // 0x00000001899CD570-0x00000001899CD5B0
	public override void AutoRecycleTypeFields() {} // 0x0000000182253FC0-0x0000000182254080
	[BlackList] // 0x00000001899D79D0-0x00000001899D7A10
	// [XID] // 0x00000001899D79D0-0x00000001899D7A10
	public override void ReturnToObjectPool() {} // 0x00000001822569B0-0x0000000182256A50
}

