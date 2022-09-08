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
public class ResetAbilitySpecial : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16675
{
	// Fields
	private string _keyName; // 0x68
	private string _valueName; // 0x70

	// Properties
	public string keyName { /* [XID] */ /* 0x0000000189629A90-0x0000000189629AB0 */ get => default; /* [XID] */ /* 0x0000000189631320-0x0000000189631340 */ private set {} } // 0x0000000182222FB0-0x0000000182223050 0x0000000182224140-0x00000001822241F0
	public string valueName { /* [XID] */ /* 0x0000000189638C70-0x0000000189638C90 */ get => default; /* [XID] */ /* 0x0000000189640130-0x0000000189640150 */ private set {} } // 0x0000000182223320-0x00000001822233C0 0x00000001822241F0-0x00000001822242A0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001896CACD0-0x00000001896CACF0 */ get => default; } // 0x0000000182223A50-0x0000000182223AF0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001896D2360-0x00000001896D2380 */ get => default; } // 0x0000000182222F10-0x0000000182222FB0 
	protected override bool ForceForwardToServer { /* [XID] */ /* 0x00000001896D9D10-0x00000001896D9D30 */ get => default; } // 0x0000000182222140-0x00000001822221E0 

	// Constructors
	public ResetAbilitySpecial() {} // 0x00000001822243E0-0x0000000182224440

	// Methods
	// [XID] // 0x0000000189647990-0x00000001896479B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182224030-0x0000000182224140
	// [XID] // 0x000000018964F000-0x000000018964F020
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182223BC0-0x0000000182223CC0
	// [XID] // 0x0000000189656890-0x00000001896568B0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF42BE */) => default; // 0x00000001822236C0-0x00000001822237A0
	// [XID] // 0x000000018965DF90-0x000000018965DFB0
	public override int GetHashNum() => default; // 0x0000000182222070-0x0000000182222140
	// [XID] // 0x00000001896656F0-0x0000000189665710
	public override void InitEmpty() {} // 0x0000000182223050-0x0000000182223140
	[BlackList] // 0x000000018966CE20-0x000000018966CE60
	// [XID] // 0x000000018966CE20-0x000000018966CE60
	public override bool FromJson(JSONNode node) => default; // 0x0000000182222890-0x0000000182222C10
	// [XID] // 0x0000000189677D70-0x0000000189677D90
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001822217B0-0x0000000182221AC0
	[BlackList] // 0x000000018967F2C0-0x000000018967F300
	// [XID] // 0x000000018967F2C0-0x000000018967F300
	public static new ResetAbilitySpecial ParseFromJson(JSONNode node) => default; // 0x0000000182223800-0x0000000182223A50
	// [XID] // 0x0000000189689E10-0x0000000189689E30
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF42BF */, bool useObjectPool = false /* Metadata: 0x00AF42C3 */) => default; // 0x00000001822233C0-0x00000001822236C0
	// [XID] // 0x0000000189691BD0-0x0000000189691BF0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF42C4 */, bool useObjectPool = false /* Metadata: 0x00AF42C8 */) => default; // 0x0000000182222330-0x0000000182222630
	// [XID] // 0x0000000189699120-0x0000000189699140
	public static new ResetAbilitySpecial ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF42C9 */, bool useObjectPool = false /* Metadata: 0x00AF42CD */) => default; // 0x0000000182222C10-0x0000000182222E30
	[BlackList] // 0x00000001896A0630-0x00000001896A0670
	// [XID] // 0x00000001896A0630-0x00000001896A0670
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182221AC0-0x0000000182221D90
	// [XID] // 0x00000001896AAA10-0x00000001896AAA30
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182223DA0-0x0000000182224030
	[BlackList] // 0x00000001896B1990-0x00000001896B19D0
	// [XID] // 0x00000001896B1990-0x00000001896B19D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182223220-0x0000000182223320
	// [XID] // 0x00000001896BC320-0x00000001896BC340
	public override bool isAlreadyHandledRecoverCase() => default; // 0x00000001822242A0-0x0000000182224340
	// [XID] // 0x00000001896C37C0-0x00000001896C37E0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182222630-0x0000000182222790
	[BlackList] // 0x00000001896E1370-0x00000001896E13B0
	// [XID] // 0x00000001896E1370-0x00000001896E13B0
	public override void AutoAllocTypeFields() {} // 0x0000000182221D90-0x0000000182221E30
	[BlackList] // 0x00000001896EB6E0-0x00000001896EB720
	// [XID] // 0x00000001896EB6E0-0x00000001896EB720
	public override void AutoRecycleTypeFields() {} // 0x0000000182221E30-0x0000000182221EE0
	[BlackList] // 0x00000001896F5E40-0x00000001896F5E80
	// [XID] // 0x00000001896F5E40-0x00000001896F5E80
	public override void ReturnToObjectPool() {} // 0x0000000182224340-0x00000001822243E0
}

