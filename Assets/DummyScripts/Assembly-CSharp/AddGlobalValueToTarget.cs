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
public class AddGlobalValueToTarget : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16761
{
	// Fields
	private AbilityTargetting _srcTarget; // 0x68
	private AbilityTargetting _dstTarget; // 0x6C
	private string _srcKey; // 0x70
	private string _dstKey; // 0x78

	// Properties
	public AbilityTargetting srcTarget { /* [XID] */ /* 0x000000018966A280-0x000000018966A2A0 */ get => default; /* [XID] */ /* 0x0000000189671EE0-0x0000000189671F00 */ private set {} } // 0x0000000182842E90-0x0000000182842F30 0x0000000182842DE0-0x0000000182842E90
	public AbilityTargetting dstTarget { /* [XID] */ /* 0x00000001896796D0-0x00000001896796F0 */ get => default; /* [XID] */ /* 0x0000000189680E40-0x0000000189680E60 */ private set {} } // 0x0000000182843770-0x0000000182843810 0x0000000182842B60-0x0000000182842C10
	public string srcKey { /* [XID] */ /* 0x0000000189688860-0x0000000189688880 */ get => default; /* [XID] */ /* 0x0000000189690260-0x0000000189690280 */ private set {} } // 0x0000000182841C60-0x0000000182841D00 0x0000000182843410-0x00000001828434C0
	public string dstKey { /* [XID] */ /* 0x0000000189697BC0-0x0000000189697BE0 */ get => default; /* [XID] */ /* 0x000000018969EF30-0x000000018969EF50 */ private set {} } // 0x00000001828429B0-0x0000000182842A50 0x0000000182842360-0x0000000182842410
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189721190-0x00000001897211B0 */ get => default; } // 0x0000000182843810-0x00000001828438B0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189728790-0x00000001897287B0 */ get => default; } // 0x0000000182842AC0-0x0000000182842B60 

	// Constructors
	public AddGlobalValueToTarget() {} // 0x0000000182844070-0x00000001828440E0

	// Methods
	// [XID] // 0x00000001896A63D0-0x00000001896A63F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182843E80-0x0000000182843FD0
	// [XID] // 0x00000001896AD990-0x00000001896AD9B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182843910-0x0000000182843A10
	// [XID] // 0x00000001896B50F0-0x00000001896B5110
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF456E */) => default; // 0x0000000182843330-0x0000000182843410
	// [XID] // 0x00000001896BC300-0x00000001896BC320
	public override int GetHashNum() => default; // 0x0000000182841A40-0x0000000182841B10
	// [XID] // 0x00000001896C37A0-0x00000001896C37C0
	public override void InitEmpty() {} // 0x0000000182842C10-0x0000000182842D00
	[BlackList] // 0x00000001896CAC90-0x00000001896CACD0
	// [XID] // 0x00000001896CAC90-0x00000001896CACD0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182842410-0x0000000182842790
	// [XID] // 0x00000001896D5440-0x00000001896D5460
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182840FD0-0x0000000182841480
	[BlackList] // 0x00000001896DC960-0x00000001896DC9A0
	// [XID] // 0x00000001896DC960-0x00000001896DC9A0
	public static new AddGlobalValueToTarget ParseFromJson(JSONNode node) => default; // 0x0000000182843520-0x0000000182843770
	// [XID] // 0x00000001896E6FA0-0x00000001896E6FC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF456F */, bool useObjectPool = false /* Metadata: 0x00AF4573 */) => default; // 0x0000000182843030-0x0000000182843330
	// [XID] // 0x00000001896EE510-0x00000001896EE530
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4574 */, bool useObjectPool = false /* Metadata: 0x00AF4578 */) => default; // 0x0000000182841D00-0x0000000182842100
	// [XID] // 0x00000001896F5E20-0x00000001896F5E40
	public static new AddGlobalValueToTarget ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4579 */, bool useObjectPool = false /* Metadata: 0x00AF457D */) => default; // 0x0000000182842790-0x00000001828429B0
	[BlackList] // 0x00000001896FD5F0-0x00000001896FD630
	// [XID] // 0x00000001896FD5F0-0x00000001896FD630
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182841480-0x0000000182841750
	// [XID] // 0x0000000189707A30-0x0000000189707A50
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182843AF0-0x0000000182843E80
	[BlackList] // 0x000000018970F420-0x000000018970F460
	// [XID] // 0x000000018970F420-0x000000018970F460
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182842F30-0x0000000182843030
	// [XID] // 0x0000000189719B90-0x0000000189719BB0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182842100-0x0000000182842260
	[BlackList] // 0x000000018972FF00-0x000000018972FF40
	// [XID] // 0x000000018972FF00-0x000000018972FF40
	public override void AutoAllocTypeFields() {} // 0x0000000182841750-0x00000001828417F0
	[BlackList] // 0x000000018973A490-0x000000018973A4D0
	// [XID] // 0x000000018973A490-0x000000018973A4D0
	public override void AutoRecycleTypeFields() {} // 0x00000001828417F0-0x00000001828418B0
	[BlackList] // 0x0000000189744D30-0x0000000189744D70
	// [XID] // 0x0000000189744D30-0x0000000189744D70
	public override void ReturnToObjectPool() {} // 0x0000000182843FD0-0x0000000182844070
}

