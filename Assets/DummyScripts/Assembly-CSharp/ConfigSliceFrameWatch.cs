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
public class ConfigSliceFrameWatch : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18119
{
	// Fields
	private SimpleSafeFloat amortizedTickMassiveEntityBudgetRawNum; // 0x10
	private SimpleSafeFloat sharedSliceFrameGameSystemTimeRawNum; // 0x14
	private SimpleSafeFloat resourcesManagerAssetJobMinTimeRawNum; // 0x18
	private SimpleSafeFloat resourcesManagerAssetJobMaxTimeRawNum; // 0x1C
	private SimpleSafeFloat resourcesManagerInstantiateMinTimeRawNum; // 0x20
	private SimpleSafeFloat resourcesManagerInstantiateMaxTimeRawNum; // 0x24
	private SimpleSafeFloat resourcesManagerUnloadMinTimeRawNum; // 0x28
	private SimpleSafeFloat resourcesManagerUnloadMaxTimeRawNum; // 0x2C
	private SimpleSafeFloat resourcesManagerInstantiateJobTimeRawNum; // 0x30
	private SimpleSafeFloat levelAppearDisappearTimeMSDefaultRawNum; // 0x34
	private SimpleSafeInt32 levelAppearDisappearWRRWeightRawNum; // 0x38
	private SimpleSafeFloat InitComponentCommonSlicingTimeDefaultRawNum; // 0x3C
	private SimpleSafeFloat removeEntityTimeMSDefaultRawNum; // 0x40
	private SimpleSafeInt32 removeEnityWRRWeightRawNum; // 0x44
	private SimpleSafeInt32 sectrWRRWeightDefaultRawNum; // 0x48
	private SimpleSafeFloat timerManagerTimeMSRawNum; // 0x4C
	private bool _UseLegacyGenericObjectPool; // 0x50
	private SimpleSafeInt32 significanceTaskThreadLODRawNum; // 0x54
	private bool _loadingUseSyncLoad; // 0x58

	// Properties
	public float amortizedTickMassiveEntityBudget { /* [XID] */ /* 0x0000000189BCD7C0-0x0000000189BCD7E0 */ get => default; /* [XID] */ /* 0x0000000189BD4CF0-0x0000000189BD4D10 */ private set {} } // 0x0000000184A1D140-0x0000000184A1D220 0x0000000184A22850-0x0000000184A22930
	public float sharedSliceFrameGameSystemTime { /* [XID] */ /* 0x0000000189BDC7C0-0x0000000189BDC7E0 */ get => default; /* [XID] */ /* 0x00000001895E9110-0x00000001895E9130 */ private set {} } // 0x0000000184A1EB30-0x0000000184A1EC10 0x0000000184A210D0-0x0000000184A211B0
	public float resourcesManagerAssetJobMinTime { /* [XID] */ /* 0x00000001895F0920-0x00000001895F0940 */ get => default; /* [XID] */ /* 0x00000001895F82B0-0x00000001895F82D0 */ private set {} } // 0x0000000184A1EC10-0x0000000184A1ECF0 0x0000000184A205B0-0x0000000184A20690
	public float resourcesManagerAssetJobMaxTime { /* [XID] */ /* 0x00000001895FF870-0x00000001895FF890 */ get => default; /* [XID] */ /* 0x0000000189607020-0x0000000189607040 */ private set {} } // 0x0000000184A21370-0x0000000184A21450 0x0000000184A20310-0x0000000184A203F0
	public float resourcesManagerInstantiateMinTime { /* [XID] */ /* 0x000000018960EA40-0x000000018960EA60 */ get => default; /* [XID] */ /* 0x0000000189616060-0x0000000189616080 */ private set {} } // 0x0000000184A204D0-0x0000000184A205B0 0x0000000184A20690-0x0000000184A20770
	public float resourcesManagerInstantiateMaxTime { /* [XID] */ /* 0x000000018961D850-0x000000018961D870 */ get => default; /* [XID] */ /* 0x0000000189624C50-0x0000000189624C70 */ private set {} } // 0x0000000184A203F0-0x0000000184A204D0 0x0000000184A21530-0x0000000184A21610
	public float resourcesManagerUnloadMinTime { /* [XID] */ /* 0x000000018962C430-0x000000018962C450 */ get => default; /* [XID] */ /* 0x0000000189633FF0-0x0000000189634010 */ private set {} } // 0x0000000184A21450-0x0000000184A21530 0x0000000184A20980-0x0000000184A20A60
	public float resourcesManagerUnloadMaxTime { /* [XID] */ /* 0x000000018963B820-0x000000018963B840 */ get => default; /* [XID] */ /* 0x0000000189643040-0x0000000189643060 */ private set {} } // 0x0000000184A20FF0-0x0000000184A210D0 0x0000000184A22A10-0x0000000184A22AF0
	public float resourcesManagerInstantiateJobTime { /* [XID] */ /* 0x000000018964A700-0x000000018964A720 */ get => default; /* [XID] */ /* 0x0000000189651EE0-0x0000000189651F00 */ private set {} } // 0x0000000184A200A0-0x0000000184A20180 0x0000000184A1FFC0-0x0000000184A200A0
	public float levelAppearDisappearTimeMSDefault { /* [XID] */ /* 0x00000001896595F0-0x0000000189659610 */ get => default; /* [XID] */ /* 0x0000000189660D90-0x0000000189660DB0 */ private set {} } // 0x0000000184A1FA10-0x0000000184A1FAF0 0x0000000184A21610-0x0000000184A216F0
	public int levelAppearDisappearWRRWeight { /* [XID] */ /* 0x00000001896686A0-0x00000001896686C0 */ get => default; /* [XID] */ /* 0x00000001896701F0-0x0000000189670210 */ private set {} } // 0x0000000184A1E7B0-0x0000000184A1E880 0x0000000184A20F10-0x0000000184A20FF0
	public float InitComponentCommonSlicingTimeDefault { /* [XID] */ /* 0x0000000189677AB0-0x0000000189677AD0 */ get => default; /* [XID] */ /* 0x000000018967F000-0x000000018967F020 */ private set {} } // 0x0000000184A21290-0x0000000184A21370 0x0000000184A20180-0x0000000184A20260
	public float removeEntityTimeMSDefault { /* [XID] */ /* 0x0000000189686910-0x0000000189686930 */ get => default; /* [XID] */ /* 0x000000018968E730-0x000000018968E750 */ private set {} } // 0x0000000184A1F780-0x0000000184A1F860 0x0000000184A1F860-0x0000000184A1F940
	public int removeEnityWRRWeight { /* [XID] */ /* 0x00000001896961F0-0x0000000189696210 */ get => default; /* [XID] */ /* 0x000000018969D870-0x000000018969D890 */ private set {} } // 0x0000000184A222E0-0x0000000184A223B0 0x0000000184A22930-0x0000000184A22A10
	public int sectrWRRWeightDefault { /* [XID] */ /* 0x00000001896A48A0-0x00000001896A48C0 */ get => default; /* [XID] */ /* 0x00000001896AC050-0x00000001896AC070 */ private set {} } // 0x0000000184A20E40-0x0000000184A20F10 0x0000000184A20D60-0x0000000184A20E40
	public float timerManagerTimeMS { /* [XID] */ /* 0x00000001896B3290-0x00000001896B32B0 */ get => default; /* [XID] */ /* 0x00000001896BAA90-0x00000001896BAAB0 */ private set {} } // 0x0000000184A1D060-0x0000000184A1D140 0x0000000184A211B0-0x0000000184A21290
	public bool UseLegacyGenericObjectPool { /* [XID] */ /* 0x00000001896C1AC0-0x00000001896C1AE0 */ get => default; /* [XID] */ /* 0x00000001896C9190-0x00000001896C91B0 */ private set {} } // 0x0000000184A223B0-0x0000000184A22450 0x0000000184A1FAF0-0x0000000184A1FBA0
	public int significanceTaskThreadLOD { /* [XID] */ /* 0x00000001896D0B00-0x00000001896D0B20 */ get => default; /* [XID] */ /* 0x00000001896D8010-0x00000001896D8030 */ private set {} } // 0x0000000184A1F940-0x0000000184A1FA10 0x0000000184A1CF80-0x0000000184A1D060
	public bool loadingUseSyncLoad { /* [XID] */ /* 0x00000001896DF900-0x00000001896DF920 */ get => default; /* [XID] */ /* 0x00000001896E6CA0-0x00000001896E6CC0 */ private set {} } // 0x0000000184A1FF20-0x0000000184A1FFC0 0x0000000184A20260-0x0000000184A20310

	// Constructors
	public ConfigSliceFrameWatch() {} // 0x0000000184A22B90-0x0000000184A22D70

	// Methods
	// [XID] // 0x00000001896EE170-0x00000001896EE190
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000184A22450-0x0000000184A22710
	// [XID] // 0x00000001896F5AC0-0x00000001896F5AE0
	public void InitEmpty() {} // 0x0000000184A20770-0x0000000184A20980
	[BlackList] // 0x00000001896FD290-0x00000001896FD2D0
	// [XID] // 0x00000001896FD290-0x00000001896FD2D0
	public bool FromJson(JSONNode node) => default; // 0x0000000184A1FBA0-0x0000000184A1FF20
	// [XID] // 0x0000000189707730-0x0000000189707750
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000184A1D220-0x0000000184A1E4E0
	// [XID] // 0x000000018970F1A0-0x000000018970F1C0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8BBD */, bool useObjectPool = false /* Metadata: 0x00AF8BC1 */) => default; // 0x0000000184A20A60-0x0000000184A20D60
	// [XID] // 0x00000001897165A0-0x00000001897165C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8BC2 */, bool useObjectPool = false /* Metadata: 0x00AF8BC6 */) => default; // 0x0000000184A1ECF0-0x0000000184A1F780
	[BlackList] // 0x000000018971DFA0-0x000000018971DFE0
	// [XID] // 0x000000018971DFA0-0x000000018971DFE0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184A1E4E0-0x0000000184A1E7B0
	// [XID] // 0x00000001897284F0-0x0000000189728510
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000184A216F0-0x0000000184A222E0
	[BlackList] // 0x000000018972FC70-0x000000018972FCB0
	// [XID] // 0x000000018972FC70-0x000000018972FCB0
	public virtual void AutoAllocTypeFields() {} // 0x0000000184A1E880-0x0000000184A1E920
	[BlackList] // 0x000000018973A190-0x000000018973A1D0
	// [XID] // 0x000000018973A190-0x000000018973A1D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184A1E920-0x0000000184A1EB30
	[BlackList] // 0x0000000189744A30-0x0000000189744A70
	// [XID] // 0x0000000189744A30-0x0000000189744A70
	public virtual void ReturnToObjectPool() {} // 0x0000000184A22AF0-0x0000000184A22B90
	[BlackList] // 0x000000018974F410-0x000000018974F450
	// [XID] // 0x000000018974F410-0x000000018974F450
	public virtual void OnPoolAllocated() {} // 0x0000000184A227B0-0x0000000184A22850
	[BlackList] // 0x0000000189759760-0x00000001897597A0
	// [XID] // 0x0000000189759760-0x00000001897597A0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184A22710-0x0000000184A227B0
}

