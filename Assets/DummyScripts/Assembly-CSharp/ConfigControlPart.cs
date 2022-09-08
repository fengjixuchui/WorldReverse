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
using MoleMole.Config;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class ConfigControlPart : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18003
{
	// Fields
	private SimpleSafeFloat angularSpeedRawNum; // 0x10
	private string _partRootName; // 0x18
	private ControlPartForwardBy _forwardBy; // 0x20
	private MoleMole.Config.Vector _forwardAxialFix; // 0x24
	private ControlPartRotateBy _rotateBy; // 0x30
	private ControlPartDoOnUnEnabled _doOnUnEabled; // 0x34
	private string _forwardByTransName; // 0x38
	private SimpleSafeFloat limitHorizontalRawNum; // 0x40
	private SimpleSafeFloat limitVerticalRawNum; // 0x44
	private ControlPartTargetType _targetType; // 0x48

	// Properties
	public float angularSpeed { /* [XID] */ /* 0x00000001896686C0-0x00000001896686E0 */ get => default; /* [XID] */ /* 0x0000000189670210-0x0000000189670230 */ private set {} } // 0x00000001851D2770-0x00000001851D2850 0x00000001851D3400-0x00000001851D34E0
	public string partRootName { /* [XID] */ /* 0x0000000189677AD0-0x0000000189677AF0 */ get => default; /* [XID] */ /* 0x000000018967F020-0x000000018967F040 */ private set {} } // 0x00000001851D13C0-0x00000001851D1460 0x00000001851D2370-0x00000001851D2420
	public ControlPartForwardBy forwardBy { /* [XID] */ /* 0x0000000189686930-0x0000000189686950 */ get => default; /* [XID] */ /* 0x000000018968E790-0x000000018968E7B0 */ private set {} } // 0x00000001851D36B0-0x00000001851D3750 0x00000001851D2FF0-0x00000001851D30A0
	public MoleMole.Config.Vector forwardAxialFix { /* [XID] */ /* 0x0000000189696230-0x0000000189696250 */ get => default; /* [XID] */ /* 0x000000018969D8D0-0x000000018969D8F0 */ private set {} } // 0x00000001851D1530-0x00000001851D1610 0x00000001851D1E40-0x00000001851D1F10
	public ControlPartRotateBy rotateBy { /* [XID] */ /* 0x00000001899A0C30-0x00000001899A0C50 */ get => default; /* [XID] */ /* 0x00000001896AC090-0x00000001896AC0B0 */ private set {} } // 0x00000001851D16B0-0x00000001851D1750 0x00000001851D0E70-0x00000001851D0F20
	public ControlPartDoOnUnEnabled doOnUnEabled { /* [XID] */ /* 0x00000001896B32F0-0x00000001896B3310 */ get => default; /* [XID] */ /* 0x00000001896BAB10-0x00000001896BAB30 */ private set {} } // 0x00000001851D2F50-0x00000001851D2FF0 0x00000001851D30A0-0x00000001851D3150
	public string forwardByTransName { /* [XID] */ /* 0x000000018990A5F0-0x000000018990A610 */ get => default; /* [XID] */ /* 0x00000001896C91B0-0x00000001896C91D0 */ private set {} } // 0x00000001851D1610-0x00000001851D16B0 0x00000001851D3350-0x00000001851D3400
	public float limitHorizontal { /* [XID] */ /* 0x0000000189A373A0-0x0000000189A373C0 */ get => default; /* [XID] */ /* 0x00000001896D8030-0x00000001896D8050 */ private set {} } // 0x00000001851D29A0-0x00000001851D2A80 0x00000001851D2690-0x00000001851D2770
	public float limitVertical { /* [XID] */ /* 0x0000000189A281A0-0x0000000189A281C0 */ get => default; /* [XID] */ /* 0x00000001896E6D00-0x00000001896E6D20 */ private set {} } // 0x00000001851D1F10-0x00000001851D1FF0 0x00000001851D35D0-0x00000001851D36B0
	public ControlPartTargetType targetType { /* [XID] */ /* 0x00000001896EE210-0x00000001896EE230 */ get => default; /* [XID] */ /* 0x00000001896F5B40-0x00000001896F5B60 */ private set {} } // 0x00000001851D25F0-0x00000001851D2690 0x00000001851D03B0-0x00000001851D0460

	// Constructors
	public ConfigControlPart() {} // 0x00000001851D4210-0x00000001851D42D0

	// Methods
	// [XID] // 0x00000001896FD330-0x00000001896FD350
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001851D3E30-0x00000001851D4030
	// [XID] // 0x0000000189704810-0x0000000189704830
	public virtual void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001851D34E0-0x00000001851D35D0
	// [XID] // 0x000000018970BFF0-0x000000018970C010
	public virtual ConfigControlPart Clone(bool useObjectPool = false /* Metadata: 0x00AF8639 */) => default; // 0x00000001851D2E70-0x00000001851D2F50
	// [XID] // 0x0000000189713920-0x0000000189713940
	public virtual int GetHashNum() => default; // 0x00000001851D1460-0x00000001851D1530
	// [XID] // 0x000000018971B1A0-0x000000018971B1C0
	public virtual void InitEmpty() {} // 0x00000001851D2850-0x00000001851D29A0
	[BlackList] // 0x0000000189722520-0x0000000189722560
	// [XID] // 0x0000000189722520-0x0000000189722560
	public virtual bool FromJson(JSONNode node) => default; // 0x00000001851D1FF0-0x00000001851D2370
	// [XID] // 0x000000018972CB20-0x000000018972CB40
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001851D0460-0x00000001851D0E70
	[BlackList] // 0x00000001897342B0-0x00000001897342F0
	// [XID] // 0x00000001897342B0-0x00000001897342F0
	public static ConfigControlPart ParseFromJson(JSONNode node) => default; // 0x00000001851D3150-0x00000001851D3350
	// [XID] // 0x000000018973F1C0-0x000000018973F1E0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF863A */, bool useObjectPool = false /* Metadata: 0x00AF863E */) => default; // 0x00000001851D2B70-0x00000001851D2E70
	// [XID] // 0x00000001897463E0-0x0000000189746400
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF863F */, bool useObjectPool = false /* Metadata: 0x00AF8643 */) => default; // 0x00000001851D1750-0x00000001851D1E40
	// [XID] // 0x000000018974DE90-0x000000018974DEB0
	public static ConfigControlPart ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8644 */, bool useObjectPool = false /* Metadata: 0x00AF8648 */) => default; // 0x00000001851D2420-0x00000001851D25F0
	[BlackList] // 0x00000001897555B0-0x00000001897555F0
	// [XID] // 0x00000001897555B0-0x00000001897555F0
	public virtual bool ToBinary(ByteArray byteArray) => default; // 0x00000001851D0F20-0x00000001851D11F0
	// [XID] // 0x000000018975FAF0-0x000000018975FB10
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001851D3750-0x00000001851D3E30
	[BlackList] // 0x0000000189767080-0x00000001897670C0
	// [XID] // 0x0000000189767080-0x00000001897670C0
	public virtual bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001851D2A80-0x00000001851D2B70
	[BlackList] // 0x00000001897717D0-0x0000000189771810
	// [XID] // 0x00000001897717D0-0x0000000189771810
	public virtual void AutoAllocTypeFields() {} // 0x00000001851D11F0-0x00000001851D1290
	[BlackList] // 0x000000018977BCE0-0x000000018977BD20
	// [XID] // 0x000000018977BCE0-0x000000018977BD20
	public virtual void AutoRecycleTypeFields() {} // 0x00000001851D1290-0x00000001851D13C0
	[BlackList] // 0x0000000189786640-0x0000000189786680
	// [XID] // 0x0000000189786640-0x0000000189786680
	public virtual void ReturnToObjectPool() {} // 0x00000001851D4170-0x00000001851D4210
	[BlackList] // 0x0000000189790B10-0x0000000189790B50
	// [XID] // 0x0000000189790B10-0x0000000189790B50
	public virtual void OnPoolAllocated() {} // 0x00000001851D40D0-0x00000001851D4170
	[BlackList] // 0x000000018979BC10-0x000000018979BC50
	// [XID] // 0x000000018979BC10-0x000000018979BC50
	public virtual void OnBeforePoolRecycled() {} // 0x00000001851D4030-0x00000001851D40D0
}

