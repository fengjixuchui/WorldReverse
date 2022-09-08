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
public sealed class ConfigGuideUIMaskAction : ConfigGuideAction, IAutoAllocRecycle // TypeDefIndex: 18308
{
	// Fields
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigGuideWidgetContent[] _widgetList; // 0x18
	private string _topInfo; // 0x20
	private string[] _prefabList; // 0x28
	private bool _clickToClose; // 0x30
	private NewbieDialogContext _newBieDialog; // 0x38
	private bool preUICompatibily; // 0x40

	// Properties
	public ConfigGuideWidgetContent[] widgetList { /* [XID] */ /* 0x000000018960D0E0-0x000000018960D100 */ get => default; /* [XID] */ /* 0x0000000189614740-0x0000000189614760 */ private set {} } // 0x00000001848668E0-0x0000000184866980 0x0000000184865F90-0x0000000184866040
	public string topInfo { /* [XID] */ /* 0x000000018961C060-0x000000018961C080 */ get => default; /* [XID] */ /* 0x00000001896235C0-0x00000001896235E0 */ private set {} } // 0x0000000184866A70-0x0000000184866B10 0x0000000184866F00-0x0000000184866FB0
	public string[] prefabList { /* [XID] */ /* 0x000000018962AE80-0x000000018962AEA0 */ get => default; /* [XID] */ /* 0x00000001896325C0-0x00000001896325E0 */ private set {} } // 0x00000001848647A0-0x0000000184864840 0x0000000184865370-0x0000000184865420
	public bool clickToClose { /* [XID] */ /* 0x000000018963A030-0x000000018963A050 */ get => default; /* [XID] */ /* 0x00000001896415A0-0x00000001896415C0 */ private set {} } // 0x0000000184865A70-0x0000000184865B10 0x0000000184867570-0x0000000184867620

	// Constructors
	public ConfigGuideUIMaskAction() {} // 0x00000001848676C0-0x0000000184867730

	// Methods
	// [XID] // 0x0000000189648F60-0x0000000189648F80
	public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184867420-0x0000000184867570
	// [XID] // 0x0000000189650570-0x0000000189650590
	public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000184866DF0-0x0000000184866F00
	// [XID] // 0x0000000189657EB0-0x0000000189657ED0
	public override ConfigBaseGuide Clone(bool useObjectPool = false /* Metadata: 0x00AF93BB */) => default; // 0x0000000184866980-0x0000000184866A70
	// [XID] // 0x000000018965F4E0-0x000000018965F500
	public override int GetHashNum() => default; // 0x0000000184865240-0x0000000184865310
	// [XID] // 0x0000000189666DB0-0x0000000189666DD0
	public override void InitEmpty() {} // 0x00000001848662A0-0x00000001848663A0
	[BlackList] // 0x000000018966E4C0-0x000000018966E500
	// [XID] // 0x000000018966E4C0-0x000000018966E500
	public override bool FromJson(JSONNode node) => default; // 0x0000000184865C10-0x0000000184865F90
	// [XID] // 0x00000001896793D0-0x00000001896793F0
	private new bool InternalFromJson(JSONNode node) => default; // 0x0000000184864840-0x0000000184864CE0
	[BlackList] // 0x0000000189680B00-0x0000000189680B40
	// [XID] // 0x0000000189680B00-0x0000000189680B40
	public static new ConfigGuideUIMaskAction ParseFromJson(JSONNode node) => default; // 0x0000000184866B70-0x0000000184866D90
	// [XID] // 0x000000018968B5B0-0x000000018968B5D0
	public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF93BC */, bool useObjectPool = false /* Metadata: 0x00AF93C0 */) => default; // 0x00000001848665E0-0x00000001848668E0
	// [XID] // 0x0000000189693200-0x0000000189693220
	private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF93C1 */, bool useObjectPool = false /* Metadata: 0x00AF93C5 */) => default; // 0x0000000184865650-0x0000000184865A70
	// [XID] // 0x000000018969A3F0-0x000000018969A410
	public static new ConfigGuideUIMaskAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF93C6 */, bool useObjectPool = false /* Metadata: 0x00AF93CA */) => default; // 0x0000000184866040-0x0000000184866230
	[BlackList] // 0x00000001896A1CA0-0x00000001896A1CE0
	// [XID] // 0x00000001896A1CA0-0x00000001896A1CE0
	public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000184864CE0-0x0000000184864FB0
	// [XID] // 0x00000001896AC010-0x00000001896AC030
	private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184867030-0x0000000184867420
	[BlackList] // 0x00000001896B3230-0x00000001896B3270
	// [XID] // 0x00000001896B3230-0x00000001896B3270
	public override bool SuperToBinary(ByteArray byteArray) => default; // 0x00000001848664F0-0x00000001848665E0
	// [XID] // 0x00000001896BD6E0-0x00000001896BD700
	protected override bool Start(ConfigGuideTask taskBelonged) => default; // 0x00000001848654A0-0x0000000184865650
	// [XID] // 0x00000001896C4DB0-0x00000001896C4DD0
	protected override bool Stop() => default; // 0x0000000184864690-0x00000001848647A0
	[BlackList] // 0x00000001896CC210-0x00000001896CC250
	// [XID] // 0x00000001896CC210-0x00000001896CC250
	public override void AutoAllocTypeFields() {} // 0x0000000184864FB0-0x0000000184865050
	[BlackList] // 0x00000001896D6880-0x00000001896D68C0
	// [XID] // 0x00000001896D6880-0x00000001896D68C0
	public override void AutoRecycleTypeFields() {} // 0x0000000184865050-0x0000000184865120
	[BlackList] // 0x00000001896E1030-0x00000001896E1070
	// [XID] // 0x00000001896E1030-0x00000001896E1070
	public override void ReturnToObjectPool() {} // 0x0000000184867620-0x00000001848676C0
}

