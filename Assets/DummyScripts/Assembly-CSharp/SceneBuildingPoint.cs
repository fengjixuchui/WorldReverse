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
public class SceneBuildingPoint : ConfigScenePoint, IAutoAllocRecycle // TypeDefIndex: 14982
{
	// Fields
	private SceneBuildingType _buildingType; // 0x60
	private SimpleSafeUInt16 fogIdRawNum; // 0x64

	// Properties
	public override RealScenePointType pointType { /* [XID] */ /* 0x0000000189B82110-0x0000000189B82130 */ get => default; } // 0x0000000182326D50-0x0000000182326DF0 
	public SceneBuildingType buildingType { /* [XID] */ /* 0x0000000189BCCBC0-0x0000000189BCCBE0 */ get => default; /* [XID] */ /* 0x0000000189B90F30-0x0000000189B90F50 */ private set {} } // 0x0000000182325AB0-0x0000000182325B50 0x0000000182325F10-0x0000000182325FC0
	public ushort fogId { /* [XID] */ /* 0x0000000189B981A0-0x0000000189B981C0 */ get => default; /* [XID] */ /* 0x0000000189B9F650-0x0000000189B9F670 */ private set {} } // 0x0000000182327300-0x00000001823273D0 0x0000000182326E50-0x0000000182326F30

	// Constructors
	public SceneBuildingPoint() {} // 0x0000000182327840-0x00000001823278A0

	// Methods
	// [XID] // 0x0000000189BA6EA0-0x0000000189BA6EC0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182327690-0x00000001823277A0
	// [XID] // 0x0000000189BADFE0-0x0000000189BAE000
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001823271E0-0x0000000182327290
	// [XID] // 0x0000000189BB58B0-0x0000000189BB58D0
	public override ConfigScenePoint Clone(bool useObjectPool = false /* Metadata: 0x00AEFD88 */) => default; // 0x0000000182326C70-0x0000000182326D50
	// [XID] // 0x0000000189BBD040-0x0000000189BBD060
	public override int GetHashNum() => default; // 0x00000001823259E0-0x0000000182325AB0
	// [XID] // 0x0000000189BC4C20-0x0000000189BC4C40
	public override void InitEmpty() {} // 0x00000001823266D0-0x00000001823267A0
	[BlackList] // 0x0000000189BCC6E0-0x0000000189BCC720
	// [XID] // 0x0000000189BCC6E0-0x0000000189BCC720
	public override bool FromJson(JSONNode node) => default; // 0x00000001823260C0-0x0000000182326440
	// [XID] // 0x0000000189BD68A0-0x0000000189BD68C0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182325120-0x0000000182325470
	[BlackList] // 0x0000000189BDE620-0x0000000189BDE660
	// [XID] // 0x0000000189BDE620-0x0000000189BDE660
	public static new SceneBuildingPoint ParseFromJson(JSONNode node) => default; // 0x0000000182326F30-0x0000000182327180
	// [XID] // 0x00000001895EE030-0x00000001895EE050
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD89 */, bool useObjectPool = false /* Metadata: 0x00AEFD8D */) => default; // 0x0000000182326970-0x0000000182326C70
	// [XID] // 0x00000001895F57D0-0x00000001895F57F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD8E */, bool useObjectPool = false /* Metadata: 0x00AEFD92 */) => default; // 0x0000000182325C30-0x0000000182325F10
	// [XID] // 0x00000001895FCD30-0x00000001895FCD50
	public static new SceneBuildingPoint ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEFD93 */, bool useObjectPool = false /* Metadata: 0x00AEFD97 */) => default; // 0x0000000182326440-0x0000000182326660
	[BlackList] // 0x0000000189604790-0x00000001896047D0
	// [XID] // 0x0000000189604790-0x00000001896047D0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182325470-0x0000000182325740
	// [XID] // 0x000000018960EFC0-0x000000018960EFE0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001823273D0-0x0000000182327690
	[BlackList] // 0x0000000189616620-0x0000000189616660
	// [XID] // 0x0000000189616620-0x0000000189616660
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182326880-0x0000000182326970
	[BlackList] // 0x0000000189620D60-0x0000000189620DA0
	// [XID] // 0x0000000189620D60-0x0000000189620DA0
	public override void AutoAllocTypeFields() {} // 0x0000000182325740-0x00000001823257E0
	[BlackList] // 0x000000018962B440-0x000000018962B480
	// [XID] // 0x000000018962B440-0x000000018962B480
	public override void AutoRecycleTypeFields() {} // 0x00000001823257E0-0x00000001823258C0
	[BlackList] // 0x00000001896360D0-0x0000000189636110
	// [XID] // 0x00000001896360D0-0x0000000189636110
	public override void ReturnToObjectPool() {} // 0x00000001823277A0-0x0000000182327840
}

