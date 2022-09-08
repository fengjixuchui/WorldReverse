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
public class ConfigMapGlobal : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18537
{
	// Fields
	private SimpleSafeFloat miniMapUIRadiusRawNum; // 0x10
	private SimpleSafeFloat miniMapSightRadiusRawNum; // 0x14
	private SimpleSafeFloat miniMapScaleDefaultRawNum; // 0x18
	private SimpleSafeFloat[] _miniMapScaleRanks; // 0x20
	private SimpleSafeFloat levelMapScaleDefaultRawNum; // 0x28
	private SimpleSafeFloat levelMapScaleMaxRawNum; // 0x2C
	private SimpleSafeFloat levelMapScaleMinRawNum; // 0x30
	private SimpleSafeFloat levelMapTransPointRadiusRawNum; // 0x34
	private SimpleSafeFloat levelMapCustomMarkCancelRadiusRawNum; // 0x38
	private SimpleSafeFloat levelMapCustomMarkNearCancelRadiusRawNum; // 0x3C
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigVCustomMapMark[] _customStyles; // 0x40
	private SimpleSafeFloat MarkNearThresholdRawNum; // 0x48
	private SimpleSafeFloat MarkSelectedScaleRawNum; // 0x4C
	private SimpleSafeFloat RewardTipSlideValueRawNum; // 0x50
	private SimpleSafeUInt32 FirstAreaIDHideMiniMapRawNum; // 0x54
	private SimpleSafeFloat MarkUnlockEffectDelayRawNum; // 0x58

	// Properties
	public float miniMapUIRadius { /* [XID] */ /* 0x0000000189778E20-0x0000000189778E40 */ get => default; /* [XID] */ /* 0x0000000189780460-0x0000000189780480 */ private set {} } // 0x0000000183A035A0-0x0000000183A03680 0x0000000183A01D90-0x0000000183A01E70
	public float miniMapSightRadius { /* [XID] */ /* 0x0000000189787C60-0x0000000189787C80 */ get => default; /* [XID] */ /* 0x000000018978F1C0-0x000000018978F1E0 */ private set {} } // 0x0000000183A034C0-0x0000000183A035A0 0x0000000183A04410-0x0000000183A044F0
	public float miniMapScaleDefault { /* [XID] */ /* 0x00000001897969F0-0x0000000189796A10 */ get => default; /* [XID] */ /* 0x000000018979EB50-0x000000018979EB70 */ private set {} } // 0x0000000183A03C70-0x0000000183A03D50 0x0000000183A02450-0x0000000183A02530
	public SimpleSafeFloat[] miniMapScaleRanks { /* [XID] */ /* 0x00000001897A6220-0x00000001897A6240 */ get => default; /* [XID] */ /* 0x00000001897AD6B0-0x00000001897AD6D0 */ private set {} } // 0x0000000183A04870-0x0000000183A04910 0x0000000183A01E70-0x0000000183A01F20
	public float levelMapScaleDefault { /* [XID] */ /* 0x00000001897B57F0-0x00000001897B5810 */ get => default; /* [XID] */ /* 0x00000001897BD520-0x00000001897BD540 */ private set {} } // 0x0000000183A03D50-0x0000000183A03E30 0x0000000183A03B90-0x0000000183A03C70
	public float levelMapScaleMax { /* [XID] */ /* 0x00000001897C48E0-0x00000001897C4900 */ get => default; /* [XID] */ /* 0x00000001897CC070-0x00000001897CC090 */ private set {} } // 0x0000000183A02530-0x0000000183A02610 0x0000000183A04330-0x0000000183A04410
	public float levelMapScaleMin { /* [XID] */ /* 0x00000001897D39E0-0x00000001897D3A00 */ get => default; /* [XID] */ /* 0x00000001897DB470-0x00000001897DB490 */ private set {} } // 0x0000000183A02370-0x0000000183A02450 0x0000000183A03300-0x0000000183A033E0
	public float levelMapTransPointRadius { /* [XID] */ /* 0x00000001897E2B40-0x00000001897E2B60 */ get => default; /* [XID] */ /* 0x00000001897EA2E0-0x00000001897EA300 */ private set {} } // 0x0000000183A02290-0x0000000183A02370 0x0000000183A020D0-0x0000000183A021B0
	public float levelMapCustomMarkCancelRadius { /* [XID] */ /* 0x00000001897F1F90-0x00000001897F1FB0 */ get => default; /* [XID] */ /* 0x00000001897F9820-0x00000001897F9840 */ private set {} } // 0x0000000183A05390-0x0000000183A05470 0x0000000183A03A00-0x0000000183A03AE0
	public float levelMapCustomMarkNearCancelRadius { /* [XID] */ /* 0x0000000189800D40-0x0000000189800D60 */ get => default; /* [XID] */ /* 0x00000001898082A0-0x00000001898082C0 */ private set {} } // 0x0000000183A00510-0x0000000183A005F0 0x0000000183A021B0-0x0000000183A02290
	public ConfigVCustomMapMark[] customStyles { /* [XID] */ /* 0x000000018980FC90-0x000000018980FCB0 */ get => default; /* [XID] */ /* 0x0000000189817320-0x0000000189817340 */ private set {} } // 0x0000000183A00470-0x0000000183A00510 0x0000000183A03AE0-0x0000000183A03B90
	public float MarkNearThreshold { /* [XID] */ /* 0x000000018981EC80-0x000000018981ECA0 */ get => default; /* [XID] */ /* 0x0000000189826170-0x0000000189826190 */ private set {} } // 0x0000000183A05830-0x0000000183A05910 0x0000000183A04790-0x0000000183A04870
	public float MarkSelectedScale { /* [XID] */ /* 0x000000018982D720-0x000000018982D740 */ get => default; /* [XID] */ /* 0x0000000189834ED0-0x0000000189834EF0 */ private set {} } // 0x0000000183A044F0-0x0000000183A045D0 0x0000000183A033E0-0x0000000183A034C0
	public float RewardTipSlideValue { /* [XID] */ /* 0x000000018983C650-0x000000018983C670 */ get => default; /* [XID] */ /* 0x0000000189843D00-0x0000000189843D20 */ private set {} } // 0x0000000183A046B0-0x0000000183A04790 0x0000000183A045D0-0x0000000183A046B0
	public uint FirstAreaIDHideMiniMap { /* [XID] */ /* 0x000000018984B1D0-0x000000018984B1F0 */ get => default; /* [XID] */ /* 0x0000000189852440-0x0000000189852460 */ private set {} } // 0x0000000183A01F20-0x0000000183A01FF0 0x0000000183A00390-0x0000000183A00470
	public float MarkUnlockEffectDelay { /* [XID] */ /* 0x0000000189859D90-0x0000000189859DB0 */ get => default; /* [XID] */ /* 0x0000000189860E50-0x0000000189860E70 */ private set {} } // 0x0000000183A02610-0x0000000183A026F0 0x0000000183A01FF0-0x0000000183A020D0

	// Constructors
	public ConfigMapGlobal() {} // 0x0000000183A059B0-0x0000000183A05A10

	// Methods
	// [XID] // 0x00000001898686D0-0x00000001898686F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183A05470-0x0000000183A056F0
	// [XID] // 0x000000018986FB20-0x000000018986FB40
	public void InitEmpty() {} // 0x0000000183A03E30-0x0000000183A04030
	[BlackList] // 0x00000001898771D0-0x0000000189877210
	// [XID] // 0x00000001898771D0-0x0000000189877210
	public bool FromJson(JSONNode node) => default; // 0x0000000183A03680-0x0000000183A03A00
	// [XID] // 0x0000000189881860-0x0000000189881880
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183A005F0-0x0000000183A01820
	// [XID] // 0x0000000189888DE0-0x0000000189888E00
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA0FB */, bool useObjectPool = false /* Metadata: 0x00AFA0FF */) => default; // 0x0000000183A04030-0x0000000183A04330
	// [XID] // 0x00000001898901A0-0x00000001898901C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AFA100 */, bool useObjectPool = false /* Metadata: 0x00AFA104 */) => default; // 0x0000000183A026F0-0x0000000183A03300
	[BlackList] // 0x0000000189897780-0x00000001898977C0
	// [XID] // 0x0000000189897780-0x00000001898977C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183A01820-0x0000000183A01AF0
	// [XID] // 0x00000001898A1CC0-0x00000001898A1CE0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183A04910-0x0000000183A05390
	[BlackList] // 0x00000001898A9510-0x00000001898A9550
	// [XID] // 0x00000001898A9510-0x00000001898A9550
	public virtual void AutoAllocTypeFields() {} // 0x0000000183A01AF0-0x0000000183A01B90
	[BlackList] // 0x00000001898B3980-0x00000001898B39C0
	// [XID] // 0x00000001898B3980-0x00000001898B39C0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183A01B90-0x0000000183A01D90
	[BlackList] // 0x00000001898BE2A0-0x00000001898BE2E0
	// [XID] // 0x00000001898BE2A0-0x00000001898BE2E0
	public virtual void ReturnToObjectPool() {} // 0x0000000183A05910-0x0000000183A059B0
	[BlackList] // 0x00000001898C8D20-0x00000001898C8D60
	// [XID] // 0x00000001898C8D20-0x00000001898C8D60
	public virtual void OnPoolAllocated() {} // 0x0000000183A05790-0x0000000183A05830
	[BlackList] // 0x00000001898D3290-0x00000001898D32D0
	// [XID] // 0x00000001898D3290-0x00000001898D32D0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183A056F0-0x0000000183A05790
}

