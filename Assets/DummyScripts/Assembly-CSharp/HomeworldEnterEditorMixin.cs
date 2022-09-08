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
public class HomeworldEnterEditorMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 17163
{
	// Fields
	private string[] _editorModifierNames; // 0x30
	private string[] _worldModifierNames; // 0x38

	// Properties
	public string[] editorModifierNames { /* [XID] */ /* 0x0000000189638BF0-0x0000000189638C10 */ get => default; /* [XID] */ /* 0x0000000189640030-0x0000000189640050 */ private set {} } // 0x0000000183D33E40-0x0000000183D33EE0 0x0000000183D33FE0-0x0000000183D34090
	public string[] worldModifierNames { /* [XID] */ /* 0x0000000189647950-0x0000000189647970 */ get => default; /* [XID] */ /* 0x000000018964EF60-0x000000018964EF80 */ private set {} } // 0x0000000183D35480-0x0000000183D35520 0x0000000183D35020-0x0000000183D350D0
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001896D2280-0x00000001896D22A0 */ get => default; } // 0x0000000183D34090-0x0000000183D34130 

	// Constructors
	public HomeworldEnterEditorMixin() {} // 0x0000000183D359C0-0x0000000183D35A20

	// Methods
	// [XID] // 0x00000001896567B0-0x00000001896567D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183D35810-0x0000000183D35920
	// [XID] // 0x000000018965DF10-0x000000018965DF30
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183D35380-0x0000000183D35480
	// [XID] // 0x0000000189665670-0x0000000189665690
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF6521 */) => default; // 0x0000000183D34EE0-0x0000000183D34FC0
	// [XID] // 0x000000018966CDC0-0x000000018966CDE0
	public override int GetHashNum() => default; // 0x0000000183D33980-0x0000000183D33A50
	// [XID] // 0x0000000189674C50-0x0000000189674C70
	public override void InitEmpty() {} // 0x0000000183D34840-0x0000000183D34930
	[BlackList] // 0x000000018967C4E0-0x000000018967C520
	// [XID] // 0x000000018967C4E0-0x000000018967C520
	public override bool FromJson(JSONNode node) => default; // 0x0000000183D34130-0x0000000183D344B0
	// [XID] // 0x0000000189686B30-0x0000000189686B50
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183D33120-0x0000000183D33440
	[BlackList] // 0x000000018968E9B0-0x000000018968E9F0
	// [XID] // 0x000000018968E9B0-0x000000018968E9F0
	public static new HomeworldEnterEditorMixin ParseFromJson(JSONNode node) => default; // 0x0000000183D350D0-0x0000000183D35320
	// [XID] // 0x00000001896990A0-0x00000001896990C0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6522 */, bool useObjectPool = false /* Metadata: 0x00AF6526 */) => default; // 0x0000000183D34B00-0x0000000183D34E00
	// [XID] // 0x00000001896A05D0-0x00000001896A05F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6527 */, bool useObjectPool = false /* Metadata: 0x00AF652B */) => default; // 0x0000000183D33B30-0x0000000183D33E40
	// [XID] // 0x00000001896A7B00-0x00000001896A7B20
	public static new HomeworldEnterEditorMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF652C */, bool useObjectPool = false /* Metadata: 0x00AF6530 */) => default; // 0x0000000183D34520-0x0000000183D34740
	[BlackList] // 0x00000001896AEED0-0x00000001896AEF10
	// [XID] // 0x00000001896AEED0-0x00000001896AEF10
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183D33440-0x0000000183D33710
	// [XID] // 0x00000001896B9310-0x00000001896B9330
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183D35520-0x0000000183D35810
	[BlackList] // 0x00000001896C0740-0x00000001896C0780
	// [XID] // 0x00000001896C0740-0x00000001896C0780
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183D34A10-0x0000000183D34B00
	// [XID] // 0x00000001896CABF0-0x00000001896CAC10
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000183D34E00-0x0000000183D34EE0
	[BlackList] // 0x00000001896D9C30-0x00000001896D9C70
	// [XID] // 0x00000001896D9C30-0x00000001896D9C70
	public override void AutoAllocTypeFields() {} // 0x0000000183D33710-0x0000000183D337B0
	[BlackList] // 0x00000001896E4250-0x00000001896E4290
	// [XID] // 0x00000001896E4250-0x00000001896E4290
	public override void AutoRecycleTypeFields() {} // 0x0000000183D337B0-0x0000000183D33860
	[BlackList] // 0x00000001896EE430-0x00000001896EE470
	// [XID] // 0x00000001896EE430-0x00000001896EE470
	public override void ReturnToObjectPool() {} // 0x0000000183D35920-0x0000000183D359C0
}

