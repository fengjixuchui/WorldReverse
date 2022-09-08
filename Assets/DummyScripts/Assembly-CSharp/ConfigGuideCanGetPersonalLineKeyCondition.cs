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
public class ConfigGuideCanGetPersonalLineKeyCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18208
{
	// Fields
	private bool _value; // 0x20
	private NotifyTypes[] _curNotifyList; // 0x28

	// Properties
	public bool value { /* [XID] */ /* 0x0000000189BC30B0-0x0000000189BC30D0 */ get => default; /* [XID] */ /* 0x0000000189BCA910-0x0000000189BCA930 */ private set {} } // 0x0000000182E70040-0x0000000182E700E0 0x0000000182E6FE50-0x0000000182E6FF00

	// Constructors
	public ConfigGuideCanGetPersonalLineKeyCondition() {} // 0x0000000182E71690-0x0000000182E71750

	// Methods
	// [XID] // 0x0000000189BD1F40-0x0000000189BD1F60
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182E71500-0x0000000182E715F0
	// [XID] // 0x0000000189BD95C0-0x0000000189BD95E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182E711D0-0x0000000182E71280
	// [XID] // 0x00000001895E6130-0x00000001895E6150
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF9043 */) => default; // 0x0000000182E70DE0-0x0000000182E70EC0
	// [XID] // 0x00000001895EDA70-0x00000001895EDA90
	public override int GetHashNum() => default; // 0x0000000182E6F9F0-0x0000000182E6FAC0
	// [XID] // 0x00000001895F52D0-0x00000001895F52F0
	public override void InitEmpty() {} // 0x0000000182E70870-0x0000000182E70910
	[BlackList] // 0x00000001895FC870-0x00000001895FC8B0
	// [XID] // 0x00000001895FC870-0x00000001895FC8B0
	public override bool FromJson(JSONNode node) => default; // 0x0000000182E700E0-0x0000000182E70460
	// [XID] // 0x0000000189606FE0-0x0000000189607000
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182E6F2B0-0x0000000182E6F4B0
	[BlackList] // 0x000000018960E9C0-0x000000018960EA00
	// [XID] // 0x000000018960E9C0-0x000000018960EA00
	public static new ConfigGuideCanGetPersonalLineKeyCondition ParseFromJson(JSONNode node) => default; // 0x0000000182E70F20-0x0000000182E71170
	// [XID] // 0x0000000189619320-0x0000000189619340
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9044 */, bool useObjectPool = false /* Metadata: 0x00AF9048 */) => default; // 0x0000000182E70AE0-0x0000000182E70DE0
	// [XID] // 0x0000000189620860-0x0000000189620880
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9049 */, bool useObjectPool = false /* Metadata: 0x00AF904D */) => default; // 0x0000000182E6FBA0-0x0000000182E6FDD0
	// [XID] // 0x0000000189627D50-0x0000000189627D70
	public static new ConfigGuideCanGetPersonalLineKeyCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF904E */, bool useObjectPool = false /* Metadata: 0x00AF9052 */) => default; // 0x0000000182E70460-0x0000000182E70680
	[BlackList] // 0x000000018962F660-0x000000018962F6A0
	// [XID] // 0x000000018962F660-0x000000018962F6A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182E6F4B0-0x0000000182E6F780
	// [XID] // 0x000000018963A090-0x000000018963A0B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182E71300-0x0000000182E71500
	[BlackList] // 0x0000000189641620-0x0000000189641660
	// [XID] // 0x0000000189641620-0x0000000189641660
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182E709F0-0x0000000182E70AE0
	// [XID] // 0x000000018964C010-0x000000018964C030
	protected override bool Prepare(GuideManager manager) => default; // 0x0000000182E6FF80-0x0000000182E70040
	// [XID] // 0x00000001896535E0-0x0000000189653600
	public override bool Ready(object body = null) => default; // 0x0000000182E706F0-0x0000000182E707F0
	[BlackList] // 0x000000018965AE30-0x000000018965AE70
	// [XID] // 0x000000018965AE30-0x000000018965AE70
	public override void AutoAllocTypeFields() {} // 0x0000000182E6F780-0x0000000182E6F820
	[BlackList] // 0x00000001896653D0-0x0000000189665410
	// [XID] // 0x00000001896653D0-0x0000000189665410
	public override void AutoRecycleTypeFields() {} // 0x0000000182E6F820-0x0000000182E6F8D0
	[BlackList] // 0x0000000189670170-0x00000001896701B0
	// [XID] // 0x0000000189670170-0x00000001896701B0
	public override void ReturnToObjectPool() {} // 0x0000000182E715F0-0x0000000182E71690
}

