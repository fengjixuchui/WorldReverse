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
public class ConfigGuideLevelCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18202
{
	// Fields
	private SimpleSafeUInt32 limitLevelRawNum; // 0x20

	// Properties
	public uint limitLevel { /* [XID] */ /* 0x0000000189969820-0x0000000189969840 */ get => default; /* [XID] */ /* 0x0000000189971560-0x0000000189971580 */ private set {} } // 0x0000000182C4DE30-0x0000000182C4DF00 0x0000000182C4D300-0x0000000182C4D3E0

	// Constructors
	public ConfigGuideLevelCondition() {} // 0x0000000182C4E090-0x0000000182C4E1F0

	// Methods
	// [XID] // 0x0000000189978F50-0x0000000189978F70
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182C4DF00-0x0000000182C4DFF0
	// [XID] // 0x0000000189980040-0x0000000189980060
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182C4DAD0-0x0000000182C4DB80
	// [XID] // 0x00000001899877D0-0x00000001899877F0
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF9013 */) => default; // 0x0000000182C4D6E0-0x0000000182C4D7C0
	// [XID] // 0x000000018998F440-0x000000018998F460
	public override int GetHashNum() => default; // 0x0000000182C4C2E0-0x0000000182C4C3B0
	// [XID] // 0x0000000189996DE0-0x0000000189996E00
	public override void InitEmpty() {} // 0x0000000182C4D060-0x0000000182C4D130
	[BlackList] // 0x000000018999E9F0-0x000000018999EA30
	// [XID] // 0x000000018999E9F0-0x000000018999EA30
	public override bool FromJson(JSONNode node) => default; // 0x0000000182C4C8B0-0x0000000182C4CC30
	// [XID] // 0x00000001899A91C0-0x00000001899A91E0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182C4BB10-0x0000000182C4BD70
	[BlackList] // 0x00000001899B0CD0-0x00000001899B0D10
	// [XID] // 0x00000001899B0CD0-0x00000001899B0D10
	public static new ConfigGuideLevelCondition ParseFromJson(JSONNode node) => default; // 0x0000000182C4D820-0x0000000182C4DA70
	// [XID] // 0x00000001899BB010-0x00000001899BB030
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9014 */, bool useObjectPool = false /* Metadata: 0x00AF9018 */) => default; // 0x0000000182C4D3E0-0x0000000182C4D6E0
	// [XID] // 0x00000001899C29E0-0x00000001899C2A00
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9019 */, bool useObjectPool = false /* Metadata: 0x00AF901D */) => default; // 0x0000000182C4C490-0x0000000182C4C700
	// [XID] // 0x00000001899CA060-0x00000001899CA080
	public static new ConfigGuideLevelCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF901E */, bool useObjectPool = false /* Metadata: 0x00AF9022 */) => default; // 0x0000000182C4CC30-0x0000000182C4CE50
	[BlackList] // 0x00000001899D1900-0x00000001899D1940
	// [XID] // 0x00000001899D1900-0x00000001899D1940
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182C4BD70-0x0000000182C4C040
	// [XID] // 0x00000001899DBD50-0x00000001899DBD70
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182C4DC00-0x0000000182C4DE30
	[BlackList] // 0x00000001899E3770-0x00000001899E37B0
	// [XID] // 0x00000001899E3770-0x00000001899E37B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182C4D210-0x0000000182C4D300
	// [XID] // 0x00000001899EDD60-0x00000001899EDD80
	protected override bool Prepare(GuideManager manager) => default; // 0x0000000182C4C800-0x0000000182C4C8B0
	// [XID] // 0x00000001899F55F0-0x00000001899F5610
	public override bool Ready(object body = null) => default; // 0x0000000182C4CEC0-0x0000000182C4CFE0
	[BlackList] // 0x00000001899FCD30-0x00000001899FCD70
	// [XID] // 0x00000001899FCD30-0x00000001899FCD70
	public override void AutoAllocTypeFields() {} // 0x0000000182C4C040-0x0000000182C4C0E0
	[BlackList] // 0x0000000189A07270-0x0000000189A072B0
	// [XID] // 0x0000000189A07270-0x0000000189A072B0
	public override void AutoRecycleTypeFields() {} // 0x0000000182C4C0E0-0x0000000182C4C1C0
	[BlackList] // 0x0000000189A11B20-0x0000000189A11B60
	// [XID] // 0x0000000189A11B20-0x0000000189A11B60
	public override void ReturnToObjectPool() {} // 0x0000000182C4DFF0-0x0000000182C4E090
}

