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
public sealed class ConfigGuideNavigationCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18262
{
	// Fields
	private SimpleSafeUInt32 navigationIdRawNum; // 0x20
	private GuideNavigationType _navigationType; // 0x24
	private GuideNavigationCheckType _checkType; // 0x28
	private bool _onlyCheckChange; // 0x2C
	private NotifyTypes[] _curNotifyList; // 0x30
	private bool _isChecked; // 0x38

	// Properties
	public uint navigationId { /* [XID] */ /* 0x0000000189A02A90-0x0000000189A02AB0 */ get => default; /* [XID] */ /* 0x0000000189A0A1C0-0x0000000189A0A1E0 */ private set {} } // 0x000000018578BA70-0x000000018578BB40 0x000000018578C130-0x000000018578C210
	public GuideNavigationType navigationType { /* [XID] */ /* 0x0000000189A11AE0-0x0000000189A11B00 */ get => default; /* [XID] */ /* 0x0000000189A18D30-0x0000000189A18D50 */ private set {} } // 0x000000018578D7B0-0x000000018578D850 0x000000018578B510-0x000000018578B5C0
	public GuideNavigationCheckType checkType { /* [XID] */ /* 0x0000000189A20410-0x0000000189A20430 */ get => default; /* [XID] */ /* 0x0000000189A27800-0x0000000189A27820 */ private set {} } // 0x000000018578A7F0-0x000000018578A890 0x000000018578C400-0x000000018578C4B0
	public bool onlyCheckChange { /* [XID] */ /* 0x0000000189A2EF30-0x0000000189A2EF50 */ get => default; /* [XID] */ /* 0x0000000189A36930-0x0000000189A36950 */ private set {} } // 0x000000018578CD00-0x000000018578CDA0 0x000000018578BBC0-0x000000018578BC70

	// Constructors
	public ConfigGuideNavigationCondition() {} // 0x000000018578D8F0-0x000000018578D9B0

	// Methods
	// [XID] // 0x0000000189A3DF30-0x0000000189A3DF50
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018578D660-0x000000018578D7B0
	// [XID] // 0x0000000189A456E0-0x0000000189A45700
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x000000018578D170-0x000000018578D220
	// [XID] // 0x0000000189A4CC40-0x0000000189A4CC60
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF91DB */) => default; // 0x000000018578CDA0-0x000000018578CE90
	// [XID] // 0x0000000189A54510-0x0000000189A54530
	public override int GetHashNum() => default; // 0x000000018578B380-0x000000018578B450
	// [XID] // 0x0000000189A5C000-0x0000000189A5C020
	public override void InitEmpty() {} // 0x000000018578C760-0x000000018578C830
	[BlackList] // 0x0000000189A63870-0x0000000189A638B0
	// [XID] // 0x0000000189A63870-0x0000000189A638B0
	public override bool FromJson(JSONNode node) => default; // 0x000000018578BDB0-0x000000018578C130
	// [XID] // 0x0000000189A6E0A0-0x0000000189A6E0C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x000000018578A910-0x000000018578AE00
	[BlackList] // 0x0000000189A75530-0x0000000189A75570
	// [XID] // 0x0000000189A75530-0x0000000189A75570
	public static new ConfigGuideNavigationCondition ParseFromJson(JSONNode node) => default; // 0x000000018578CEF0-0x000000018578D110
	// [XID] // 0x0000000189A7FE20-0x0000000189A7FE40
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF91DC */, bool useObjectPool = false /* Metadata: 0x00AF91E0 */) => default; // 0x000000018578CA00-0x000000018578CD00
	// [XID] // 0x0000000189A87BE0-0x0000000189A87C00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF91E1 */, bool useObjectPool = false /* Metadata: 0x00AF91E5 */) => default; // 0x000000018578B6A0-0x000000018578BA70
	// [XID] // 0x0000000189A8F3D0-0x0000000189A8F3F0
	public static new ConfigGuideNavigationCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF91E6 */, bool useObjectPool = false /* Metadata: 0x00AF91EA */) => default; // 0x000000018578C210-0x000000018578C400
	[BlackList] // 0x0000000189A96960-0x0000000189A969A0
	// [XID] // 0x0000000189A96960-0x0000000189A969A0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x000000018578AE00-0x000000018578B0D0
	// [XID] // 0x0000000189AA0CC0-0x0000000189AA0CE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018578D2A0-0x000000018578D660
	[BlackList] // 0x0000000189AA8280-0x0000000189AA82C0
	// [XID] // 0x0000000189AA8280-0x0000000189AA82C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x000000018578C910-0x000000018578CA00
	// [XID] // 0x0000000189AB2F60-0x0000000189AB2F80
	protected override bool Prepare(GuideManager manager) => default; // 0x000000018578BCF0-0x000000018578BDB0
	// [XID] // 0x0000000189ABAC50-0x0000000189ABAC70
	public override bool Ready(object body = null) => default; // 0x000000018578C520-0x000000018578C6E0
	// [XID] // 0x0000000189AC2420-0x0000000189AC2440
	private MarkManager.NavigationType GetNavigationType() => default; // 0x000000018578B450-0x000000018578B510
	[BlackList] // 0x0000000189AC9B40-0x0000000189AC9B80
	// [XID] // 0x0000000189AC9B40-0x0000000189AC9B80
	public override void AutoAllocTypeFields() {} // 0x000000018578B0D0-0x000000018578B170
	[BlackList] // 0x0000000189AD47A0-0x0000000189AD47E0
	// [XID] // 0x0000000189AD47A0-0x0000000189AD47E0
	public override void AutoRecycleTypeFields() {} // 0x000000018578B170-0x000000018578B260
	[BlackList] // 0x0000000189ADF2D0-0x0000000189ADF310
	// [XID] // 0x0000000189ADF2D0-0x0000000189ADF310
	public override void ReturnToObjectPool() {} // 0x000000018578D850-0x000000018578D8F0
}

