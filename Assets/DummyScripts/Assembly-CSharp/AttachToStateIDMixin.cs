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
public class AttachToStateIDMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16878
{
	// Fields
	private string[] _stateIDs; // 0x30
	private string _modifierName; // 0x38
	private AbilityTargetting _target; // 0x40
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAbilityPredicate[] _predicates; // 0x48
	private bool _isCheckOnAttach; // 0x50

	// Properties
	public string[] stateIDs { /* [XID] */ /* 0x0000000189B867C0-0x0000000189B867E0 */ get => default; /* [XID] */ /* 0x0000000189B8D8F0-0x0000000189B8D910 */ private set {} } // 0x0000000184A39F20-0x0000000184A39FC0 0x0000000184A39FC0-0x0000000184A3A070
	public string modifierName { /* [XID] */ /* 0x0000000189B94EF0-0x0000000189B94F10 */ get => default; /* [XID] */ /* 0x0000000189B9C640-0x0000000189B9C660 */ private set {} } // 0x0000000184A3A070-0x0000000184A3A110 0x0000000184A38CD0-0x0000000184A38D80
	public AbilityTargetting target { /* [XID] */ /* 0x0000000189BA3C50-0x0000000189BA3C70 */ get => default; /* [XID] */ /* 0x0000000189BAB0C0-0x0000000189BAB0E0 */ private set {} } // 0x0000000184A37B70-0x0000000184A37C10 0x0000000184A37C70-0x0000000184A37D20
	public ConfigAbilityPredicate[] predicates { /* [XID] */ /* 0x0000000189BB26B0-0x0000000189BB26D0 */ get => default; /* [XID] */ /* 0x0000000189BB9AE0-0x0000000189BB9B00 */ private set {} } // 0x0000000184A398B0-0x0000000184A39950 0x0000000184A39330-0x0000000184A393E0
	public bool isCheckOnAttach { /* [XID] */ /* 0x0000000189BC1A80-0x0000000189BC1AA0 */ get => default; /* [XID] */ /* 0x0000000189BC90C0-0x0000000189BC90E0 */ private set {} } // 0x0000000184A37AD0-0x0000000184A37B70 0x0000000184A39690-0x0000000184A39740
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001896521A0-0x00000001896521C0 */ get => default; } // 0x0000000184A38340-0x0000000184A383E0 

	// Constructors
	public AttachToStateIDMixin() {} // 0x0000000184A3A1B0-0x0000000184A3A220

	// Methods
	// [XID] // 0x0000000189BD09D0-0x0000000189BD09F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184A39DC0-0x0000000184A39F20
	// [XID] // 0x0000000189BD7ED0-0x0000000189BD7EF0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184A397A0-0x0000000184A398B0
	// [XID] // 0x0000000189BDFA80-0x0000000189BDFAA0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5C39 */) => default; // 0x0000000184A39250-0x0000000184A39330
	// [XID] // 0x00000001895EC630-0x00000001895EC650
	public override int GetHashNum() => default; // 0x0000000184A37A00-0x0000000184A37AD0
	// [XID] // 0x00000001895F3AF0-0x00000001895F3B10
	public override void InitEmpty() {} // 0x0000000184A38AF0-0x0000000184A38BF0
	[BlackList] // 0x00000001895FB3B0-0x00000001895FB3F0
	// [XID] // 0x00000001895FB3B0-0x00000001895FB3F0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184A383E0-0x0000000184A38760
	// [XID] // 0x0000000189605A70-0x0000000189605A90
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184A36F30-0x0000000184A374A0
	[BlackList] // 0x000000018960D3A0-0x000000018960D3E0
	// [XID] // 0x000000018960D3A0-0x000000018960D3E0
	public static new AttachToStateIDMixin ParseFromJson(JSONNode node) => default; // 0x0000000184A39440-0x0000000184A39690
	// [XID] // 0x0000000189617810-0x0000000189617830
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C3A */, bool useObjectPool = false /* Metadata: 0x00AF5C3E */) => default; // 0x0000000184A38E70-0x0000000184A39170
	// [XID] // 0x000000018961F420-0x000000018961F440
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C3F */, bool useObjectPool = false /* Metadata: 0x00AF5C43 */) => default; // 0x0000000184A37DA0-0x0000000184A38240
	// [XID] // 0x0000000189626840-0x0000000189626860
	public static new AttachToStateIDMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C44 */, bool useObjectPool = false /* Metadata: 0x00AF5C48 */) => default; // 0x0000000184A387D0-0x0000000184A389F0
	[BlackList] // 0x000000018962E070-0x000000018962E0B0
	// [XID] // 0x000000018962E070-0x000000018962E0B0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184A374A0-0x0000000184A37770
	// [XID] // 0x0000000189638C50-0x0000000189638C70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184A39950-0x0000000184A39DC0
	[BlackList] // 0x00000001896400F0-0x0000000189640130
	// [XID] // 0x00000001896400F0-0x0000000189640130
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184A38D80-0x0000000184A38E70
	// [XID] // 0x000000018964A8E0-0x000000018964A900
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000184A39170-0x0000000184A39250
	[BlackList] // 0x0000000189659810-0x0000000189659850
	// [XID] // 0x0000000189659810-0x0000000189659850
	public override void AutoAllocTypeFields() {} // 0x0000000184A37770-0x0000000184A37810
	[BlackList] // 0x0000000189663E60-0x0000000189663EA0
	// [XID] // 0x0000000189663E60-0x0000000189663EA0
	public override void AutoRecycleTypeFields() {} // 0x0000000184A37810-0x0000000184A378E0
	[BlackList] // 0x000000018966E7E0-0x000000018966E820
	// [XID] // 0x000000018966E7E0-0x000000018966E820
	public override void ReturnToObjectPool() {} // 0x0000000184A3A110-0x0000000184A3A1B0
}

