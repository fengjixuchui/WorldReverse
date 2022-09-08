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
public sealed class ConfigGuideHasItemCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18230
{
	// Fields
	private SimpleSafeUInt32[][] _itemIDLists; // 0x20
	private SimpleSafeInt32[] _materialTypeList; // 0x28
	private GuideItemType _type; // 0x30
	private bool _notHave; // 0x34
	private SimpleSafeFloat valueRawNum; // 0x38
	private NotifyTypes[] _curNotifyList; // 0x40

	// Properties
	public SimpleSafeUInt32[][] itemIDLists { /* [XID] */ /* 0x000000018975FAB0-0x000000018975FAD0 */ get => default; /* [XID] */ /* 0x0000000189767020-0x0000000189767040 */ private set {} } // 0x0000000182EF8800-0x0000000182EF88A0 0x0000000182EF6B80-0x0000000182EF6C30
	public SimpleSafeInt32[] materialTypeList { /* [XID] */ /* 0x000000018976E580-0x000000018976E5A0 */ get => default; /* [XID] */ /* 0x0000000189775F60-0x0000000189775F80 */ private set {} } // 0x0000000182EF7570-0x0000000182EF7610 0x0000000182EF6AD0-0x0000000182EF6B80
	public GuideItemType type { /* [XID] */ /* 0x000000018977D600-0x000000018977D620 */ get => default; /* [XID] */ /* 0x0000000189784EA0-0x0000000189784EC0 */ private set {} } // 0x0000000182EFA280-0x0000000182EFA320 0x0000000182EF9B40-0x0000000182EF9BF0
	public bool notHave { /* [XID] */ /* 0x000000018978C3B0-0x000000018978C3D0 */ get => default; /* [XID] */ /* 0x0000000189793940-0x0000000189793960 */ private set {} } // 0x0000000182EF7200-0x0000000182EF72A0 0x0000000182EF9BF0-0x0000000182EF9CA0
	public float value { /* [XID] */ /* 0x000000018979BBF0-0x000000018979BC10 */ get => default; /* [XID] */ /* 0x00000001897A3060-0x00000001897A3080 */ private set {} } // 0x0000000182EF81B0-0x0000000182EF8290 0x0000000182EF7F90-0x0000000182EF8070

	// Constructors
	public ConfigGuideHasItemCondition() {} // 0x0000000182EFA3C0-0x0000000182EFA480

	// Methods
	// [XID] // 0x00000001897AA660-0x00000001897AA680
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182EFA120-0x0000000182EFA280
	// [XID] // 0x00000001897B2170-0x00000001897B2190
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000182EF99C0-0x0000000182EF9AC0
	// [XID] // 0x00000001897B9B70-0x00000001897B9B90
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF9103 */) => default; // 0x0000000182EF95F0-0x0000000182EF96E0
	// [XID] // 0x00000001897C1B90-0x00000001897C1BB0
	public override int GetHashNum() => default; // 0x0000000182EF78C0-0x0000000182EF7990
	// [XID] // 0x00000001897C95A0-0x00000001897C95C0
	public override void InitEmpty() {} // 0x0000000182EF8E20-0x0000000182EF8F40
	[BlackList] // 0x00000001897D0B50-0x00000001897D0B90
	// [XID] // 0x00000001897D0B50-0x00000001897D0B90
	public override bool FromJson(JSONNode node) => default; // 0x0000000182EF8290-0x0000000182EF8610
	// [XID] // 0x00000001897DB510-0x00000001897DB530
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000182EF6C30-0x0000000182EF7200
	[BlackList] // 0x00000001897E2BE0-0x00000001897E2C20
	// [XID] // 0x00000001897E2BE0-0x00000001897E2C20
	public static new ConfigGuideHasItemCondition ParseFromJson(JSONNode node) => default; // 0x0000000182EF9740-0x0000000182EF9960
	// [XID] // 0x00000001897ED690-0x00000001897ED6B0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9104 */, bool useObjectPool = false /* Metadata: 0x00AF9108 */) => default; // 0x0000000182EF92F0-0x0000000182EF95F0
	// [XID] // 0x00000001897F4E30-0x00000001897F4E50
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9109 */, bool useObjectPool = false /* Metadata: 0x00AF910D */) => default; // 0x0000000182EF7A70-0x0000000182EF7F10
	// [XID] // 0x00000001897FC960-0x00000001897FC980
	public static new ConfigGuideHasItemCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF910E */, bool useObjectPool = false /* Metadata: 0x00AF9112 */) => default; // 0x0000000182EF8610-0x0000000182EF8800
	[BlackList] // 0x0000000189803EB0-0x0000000189803EF0
	// [XID] // 0x0000000189803EB0-0x0000000189803EF0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000182EF72A0-0x0000000182EF7570
	// [XID] // 0x000000018980E3F0-0x000000018980E410
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182EF9CA0-0x0000000182EFA120
	[BlackList] // 0x0000000189815AF0-0x0000000189815B30
	// [XID] // 0x0000000189815AF0-0x0000000189815B30
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000182EF9200-0x0000000182EF92F0
	// [XID] // 0x0000000189820630-0x0000000189820650
	protected override bool Prepare(GuideManager manager) => default; // 0x0000000182EF80F0-0x0000000182EF81B0
	// [XID] // 0x0000000189827CA0-0x0000000189827CC0
	private bool HasItem() => default; // 0x0000000182EF88A0-0x0000000182EF8C60
	// [XID] // 0x000000018982EFE0-0x000000018982F000
	private bool NotHasItem() => default; // 0x0000000182EF8FC0-0x0000000182EF91A0
	// [XID] // 0x00000001898368F0-0x0000000189836910
	public override bool Ready(object body = null) => default; // 0x0000000182EF8CD0-0x0000000182EF8DA0
	[BlackList] // 0x000000018983DC60-0x000000018983DCA0
	// [XID] // 0x000000018983DC60-0x000000018983DCA0
	public override void AutoAllocTypeFields() {} // 0x0000000182EF7610-0x0000000182EF76B0
	[BlackList] // 0x00000001898480C0-0x0000000189848100
	// [XID] // 0x00000001898480C0-0x0000000189848100
	public override void AutoRecycleTypeFields() {} // 0x0000000182EF76B0-0x0000000182EF77A0
	[BlackList] // 0x0000000189852480-0x00000001898524C0
	// [XID] // 0x0000000189852480-0x00000001898524C0
	public override void ReturnToObjectPool() {} // 0x0000000182EFA320-0x0000000182EFA3C0
}

