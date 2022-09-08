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
public class AddAbility : ConfigTalentMixin, IAutoAllocRecycle // TypeDefIndex: 19040
{
	// Fields
	private string _abilityName; // 0x10

	// Properties
	public string abilityName { /* [XID] */ /* 0x00000001898C6760-0x00000001898C6780 */ get => default; /* [XID] */ /* 0x0000000189A02930-0x0000000189A02950 */ private set {} } // 0x0000000184FB8B30-0x0000000184FB8BD0 0x0000000184FB9360-0x0000000184FB9410

	// Constructors
	public AddAbility() {} // 0x0000000184FB95A0-0x0000000184FB9600

	// Methods
	// [XID] // 0x0000000189A0A0A0-0x0000000189A0A0C0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184FB9410-0x0000000184FB9500
	// [XID] // 0x0000000189A119A0-0x0000000189A119C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184FB9080-0x0000000184FB9160
	// [XID] // 0x0000000189A18BB0-0x0000000189A18BD0
	public override ConfigTalentMixin Clone(bool useObjectPool = false /* Metadata: 0x00AFB869 */) => default; // 0x0000000184FB8C90-0x0000000184FB8D70
	// [XID] // 0x0000000189A20250-0x0000000189A20270
	public override int GetHashNum() => default; // 0x0000000184FB79E0-0x0000000184FB7AB0
	// [XID] // 0x0000000189A27740-0x0000000189A27760
	public override void InitEmpty() {} // 0x0000000184FB8590-0x0000000184FB8660
	[BlackList] // 0x0000000189A2EE70-0x0000000189A2EEB0
	// [XID] // 0x0000000189A2EE70-0x0000000189A2EEB0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184FB7F00-0x0000000184FB8280
	// [XID] // 0x0000000189A39650-0x0000000189A39670
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184FB7270-0x0000000184FB74A0
	[BlackList] // 0x0000000189A40DF0-0x0000000189A40E30
	// [XID] // 0x0000000189A40DF0-0x0000000189A40E30
	public static new AddAbility ParseFromJson(JSONNode node) => default; // 0x0000000184FB8DD0-0x0000000184FB9020
	// [XID] // 0x0000000189A4B420-0x0000000189A4B440
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB86A */, bool useObjectPool = false /* Metadata: 0x00AFB86E */) => default; // 0x0000000184FB8830-0x0000000184FB8B30
	// [XID] // 0x0000000189A52A60-0x0000000189A52A80
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB86F */, bool useObjectPool = false /* Metadata: 0x00AFB873 */) => default; // 0x0000000184FB7B90-0x0000000184FB7E00
	// [XID] // 0x0000000189A5A3F0-0x0000000189A5A410
	public static new AddAbility ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB874 */, bool useObjectPool = false /* Metadata: 0x00AFB878 */) => default; // 0x0000000184FB8280-0x0000000184FB84A0
	[BlackList] // 0x0000000189A61B90-0x0000000189A61BD0
	// [XID] // 0x0000000189A61B90-0x0000000189A61BD0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184FB74A0-0x0000000184FB7770
	// [XID] // 0x0000000189A6C600-0x0000000189A6C620
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184FB9160-0x0000000184FB9360
	[BlackList] // 0x0000000189A73E30-0x0000000189A73E70
	// [XID] // 0x0000000189A73E30-0x0000000189A73E70
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184FB8740-0x0000000184FB8830
	// [XID] // 0x0000000189A7E7F0-0x0000000189A7E810
	public override BaseTalentMixin CreateInstancedMixin(ActorTalent instancedTalent) => default; // 0x0000000184FB8BD0-0x0000000184FB8C90
	[BlackList] // 0x0000000189A86070-0x0000000189A860B0
	// [XID] // 0x0000000189A86070-0x0000000189A860B0
	public override void AutoAllocTypeFields() {} // 0x0000000184FB7770-0x0000000184FB7810
	[BlackList] // 0x0000000189A90B70-0x0000000189A90BB0
	// [XID] // 0x0000000189A90B70-0x0000000189A90BB0
	public override void AutoRecycleTypeFields() {} // 0x0000000184FB7810-0x0000000184FB78C0
	[BlackList] // 0x0000000189A9B2C0-0x0000000189A9B300
	// [XID] // 0x0000000189A9B2C0-0x0000000189A9B300
	public override void ReturnToObjectPool() {} // 0x0000000184FB9500-0x0000000184FB95A0
}

