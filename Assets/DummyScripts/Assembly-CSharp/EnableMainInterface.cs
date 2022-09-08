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
public class EnableMainInterface : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16691
{
	// Fields
	private bool _enable; // 0x68

	// Properties
	public bool enable { /* [XID] */ /* 0x00000001896EFB80-0x00000001896EFBA0 */ get => default; /* [XID] */ /* 0x00000001896F7590-0x00000001896F75B0 */ private set {} } // 0x000000018339BFD0-0x000000018339C070 0x000000018339CD20-0x000000018339CDD0
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001897822E0-0x0000000189782300 */ get => default; } // 0x000000018339CDD0-0x000000018339CE70 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189789660-0x0000000189789680 */ get => default; } // 0x000000018339C370-0x000000018339C410 

	// Constructors
	public EnableMainInterface() {} // 0x000000018339D490-0x000000018339D4F0

	// Methods
	// [XID] // 0x00000001896FEF50-0x00000001896FEF70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018339D260-0x000000018339D350
	// [XID] // 0x00000001897061C0-0x00000001897061E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018339CED0-0x000000018339CF80
	// [XID] // 0x000000018970DB10-0x000000018970DB30
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF433E */) => default; // 0x000000018339C990-0x000000018339CA70
	// [XID] // 0x0000000189714EF0-0x0000000189714F10
	public override int GetHashNum() => default; // 0x000000018339B5A0-0x000000018339B670
	// [XID] // 0x000000018971C9E0-0x000000018971CA00
	public override void InitEmpty() {} // 0x000000018339C410-0x000000018339C4B0
	[BlackList] // 0x0000000189723DF0-0x0000000189723E30
	// [XID] // 0x0000000189723DF0-0x0000000189723E30
	public override bool FromJson(JSONNode node) => default; // 0x000000018339BC50-0x000000018339BFD0
	// [XID] // 0x000000018972E630-0x000000018972E650
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018339ADF0-0x000000018339AFF0
	[BlackList] // 0x0000000189735DA0-0x0000000189735DE0
	// [XID] // 0x0000000189735DA0-0x0000000189735DE0
	public static new EnableMainInterface ParseFromJson(JSONNode node) => default; // 0x000000018339CAD0-0x000000018339CD20
	// [XID] // 0x0000000189740BA0-0x0000000189740BC0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF433F */, bool useObjectPool = false /* Metadata: 0x00AF4343 */) => default; // 0x000000018339C690-0x000000018339C990
	// [XID] // 0x0000000189747FE0-0x0000000189748000
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4344 */, bool useObjectPool = false /* Metadata: 0x00AF4348 */) => default; // 0x000000018339B7C0-0x000000018339B9F0
	// [XID] // 0x000000018974F770-0x000000018974F790
	public static new EnableMainInterface ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF4349 */, bool useObjectPool = false /* Metadata: 0x00AF434D */) => default; // 0x000000018339C070-0x000000018339C290
	[BlackList] // 0x0000000189756DE0-0x0000000189756E20
	// [XID] // 0x0000000189756DE0-0x0000000189756E20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018339AFF0-0x000000018339B2C0
	// [XID] // 0x0000000189761630-0x0000000189761650
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018339D060-0x000000018339D260
	[BlackList] // 0x0000000189768940-0x0000000189768980
	// [XID] // 0x0000000189768940-0x0000000189768980
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018339C590-0x000000018339C690
	// [XID] // 0x00000001897730E0-0x0000000189773100
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018339D350-0x000000018339D3F0
	// [XID] // 0x000000018977A6C0-0x000000018977A6E0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018339B9F0-0x000000018339BB50
	[BlackList] // 0x0000000189790D70-0x0000000189790DB0
	// [XID] // 0x0000000189790D70-0x0000000189790DB0
	public override void AutoAllocTypeFields() {} // 0x000000018339B2C0-0x000000018339B360
	[BlackList] // 0x000000018979BE70-0x000000018979BEB0
	// [XID] // 0x000000018979BE70-0x000000018979BEB0
	public override void AutoRecycleTypeFields() {} // 0x000000018339B360-0x000000018339B410
	[BlackList] // 0x00000001897A6500-0x00000001897A6540
	// [XID] // 0x00000001897A6500-0x00000001897A6540
	public override void ReturnToObjectPool() {} // 0x000000018339D3F0-0x000000018339D490
}

