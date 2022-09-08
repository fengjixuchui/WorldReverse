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
public class DoWidgetSystemAction : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16797
{
	// Fields
	private WidgetEventType _widgetEvent; // 0x68

	// Properties
	public WidgetEventType widgetEvent { /* [XID] */ /* 0x00000001896C6870-0x00000001896C6890 */ get => default; /* [XID] */ /* 0x00000001896CDE90-0x00000001896CDEB0 */ private set {} } // 0x00000001825DFB90-0x00000001825DFC30 0x00000001825DE590-0x00000001825DE640
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189750D00-0x0000000189750D20 */ get => default; } // 0x00000001825DF700-0x00000001825DF7A0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189758110-0x0000000189758130 */ get => default; } // 0x00000001825DED50-0x00000001825DEDF0 

	// Constructors
	public DoWidgetSystemAction() {} // 0x00000001825DFDC0-0x00000001825DFE20

	// Methods
	// [XID] // 0x00000001896D53E0-0x00000001896D5400
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001825DFC30-0x00000001825DFD20
	// [XID] // 0x00000001896DC940-0x00000001896DC960
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001825DF800-0x00000001825DF8B0
	// [XID] // 0x00000001896E4310-0x00000001896E4330
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF469E */) => default; // 0x00000001825DF370-0x00000001825DF450
	// [XID] // 0x00000001896EB6C0-0x00000001896EB6E0
	public override int GetHashNum() => default; // 0x00000001825DDFE0-0x00000001825DE0B0
	// [XID] // 0x00000001896F2AD0-0x00000001896F2AF0
	public override void InitEmpty() {} // 0x00000001825DEDF0-0x00000001825DEE90
	[BlackList] // 0x00000001896FA3D0-0x00000001896FA410
	// [XID] // 0x00000001896FA3D0-0x00000001896FA410
	public override bool FromJson(JSONNode node) => default; // 0x00000001825DE740-0x00000001825DEAC0
	// [XID] // 0x0000000189704A50-0x0000000189704A70
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001825DD810-0x00000001825DDA30
	[BlackList] // 0x000000018970C1F0-0x000000018970C230
	// [XID] // 0x000000018970C1F0-0x000000018970C230
	public static new DoWidgetSystemAction ParseFromJson(JSONNode node) => default; // 0x00000001825DF4B0-0x00000001825DF700
	// [XID] // 0x00000001897167A0-0x00000001897167C0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF469F */, bool useObjectPool = false /* Metadata: 0x00AF46A3 */) => default; // 0x00000001825DF070-0x00000001825DF370
	// [XID] // 0x000000018971E1E0-0x000000018971E200
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF46A4 */, bool useObjectPool = false /* Metadata: 0x00AF46A8 */) => default; // 0x00000001825DE200-0x00000001825DE430
	// [XID] // 0x0000000189725740-0x0000000189725760
	public static new DoWidgetSystemAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF46A9 */, bool useObjectPool = false /* Metadata: 0x00AF46AD */) => default; // 0x00000001825DEAC0-0x00000001825DECE0
	[BlackList] // 0x000000018972CC60-0x000000018972CCA0
	// [XID] // 0x000000018972CC60-0x000000018972CCA0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001825DDA30-0x00000001825DDD00
	// [XID] // 0x00000001897377A0-0x00000001897377C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001825DF990-0x00000001825DFB90
	[BlackList] // 0x000000018973F2C0-0x000000018973F300
	// [XID] // 0x000000018973F2C0-0x000000018973F300
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001825DEF70-0x00000001825DF070
	// [XID] // 0x0000000189749800-0x0000000189749820
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x00000001825DE430-0x00000001825DE590
	[BlackList] // 0x000000018975FC50-0x000000018975FC90
	// [XID] // 0x000000018975FC50-0x000000018975FC90
	public override void AutoAllocTypeFields() {} // 0x00000001825DDD00-0x00000001825DDDA0
	[BlackList] // 0x000000018976A1B0-0x000000018976A1F0
	// [XID] // 0x000000018976A1B0-0x000000018976A1F0
	public override void AutoRecycleTypeFields() {} // 0x00000001825DDDA0-0x00000001825DDE50
	[BlackList] // 0x0000000189774610-0x0000000189774650
	// [XID] // 0x0000000189774610-0x0000000189774650
	public override void ReturnToObjectPool() {} // 0x00000001825DFD20-0x00000001825DFDC0
}

