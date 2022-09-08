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
public class ConfigGuideTheatreMechanicusInfoSelectCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18226
{
	// Fields
	private SimpleSafeInt32 valueRawNum; // 0x20
	private bool _isSelect; // 0x24
	private TheatreMechanicusInfoDialogContext _baseContext; // 0x28
	private static NotifyTypes[] _curNotifyList; // 0x00

	// Properties
	public int value { /* [XID] */ /* 0x00000001896731E0-0x0000000189673200 */ get => default; /* [XID] */ /* 0x000000018967A820-0x000000018967A840 */ private set {} } // 0x00000001851C0E50-0x00000001851C0F20 0x00000001851C0C00-0x00000001851C0CE0
	public bool isSelect { /* [XID] */ /* 0x0000000189682150-0x0000000189682170 */ get => default; /* [XID] */ /* 0x0000000189689B70-0x0000000189689B90 */ private set {} } // 0x00000001851C1560-0x00000001851C1600 0x00000001851C2910-0x00000001851C29C0

	// Constructors
	public ConfigGuideTheatreMechanicusInfoSelectCondition() {} // 0x00000001851C2B30-0x00000001851C2BA0
	static ConfigGuideTheatreMechanicusInfoSelectCondition() {} // 0x00000001851C2A60-0x00000001851C2B30

	// Methods
	// [XID] // 0x0000000189691990-0x00000001896919B0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001851C2800-0x00000001851C2910
	// [XID] // 0x0000000189698EA0-0x0000000189698EC0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001851C22E0-0x00000001851C2390
	// [XID] // 0x00000001896A0410-0x00000001896A0430
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF90DF */) => default; // 0x00000001851C1EF0-0x00000001851C1FD0
	// [XID] // 0x00000001896A7920-0x00000001896A7940
	public override int GetHashNum() => default; // 0x00000001851C06F0-0x00000001851C07C0
	// [XID] // 0x00000001896AED50-0x00000001896AED70
	public override void InitEmpty() {} // 0x00000001851C1950-0x00000001851C1A20
	[BlackList] // 0x00000001896B6460-0x00000001896B64A0
	// [XID] // 0x00000001896B6460-0x00000001896B64A0
	public override bool FromJson(JSONNode node) => default; // 0x00000001851C0F20-0x00000001851C12A0
	// [XID] // 0x00000001896C0560-0x00000001896C0580
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001851BFE60-0x00000001851C0180
	[BlackList] // 0x00000001896C7C70-0x00000001896C7CB0
	// [XID] // 0x00000001896C7C70-0x00000001896C7CB0
	public static new ConfigGuideTheatreMechanicusInfoSelectCondition ParseFromJson(JSONNode node) => default; // 0x00000001851C2030-0x00000001851C2280
	// [XID] // 0x00000001896D2080-0x00000001896D20A0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF90E0 */, bool useObjectPool = false /* Metadata: 0x00AF90E4 */) => default; // 0x00000001851C1BF0-0x00000001851C1EF0
	// [XID] // 0x00000001896D9930-0x00000001896D9950
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF90E5 */, bool useObjectPool = false /* Metadata: 0x00AF90E9 */) => default; // 0x00000001851C08A0-0x00000001851C0B80
	// [XID] // 0x00000001896E1070-0x00000001896E1090
	public static new ConfigGuideTheatreMechanicusInfoSelectCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF90EA */, bool useObjectPool = false /* Metadata: 0x00AF90EE */) => default; // 0x00000001851C1340-0x00000001851C1560
	[BlackList] // 0x00000001896E82E0-0x00000001896E8320
	// [XID] // 0x00000001896E82E0-0x00000001896E8320
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001851C0180-0x00000001851C0450
	// [XID] // 0x00000001896F2730-0x00000001896F2750
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001851C2540-0x00000001851C2800
	[BlackList] // 0x00000001896FA070-0x00000001896FA0B0
	// [XID] // 0x00000001896FA070-0x00000001896FA0B0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001851C1B00-0x00000001851C1BF0
	// [XID] // 0x0000000189704770-0x0000000189704790
	protected override bool Prepare(GuideManager manager) => default; // 0x00000001851C0D60-0x00000001851C0E50
	// [XID] // 0x000000018970BF90-0x000000018970BFB0
	protected override void Finish(GuideManager manager) {} // 0x00000001851C2410-0x00000001851C24C0
	// [XID] // 0x0000000189713820-0x0000000189713840
	private void ReleaseCache() {} // 0x00000001851C12A0-0x00000001851C1340
	// [XID] // 0x000000018971B0C0-0x000000018971B0E0
	private void CheckCurPage() {} // 0x00000001851C1670-0x00000001851C1750
	// [XID] // 0x0000000189722400-0x0000000189722420
	public override bool Ready(object body = null) => default; // 0x00000001851C1750-0x00000001851C18D0
	[BlackList] // 0x0000000189729B20-0x0000000189729B60
	// [XID] // 0x0000000189729B20-0x0000000189729B60
	public override void AutoAllocTypeFields() {} // 0x00000001851C0450-0x00000001851C04F0
	[BlackList] // 0x00000001897341F0-0x0000000189734230
	// [XID] // 0x00000001897341F0-0x0000000189734230
	public override void AutoRecycleTypeFields() {} // 0x00000001851C04F0-0x00000001851C05D0
	[BlackList] // 0x000000018973F120-0x000000018973F160
	// [XID] // 0x000000018973F120-0x000000018973F160
	public override void ReturnToObjectPool() {} // 0x00000001851C29C0-0x00000001851C2A60
}

