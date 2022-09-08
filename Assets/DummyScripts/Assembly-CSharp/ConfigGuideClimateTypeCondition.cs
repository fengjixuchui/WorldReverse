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
public class ConfigGuideClimateTypeCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18210
{
	// Fields
	private JsonClimateType _climateType; // 0x20
	private bool _isEqual; // 0x24
	private NotifyTypes[] _curNotifyList; // 0x28

	// Properties
	public JsonClimateType climateType { /* [XID] */ /* 0x0000000189682170-0x0000000189682190 */ get => default; /* [XID] */ /* 0x0000000189689B90-0x0000000189689BB0 */ private set {} } // 0x00000001841D2850-0x00000001841D28F0 0x00000001841D28F0-0x00000001841D29A0
	public bool isEqual { /* [XID] */ /* 0x00000001896919B0-0x00000001896919D0 */ get => default; /* [XID] */ /* 0x0000000189698EC0-0x0000000189698EE0 */ private set {} } // 0x00000001841D21A0-0x00000001841D2240 0x00000001841D35D0-0x00000001841D3680

	// Constructors
	public ConfigGuideClimateTypeCondition() {} // 0x00000001841D3AC0-0x00000001841D3B80

	// Methods
	// [XID] // 0x00000001896A0430-0x00000001896A0450
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001841D3910-0x00000001841D3A20
	// [XID] // 0x00000001896A7940-0x00000001896A7960
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001841D34A0-0x00000001841D3550
	// [XID] // 0x00000001896AED70-0x00000001896AED90
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF9053 */) => default; // 0x00000001841D30B0-0x00000001841D3190
	// [XID] // 0x00000001896B64A0-0x00000001896B64C0
	public override int GetHashNum() => default; // 0x00000001841D1B90-0x00000001841D1C60
	// [XID] // 0x00000001896BD700-0x00000001896BD720
	public override void InitEmpty() {} // 0x00000001841D2B40-0x00000001841D2BE0
	[BlackList] // 0x00000001896C4DF0-0x00000001896C4E30
	// [XID] // 0x00000001896C4DF0-0x00000001896C4E30
	public override bool FromJson(JSONNode node) => default; // 0x00000001841D2240-0x00000001841D25C0
	// [XID] // 0x00000001896CF650-0x00000001896CF670
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001841D1370-0x00000001841D1650
	[BlackList] // 0x00000001896D68E0-0x00000001896D6920
	// [XID] // 0x00000001896D68E0-0x00000001896D6920
	public static new ConfigGuideClimateTypeCondition ParseFromJson(JSONNode node) => default; // 0x00000001841D31F0-0x00000001841D3440
	// [XID] // 0x00000001896E1090-0x00000001896E10B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9054 */, bool useObjectPool = false /* Metadata: 0x00AF9058 */) => default; // 0x00000001841D2DB0-0x00000001841D30B0
	// [XID] // 0x00000001896E8320-0x00000001896E8340
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9059 */, bool useObjectPool = false /* Metadata: 0x00AF905D */) => default; // 0x00000001841D1D40-0x00000001841D1FE0
	// [XID] // 0x00000001896EF980-0x00000001896EF9A0
	public static new ConfigGuideClimateTypeCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF905E */, bool useObjectPool = false /* Metadata: 0x00AF9062 */) => default; // 0x00000001841D25C0-0x00000001841D27E0
	[BlackList] // 0x00000001896F7310-0x00000001896F7350
	// [XID] // 0x00000001896F7310-0x00000001896F7350
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001841D1650-0x00000001841D1920
	// [XID] // 0x00000001897018A0-0x00000001897018C0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001841D3680-0x00000001841D3910
	[BlackList] // 0x0000000189709140-0x0000000189709180
	// [XID] // 0x0000000189709140-0x0000000189709180
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001841D2CC0-0x00000001841D2DB0
	// [XID] // 0x0000000189713840-0x0000000189713860
	protected override bool Prepare(GuideManager manager) => default; // 0x00000001841D20E0-0x00000001841D21A0
	// [XID] // 0x000000018971B0E0-0x000000018971B100
	public override bool Ready(object body = null) => default; // 0x00000001841D29A0-0x00000001841D2AC0
	[BlackList] // 0x0000000189722420-0x0000000189722460
	// [XID] // 0x0000000189722420-0x0000000189722460
	public override void AutoAllocTypeFields() {} // 0x00000001841D1920-0x00000001841D19C0
	[BlackList] // 0x000000018972CAA0-0x000000018972CAE0
	// [XID] // 0x000000018972CAA0-0x000000018972CAE0
	public override void AutoRecycleTypeFields() {} // 0x00000001841D19C0-0x00000001841D1A70
	[BlackList] // 0x0000000189737680-0x00000001897376C0
	// [XID] // 0x0000000189737680-0x00000001897376C0
	public override void ReturnToObjectPool() {} // 0x00000001841D3A20-0x00000001841D3AC0
}

