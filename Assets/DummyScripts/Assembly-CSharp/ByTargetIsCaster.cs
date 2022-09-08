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
public class ByTargetIsCaster : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17362
{
	// Fields
	private bool _isCaster; // 0x18

	// Properties
	public bool isCaster { /* [XID] */ /* 0x0000000189B611F0-0x0000000189B61210 */ get => default; /* [XID] */ /* 0x0000000189B68AC0-0x0000000189B68AE0 */ private set {} } // 0x0000000182CEC330-0x0000000182CEC3D0 0x0000000182CEC200-0x0000000182CEC2B0

	// Constructors
	public ByTargetIsCaster() {} // 0x0000000182CED830-0x0000000182CED8A0

	// Methods
	// [XID] // 0x0000000189B70060-0x0000000189B70080
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182CED6A0-0x0000000182CED790
	// [XID] // 0x0000000189B773B0-0x0000000189B773D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182CED340-0x0000000182CED3F0
	// [XID] // 0x0000000189B7EA40-0x0000000189B7EA60
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6BAF */) => default; // 0x0000000182CECF50-0x0000000182CED030
	// [XID] // 0x0000000189B866A0-0x0000000189B866C0
	public override int GetHashNum() => default; // 0x0000000182CEBC70-0x0000000182CEBD40
	// [XID] // 0x0000000189B8D7B0-0x0000000189B8D7D0
	public override void InitEmpty() {} // 0x0000000182CEC9E0-0x0000000182CECA80
	[BlackList] // 0x0000000189B94DB0-0x0000000189B94DF0
	// [XID] // 0x0000000189B94DB0-0x0000000189B94DF0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182CEC3D0-0x0000000182CEC750
	// [XID] // 0x0000000189B9F1B0-0x0000000189B9F1D0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182CEB530-0x0000000182CEB730
	[BlackList] // 0x0000000189BA6A20-0x0000000189BA6A60
	// [XID] // 0x0000000189BA6A20-0x0000000189BA6A60
	public static new ByTargetIsCaster ParseFromJson(JSONNode node) => default; // 0x0000000182CED090-0x0000000182CED2E0
	// [XID] // 0x0000000189BB1110-0x0000000189BB1130
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6BB0 */, bool useObjectPool = false /* Metadata: 0x00AF6BB4 */) => default; // 0x0000000182CECC50-0x0000000182CECF50
	// [XID] // 0x0000000189BB8280-0x0000000189BB82A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6BB5 */, bool useObjectPool = false /* Metadata: 0x00AF6BB9 */) => default; // 0x0000000182CEBE20-0x0000000182CEC050
	// [XID] // 0x0000000189BBF9D0-0x0000000189BBF9F0
	public static new ByTargetIsCaster ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6BBA */, bool useObjectPool = false /* Metadata: 0x00AF6BBE */) => default; // 0x0000000182CEC750-0x0000000182CEC970
	[BlackList] // 0x0000000189BC75E0-0x0000000189BC7620
	// [XID] // 0x0000000189BC75E0-0x0000000189BC7620
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182CEB730-0x0000000182CEBA00
	// [XID] // 0x0000000189BD2060-0x0000000189BD2080
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182CED4A0-0x0000000182CED6A0
	[BlackList] // 0x0000000189BD9700-0x0000000189BD9740
	// [XID] // 0x0000000189BD9700-0x0000000189BD9740
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182CECB60-0x0000000182CECC50
	// [XID] // 0x00000001895E9290-0x00000001895E92B0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000182CEC050-0x0000000182CEC180
	[BlackList] // 0x00000001895F0A20-0x00000001895F0A60
	// [XID] // 0x00000001895F0A20-0x00000001895F0A60
	public override void AutoAllocTypeFields() {} // 0x0000000182CEBA00-0x0000000182CEBAA0
	[BlackList] // 0x00000001895FB2B0-0x00000001895FB2F0
	// [XID] // 0x00000001895FB2B0-0x00000001895FB2F0
	public override void AutoRecycleTypeFields() {} // 0x0000000182CEBAA0-0x0000000182CEBB50
	[BlackList] // 0x0000000189605950-0x0000000189605990
	// [XID] // 0x0000000189605950-0x0000000189605990
	public override void ReturnToObjectPool() {} // 0x0000000182CED790-0x0000000182CED830
}

