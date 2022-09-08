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
public class ConfigGuideOpenUICondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18204
{
	// Fields
	private string _contextName; // 0x20
	private bool _enable; // 0x28
	private string[] _activeList; // 0x30
	private GuidePageType _pageType; // 0x38
	private NotifyTypes[] _curNotifyList; // 0x40

	// Properties
	public string contextName { /* [XID] */ /* 0x0000000189A234A0-0x0000000189A234C0 */ get => default; /* [XID] */ /* 0x0000000189A2A880-0x0000000189A2A8A0 */ private set {} } // 0x0000000182CF1870-0x0000000182CF1910 0x0000000182CF2040-0x0000000182CF20F0
	public bool enable { /* [XID] */ /* 0x0000000189A31D80-0x0000000189A31DA0 */ get => default; /* [XID] */ /* 0x0000000189A397D0-0x0000000189A397F0 */ private set {} } // 0x0000000182CF17D0-0x0000000182CF1870 0x0000000182CF2870-0x0000000182CF2920
	public string[] activeList { /* [XID] */ /* 0x0000000189A41030-0x0000000189A41050 */ get => default; /* [XID] */ /* 0x0000000189A48610-0x0000000189A48630 */ private set {} } // 0x0000000182CF2B20-0x0000000182CF2BC0 0x0000000182CF0D20-0x0000000182CF0DD0
	public GuidePageType pageType { /* [XID] */ /* 0x0000000189A4FE80-0x0000000189A4FEA0 */ get => default; /* [XID] */ /* 0x0000000189A57410-0x0000000189A57430 */ private set {} } // 0x0000000182CF2A80-0x0000000182CF2B20 0x0000000182CF1250-0x0000000182CF1300

	// Constructors
	public ConfigGuideOpenUICondition() {} // 0x0000000182CF31F0-0x0000000182CF32D0

	// Methods
	// [XID] // 0x0000000189A5EF50-0x0000000189A5EF70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182CF3000-0x0000000182CF3150
	// [XID] // 0x0000000189A668A0-0x0000000189A668C0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182CF2980-0x0000000182CF2A80
	// [XID] // 0x0000000189A6E0C0-0x0000000189A6E0E0
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF9023 */) => default; // 0x0000000182CF24E0-0x0000000182CF25C0
	// [XID] // 0x0000000189A75570-0x0000000189A75590
	public override int GetHashNum() => default; // 0x0000000182CF0B70-0x0000000182CF0C40
	// [XID] // 0x0000000189A7D290-0x0000000189A7D2B0
	public override void InitEmpty() {} // 0x0000000182CF1E70-0x0000000182CF1F60
	[BlackList] // 0x0000000189A84AC0-0x0000000189A84B00
	// [XID] // 0x0000000189A84AC0-0x0000000189A84B00
	public override bool FromJson(JSONNode node) => default; // 0x0000000182CF1450-0x0000000182CF17D0
	// [XID] // 0x0000000189A8F410-0x0000000189A8F430
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182CF0180-0x0000000182CF0620
	[BlackList] // 0x0000000189A969C0-0x0000000189A96A00
	// [XID] // 0x0000000189A969C0-0x0000000189A96A00
	public static new ConfigGuideOpenUICondition ParseFromJson(JSONNode node) => default; // 0x0000000182CF2620-0x0000000182CF2870
	// [XID] // 0x0000000189AA0D00-0x0000000189AA0D20
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9024 */, bool useObjectPool = false /* Metadata: 0x00AF9028 */) => default; // 0x0000000182CF21E0-0x0000000182CF24E0
	// [XID] // 0x0000000189AA8320-0x0000000189AA8340
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9029 */, bool useObjectPool = false /* Metadata: 0x00AF902D */) => default; // 0x0000000182CF0DD0-0x0000000182CF11D0
	// [XID] // 0x0000000189AB0020-0x0000000189AB0040
	public static new ConfigGuideOpenUICondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF902E */, bool useObjectPool = false /* Metadata: 0x00AF9032 */) => default; // 0x0000000182CF1910-0x0000000182CF1B30
	[BlackList] // 0x0000000189AB7790-0x0000000189AB77D0
	// [XID] // 0x0000000189AB7790-0x0000000189AB77D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182CF0620-0x0000000182CF08F0
	// [XID] // 0x0000000189AC2440-0x0000000189AC2460
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182CF2C40-0x0000000182CF3000
	[BlackList] // 0x0000000189AC9B80-0x0000000189AC9BC0
	// [XID] // 0x0000000189AC9B80-0x0000000189AC9BC0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182CF20F0-0x0000000182CF21E0
	// [XID] // 0x0000000189AD4800-0x0000000189AD4820
	protected override bool Prepare(GuideManager manager) => default; // 0x0000000182CF1380-0x0000000182CF1450
	// [XID] // 0x0000000189ADC100-0x0000000189ADC120
	public override bool Ready(object body = null) => default; // 0x0000000182CF1BA0-0x0000000182CF1DF0
	[BlackList] // 0x0000000189AE3AF0-0x0000000189AE3B30
	// [XID] // 0x0000000189AE3AF0-0x0000000189AE3B30
	public override void AutoAllocTypeFields() {} // 0x0000000182CF08F0-0x0000000182CF0990
	[BlackList] // 0x0000000189AEE620-0x0000000189AEE660
	// [XID] // 0x0000000189AEE620-0x0000000189AEE660
	public override void AutoRecycleTypeFields() {} // 0x0000000182CF0990-0x0000000182CF0A50
	[BlackList] // 0x0000000189AF8D90-0x0000000189AF8DD0
	// [XID] // 0x0000000189AF8D90-0x0000000189AF8DD0
	public override void ReturnToObjectPool() {} // 0x0000000182CF3150-0x0000000182CF31F0
}

