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
public class KillGadget : ConfigAbilityAction, IAutoAllocRecycle // TypeDefIndex: 16505
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private SelectTargetsByChildren _gadgetInfo; // 0x68

	// Properties
	public SelectTargetsByChildren gadgetInfo { /* [XID] */ /* 0x0000000189807110-0x0000000189807130 */ get => default; /* [XID] */ /* 0x000000018980E710-0x000000018980E730 */ private set {} } // 0x000000018463D320-0x000000018463D3C0 0x000000018463E130-0x000000018463E1E0
	protected override bool MuteAuthority { /* [XID] */ /* 0x0000000189897BA0-0x0000000189897BC0 */ get => default; } // 0x000000018463DE70-0x000000018463DF10 
	protected override bool MuteRemote { /* [XID] */ /* 0x000000018989EFA0-0x000000018989EFC0 */ get => default; } // 0x000000018463D4A0-0x000000018463D540 

	// Constructors
	public KillGadget() {} // 0x000000018463E630-0x000000018463E690

	// Methods
	// [XID] // 0x0000000189815EB0-0x0000000189815ED0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018463E410-0x000000018463E4F0
	// [XID] // 0x000000018981D7F0-0x000000018981D810
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018463DF70-0x000000018463E050
	// [XID] // 0x0000000189824CC0-0x0000000189824CE0
	public override ConfigAbilityAction Clone(bool useObjectPool = false /* Metadata: 0x00AF3D8A */) => default; // 0x000000018463DAE0-0x000000018463DBC0
	// [XID] // 0x000000018982C690-0x000000018982C6B0
	public override int GetHashNum() => default; // 0x000000018463C660-0x000000018463C730
	// [XID] // 0x0000000189833C60-0x0000000189833C80
	public override void InitEmpty() {} // 0x000000018463D540-0x000000018463D610
	[BlackList] // 0x000000018983B1A0-0x000000018983B1E0
	// [XID] // 0x000000018983B1A0-0x000000018983B1E0
	public override bool FromJson(JSONNode node) => default; // 0x000000018463CD80-0x000000018463D100
	// [XID] // 0x00000001898457D0-0x00000001898457F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018463BDE0-0x000000018463C030
	[BlackList] // 0x000000018984CD00-0x000000018984CD40
	// [XID] // 0x000000018984CD00-0x000000018984CD40
	public static new KillGadget ParseFromJson(JSONNode node) => default; // 0x000000018463DC20-0x000000018463DE70
	// [XID] // 0x0000000189856E40-0x0000000189856E60
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D8B */, bool useObjectPool = false /* Metadata: 0x00AF3D8F */) => default; // 0x000000018463D7E0-0x000000018463DAE0
	// [XID] // 0x000000018985DFB0-0x000000018985DFD0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D90 */, bool useObjectPool = false /* Metadata: 0x00AF3D94 */) => default; // 0x000000018463C880-0x000000018463CB20
	// [XID] // 0x0000000189865A90-0x0000000189865AB0
	public static new KillGadget ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3D95 */, bool useObjectPool = false /* Metadata: 0x00AF3D99 */) => default; // 0x000000018463D100-0x000000018463D320
	[BlackList] // 0x000000018986CFB0-0x000000018986CFF0
	// [XID] // 0x000000018986CFB0-0x000000018986CFF0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018463C030-0x000000018463C300
	// [XID] // 0x00000001898775D0-0x00000001898775F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018463E1E0-0x000000018463E410
	[BlackList] // 0x000000018987EE40-0x000000018987EE80
	// [XID] // 0x000000018987EE40-0x000000018987EE80
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018463D6F0-0x000000018463D7E0
	// [XID] // 0x00000001898891C0-0x00000001898891E0
	public override bool isAlreadyHandledRecoverCase() => default; // 0x000000018463E4F0-0x000000018463E590
	// [XID] // 0x0000000189890640-0x0000000189890660
	public override void Call(ActorAbilityPlugin abilityPlugin, ConfigAbilityAction actionConfig, ActorAbility instancedAbility, ActorModifier instancedModifier, ActorAbilityPlugin.AbilityAttackTarget target, BaseEvent evt) {} // 0x000000018463CB20-0x000000018463CC80
	[BlackList] // 0x00000001898A6A40-0x00000001898A6A80
	// [XID] // 0x00000001898A6A40-0x00000001898A6A80
	public override void AutoAllocTypeFields() {} // 0x000000018463C300-0x000000018463C3A0
	[BlackList] // 0x00000001898B10C0-0x00000001898B1100
	// [XID] // 0x00000001898B10C0-0x00000001898B1100
	public override void AutoRecycleTypeFields() {} // 0x000000018463C3A0-0x000000018463C4D0
	[BlackList] // 0x00000001898BBA10-0x00000001898BBA50
	// [XID] // 0x00000001898BBA10-0x00000001898BBA50
	public override void ReturnToObjectPool() {} // 0x000000018463E590-0x000000018463E630
}

