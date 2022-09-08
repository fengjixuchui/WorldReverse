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
public class ConfigGuideTabItemCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18222
{
	// Fields
	private string _path; // 0x20
	private string _contextName; // 0x28
	private SimpleSafeInt32 valueRawNum; // 0x30
	private GuidePageType _pageType; // 0x34
	private bool _isSelect; // 0x38
	private BaseContext _baseContext; // 0x40
	private MonoReusableList _targetList; // 0x48
	private static NotifyTypes[] _curNotifyList; // 0x00

	// Properties
	public string path { /* [XID] */ /* 0x0000000189A73FB0-0x0000000189A73FD0 */ get => default; /* [XID] */ /* 0x0000000189A7B9A0-0x0000000189A7B9C0 */ private set {} } // 0x0000000183E27250-0x0000000183E272F0 0x0000000183E27070-0x0000000183E27120
	public string contextName { /* [XID] */ /* 0x0000000189A83200-0x0000000189A83220 */ get => default; /* [XID] */ /* 0x0000000189A8AB00-0x0000000189A8AB20 */ private set {} } // 0x0000000183E25A50-0x0000000183E25AF0 0x0000000183E26640-0x0000000183E266F0
	public int value { /* [XID] */ /* 0x0000000189A92370-0x0000000189A92390 */ get => default; /* [XID] */ /* 0x0000000189A99D20-0x0000000189A99D40 */ private set {} } // 0x0000000183E25600-0x0000000183E256D0 0x0000000183E253B0-0x0000000183E25490
	public GuidePageType pageType { /* [XID] */ /* 0x0000000189AA0CE0-0x0000000189AA0D00 */ get => default; /* [XID] */ /* 0x0000000189AA8300-0x0000000189AA8320 */ private set {} } // 0x0000000183E26FD0-0x0000000183E27070 0x0000000183E25300-0x0000000183E253B0
	public bool isSelect { /* [XID] */ /* 0x0000000189AB0000-0x0000000189AB0020 */ get => default; /* [XID] */ /* 0x0000000189AB7770-0x0000000189AB7790 */ private set {} } // 0x0000000183E25DB0-0x0000000183E25E50 0x0000000183E27920-0x0000000183E279D0

	// Constructors
	public ConfigGuideTabItemCondition() {} // 0x0000000183E27B40-0x0000000183E27BB0
	static ConfigGuideTabItemCondition() {} // 0x0000000183E27A70-0x0000000183E27B40

	// Methods
	// [XID] // 0x0000000189ABF1D0-0x0000000189ABF1F0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183E277C0-0x0000000183E27920
	// [XID] // 0x0000000189AC6BE0-0x0000000189AC6C00
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183E26ED0-0x0000000183E26FD0
	// [XID] // 0x0000000189ACE410-0x0000000189ACE430
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF90BF */) => default; // 0x0000000183E26AE0-0x0000000183E26BC0
	// [XID] // 0x0000000189AD6200-0x0000000189AD6220
	public override int GetHashNum() => default; // 0x0000000183E24C30-0x0000000183E24D00
	// [XID] // 0x0000000189ADDBA0-0x0000000189ADDBC0
	public override void InitEmpty() {} // 0x0000000183E26450-0x0000000183E26560
	[BlackList] // 0x0000000189AE54C0-0x0000000189AE5500
	// [XID] // 0x0000000189AE54C0-0x0000000189AE5500
	public override bool FromJson(JSONNode node) => default; // 0x0000000183E256D0-0x0000000183E25A50
	// [XID] // 0x0000000189AEFF30-0x0000000189AEFF50
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183E24100-0x0000000183E246B0
	[BlackList] // 0x0000000189AF73E0-0x0000000189AF7420
	// [XID] // 0x0000000189AF73E0-0x0000000189AF7420
	public static new ConfigGuideTabItemCondition ParseFromJson(JSONNode node) => default; // 0x0000000183E26C20-0x0000000183E26E70
	// [XID] // 0x0000000189B01AD0-0x0000000189B01AF0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF90C0 */, bool useObjectPool = false /* Metadata: 0x00AF90C4 */) => default; // 0x0000000183E267E0-0x0000000183E26AE0
	// [XID] // 0x0000000189B09090-0x0000000189B090B0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF90C5 */, bool useObjectPool = false /* Metadata: 0x00AF90C9 */) => default; // 0x0000000183E24DE0-0x0000000183E25280
	// [XID] // 0x0000000189B10AD0-0x0000000189B10AF0
	public static new ConfigGuideTabItemCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF90CA */, bool useObjectPool = false /* Metadata: 0x00AF90CE */) => default; // 0x0000000183E25B90-0x0000000183E25DB0
	[BlackList] // 0x0000000189B17BE0-0x0000000189B17C20
	// [XID] // 0x0000000189B17BE0-0x0000000189B17C20
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183E246B0-0x0000000183E24980
	// [XID] // 0x0000000189B22390-0x0000000189B223B0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183E27370-0x0000000183E277C0
	[BlackList] // 0x0000000189B298E0-0x0000000189B29920
	// [XID] // 0x0000000189B298E0-0x0000000189B29920
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183E266F0-0x0000000183E267E0
	// [XID] // 0x0000000189B33D40-0x0000000189B33D60
	protected override bool Prepare(GuideManager manager) => default; // 0x0000000183E25510-0x0000000183E25600
	// [XID] // 0x0000000189B3B5F0-0x0000000189B3B610
	protected override void Finish(GuideManager manager) {} // 0x0000000183E271A0-0x0000000183E27250
	// [XID] // 0x0000000189B43030-0x0000000189B43050
	private void ReleaseCache() {} // 0x0000000183E25AF0-0x0000000183E25B90
	// [XID] // 0x0000000189B4A870-0x0000000189B4A890
	private void CheckCurPage() {} // 0x0000000183E25EC0-0x0000000183E260A0
	// [XID] // 0x0000000189B51FE0-0x0000000189B52000
	public override bool Ready(object body = null) => default; // 0x0000000183E260A0-0x0000000183E263D0
	[BlackList] // 0x0000000189B598A0-0x0000000189B598E0
	// [XID] // 0x0000000189B598A0-0x0000000189B598E0
	public override void AutoAllocTypeFields() {} // 0x0000000183E24980-0x0000000183E24A20
	[BlackList] // 0x0000000189B63FD0-0x0000000189B64010
	// [XID] // 0x0000000189B63FD0-0x0000000189B64010
	public override void AutoRecycleTypeFields() {} // 0x0000000183E24A20-0x0000000183E24B10
	[BlackList] // 0x0000000189B6E460-0x0000000189B6E4A0
	// [XID] // 0x0000000189B6E460-0x0000000189B6E4A0
	public override void ReturnToObjectPool() {} // 0x0000000183E279D0-0x0000000183E27A70
}

