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
public class SetPaimonTempOffset : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16637
{
	// Fields
	private PaimonRequestFrom _from; // 0x68
	private MoleMole.Config.Vector _offSetPos; // 0x6C
	private SimpleSafeFloat timeRawNum; // 0x78

	// Properties
	public PaimonRequestFrom from { /* [XID] */ /* 0x00000001898E77B0-0x00000001898E77D0 */ get => default; /* [XID] */ /* 0x00000001898EEF40-0x00000001898EEF60 */ private set {} } // 0x0000000184611210-0x00000001846112B0 0x0000000184611670-0x0000000184611720
	public MoleMole.Config.Vector offSetPos { /* [XID] */ /* 0x00000001898F6800-0x00000001898F6820 */ get => default; /* [XID] */ /* 0x00000001898FDFA0-0x00000001898FDFC0 */ private set {} } // 0x0000000184610FB0-0x0000000184611090 0x00000001846112B0-0x0000000184611380
	public float time { /* [XID] */ /* 0x00000001899057C0-0x00000001899057E0 */ get => default; /* [XID] */ /* 0x000000018990D010-0x000000018990D030 */ private set {} } // 0x0000000184612680-0x0000000184612760 0x00000001846123B0-0x0000000184612490
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189998A50-0x0000000189998A70 */ get => default; } // 0x0000000184611DB0-0x0000000184611E50 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001899A0390-0x00000001899A03B0 */ get => default; } // 0x0000000184611170-0x0000000184611210 

	// Constructors
	public SetPaimonTempOffset() {} // 0x0000000184612800-0x0000000184612860

	// Methods
	// [XID] // 0x00000001899147C0-0x00000001899147E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184612490-0x00000001846125E0
	// [XID] // 0x000000018991C3A0-0x000000018991C3C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184611EB0-0x0000000184611F60
	// [XID] // 0x0000000189923AC0-0x0000000189923AE0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF419A */) => default; // 0x0000000184611A20-0x0000000184611B00
	// [XID] // 0x000000018992B1A0-0x000000018992B1C0
	public override int GetHashNum() => default; // 0x0000000184610220-0x00000001846102F0
	// [XID] // 0x00000001899327E0-0x0000000189932800
	public override void InitEmpty() {} // 0x0000000184611380-0x0000000184611490
	[BlackList] // 0x000000018993A1F0-0x000000018993A230
	// [XID] // 0x000000018993A1F0-0x000000018993A230
	public override bool FromJson(JSONNode node) => default; // 0x0000000184610A10-0x0000000184610D90
	// [XID] // 0x0000000189944640-0x0000000189944660
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018460F800-0x000000018460FC30
	[BlackList] // 0x000000018994BC40-0x000000018994BC80
	// [XID] // 0x000000018994BC40-0x000000018994BC80
	public static new SetPaimonTempOffset ParseFromJson(JSONNode node) => default; // 0x0000000184611B60-0x0000000184611DB0
	// [XID] // 0x00000001899561C0-0x00000001899561E0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF419B */, bool useObjectPool = false /* Metadata: 0x00AF419F */) => default; // 0x0000000184611720-0x0000000184611A20
	// [XID] // 0x000000018995DCF0-0x000000018995DD10
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF41A0 */, bool useObjectPool = false /* Metadata: 0x00AF41A4 */) => default; // 0x0000000184610440-0x00000001846107B0
	// [XID] // 0x00000001899654F0-0x0000000189965510
	public static new SetPaimonTempOffset ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF41A5 */, bool useObjectPool = false /* Metadata: 0x00AF41A9 */) => default; // 0x0000000184610D90-0x0000000184610FB0
	[BlackList] // 0x000000018996CB30-0x000000018996CB70
	// [XID] // 0x000000018996CB30-0x000000018996CB70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018460FC30-0x000000018460FF00
	// [XID] // 0x0000000189977540-0x0000000189977560
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184612040-0x00000001846123B0
	[BlackList] // 0x000000018997E860-0x000000018997E8A0
	// [XID] // 0x000000018997E860-0x000000018997E8A0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184611570-0x0000000184611670
	// [XID] // 0x0000000189989760-0x0000000189989780
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001846125E0-0x0000000184612680
	// [XID] // 0x0000000189990FD0-0x0000000189990FF0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001846107B0-0x0000000184610910
	[BlackList] // 0x00000001899A7F40-0x00000001899A7F80
	// [XID] // 0x00000001899A7F40-0x00000001899A7F80
	public override void AutoAllocTypeFields() {} // 0x000000018460FF00-0x000000018460FFA0
	[BlackList] // 0x00000001899B2830-0x00000001899B2870
	// [XID] // 0x00000001899B2830-0x00000001899B2870
	public override void AutoRecycleTypeFields() {} // 0x000000018460FFA0-0x0000000184610090
	[BlackList] // 0x00000001899BCC30-0x00000001899BCC70
	// [XID] // 0x00000001899BCC30-0x00000001899BCC70
	public override void ReturnToObjectPool() {} // 0x0000000184612760-0x0000000184612800
}

