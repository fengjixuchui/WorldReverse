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
public class ConfigNpcStateIDInfo : ConfigNormalStateIDInfo, IAutoAllocRecycle // TypeDefIndex: 19034
{
	// Fields
	private bool _canBeInter; // 0x60

	// Properties
	public bool canBeInter { /* [XID] */ /* 0x00000001896E3E70-0x00000001896E3E90 */ get => default; /* [XID] */ /* 0x00000001896EB240-0x00000001896EB260 */ private set {} } // 0x0000000184ACA1E0-0x0000000184ACA280 0x0000000184ACA960-0x0000000184ACAA10

	// Constructors
	public ConfigNpcStateIDInfo() {} // 0x0000000184ACAC60-0x0000000184ACACD0

	// Methods
	// [XID] // 0x00000001896F25D0-0x00000001896F25F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184ACAA10-0x0000000184ACAB00
	// [XID] // 0x00000001896F9F70-0x00000001896F9F90
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184ACA530-0x0000000184ACA5E0
	// [XID] // 0x0000000189701680-0x00000001897016A0
	public override ConfigBaseStateIDInfo Clone(bool useObjectPool = false /* Metadata: 0x00AFB829 */) => default; // 0x0000000184ACA0A0-0x0000000184ACA180
	// [XID] // 0x0000000189708EE0-0x0000000189708F00
	public override int GetHashNum() => default; // 0x0000000184AC9040-0x0000000184AC9110
	// [XID] // 0x00000001897107B0-0x00000001897107D0
	public override void InitEmpty() {} // 0x0000000184AC9B30-0x0000000184AC9BD0
	[BlackList] // 0x0000000189717B90-0x0000000189717BD0
	// [XID] // 0x0000000189717B90-0x0000000189717BD0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184AC9520-0x0000000184AC98A0
	// [XID] // 0x00000001897222A0-0x00000001897222C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184AC8900-0x0000000184AC8B00
	[BlackList] // 0x00000001897299E0-0x0000000189729A20
	// [XID] // 0x00000001897299E0-0x0000000189729A20
	public static new ConfigNpcStateIDInfo ParseFromJson(JSONNode node) => default; // 0x0000000184ACA280-0x0000000184ACA4D0
	// [XID] // 0x0000000189734150-0x0000000189734170
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB82A */, bool useObjectPool = false /* Metadata: 0x00AFB82E */) => default; // 0x0000000184AC9DA0-0x0000000184ACA0A0
	// [XID] // 0x000000018973B8B0-0x000000018973B8D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB82F */, bool useObjectPool = false /* Metadata: 0x00AFB833 */) => default; // 0x0000000184AC91F0-0x0000000184AC9420
	// [XID] // 0x00000001897433D0-0x00000001897433F0
	public static new ConfigNpcStateIDInfo ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFB834 */, bool useObjectPool = false /* Metadata: 0x00AFB838 */) => default; // 0x0000000184AC98A0-0x0000000184AC9AC0
	[BlackList] // 0x000000018974AF60-0x000000018974AFA0
	// [XID] // 0x000000018974AF60-0x000000018974AFA0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184AC8B00-0x0000000184AC8DD0
	// [XID] // 0x00000001897553B0-0x00000001897553D0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184ACA760-0x0000000184ACA960
	[BlackList] // 0x000000018975C570-0x000000018975C5B0
	// [XID] // 0x000000018975C570-0x000000018975C5B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184AC9CB0-0x0000000184AC9DA0
	[BlackList] // 0x0000000189766E60-0x0000000189766EA0
	// [XID] // 0x0000000189766E60-0x0000000189766EA0
	public override void AutoAllocTypeFields() {} // 0x0000000184AC8DD0-0x0000000184AC8E70
	[BlackList] // 0x00000001897715D0-0x0000000189771610
	// [XID] // 0x00000001897715D0-0x0000000189771610
	public override void AutoRecycleTypeFields() {} // 0x0000000184AC8E70-0x0000000184AC8F20
	[BlackList] // 0x000000018977BB20-0x000000018977BB60
	// [XID] // 0x000000018977BB20-0x000000018977BB60
	public override void ReturnToObjectPool() {} // 0x0000000184ACABC0-0x0000000184ACAC60
	// [XID] // 0x00000001897864A0-0x00000001897864C0
	public override void HandleAnimatorState(BaseEntity entity, bool isTo, int fromStateID, int toStateID, VCAnimatorEvent animatorComponent) {} // 0x0000000184ACA5E0-0x0000000184ACA760
}

