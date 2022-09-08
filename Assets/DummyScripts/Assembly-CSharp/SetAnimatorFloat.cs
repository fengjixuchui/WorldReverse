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
public class SetAnimatorFloat : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16480
{
	// Fields
	private string _floatID; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _value; // 0x70
	private bool _persistent; // 0x78
	private bool _useRandomValue; // 0x79
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _randomValueMin; // 0x80
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _randomValueMax; // 0x88

	// Properties
	public string floatID { /* [XID] */ /* 0x00000001897B5BB0-0x00000001897B5BD0 */ get => default; /* [XID] */ /* 0x00000001897BD9E0-0x00000001897BDA00 */ private set {} } // 0x000000018251A700-0x000000018251A7A0 0x00000001825186A0-0x0000000182518750
	public DynamicFloat value { /* [XID] */ /* 0x00000001897C4D80-0x00000001897C4DA0 */ get => default; /* [XID] */ /* 0x00000001897CC530-0x00000001897CC550 */ private set {} } // 0x0000000182518560-0x0000000182518600 0x0000000182518430-0x00000001825184E0
	public bool persistent { /* [XID] */ /* 0x00000001897D3E00-0x00000001897D3E20 */ get => default; /* [XID] */ /* 0x00000001897DB750-0x00000001897DB770 */ private set {} } // 0x0000000182519910-0x00000001825199B0 0x00000001825179C0-0x0000000182517A70
	public bool useRandomValue { /* [XID] */ /* 0x00000001897E2F20-0x00000001897E2F40 */ get => default; /* [XID] */ /* 0x00000001897EA700-0x00000001897EA720 */ private set {} } // 0x0000000182518600-0x00000001825186A0 0x0000000182519800-0x00000001825198B0
	public DynamicFloat randomValueMin { /* [XID] */ /* 0x00000001897F24D0-0x00000001897F24F0 */ get => default; /* [XID] */ /* 0x00000001897F9C00-0x00000001897F9C20 */ private set {} } // 0x00000001825181A0-0x0000000182518250 0x0000000182518F20-0x0000000182518FD0
	public DynamicFloat randomValueMax { /* [XID] */ /* 0x00000001898011C0-0x00000001898011E0 */ get => default; /* [XID] */ /* 0x0000000189808580-0x00000001898085A0 */ private set {} } // 0x00000001825191D0-0x0000000182519280 0x0000000182519370-0x0000000182519420
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189899590-0x00000001898995B0 */ get => default; } // 0x0000000182519C00-0x0000000182519CA0 
	protected override bool MuteRemote { /* [XID] */ /* 0x00000001898A0750-0x00000001898A0770 */ get => default; } // 0x0000000182518E80-0x0000000182518F20 

	// Constructors
	public SetAnimatorFloat() {} // 0x000000018251AAA0-0x000000018251AB10

	// Methods
	// [XID] // 0x0000000189810150-0x0000000189810170
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018251A7A0-0x000000018251A960
	// [XID] // 0x0000000189817740-0x0000000189817760
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182519D00-0x0000000182519E30
	// [XID] // 0x000000018981F080-0x000000018981F0A0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3CC0 */) => default; // 0x0000000182519720-0x0000000182519800
	// [XID] // 0x00000001898265D0-0x00000001898265F0
	public override int GetHashNum() => default; // 0x00000001825178F0-0x00000001825179C0
	// [XID] // 0x000000018982DC40-0x000000018982DC60
	public override void InitEmpty() {} // 0x0000000182518FD0-0x00000001825190F0
	[BlackList] // 0x00000001898352F0-0x0000000189835330
	// [XID] // 0x00000001898352F0-0x0000000189835330
	public override bool FromJson(JSONNode node) => default; // 0x0000000182518750-0x0000000182518AD0
	// [XID] // 0x000000018983F950-0x000000018983F970
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182516B40-0x00000001825171C0
	[BlackList] // 0x0000000189846F70-0x0000000189846FB0
	// [XID] // 0x0000000189846F70-0x0000000189846FB0
	public static new SetAnimatorFloat ParseFromJson(JSONNode node) => default; // 0x00000001825199B0-0x0000000182519C00
	// [XID] // 0x0000000189851410-0x0000000189851430
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3CC1 */, bool useObjectPool = false /* Metadata: 0x00AF3CC5 */) => default; // 0x0000000182519420-0x0000000182519720
	// [XID] // 0x0000000189858940-0x0000000189858960
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3CC6 */, bool useObjectPool = false /* Metadata: 0x00AF3CCA */) => default; // 0x0000000182517BC0-0x00000001825181A0
	// [XID] // 0x000000018985FA70-0x000000018985FA90
	public static new SetAnimatorFloat ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3CCB */, bool useObjectPool = false /* Metadata: 0x00AF3CCF */) => default; // 0x0000000182518B80-0x0000000182518DA0
	[BlackList] // 0x00000001898671F0-0x0000000189867230
	// [XID] // 0x00000001898671F0-0x0000000189867230
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001825171C0-0x0000000182517490
	// [XID] // 0x0000000189871650-0x0000000189871670
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182519F10-0x000000018251A410
	[BlackList] // 0x0000000189878ED0-0x0000000189878F10
	// [XID] // 0x0000000189878ED0-0x0000000189878F10
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182519280-0x0000000182519370
	// [XID] // 0x00000001898830B0-0x00000001898830D0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018251A960-0x000000018251AA00
	// [XID] // 0x000000018988A890-0x000000018988A8B0
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x0000000182518250-0x00000001825183B0
	// [XID] // 0x0000000189891CC0-0x0000000189891CE0
	public override bool GetDebugOutput(ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt, ref string output) => default; // 0x000000018251A410-0x000000018251A700
	[BlackList] // 0x00000001898A7E90-0x00000001898A7ED0
	// [XID] // 0x00000001898A7E90-0x00000001898A7ED0
	public override void AutoAllocTypeFields() {} // 0x0000000182517490-0x0000000182517530
	[BlackList] // 0x00000001898B25F0-0x00000001898B2630
	// [XID] // 0x00000001898B25F0-0x00000001898B2630
	public override void AutoRecycleTypeFields() {} // 0x0000000182517530-0x0000000182517760
	[BlackList] // 0x00000001898BD160-0x00000001898BD1A0
	// [XID] // 0x00000001898BD160-0x00000001898BD1A0
	public override void ReturnToObjectPool() {} // 0x000000018251AA00-0x000000018251AAA0
}

