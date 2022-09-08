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
public class ConfigAITSTargetBearingSetting : ConfigAIThreatScoreBaseSetting, IAutoAllocRecycle // TypeDefIndex: 17395
{
	// Constructors
	public ConfigAITSTargetBearingSetting() {} // 0x00000001829AF940-0x00000001829AF9A0

	// Methods
	// [XID] // 0x000000018981A6C0-0x000000018981A6E0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001829AF680-0x00000001829AF730
	// [XID] // 0x0000000189821EB0-0x0000000189821ED0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001829AF4E0-0x00000001829AF590
	// [XID] // 0x00000001898293B0-0x00000001898293D0
	public override ConfigAIThreatScoreBaseSetting Clone(bool useObjectPool = false /* Metadata: 0x00AF6D13 */) => default; // 0x00000001829AF0F0-0x00000001829AF1D0
	// [XID] // 0x0000000189830A80-0x0000000189830AA0
	public override int GetHashNum() => default; // 0x00000001829AE190-0x00000001829AE260
	// [XID] // 0x0000000189838000-0x0000000189838020
	public override void InitEmpty() {} // 0x00000001829AEB80-0x00000001829AEC20
	[BlackList] // 0x000000018983F7D0-0x000000018983F810
	// [XID] // 0x000000018983F7D0-0x000000018983F810
	public override bool FromJson(JSONNode node) => default; // 0x00000001829AE570-0x00000001829AE8F0
	// [XID] // 0x0000000189849B10-0x0000000189849B30
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001829ADAD0-0x00000001829ADBC0
	[BlackList] // 0x0000000189851290-0x00000001898512D0
	// [XID] // 0x0000000189851290-0x00000001898512D0
	public static new ConfigAITSTargetBearingSetting ParseFromJson(JSONNode node) => default; // 0x00000001829AF230-0x00000001829AF480
	// [XID] // 0x000000018985B670-0x000000018985B690
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D14 */, bool useObjectPool = false /* Metadata: 0x00AF6D18 */) => default; // 0x00000001829AEDF0-0x00000001829AF0F0
	// [XID] // 0x0000000189862C50-0x0000000189862C70
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D19 */, bool useObjectPool = false /* Metadata: 0x00AF6D1D */) => default; // 0x00000001829AE340-0x00000001829AE470
	// [XID] // 0x000000018986A0C0-0x000000018986A0E0
	public static new ConfigAITSTargetBearingSetting ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D1E */, bool useObjectPool = false /* Metadata: 0x00AF6D22 */) => default; // 0x00000001829AE8F0-0x00000001829AEB10
	[BlackList] // 0x00000001898713F0-0x0000000189871430
	// [XID] // 0x00000001898713F0-0x0000000189871430
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001829ADBC0-0x00000001829ADE90
	// [XID] // 0x000000018987BCC0-0x000000018987BCE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001829AF590-0x00000001829AF680
	[BlackList] // 0x0000000189882E50-0x0000000189882E90
	// [XID] // 0x0000000189882E50-0x0000000189882E90
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001829AED00-0x00000001829AEDF0
	[BlackList] // 0x000000018988D420-0x000000018988D460
	// [XID] // 0x000000018988D420-0x000000018988D460
	public override void AutoAllocTypeFields() {} // 0x00000001829ADF30-0x00000001829ADFD0
	[BlackList] // 0x0000000189897960-0x00000001898979A0
	// [XID] // 0x0000000189897960-0x00000001898979A0
	public override void AutoRecycleTypeFields() {} // 0x00000001829ADFD0-0x00000001829AE070
	[BlackList] // 0x00000001898A1EE0-0x00000001898A1F20
	// [XID] // 0x00000001898A1EE0-0x00000001898A1F20
	public override void ReturnToObjectPool() {} // 0x00000001829AF8A0-0x00000001829AF940
	// [XID] // 0x00000001898AC600-0x00000001898AC620
	public override float CalculateScore(AIKnowledge aiKnowledge, ThreatInfo threatInfo, ThreadRuntimeInfo threatRuntimeInfo) => default; // 0x00000001829AF730-0x00000001829AF8A0
}

