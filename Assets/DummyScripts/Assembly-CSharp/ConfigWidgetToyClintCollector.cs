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
public class ConfigWidgetToyClintCollector : ConfigBaseWidgetToy, IAutoAllocRecycle // TypeDefIndex: 19208
{
	// Fields
	private CollectorType _targetType; // 0x30
	private ElementType _elementType; // 0x34
	private SimpleSafeUInt32 rechargePointsRawNum; // 0x38
	private SimpleSafeUInt32 maxPointsRawNum; // 0x3C
	private SimpleSafeUInt32 effectGadgetIdRawNum; // 0x40
	private SimpleSafeUInt32 useGadgetIdRawNum; // 0x44
	private bool _allowOtherWorld; // 0x48

	// Properties
	public CollectorType targetType { /* [XID] */ /* 0x00000001896F5920-0x00000001896F5940 */ get => default; /* [XID] */ /* 0x00000001896FD110-0x00000001896FD130 */ private set {} } // 0x00000001849845F0-0x0000000184984690 0x00000001849826B0-0x0000000184982760
	public ElementType elementType { /* [XID] */ /* 0x0000000189704670-0x0000000189704690 */ get => default; /* [XID] */ /* 0x000000018970BD30-0x000000018970BD50 */ private set {} } // 0x0000000184983E40-0x0000000184983EE0 0x0000000184985010-0x00000001849850C0
	public uint rechargePoints { /* [XID] */ /* 0x00000001897136C0-0x00000001897136E0 */ get => default; /* [XID] */ /* 0x000000018971AEA0-0x000000018971AEC0 */ private set {} } // 0x0000000184985B80-0x0000000184985C50 0x0000000184984F30-0x0000000184985010
	public uint maxPoints { /* [XID] */ /* 0x0000000189722260-0x0000000189722280 */ get => default; /* [XID] */ /* 0x0000000189729960-0x0000000189729980 */ private set {} } // 0x0000000184983600-0x00000001849836D0 0x0000000184984740-0x0000000184984820
	public uint effectGadgetId { /* [XID] */ /* 0x00000001897310E0-0x0000000189731100 */ get => default; /* [XID] */ /* 0x00000001897389D0-0x00000001897389F0 */ private set {} } // 0x0000000184985EC0-0x0000000184985F90 0x0000000184985DE0-0x0000000184985EC0
	public uint useGadgetId { /* [XID] */ /* 0x0000000189740720-0x0000000189740740 */ get => default; /* [XID] */ /* 0x0000000189747A70-0x0000000189747A90 */ private set {} } // 0x0000000184983730-0x0000000184983800 0x00000001849854C0-0x00000001849855A0
	public bool allowOtherWorld { /* [XID] */ /* 0x000000018974F230-0x000000018974F250 */ get => default; /* [XID] */ /* 0x0000000189756940-0x0000000189756960 */ private set {} } // 0x0000000184985420-0x00000001849854C0 0x0000000184984690-0x0000000184984740

	// Constructors
	public ConfigWidgetToyClintCollector() {} // 0x0000000184986030-0x0000000184986090

	// Methods
	// [XID] // 0x000000018975DD90-0x000000018975DDB0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184985C50-0x0000000184985DE0
	// [XID] // 0x00000001897653F0-0x0000000189765410
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184985370-0x0000000184985420
	// [XID] // 0x000000018976CE40-0x000000018976CE60
	public override ConfigBaseWidgetToy Clone(bool useObjectPool = false /* Metadata: 0x00AFC555 */) => default; // 0x0000000184984DF0-0x0000000184984ED0
	// [XID] // 0x00000001897742B0-0x00000001897742D0
	public override int GetHashNum() => default; // 0x0000000184983530-0x0000000184983600
	// [XID] // 0x000000018977BA80-0x000000018977BAA0
	public override void InitEmpty() {} // 0x0000000184984820-0x0000000184984920
	[BlackList] // 0x0000000189783490-0x00000001897834D0
	// [XID] // 0x0000000189783490-0x00000001897834D0
	public override bool FromJson(JSONNode node) => default; // 0x0000000184983FE0-0x0000000184984360
	// [XID] // 0x000000018978DA50-0x000000018978DA70
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184982760-0x0000000184982F80
	[BlackList] // 0x0000000189795020-0x0000000189795060
	// [XID] // 0x0000000189795020-0x0000000189795060
	public static new ConfigWidgetToyClintCollector ParseFromJson(JSONNode node) => default; // 0x00000001849850C0-0x0000000184985310
	// [XID] // 0x00000001897A0150-0x00000001897A0170
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC556 */, bool useObjectPool = false /* Metadata: 0x00AFC55A */) => default; // 0x0000000184984AF0-0x0000000184984DF0
	// [XID] // 0x00000001897A7680-0x00000001897A76A0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC55B */, bool useObjectPool = false /* Metadata: 0x00AFC55F */) => default; // 0x0000000184983880-0x0000000184983E40
	// [XID] // 0x00000001897AF150-0x00000001897AF170
	public static new ConfigWidgetToyClintCollector ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFC560 */, bool useObjectPool = false /* Metadata: 0x00AFC564 */) => default; // 0x0000000184984360-0x0000000184984580
	[BlackList] // 0x00000001897B6E30-0x00000001897B6E70
	// [XID] // 0x00000001897B6E30-0x00000001897B6E70
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184982F80-0x0000000184983250
	// [XID] // 0x00000001897C19D0-0x00000001897C19F0
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001849855A0-0x0000000184985B80
	[BlackList] // 0x00000001897C93A0-0x00000001897C93E0
	// [XID] // 0x00000001897C93A0-0x00000001897C93E0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000184984A00-0x0000000184984AF0
	[BlackList] // 0x00000001897D38E0-0x00000001897D3920
	// [XID] // 0x00000001897D38E0-0x00000001897D3920
	public override void AutoAllocTypeFields() {} // 0x0000000184983250-0x00000001849832F0
	[BlackList] // 0x00000001897DE090-0x00000001897DE0D0
	// [XID] // 0x00000001897DE090-0x00000001897DE0D0
	public override void AutoRecycleTypeFields() {} // 0x00000001849832F0-0x0000000184983410
	[BlackList] // 0x00000001897E8A30-0x00000001897E8A70
	// [XID] // 0x00000001897E8A30-0x00000001897E8A70
	public override void ReturnToObjectPool() {} // 0x0000000184985F90-0x0000000184986030
}

