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
public class ByHitStrikeType : ConfigAbilityPredicate, IAutoAllocRecycle // TypeDefIndex: 17242
{
	// Fields
	private StrikeType _strikeType; // 0x18

	// Properties
	public StrikeType strikeType { /* [XID] */ /* 0x0000000189B93750-0x0000000189B93770 */ get => default; /* [XID] */ /* 0x0000000189B9AC80-0x0000000189B9ACA0 */ private set {} } // 0x0000000184352D60-0x0000000184352E00 0x0000000184352510-0x00000001843525C0

	// Constructors
	public ByHitStrikeType() {} // 0x0000000184353240-0x00000001843532A0

	// Methods
	// [XID] // 0x0000000189BA24B0-0x0000000189BA24D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001843530B0-0x00000001843531A0
	// [XID] // 0x0000000189BA99C0-0x0000000189BA99E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184352CB0-0x0000000184352D60
	// [XID] // 0x0000000189BB11B0-0x0000000189BB11D0
	public override ConfigAbilityPredicate Clone(bool useObjectPool = false /* Metadata: 0x00AF67C7 */) => default; // 0x00000001843528C0-0x00000001843529A0
	// [XID] // 0x0000000189BB82E0-0x0000000189BB8300
	public override int GetHashNum() => default; // 0x0000000184351680-0x0000000184351750
	// [XID] // 0x0000000189BBFA90-0x0000000189BBFAB0
	public override void InitEmpty() {} // 0x00000001843522A0-0x0000000184352340
	[BlackList] // 0x0000000189BC7660-0x0000000189BC76A0
	// [XID] // 0x0000000189BC7660-0x0000000189BC76A0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184351C90-0x0000000184352010
	// [XID] // 0x0000000189BD2120-0x0000000189BD2140
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184350F20-0x0000000184351140
	[BlackList] // 0x0000000189BD9760-0x0000000189BD97A0
	// [XID] // 0x0000000189BD9760-0x0000000189BD97A0
	public static new ByHitStrikeType ParseFromJson(JSONNode node) => default; // 0x0000000184352A00-0x0000000184352C50
	// [XID] // 0x00000001895E9310-0x00000001895E9330
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF67C8 */, bool useObjectPool = false /* Metadata: 0x00AF67CC */) => default; // 0x00000001843525C0-0x00000001843528C0
	// [XID] // 0x00000001895F0A80-0x00000001895F0AA0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF67CD */, bool useObjectPool = false /* Metadata: 0x00AF67D1 */) => default; // 0x0000000184351830-0x0000000184351A60
	// [XID] // 0x00000001895F8430-0x00000001895F8450
	public static new ByHitStrikeType ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF67D2 */, bool useObjectPool = false /* Metadata: 0x00AF67D6 */) => default; // 0x0000000184352010-0x0000000184352230
	[BlackList] // 0x00000001895FF970-0x00000001895FF9B0
	// [XID] // 0x00000001895FF970-0x00000001895FF9B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184351140-0x0000000184351410
	// [XID] // 0x000000018960A3D0-0x000000018960A3F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184352EB0-0x00000001843530B0
	[BlackList] // 0x0000000189611B60-0x0000000189611BA0
	// [XID] // 0x0000000189611B60-0x0000000189611BA0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184352420-0x0000000184352510
	// [XID] // 0x000000018961C3C0-0x000000018961C3E0
	public override bool Call(ActorAbilityPlugin abilityPlugin, ActorAbility instancedAbility, ActorModifier instancedModifier, BaseEntity target, BaseEvent evt) => default; // 0x0000000184351A60-0x0000000184351B90
	[BlackList] // 0x0000000189623760-0x00000001896237A0
	// [XID] // 0x0000000189623760-0x00000001896237A0
	public override void AutoAllocTypeFields() {} // 0x0000000184351410-0x00000001843514B0
	[BlackList] // 0x000000018962DFD0-0x000000018962E010
	// [XID] // 0x000000018962DFD0-0x000000018962E010
	public override void AutoRecycleTypeFields() {} // 0x00000001843514B0-0x0000000184351560
	[BlackList] // 0x0000000189638BB0-0x0000000189638BF0
	// [XID] // 0x0000000189638BB0-0x0000000189638BF0
	public override void ReturnToObjectPool() {} // 0x00000001843531A0-0x0000000184353240
}

