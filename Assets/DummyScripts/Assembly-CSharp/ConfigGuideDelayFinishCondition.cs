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
public sealed class ConfigGuideDelayFinishCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18240
{
	// Fields
	private SimpleSafeFloat delayTimeRawNum; // 0x20
	private ulong lastLocalNowMsTimeStamp; // 0x28

	// Properties
	public float delayTime { /* [XID] */ /* 0x0000000189A0B8F0-0x0000000189A0B910 */ get => default; /* [XID] */ /* 0x0000000189A13140-0x0000000189A13160 */ private set {} } // 0x0000000182C23830-0x0000000182C23910 0x0000000182C23910-0x0000000182C239F0

	// Constructors
	public ConfigGuideDelayFinishCondition() {} // 0x0000000182C254D0-0x0000000182C25540

	// Methods
	// [XID] // 0x0000000189A1A3D0-0x0000000189A1A3F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182C25330-0x0000000182C25430
	// [XID] // 0x0000000189A21AB0-0x0000000189A21AD0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182C25010-0x0000000182C250C0
	// [XID] // 0x0000000189A29060-0x0000000189A29080
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF9143 */) => default; // 0x0000000182C24C40-0x0000000182C24D30
	// [XID] // 0x0000000189A30630-0x0000000189A30650
	public override int GetHashNum() => default; // 0x0000000182C23760-0x0000000182C23830
	// [XID] // 0x0000000189A37FB0-0x0000000189A37FD0
	public override void InitEmpty() {} // 0x0000000182C246A0-0x0000000182C24770
	[BlackList] // 0x0000000189A3F780-0x0000000189A3F7C0
	// [XID] // 0x0000000189A3F780-0x0000000189A3F7C0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182C23F20-0x0000000182C242A0
	// [XID] // 0x0000000189A49C00-0x0000000189A49C20
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182C22F80-0x0000000182C231F0
	[BlackList] // 0x0000000189A515D0-0x0000000189A51610
	// [XID] // 0x0000000189A515D0-0x0000000189A51610
	public static new ConfigGuideDelayFinishCondition ParseFromJson(JSONNode node) => default; // 0x0000000182C24D90-0x0000000182C24FB0
	// [XID] // 0x0000000189A5C020-0x0000000189A5C040
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9144 */, bool useObjectPool = false /* Metadata: 0x00AF9148 */) => default; // 0x0000000182C24940-0x0000000182C24C40
	// [XID] // 0x0000000189A638B0-0x0000000189A638D0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9149 */, bool useObjectPool = false /* Metadata: 0x00AF914D */) => default; // 0x0000000182C23AD0-0x0000000182C23D40
	// [XID] // 0x0000000189A6B110-0x0000000189A6B130
	public static new ConfigGuideDelayFinishCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF914E */, bool useObjectPool = false /* Metadata: 0x00AF9152 */) => default; // 0x0000000182C242A0-0x0000000182C24490
	[BlackList] // 0x0000000189A72920-0x0000000189A72960
	// [XID] // 0x0000000189A72920-0x0000000189A72960
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182C231F0-0x0000000182C234C0
	// [XID] // 0x0000000189A7D270-0x0000000189A7D290
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182C25140-0x0000000182C25330
	[BlackList] // 0x0000000189A84A80-0x0000000189A84AC0
	// [XID] // 0x0000000189A84A80-0x0000000189A84AC0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182C24850-0x0000000182C24940
	// [XID] // 0x0000000189A8F3F0-0x0000000189A8F410
	protected override bool Prepare(GuideManager manager) => default; // 0x0000000182C23E40-0x0000000182C23F20
	// [XID] // 0x0000000189A969A0-0x0000000189A969C0
	public override bool Ready(object body = null) => default; // 0x0000000182C24500-0x0000000182C24620
	[BlackList] // 0x0000000189A9DDD0-0x0000000189A9DE10
	// [XID] // 0x0000000189A9DDD0-0x0000000189A9DE10
	public override void AutoAllocTypeFields() {} // 0x0000000182C234C0-0x0000000182C23560
	[BlackList] // 0x0000000189AA82C0-0x0000000189AA8300
	// [XID] // 0x0000000189AA82C0-0x0000000189AA8300
	public override void AutoRecycleTypeFields() {} // 0x0000000182C23560-0x0000000182C23640
	[BlackList] // 0x0000000189AB2F80-0x0000000189AB2FC0
	// [XID] // 0x0000000189AB2F80-0x0000000189AB2FC0
	public override void ReturnToObjectPool() {} // 0x0000000182C25430-0x0000000182C254D0
}

