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
public sealed class ConfigGuidePressKeyCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18282
{
	// Fields
	private InputEventType _eventID; // 0x20
	private InputEventType _endEventID; // 0x24
	private GuideKeyClick _type; // 0x28
	private SimpleSafeFloat valueRawNum; // 0x2C
	private bool isReady; // 0x30
	private float _pressTime; // 0x34
	private bool _inited; // 0x38
	private NewbieDialogContext _newBieDialog; // 0x40

	// Properties
	public InputEventType eventID { /* [XID] */ /* 0x00000001898C7520-0x00000001898C7540 */ get => default; /* [XID] */ /* 0x00000001898CEB70-0x00000001898CEB90 */ private set {} } // 0x00000001829FF470-0x00000001829FF510 0x00000001829FE390-0x00000001829FE440
	public InputEventType endEventID { /* [XID] */ /* 0x00000001898D64E0-0x00000001898D6500 */ get => default; /* [XID] */ /* 0x00000001898DE160-0x00000001898DE180 */ private set {} } // 0x00000001829FFBF0-0x00000001829FFC90 0x00000001829FEA10-0x00000001829FEAC0
	public GuideKeyClick type { /* [XID] */ /* 0x00000001898E5940-0x00000001898E5960 */ get => default; /* [XID] */ /* 0x00000001898ED380-0x00000001898ED3A0 */ private set {} } // 0x00000001829FFC90-0x00000001829FFD30 0x00000001829FF2C0-0x00000001829FF370
	public float value { /* [XID] */ /* 0x00000001898F4B20-0x00000001898F4B40 */ get => default; /* [XID] */ /* 0x00000001898FC3D0-0x00000001898FC3F0 */ private set {} } // 0x00000001829FDCD0-0x00000001829FDDB0 0x00000001829FDAB0-0x00000001829FDB90

	// Constructors
	public ConfigGuidePressKeyCondition() {} // 0x00000001829FFDD0-0x00000001829FFE40

	// Methods
	// [XID] // 0x0000000189903E30-0x0000000189903E50
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001829FFAA0-0x00000001829FFBF0
	// [XID] // 0x000000018990B3D0-0x000000018990B3F0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001829FF190-0x00000001829FF240
	// [XID] // 0x0000000189913080-0x00000001899130A0
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF92BF */) => default; // 0x00000001829FEDC0-0x00000001829FEEB0
	// [XID] // 0x000000018991A850-0x000000018991A870
	public override int GetHashNum() => default; // 0x00000001829FD4B0-0x00000001829FD580
	// [XID] // 0x0000000189922060-0x0000000189922080
	public override void InitEmpty() {} // 0x00000001829FE770-0x00000001829FE840
	[BlackList] // 0x0000000189929780-0x00000001899297C0
	// [XID] // 0x0000000189929780-0x00000001899297C0
	public override bool FromJson(JSONNode node) => default; // 0x00000001829FDDB0-0x00000001829FE130
	// [XID] // 0x0000000189933B00-0x0000000189933B20
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001829FCA30-0x00000001829FCF30
	[BlackList] // 0x000000018993B690-0x000000018993B6D0
	// [XID] // 0x000000018993B690-0x000000018993B6D0
	public static new ConfigGuidePressKeyCondition ParseFromJson(JSONNode node) => default; // 0x00000001829FEF10-0x00000001829FF130
	// [XID] // 0x0000000189945AE0-0x0000000189945B00
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF92C0 */, bool useObjectPool = false /* Metadata: 0x00AF92C4 */) => default; // 0x00000001829FEAC0-0x00000001829FEDC0
	// [XID] // 0x000000018994CEF0-0x000000018994CF10
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF92C5 */, bool useObjectPool = false /* Metadata: 0x00AF92C9 */) => default; // 0x00000001829FD660-0x00000001829FDA30
	// [XID] // 0x00000001899546C0-0x00000001899546E0
	public static new ConfigGuidePressKeyCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF92CA */, bool useObjectPool = false /* Metadata: 0x00AF92CE */) => default; // 0x00000001829FE130-0x00000001829FE320
	[BlackList] // 0x000000018995BFC0-0x000000018995C000
	// [XID] // 0x000000018995BFC0-0x000000018995C000
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001829FCF30-0x00000001829FD200
	// [XID] // 0x0000000189966A10-0x0000000189966A30
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001829FF590-0x00000001829FF920
	[BlackList] // 0x000000018996DE00-0x000000018996DE40
	// [XID] // 0x000000018996DE00-0x000000018996DE40
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001829FE920-0x00000001829FEA10
	// [XID] // 0x0000000189978F30-0x0000000189978F50
	protected override bool Prepare(GuideManager manager) => default; // 0x00000001829FDC10-0x00000001829FDCD0
	// [XID] // 0x0000000189980020-0x0000000189980040
	private void ShowProgressTime() {} // 0x00000001829FF920-0x00000001829FFAA0
	// [XID] // 0x00000001899877B0-0x00000001899877D0
	public override bool Ready(object body = null) => default; // 0x00000001829FE440-0x00000001829FE6F0
	// [XID] // 0x000000018998F420-0x000000018998F440
	protected override void Finish(GuideManager manager) {} // 0x00000001829FF370-0x00000001829FF470
	[BlackList] // 0x0000000189996DA0-0x0000000189996DE0
	// [XID] // 0x0000000189996DA0-0x0000000189996DE0
	public override void AutoAllocTypeFields() {} // 0x00000001829FD200-0x00000001829FD2A0
	[BlackList] // 0x00000001899A1910-0x00000001899A1950
	// [XID] // 0x00000001899A1910-0x00000001899A1950
	public override void AutoRecycleTypeFields() {} // 0x00000001829FD2A0-0x00000001829FD390
	[BlackList] // 0x00000001899AC3F0-0x00000001899AC430
	// [XID] // 0x00000001899AC3F0-0x00000001899AC430
	public override void ReturnToObjectPool() {} // 0x00000001829FFD30-0x00000001829FFDD0
}

