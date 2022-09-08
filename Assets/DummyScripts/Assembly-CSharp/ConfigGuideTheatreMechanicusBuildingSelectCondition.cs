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
public class ConfigGuideTheatreMechanicusBuildingSelectCondition : ConfigGuideCondition, IAutoAllocRecycle // TypeDefIndex: 18224
{
	// Fields
	private SimpleSafeInt32 valueRawNum; // 0x20
	private bool _isRebuild; // 0x24
	private bool _isSelect; // 0x25
	private TheatreMechanicusBuildingPageContext _baseContext; // 0x28
	private static NotifyTypes[] _curNotifyList; // 0x00

	// Properties
	public int value { /* [XID] */ /* 0x0000000189B800F0-0x0000000189B80110 */ get => default; /* [XID] */ /* 0x0000000189B87BE0-0x0000000189B87C00 */ private set {} } // 0x0000000183D50C80-0x0000000183D50D50 0x0000000183D50A30-0x0000000183D50B10
	public bool isRebuild { /* [XID] */ /* 0x0000000189B8EDF0-0x0000000189B8EE10 */ get => default; /* [XID] */ /* 0x0000000189B962A0-0x0000000189B962C0 */ private set {} } // 0x0000000183D52970-0x0000000183D52A10 0x0000000183D51E90-0x0000000183D51F40
	public bool isSelect { /* [XID] */ /* 0x0000000189B9D7A0-0x0000000189B9D7C0 */ get => default; /* [XID] */ /* 0x0000000189BA5270-0x0000000189BA5290 */ private set {} } // 0x0000000183D51390-0x0000000183D51430 0x0000000183D528C0-0x0000000183D52970

	// Constructors
	public ConfigGuideTheatreMechanicusBuildingSelectCondition() {} // 0x0000000183D52B80-0x0000000183D52BF0
	static ConfigGuideTheatreMechanicusBuildingSelectCondition() {} // 0x0000000183D52AB0-0x0000000183D52B80

	// Methods
	// [XID] // 0x0000000189BAC410-0x0000000189BAC430
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183D52790-0x0000000183D528C0
	// [XID] // 0x0000000189BB3C70-0x0000000189BB3C90
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000183D521F0-0x0000000183D522A0
	// [XID] // 0x0000000189BBB210-0x0000000189BBB230
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF90CF */) => default; // 0x0000000183D51D50-0x0000000183D51E30
	// [XID] // 0x0000000189BC3090-0x0000000189BC30B0
	public override int GetHashNum() => default; // 0x0000000183D504B0-0x0000000183D50580
	// [XID] // 0x0000000189BCA8F0-0x0000000189BCA910
	public override void InitEmpty() {} // 0x0000000183D517B0-0x0000000183D51880
	[BlackList] // 0x0000000189BD1F00-0x0000000189BD1F40
	// [XID] // 0x0000000189BD1F00-0x0000000189BD1F40
	public override bool FromJson(JSONNode node) => default; // 0x0000000183D50D50-0x0000000183D510D0
	// [XID] // 0x0000000189BDC760-0x0000000189BDC780
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000183D4FB60-0x0000000183D4FF30
	[BlackList] // 0x00000001895E90D0-0x00000001895E9110
	// [XID] // 0x00000001895E90D0-0x00000001895E9110
	public static new ConfigGuideTheatreMechanicusBuildingSelectCondition ParseFromJson(JSONNode node) => default; // 0x0000000183D51F40-0x0000000183D52190
	// [XID] // 0x00000001895F37F0-0x00000001895F3810
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF90D0 */, bool useObjectPool = false /* Metadata: 0x00AF90D4 */) => default; // 0x0000000183D51A50-0x0000000183D51D50
	// [XID] // 0x00000001895FB0D0-0x00000001895FB0F0
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF90D5 */, bool useObjectPool = false /* Metadata: 0x00AF90D9 */) => default; // 0x0000000183D50660-0x0000000183D509B0
	// [XID] // 0x0000000189602830-0x0000000189602850
	public static new ConfigGuideTheatreMechanicusBuildingSelectCondition ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF90DA */, bool useObjectPool = false /* Metadata: 0x00AF90DE */) => default; // 0x0000000183D51170-0x0000000183D51390
	[BlackList] // 0x000000018960A1D0-0x000000018960A210
	// [XID] // 0x000000018960A1D0-0x000000018960A210
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000183D4FF30-0x0000000183D50200
	// [XID] // 0x0000000189614760-0x0000000189614780
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183D52450-0x0000000183D52790
	[BlackList] // 0x000000018961C080-0x000000018961C0C0
	// [XID] // 0x000000018961C080-0x000000018961C0C0
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000183D51960-0x0000000183D51A50
	// [XID] // 0x00000001896264E0-0x0000000189626500
	protected override bool Prepare(GuideManager manager) => default; // 0x0000000183D50B90-0x0000000183D50C80
	// [XID] // 0x000000018962DE70-0x000000018962DE90
	protected override void Finish(GuideManager manager) {} // 0x0000000183D52320-0x0000000183D523D0
	// [XID] // 0x0000000189635AF0-0x0000000189635B10
	private void ReleaseCache() {} // 0x0000000183D510D0-0x0000000183D51170
	// [XID] // 0x000000018963D190-0x000000018963D1B0
	private void CheckCurPage() {} // 0x0000000183D514A0-0x0000000183D515B0
	// [XID] // 0x00000001896446B0-0x00000001896446D0
	public override bool Ready(object body = null) => default; // 0x0000000183D515B0-0x0000000183D51730
	[BlackList] // 0x000000018964BFD0-0x000000018964C010
	// [XID] // 0x000000018964BFD0-0x000000018964C010
	public override void AutoAllocTypeFields() {} // 0x0000000183D50200-0x0000000183D502A0
	[BlackList] // 0x0000000189656610-0x0000000189656650
	// [XID] // 0x0000000189656610-0x0000000189656650
	public override void AutoRecycleTypeFields() {} // 0x0000000183D502A0-0x0000000183D50390
	[BlackList] // 0x0000000189660D50-0x0000000189660D90
	// [XID] // 0x0000000189660D50-0x0000000189660D90
	public override void ReturnToObjectPool() {} // 0x0000000183D52A10-0x0000000183D52AB0
}

