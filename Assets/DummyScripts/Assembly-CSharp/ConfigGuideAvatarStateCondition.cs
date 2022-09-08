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
public class ConfigGuideAvatarStateCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18216
{
	// Fields
	private GuideAvatarState _state; // 0x20

	// Properties
	public GuideAvatarState state { /* [XID] */ /* 0x00000001898308A0-0x00000001898308C0 */ get => default; /* [XID] */ /* 0x0000000189837DE0-0x0000000189837E00 */ private set {} } // 0x0000000183DE5A60-0x0000000183DE5B00 0x0000000183DE4B90-0x0000000183DE4C40

	// Constructors
	public ConfigGuideAvatarStateCondition() {} // 0x0000000183DE73E0-0x0000000183DE7440

	// Methods
	// [XID] // 0x000000018983F5B0-0x000000018983F5D0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183DE7250-0x0000000183DE7340
	// [XID] // 0x0000000189846C50-0x0000000189846C70
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183DE6F20-0x0000000183DE6FD0
	// [XID] // 0x000000018984E260-0x000000018984E280
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF908F */) => default; // 0x0000000183DE6B30-0x0000000183DE6C10
	// [XID] // 0x00000001898553B0-0x00000001898553D0
	public override int GetHashNum() => default; // 0x0000000183DE5400-0x0000000183DE54D0
	// [XID] // 0x000000018985CA50-0x000000018985CA70
	public override void InitEmpty() {} // 0x0000000183DE65C0-0x0000000183DE6660
	[BlackList] // 0x00000001898642D0-0x0000000189864310
	// [XID] // 0x00000001898642D0-0x0000000189864310
	public override bool FromJson(JSONNode node) => default; // 0x0000000183DE5DD0-0x0000000183DE6150
	// [XID] // 0x000000018986E710-0x000000018986E730
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183DE4970-0x0000000183DE4B90
	[BlackList] // 0x0000000189875AE0-0x0000000189875B20
	// [XID] // 0x0000000189875AE0-0x0000000189875B20
	public static new ConfigGuideAvatarStateCondition ParseFromJson(JSONNode node) => default; // 0x0000000183DE6C70-0x0000000183DE6EC0
	// [XID] // 0x0000000189880260-0x0000000189880280
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9090 */, bool useObjectPool = false /* Metadata: 0x00AF9094 */) => default; // 0x0000000183DE6830-0x0000000183DE6B30
	// [XID] // 0x00000001898877A0-0x00000001898877C0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9095 */, bool useObjectPool = false /* Metadata: 0x00AF9099 */) => default; // 0x0000000183DE5830-0x0000000183DE5A60
	// [XID] // 0x000000018988EAA0-0x000000018988EAC0
	public static new ConfigGuideAvatarStateCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF909A */, bool useObjectPool = false /* Metadata: 0x00AF909E */) => default; // 0x0000000183DE6150-0x0000000183DE6370
	[BlackList] // 0x0000000189895F00-0x0000000189895F40
	// [XID] // 0x0000000189895F00-0x0000000189895F40
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183DE4C40-0x0000000183DE4F10
	// [XID] // 0x00000001898A0470-0x00000001898A0490
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183DE7050-0x0000000183DE7250
	[BlackList] // 0x00000001898A7BB0-0x00000001898A7BF0
	// [XID] // 0x00000001898A7BB0-0x00000001898A7BF0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183DE6740-0x0000000183DE6830
	// [XID] // 0x00000001898B2350-0x00000001898B2370
	protected override bool Prepare(GuideManager manager) => default; // 0x0000000183DE5C00-0x0000000183DE5CB0
	// [XID] // 0x00000001898BA100-0x00000001898BA120
	private bool CanAvatarFly() => default; // 0x0000000183DE4800-0x0000000183DE4970
	// [XID] // 0x00000001898C13C0-0x00000001898C13E0
	private bool AvatarInFly() => default; // 0x0000000183DE5CB0-0x0000000183DE5DD0
	// [XID] // 0x00000001898C8DA0-0x00000001898C8DC0
	private bool CanAvatarPromote() => default; // 0x0000000183DE5100-0x0000000183DE5380
	// [XID] // 0x00000001898D0600-0x00000001898D0620
	private bool CanAvatarUpGrade() => default; // 0x0000000183DE54D0-0x0000000183DE5750
	// [XID] // 0x00000001898D7CC0-0x00000001898D7CE0
	public override bool Ready(object body = null) => default; // 0x0000000183DE63E0-0x0000000183DE6540
	[BlackList] // 0x00000001898DF940-0x00000001898DF980
	// [XID] // 0x00000001898DF940-0x00000001898DF980
	public override void AutoAllocTypeFields() {} // 0x0000000183DE4F10-0x0000000183DE4FB0
	[BlackList] // 0x00000001898EA570-0x00000001898EA5B0
	// [XID] // 0x00000001898EA570-0x00000001898EA5B0
	public override void AutoRecycleTypeFields() {} // 0x0000000183DE4FB0-0x0000000183DE5060
	[BlackList] // 0x00000001898F4B40-0x00000001898F4B80
	// [XID] // 0x00000001898F4B40-0x00000001898F4B80
	public override void ReturnToObjectPool() {} // 0x0000000183DE7340-0x0000000183DE73E0
}

