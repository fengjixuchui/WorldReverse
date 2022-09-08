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
public class AttachToPoseIDMixin : ConfigAbilityMixin, IAutoAllocRecycle // TypeDefIndex: 16886
{
	// Fields
	private SimpleSafeInt32[] _poseIDs; // 0x30
	private string _modifierName; // 0x38

	// Properties
	public SimpleSafeInt32[] poseIDs { /* [XID] */ /* 0x00000001898FDF40-0x00000001898FDF60 */ get => default; /* [XID] */ /* 0x0000000189905720-0x0000000189905740 */ private set {} } // 0x00000001820F2040-0x00000001820F20E0 0x00000001820F42D0-0x00000001820F4380
	public string modifierName { /* [XID] */ /* 0x000000018990CF70-0x000000018990CF90 */ get => default; /* [XID] */ /* 0x0000000189914740-0x0000000189914760 */ private set {} } // 0x00000001820F4750-0x00000001820F47F0 0x00000001820F3860-0x00000001820F3910
	public override MixinMPBehaviorType MixinMPBehavior { /* [XID] */ /* 0x00000001899989D0-0x00000001899989F0 */ get => default; } // 0x00000001820F2EE0-0x00000001820F2F80 

	// Constructors
	public AttachToPoseIDMixin() {} // 0x00000001820F4890-0x00000001820F48F0

	// Methods
	// [XID] // 0x000000018991C300-0x000000018991C320
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001820F4640-0x00000001820F4750
	// [XID] // 0x0000000189923A40-0x0000000189923A60
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001820F41D0-0x00000001820F42D0
	// [XID] // 0x000000018992B080-0x000000018992B0A0
	public override ConfigAbilityMixin Clone(bool useObjectPool = false /* Metadata: 0x00AF5C79 */) => default; // 0x00000001820F3DE0-0x00000001820F3EC0
	// [XID] // 0x0000000189932760-0x0000000189932780
	public override int GetHashNum() => default; // 0x00000001820F2930-0x00000001820F2A00
	// [XID] // 0x000000018993A130-0x000000018993A150
	public override void InitEmpty() {} // 0x00000001820F3690-0x00000001820F3780
	[BlackList] // 0x0000000189941300-0x0000000189941340
	// [XID] // 0x0000000189941300-0x0000000189941340
	public override bool FromJson(JSONNode node) => default; // 0x00000001820F2F80-0x00000001820F3300
	// [XID] // 0x000000018994BBC0-0x000000018994BBE0
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001820F20E0-0x00000001820F23F0
	[BlackList] // 0x00000001899533B0-0x00000001899533F0
	// [XID] // 0x00000001899533B0-0x00000001899533F0
	public static new AttachToPoseIDMixin ParseFromJson(JSONNode node) => default; // 0x00000001820F3F20-0x00000001820F4170
	// [XID] // 0x000000018995DC50-0x000000018995DC70
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C7A */, bool useObjectPool = false /* Metadata: 0x00AF5C7E */) => default; // 0x00000001820F3A00-0x00000001820F3D00
	// [XID] // 0x0000000189965470-0x0000000189965490
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C7F */, bool useObjectPool = false /* Metadata: 0x00AF5C83 */) => default; // 0x00000001820F2AE0-0x00000001820F2DE0
	// [XID] // 0x000000018996CA90-0x000000018996CAB0
	public static new AttachToPoseIDMixin ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF5C84 */, bool useObjectPool = false /* Metadata: 0x00AF5C88 */) => default; // 0x00000001820F3370-0x00000001820F3590
	[BlackList] // 0x0000000189974530-0x0000000189974570
	// [XID] // 0x0000000189974530-0x0000000189974570
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001820F23F0-0x00000001820F26C0
	// [XID] // 0x000000018997E7C0-0x000000018997E7E0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001820F4380-0x00000001820F4640
	[BlackList] // 0x0000000189986210-0x0000000189986250
	// [XID] // 0x0000000189986210-0x0000000189986250
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001820F3910-0x00000001820F3A00
	// [XID] // 0x0000000189990F50-0x0000000189990F70
	public override BaseAbilityMixin CreateInstancedMixin(ActorAbility instancedAbility, ActorModifier instancedModifier) => default; // 0x00000001820F3D00-0x00000001820F3DE0
	[BlackList] // 0x00000001899A02F0-0x00000001899A0330
	// [XID] // 0x00000001899A02F0-0x00000001899A0330
	public override void AutoAllocTypeFields() {} // 0x00000001820F26C0-0x00000001820F2760
	[BlackList] // 0x00000001899AAC80-0x00000001899AACC0
	// [XID] // 0x00000001899AAC80-0x00000001899AACC0
	public override void AutoRecycleTypeFields() {} // 0x00000001820F2760-0x00000001820F2810
	[BlackList] // 0x00000001899B5440-0x00000001899B5480
	// [XID] // 0x00000001899B5440-0x00000001899B5480
	public override void ReturnToObjectPool() {} // 0x00000001820F47F0-0x00000001820F4890
}

