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
public class SetAnimatorInt : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16478
{
	// Fields
	private string _intID; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _value; // 0x70
	private bool _persistent; // 0x78

	// Properties
	public string intID { /* [XID] */ /* 0x00000001896B1A50-0x00000001896B1A70 */ get => default; /* [XID] */ /* 0x00000001896B9470-0x00000001896B9490 */ private set {} } // 0x0000000184907320-0x00000001849073C0 0x0000000184908230-0x00000001849082E0
	public DynamicFloat value { /* [XID] */ /* 0x00000001896C0840-0x00000001896C0860 */ get => default; /* [XID] */ /* 0x00000001896C7FB0-0x00000001896C7FD0 */ private set {} } // 0x0000000184907280-0x0000000184907320 0x0000000184907150-0x0000000184907200
	public bool persistent { /* [XID] */ /* 0x00000001896CF8F0-0x00000001896CF910 */ get => default; /* [XID] */ /* 0x00000001896D6BC0-0x00000001896D6BE0 */ private set {} } // 0x0000000184908340-0x00000001849083E0 0x00000001849069C0-0x0000000184906A70
	protected override bool MuteAuthority { /* [XID] */ /* 0x00000001897689C0-0x00000001897689E0 */ get => default; } // 0x0000000184908630-0x00000001849086D0 
	protected override bool MuteRemote { /* [XID] */ /* 0x0000000189770070-0x0000000189770090 */ get => default; } // 0x0000000184907AF0-0x0000000184907B90 

	// Constructors
	public SetAnimatorInt() {} // 0x00000001849091B0-0x0000000184909210

	// Methods
	// [XID] // 0x00000001896DE280-0x00000001896DE2A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184908F30-0x0000000184909070
	// [XID] // 0x00000001896E5790-0x00000001896E57B0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184908730-0x0000000184908830
	// [XID] // 0x00000001896ECE20-0x00000001896ECE40
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3CB0 */) => default; // 0x0000000184908150-0x0000000184908230
	// [XID] // 0x00000001896F4640-0x00000001896F4660
	public override int GetHashNum() => default; // 0x00000001849068F0-0x00000001849069C0
	// [XID] // 0x00000001896FBEB0-0x00000001896FBED0
	public override void InitEmpty() {} // 0x0000000184907B90-0x0000000184907C80
	[BlackList] // 0x0000000189703370-0x00000001897033B0
	// [XID] // 0x0000000189703370-0x00000001897033B0
	public override bool FromJson(JSONNode node) => default; // 0x00000001849073C0-0x0000000184907740
	// [XID] // 0x000000018970DB50-0x000000018970DB70
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184905ED0-0x00000001849062B0
	[BlackList] // 0x0000000189714F30-0x0000000189714F70
	// [XID] // 0x0000000189714F30-0x0000000189714F70
	public static new SetAnimatorInt ParseFromJson(JSONNode node) => default; // 0x00000001849083E0-0x0000000184908630
	// [XID] // 0x000000018971FA70-0x000000018971FA90
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3CB1 */, bool useObjectPool = false /* Metadata: 0x00AF3CB5 */) => default; // 0x0000000184907E50-0x0000000184908150
	// [XID] // 0x0000000189727100-0x0000000189727120
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3CB6 */, bool useObjectPool = false /* Metadata: 0x00AF3CBA */) => default; // 0x0000000184906BC0-0x0000000184906F70
	// [XID] // 0x000000018972E6D0-0x000000018972E6F0
	public static new SetAnimatorInt ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3CBB */, bool useObjectPool = false /* Metadata: 0x00AF3CBF */) => default; // 0x00000001849077F0-0x0000000184907A10
	[BlackList] // 0x0000000189735E20-0x0000000189735E60
	// [XID] // 0x0000000189735E20-0x0000000189735E60
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001849062B0-0x0000000184906580
	// [XID] // 0x0000000189740C00-0x0000000189740C20
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184908910-0x0000000184908C40
	[BlackList] // 0x0000000189748040-0x0000000189748080
	// [XID] // 0x0000000189748040-0x0000000189748080
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184907D60-0x0000000184907E50
	// [XID] // 0x0000000189752470-0x0000000189752490
	public override bool isAlreadyHandledRecoverCase() => default; // 0x0000000184909070-0x0000000184909110
	// [XID] // 0x0000000189759A00-0x0000000189759A20
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000184906F70-0x00000001849070D0
	// [XID] // 0x0000000189761690-0x00000001897616B0
	public override bool GetDebugOutput(ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref string output) => default; // 0x0000000184908C40-0x0000000184908F30
	[BlackList] // 0x00000001897777D0-0x0000000189777810
	// [XID] // 0x00000001897777D0-0x0000000189777810
	public override void AutoAllocTypeFields() {} // 0x0000000184906580-0x0000000184906620
	[BlackList] // 0x0000000189782320-0x0000000189782360
	// [XID] // 0x0000000189782320-0x0000000189782360
	public override void AutoRecycleTypeFields() {} // 0x0000000184906620-0x0000000184906760
	[BlackList] // 0x000000018978C6B0-0x000000018978C6F0
	// [XID] // 0x000000018978C6B0-0x000000018978C6F0
	public override void ReturnToObjectPool() {} // 0x0000000184909110-0x00000001849091B0
}

