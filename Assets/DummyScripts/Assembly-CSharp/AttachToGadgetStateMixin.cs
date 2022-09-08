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
public class AttachToGadgetStateMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16888
{
	// Fields
	private SimpleSafeInt32 gadgetStateRawNum; // 0x30
	private string _modifierName; // 0x38

	// Properties
	public int gadgetState { /* [XID] */ /* 0x00000001899C74B0-0x00000001899C74D0 */ get => default; /* [XID] */ /* 0x00000001899CEB00-0x00000001899CEB20 */ private set {} } // 0x000000018240F910-0x000000018240F9E0 0x00000001824109F0-0x0000000182410AD0
	public string modifierName { /* [XID] */ /* 0x00000001899D6230-0x00000001899D6250 */ get => default; /* [XID] */ /* 0x00000001899DD6E0-0x00000001899DD700 */ private set {} } // 0x0000000182410AD0-0x0000000182410B70 0x000000018240FBD0-0x000000018240FC80
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x0000000189A60960-0x0000000189A60980 */ get => default; } // 0x000000018240F160-0x000000018240F200 

	// Constructors
	public AttachToGadgetStateMixin() {} // 0x0000000182410C10-0x0000000182410C70

	// Methods
	// [XID] // 0x00000001899E53E0-0x00000001899E5400
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001824108E0-0x00000001824109F0
	// [XID] // 0x00000001899EC6D0-0x00000001899EC6F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182410540-0x0000000182410620
	// [XID] // 0x00000001899F4450-0x00000001899F4470
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5C89 */) => default; // 0x0000000182410150-0x0000000182410230
	// [XID] // 0x00000001899FB9D0-0x00000001899FB9F0
	public override int GetHashNum() => default; // 0x000000018240EBB0-0x000000018240EC80
	// [XID] // 0x0000000189A02DD0-0x0000000189A02DF0
	public override void InitEmpty() {} // 0x000000018240F9E0-0x000000018240FAF0
	[BlackList] // 0x0000000189A0A440-0x0000000189A0A480
	// [XID] // 0x0000000189A0A440-0x0000000189A0A480
	public override bool FromJson(JSONNode node) => default; // 0x000000018240F200-0x000000018240F580
	// [XID] // 0x0000000189A14C00-0x0000000189A14C20
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018240E300-0x000000018240E640
	[BlackList] // 0x0000000189A1BE30-0x0000000189A1BE70
	// [XID] // 0x0000000189A1BE30-0x0000000189A1BE70
	public static new AttachToGadgetStateMixin ParseFromJson(JSONNode node) => default; // 0x0000000182410290-0x00000001824104E0
	// [XID] // 0x0000000189A26480-0x0000000189A264A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C8A */, bool useObjectPool = false /* Metadata: 0x00AF5C8E */) => default; // 0x000000018240FD70-0x0000000182410070
	// [XID] // 0x0000000189A2D750-0x0000000189A2D770
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C8F */, bool useObjectPool = false /* Metadata: 0x00AF5C93 */) => default; // 0x000000018240ED60-0x000000018240F060
	// [XID] // 0x0000000189A35290-0x0000000189A352B0
	public static new AttachToGadgetStateMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C94 */, bool useObjectPool = false /* Metadata: 0x00AF5C98 */) => default; // 0x000000018240F5F0-0x000000018240F810
	[BlackList] // 0x0000000189A3C880-0x0000000189A3C8C0
	// [XID] // 0x0000000189A3C880-0x0000000189A3C8C0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018240E640-0x000000018240E910
	// [XID] // 0x0000000189A470D0-0x0000000189A470F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182410620-0x00000001824108E0
	[BlackList] // 0x0000000189A4E9F0-0x0000000189A4EA30
	// [XID] // 0x0000000189A4E9F0-0x0000000189A4EA30
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018240FC80-0x000000018240FD70
	// [XID] // 0x0000000189A58FE0-0x0000000189A59000
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x0000000182410070-0x0000000182410150
	[BlackList] // 0x0000000189A68750-0x0000000189A68790
	// [XID] // 0x0000000189A68750-0x0000000189A68790
	public override void AutoAllocTypeFields() {} // 0x000000018240E910-0x000000018240E9B0
	[BlackList] // 0x0000000189A72BC0-0x0000000189A72C00
	// [XID] // 0x0000000189A72BC0-0x0000000189A72C00
	public override void AutoRecycleTypeFields() {} // 0x000000018240E9B0-0x000000018240EA90
	[BlackList] // 0x0000000189A7D4B0-0x0000000189A7D4F0
	// [XID] // 0x0000000189A7D4B0-0x0000000189A7D4F0
	public override void ReturnToObjectPool() {} // 0x0000000182410B70-0x0000000182410C10
}

