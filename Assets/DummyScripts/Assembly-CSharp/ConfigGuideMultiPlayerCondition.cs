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
public class ConfigGuideMultiPlayerCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18244
{
	// Fields
	private bool _isIn; // 0x20
	private SimpleSafeInt32 playerNumRawNum; // 0x24
	private GuideOperator _opt; // 0x28
	private GuideMultiPlayerMode _mode; // 0x2C
	private NotifyTypes[] _curNotifyList; // 0x30

	// Properties
	public bool isIn { /* [XID] */ /* 0x0000000189B7E8A0-0x0000000189B7E8C0 */ get => default; /* [XID] */ /* 0x0000000189B865A0-0x0000000189B865C0 */ private set {} } // 0x00000001843EF6B0-0x00000001843EF750 0x00000001843ED980-0x00000001843EDA30
	public int playerNum { /* [XID] */ /* 0x0000000189B8D630-0x0000000189B8D650 */ get => default; /* [XID] */ /* 0x0000000189B94BB0-0x0000000189B94BD0 */ private set {} } // 0x00000001843ED8B0-0x00000001843ED980 0x00000001843EF0E0-0x00000001843EF1C0
	public GuideOperator opt { /* [XID] */ /* 0x0000000189B9C2E0-0x0000000189B9C300 */ get => default; /* [XID] */ /* 0x0000000189BA39B0-0x0000000189BA39D0 */ private set {} } // 0x00000001843EDA30-0x00000001843EDAD0 0x00000001843EEC50-0x00000001843EED00
	public GuideMultiPlayerMode mode { /* [XID] */ /* 0x0000000189BAAE20-0x0000000189BAAE40 */ get => default; /* [XID] */ /* 0x0000000189BB2470-0x0000000189BB2490 */ private set {} } // 0x00000001843EFB10-0x00000001843EFBB0 0x00000001843EF600-0x00000001843EF6B0

	// Constructors
	public ConfigGuideMultiPlayerCondition() {} // 0x00000001843EFDA0-0x00000001843EFE90

	// Methods
	// [XID] // 0x0000000189BB9880-0x0000000189BB98A0
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001843EFBB0-0x00000001843EFD00
	// [XID] // 0x0000000189BC17C0-0x0000000189BC17E0
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x00000001843EF4D0-0x00000001843EF580
	// [XID] // 0x0000000189BC8DC0-0x0000000189BC8DE0
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF9163 */) => default; // 0x00000001843EF000-0x00000001843EF0E0
	// [XID] // 0x0000000189BD0610-0x0000000189BD0630
	public override int GetHashNum() => default; // 0x00000001843ED7E0-0x00000001843ED8B0
	// [XID] // 0x0000000189BD7BB0-0x0000000189BD7BD0
	public override void InitEmpty() {} // 0x00000001843EE9B0-0x00000001843EEA80
	[BlackList] // 0x0000000189BDF7C0-0x0000000189BDF800
	// [XID] // 0x0000000189BDF7C0-0x0000000189BDF800
	public override bool FromJson(JSONNode node) => default; // 0x00000001843EE110-0x00000001843EE490
	// [XID] // 0x00000001895EF140-0x00000001895EF160
	private new bool InternalFromJson(JSONNode node) => default; // 0x00000001843ECDC0-0x00000001843ED270
	[BlackList] // 0x00000001895F6B00-0x00000001895F6B40
	// [XID] // 0x00000001895F6B00-0x00000001895F6B40
	public static new ConfigGuideMultiPlayerCondition ParseFromJson(JSONNode node) => default; // 0x00000001843EF220-0x00000001843EF470
	// [XID] // 0x0000000189601060-0x0000000189601080
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9164 */, bool useObjectPool = false /* Metadata: 0x00AF9168 */) => default; // 0x00000001843EED00-0x00000001843EF000
	// [XID] // 0x0000000189608A50-0x0000000189608A70
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9169 */, bool useObjectPool = false /* Metadata: 0x00AF916D */) => default; // 0x00000001843EDBB0-0x00000001843EDF50
	// [XID] // 0x0000000189610250-0x0000000189610270
	public static new ConfigGuideMultiPlayerCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF916E */, bool useObjectPool = false /* Metadata: 0x00AF9172 */) => default; // 0x00000001843EE490-0x00000001843EE6B0
	[BlackList] // 0x00000001896174F0-0x0000000189617530
	// [XID] // 0x00000001896174F0-0x0000000189617530
	public override bool ToBinary(ByteArray byteArray) => default; // 0x00000001843ED270-0x00000001843ED540
	// [XID] // 0x0000000189621E00-0x0000000189621E20
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001843EF750-0x00000001843EFB10
	[BlackList] // 0x0000000189629790-0x00000001896297D0
	// [XID] // 0x0000000189629790-0x00000001896297D0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001843EEB60-0x00000001843EEC50
	// [XID] // 0x0000000189633FD0-0x0000000189633FF0
	protected override bool Prepare(GuideManager manager) => default; // 0x00000001843EE050-0x00000001843EE110
	// [XID] // 0x000000018963B7C0-0x000000018963B7E0
	public override bool Ready(object body = null) => default; // 0x00000001843EE720-0x00000001843EE930
	[BlackList] // 0x0000000189643000-0x0000000189643040
	// [XID] // 0x0000000189643000-0x0000000189643040
	public override void AutoAllocTypeFields() {} // 0x00000001843ED540-0x00000001843ED5E0
	[BlackList] // 0x000000018964D760-0x000000018964D7A0
	// [XID] // 0x000000018964D760-0x000000018964D7A0
	public override void AutoRecycleTypeFields() {} // 0x00000001843ED5E0-0x00000001843ED6C0
	[BlackList] // 0x0000000189657EF0-0x0000000189657F30
	// [XID] // 0x0000000189657EF0-0x0000000189657F30
	public override void ReturnToObjectPool() {} // 0x00000001843EFD00-0x00000001843EFDA0
}

