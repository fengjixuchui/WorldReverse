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
public class ByCurTeamHasBodyType : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17300
{
	// Fields
	private string _bodyType; // 0x18
	private SimpleSafeUInt32 numberRawNum; // 0x20
	private RelationalOperator _logic; // 0x24

	// Properties
	public string bodyType { /* [XID] */ /* 0x000000018977EDC0-0x000000018977EDE0 */ get => default; /* [XID] */ /* 0x00000001897867E0-0x0000000189786800 */ private set {} } // 0x00000001833DE5D0-0x00000001833DE670 0x00000001833DEC80-0x00000001833DED30
	public uint number { /* [XID] */ /* 0x000000018978DDB0-0x000000018978DDD0 */ get => default; /* [XID] */ /* 0x0000000189795480-0x00000001897954A0 */ private set {} } // 0x00000001833DCE80-0x00000001833DCF50 0x00000001833DE7B0-0x00000001833DE890
	public RelationalOperator logic { /* [XID] */ /* 0x000000018979D850-0x000000018979D870 */ get => default; /* [XID] */ /* 0x00000001897A4B10-0x00000001897A4B30 */ private set {} } // 0x00000001833DE2E0-0x00000001833DE380 0x00000001833DDAA0-0x00000001833DDB50

	// Constructors
	public ByCurTeamHasBodyType() {} // 0x00000001833DEF00-0x00000001833DEF60

	// Methods
	// [XID] // 0x00000001897AC160-0x00000001897AC180
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001833DED30-0x00000001833DEE60
	// [XID] // 0x00000001897B40B0-0x00000001897B40D0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001833DE6D0-0x00000001833DE7B0
	// [XID] // 0x00000001897BBDB0-0x00000001897BBDD0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF69CB */) => default; // 0x00000001833DE1A0-0x00000001833DE280
	// [XID] // 0x00000001897C35B0-0x00000001897C35D0
	public override int GetHashNum() => default; // 0x00000001833DCCD0-0x00000001833DCDA0
	// [XID] // 0x00000001897CAE10-0x00000001897CAE30
	public override void InitEmpty() {} // 0x00000001833DDBC0-0x00000001833DDCD0
	[BlackList] // 0x00000001897D23B0-0x00000001897D23F0
	// [XID] // 0x00000001897D23B0-0x00000001897D23F0
	public override bool FromJson(JSONNode node) => default; // 0x00000001833DD500-0x00000001833DD880
	// [XID] // 0x00000001897DCBB0-0x00000001897DCBD0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001833DC330-0x00000001833DC760
	[BlackList] // 0x00000001897E4570-0x00000001897E45B0
	// [XID] // 0x00000001897E4570-0x00000001897E45B0
	public static new ByCurTeamHasBodyType ParseFromJson(JSONNode node) => default; // 0x00000001833DE380-0x00000001833DE5D0
	// [XID] // 0x00000001897EF050-0x00000001897EF070
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF69CC */, bool useObjectPool = false /* Metadata: 0x00AF69D0 */) => default; // 0x00000001833DDEA0-0x00000001833DE1A0
	// [XID] // 0x00000001897F66E0-0x00000001897F6700
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF69D1 */, bool useObjectPool = false /* Metadata: 0x00AF69D5 */) => default; // 0x00000001833DCF50-0x00000001833DD2D0
	// [XID] // 0x00000001897FDD80-0x00000001897FDDA0
	public static new ByCurTeamHasBodyType ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF69D6 */, bool useObjectPool = false /* Metadata: 0x00AF69DA */) => default; // 0x00000001833DD880-0x00000001833DDAA0
	[BlackList] // 0x0000000189805530-0x0000000189805570
	// [XID] // 0x0000000189805530-0x0000000189805570
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001833DC760-0x00000001833DCA30
	// [XID] // 0x000000018980FFB0-0x000000018980FFD0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001833DE940-0x00000001833DEC80
	[BlackList] // 0x0000000189817500-0x0000000189817540
	// [XID] // 0x0000000189817500-0x0000000189817540
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001833DDDB0-0x00000001833DDEA0
	// [XID] // 0x0000000189821F10-0x0000000189821F30
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x00000001833DD2D0-0x00000001833DD400
	[BlackList] // 0x00000001898293D0-0x0000000189829410
	// [XID] // 0x00000001898293D0-0x0000000189829410
	public override void AutoAllocTypeFields() {} // 0x00000001833DCA30-0x00000001833DCAD0
	[BlackList] // 0x0000000189833AE0-0x0000000189833B20
	// [XID] // 0x0000000189833AE0-0x0000000189833B20
	public override void AutoRecycleTypeFields() {} // 0x00000001833DCAD0-0x00000001833DCBB0
	[BlackList] // 0x000000018983DE40-0x000000018983DE80
	// [XID] // 0x000000018983DE40-0x000000018983DE80
	public override void ReturnToObjectPool() {} // 0x00000001833DEE60-0x00000001833DEF00
}

