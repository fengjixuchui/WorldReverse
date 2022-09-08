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
public class ByHitElementDurability : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17364
{
	// Fields
	private ElementType _element; // 0x18
	private SimpleSafeFloat durabilityRawNum; // 0x1C
	private RelationType _compareType; // 0x20
	private bool _applyAttenuation; // 0x24

	// Properties
	public ElementType element { /* [XID] */ /* 0x0000000189617710-0x0000000189617730 */ get => default; /* [XID] */ /* 0x000000018961F300-0x000000018961F320 */ private set {} } // 0x0000000184D14A70-0x0000000184D14B10 0x0000000184D15740-0x0000000184D157F0
	public float durability { /* [XID] */ /* 0x00000001896266C0-0x00000001896266E0 */ get => default; /* [XID] */ /* 0x000000018962DF90-0x000000018962DFB0 */ private set {} } // 0x0000000184D15CE0-0x0000000184D15DC0 0x0000000184D14920-0x0000000184D14A00
	public RelationType compareType { /* [XID] */ /* 0x0000000189635C90-0x0000000189635CB0 */ get => default; /* [XID] */ /* 0x000000018963D410-0x000000018963D430 */ private set {} } // 0x0000000184D150B0-0x0000000184D15150 0x0000000184D13BF0-0x0000000184D13CA0
	public bool applyAttenuation { /* [XID] */ /* 0x00000001896448F0-0x0000000189644910 */ get => default; /* [XID] */ /* 0x000000018964C170-0x000000018964C190 */ private set {} } // 0x0000000184D155F0-0x0000000184D15690 0x0000000184D13010-0x0000000184D130C0

	// Constructors
	public ByHitElementDurability() {} // 0x0000000184D15E60-0x0000000184D15ED0

	// Methods
	// [XID] // 0x0000000189653880-0x00000001896538A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184D15B90-0x0000000184D15CE0
	// [XID] // 0x000000018965B130-0x000000018965B150
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184D15540-0x0000000184D155F0
	// [XID] // 0x00000001896625E0-0x0000000189662600
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF6BBF */) => default; // 0x0000000184D15150-0x0000000184D15230
	// [XID] // 0x000000018966A160-0x000000018966A180
	public override int GetHashNum() => default; // 0x0000000184D13B20-0x0000000184D13BF0
	// [XID] // 0x0000000189671DE0-0x0000000189671E00
	public override void InitEmpty() {} // 0x0000000184D14B10-0x0000000184D14BE0
	[BlackList] // 0x0000000189679590-0x00000001896795D0
	// [XID] // 0x0000000189679590-0x00000001896795D0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184D14380-0x0000000184D14700
	// [XID] // 0x0000000189683AD0-0x0000000189683AF0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184D130C0-0x0000000184D135B0
	[BlackList] // 0x000000018968B810-0x000000018968B850
	// [XID] // 0x000000018968B810-0x000000018968B850
	public static new ByHitElementDurability ParseFromJson(JSONNode node) => default; // 0x0000000184D15290-0x0000000184D154E0
	// [XID] // 0x00000001896963D0-0x00000001896963F0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6BC0 */, bool useObjectPool = false /* Metadata: 0x00AF6BC4 */) => default; // 0x0000000184D14DB0-0x0000000184D150B0
	// [XID] // 0x000000018969D9D0-0x000000018969D9F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6BC5 */, bool useObjectPool = false /* Metadata: 0x00AF6BC9 */) => default; // 0x0000000184D13D80-0x0000000184D14150
	// [XID] // 0x00000001896A4A00-0x00000001896A4A20
	public static new ByHitElementDurability ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6BCA */, bool useObjectPool = false /* Metadata: 0x00AF6BCE */) => default; // 0x0000000184D14700-0x0000000184D14920
	[BlackList] // 0x00000001896AC1F0-0x00000001896AC230
	// [XID] // 0x00000001896AC1F0-0x00000001896AC230
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184D135B0-0x0000000184D13880
	// [XID] // 0x00000001896B6520-0x00000001896B6540
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184D157F0-0x0000000184D15B90
	[BlackList] // 0x00000001896BD800-0x00000001896BD840
	// [XID] // 0x00000001896BD800-0x00000001896BD840
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184D14CC0-0x0000000184D14DB0
	// [XID] // 0x00000001896C7E30-0x00000001896C7E50
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000184D14150-0x0000000184D14280
	[BlackList] // 0x00000001896CF770-0x00000001896CF7B0
	// [XID] // 0x00000001896CF770-0x00000001896CF7B0
	public override void AutoAllocTypeFields() {} // 0x0000000184D13880-0x0000000184D13920
	[BlackList] // 0x00000001896D9BB0-0x00000001896D9BF0
	// [XID] // 0x00000001896D9BB0-0x00000001896D9BF0
	public override void AutoRecycleTypeFields() {} // 0x0000000184D13920-0x0000000184D13A00
	[BlackList] // 0x00000001896E41B0-0x00000001896E41F0
	// [XID] // 0x00000001896E41B0-0x00000001896E41F0
	public override void ReturnToObjectPool() {} // 0x0000000184D15DC0-0x0000000184D15E60
}

