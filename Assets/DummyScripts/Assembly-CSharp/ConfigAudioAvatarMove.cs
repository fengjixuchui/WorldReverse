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
public class ConfigAudioAvatarMove : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17555
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _flyDirectionRtpcKey; // 0x10
	private SimpleSafeFloat flyDirectionRtpcFrontRawNum; // 0x18
	private SimpleSafeFloat flyDirectionRtpcSideRawNum; // 0x1C
	private SimpleSafeFloat flyDirectionRtpcBackRawNum; // 0x20
	private SimpleSafeFloat flyDirectionRtpcDropRawNum; // 0x24
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _lastFrameSpeedInAirRtpcKey; // 0x28
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _eventFallInWater; // 0x30
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _altitudeRtpcKey; // 0x38
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _slopeRtpcKey; // 0x40
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _flyTurnEvent; // 0x48
	private SimpleSafeFloat flyTurnEventIntervalRawNum; // 0x50
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _flySpeedRtpcKey; // 0x58
	private SimpleSafeFloat airflowSpeedGainRawNum; // 0x60
	private SimpleSafeFloat airflowGainFadeLengthRawNum; // 0x64
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _climbVerticalScalerRtpcKey; // 0x68
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _climbVerticalScalerAnimatorKey; // 0x70
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _cameraAngleXRtpcKey; // 0x78
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _cameraAngleYRtpcKey; // 0x80
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _enterSpeedupFieldEvent; // 0x88
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private ConfigWwiseString _fallOnWaterRtpcKey; // 0x90

	// Properties
	public ConfigWwiseString flyDirectionRtpcKey { /* [XID] */ /* 0x000000018985B5B0-0x000000018985B5D0 */ get => default; /* [XID] */ /* 0x0000000189862B90-0x0000000189862BB0 */ private set {} } // 0x000000018135C850-0x000000018135C8F0 0x000000018135C8F0-0x000000018135C9A0
	public float flyDirectionRtpcFront { /* [XID] */ /* 0x000000018986A040-0x000000018986A060 */ get => default; /* [XID] */ /* 0x00000001898713B0-0x00000001898713D0 */ private set {} } // 0x000000018135D1B0-0x000000018135D290 0x000000018135E4E0-0x000000018135E5C0
	public float flyDirectionRtpcSide { /* [XID] */ /* 0x0000000189878DB0-0x0000000189878DD0 */ get => default; /* [XID] */ /* 0x0000000189880400-0x0000000189880420 */ private set {} } // 0x000000018135D0D0-0x000000018135D1B0 0x000000018135B430-0x000000018135B510
	public float flyDirectionRtpcBack { /* [XID] */ /* 0x00000001898878E0-0x0000000189887900 */ get => default; /* [XID] */ /* 0x000000018988EC00-0x000000018988EC20 */ private set {} } // 0x000000018135DEE0-0x000000018135DFC0 0x000000018135DCA0-0x000000018135DD80
	public float flyDirectionRtpcDrop { /* [XID] */ /* 0x0000000189896120-0x0000000189896140 */ get => default; /* [XID] */ /* 0x000000018989D720-0x000000018989D740 */ private set {} } // 0x000000018135B510-0x000000018135B5F0 0x000000018135F320-0x000000018135F400
	public ConfigWwiseString lastFrameSpeedInAirRtpcKey { /* [XID] */ /* 0x00000001898A5120-0x00000001898A5140 */ get => default; /* [XID] */ /* 0x00000001898AC5C0-0x00000001898AC5E0 */ private set {} } // 0x000000018135C9A0-0x000000018135CA40 0x000000018135E230-0x000000018135E2E0
	public ConfigWwiseString eventFallInWater { /* [XID] */ /* 0x00000001898B3B40-0x00000001898B3B60 */ get => default; /* [XID] */ /* 0x00000001898BB8F0-0x00000001898BB910 */ private set {} } // 0x000000018135D340-0x000000018135D3E0 0x000000018135E390-0x000000018135E440
	public ConfigWwiseString altitudeRtpcKey { /* [XID] */ /* 0x00000001898C2BA0-0x00000001898C2BC0 */ get => default; /* [XID] */ /* 0x00000001898CA5A0-0x00000001898CA5C0 */ private set {} } // 0x000000018135DA80-0x000000018135DB20 0x000000018135B690-0x000000018135B740
	public ConfigWwiseString slopeRtpcKey { /* [XID] */ /* 0x00000001898D1DF0-0x00000001898D1E10 */ get => default; /* [XID] */ /* 0x00000001898D9630-0x00000001898D9650 */ private set {} } // 0x000000018135B2E0-0x000000018135B380 0x000000018135E2E0-0x000000018135E390
	public ConfigWwiseString flyTurnEvent { /* [XID] */ /* 0x00000001898E1300-0x00000001898E1320 */ get => default; /* [XID] */ /* 0x00000001898E8D20-0x00000001898E8D40 */ private set {} } // 0x000000018135B5F0-0x000000018135B690 0x000000018135B380-0x000000018135B430
	public float flyTurnEventInterval { /* [XID] */ /* 0x00000001898F0480-0x00000001898F04A0 */ get => default; /* [XID] */ /* 0x00000001898F7E50-0x00000001898F7E70 */ private set {} } // 0x000000018135DFC0-0x000000018135E0A0 0x000000018135E150-0x000000018135E230
	public ConfigWwiseString flySpeedRtpcKey { /* [XID] */ /* 0x00000001898FF4F0-0x00000001898FF510 */ get => default; /* [XID] */ /* 0x0000000189906D10-0x0000000189906D30 */ private set {} } // 0x000000018135DB20-0x000000018135DBC0 0x000000018135DE30-0x000000018135DEE0
	public float airflowSpeedGain { /* [XID] */ /* 0x000000018990E730-0x000000018990E750 */ get => default; /* [XID] */ /* 0x0000000189915DA0-0x0000000189915DC0 */ private set {} } // 0x000000018135A770-0x000000018135A850 0x000000018135DBC0-0x000000018135DCA0
	public float airflowGainFadeLength { /* [XID] */ /* 0x000000018991D8B0-0x000000018991D8D0 */ get => default; /* [XID] */ /* 0x0000000189925020-0x0000000189925040 */ private set {} } // 0x000000018135CA40-0x000000018135CB20 0x000000018135CFF0-0x000000018135D0D0
	public ConfigWwiseString climbVerticalScalerRtpcKey { /* [XID] */ /* 0x000000018992C600-0x000000018992C620 */ get => default; /* [XID] */ /* 0x0000000189933C80-0x0000000189933CA0 */ private set {} } // 0x000000018135D3E0-0x000000018135D480 0x000000018135E0A0-0x000000018135E150
	public ConfigWwiseString climbVerticalScalerAnimatorKey { /* [XID] */ /* 0x000000018993B8D0-0x000000018993B8F0 */ get => default; /* [XID] */ /* 0x00000001899429B0-0x00000001899429D0 */ private set {} } // 0x000000018135E440-0x000000018135E4E0 0x000000018135A6C0-0x000000018135A770
	public ConfigWwiseString cameraAngleXRtpcKey { /* [XID] */ /* 0x000000018994A1E0-0x000000018994A200 */ get => default; /* [XID] */ /* 0x0000000189951C90-0x0000000189951CB0 */ private set {} } // 0x000000018135CB20-0x000000018135CBC0 0x000000018135CBC0-0x000000018135CC70
	public ConfigWwiseString cameraAngleYRtpcKey { /* [XID] */ /* 0x00000001899591B0-0x00000001899591D0 */ get => default; /* [XID] */ /* 0x0000000189960A20-0x0000000189960A40 */ private set {} } // 0x000000018135D290-0x000000018135D340 0x000000018135F930-0x000000018135F9E0
	public ConfigWwiseString enterSpeedupFieldEvent { /* [XID] */ /* 0x00000001899681E0-0x0000000189968200 */ get => default; /* [XID] */ /* 0x000000018996F5E0-0x000000018996F600 */ private set {} } // 0x000000018135D6D0-0x000000018135D780 0x000000018135DD80-0x000000018135DE30
	public ConfigWwiseString fallOnWaterRtpcKey { /* [XID] */ /* 0x0000000189977280-0x00000001899772A0 */ get => default; /* [XID] */ /* 0x000000018997E620-0x000000018997E640 */ private set {} } // 0x0000000181359100-0x00000001813591B0 0x000000018135F9E0-0x000000018135FA90

	// Constructors
	public ConfigAudioAvatarMove() {} // 0x000000018135FB30-0x000000018135FB90

	// Methods
	// [XID] // 0x0000000189986050-0x0000000189986070
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018135F400-0x000000018135F7F0
	// [XID] // 0x000000018998DD20-0x000000018998DD40
	public void InitEmpty() {} // 0x000000018135D480-0x000000018135D6D0
	[BlackList] // 0x00000001899957F0-0x0000000189995830
	// [XID] // 0x00000001899957F0-0x0000000189995830
	public bool FromJson(JSONNode node) => default; // 0x000000018135CC70-0x000000018135CFF0
	// [XID] // 0x00000001899A0190-0x00000001899A01B0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001813591B0-0x000000018135A6C0
	// [XID] // 0x00000001899A7CC0-0x00000001899A7CE0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF72C5 */, bool useObjectPool = false /* Metadata: 0x00AF72C9 */) => default; // 0x000000018135D780-0x000000018135DA80
	// [XID] // 0x00000001899AF4D0-0x00000001899AF4F0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF72CA */, bool useObjectPool = false /* Metadata: 0x00AF72CE */) => default; // 0x000000018135B740-0x000000018135C850
	[BlackList] // 0x00000001899B6950-0x00000001899B6990
	// [XID] // 0x00000001899B6950-0x00000001899B6990
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018135A850-0x000000018135AB20
	// [XID] // 0x00000001899C13B0-0x00000001899C13D0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018135E5C0-0x000000018135F320
	[BlackList] // 0x00000001899C89C0-0x00000001899C8A00
	// [XID] // 0x00000001899C89C0-0x00000001899C8A00
	public virtual void AutoAllocTypeFields() {} // 0x000000018135AB20-0x000000018135ABC0
	[BlackList] // 0x00000001899D31D0-0x00000001899D3210
	// [XID] // 0x00000001899D31D0-0x00000001899D3210
	public virtual void AutoRecycleTypeFields() {} // 0x000000018135ABC0-0x000000018135B2E0
	[BlackList] // 0x00000001899DD5C0-0x00000001899DD600
	// [XID] // 0x00000001899DD5C0-0x00000001899DD600
	public virtual void ReturnToObjectPool() {} // 0x000000018135FA90-0x000000018135FB30
	[BlackList] // 0x00000001899E80C0-0x00000001899E8100
	// [XID] // 0x00000001899E80C0-0x00000001899E8100
	public virtual void OnPoolAllocated() {} // 0x000000018135F890-0x000000018135F930
	[BlackList] // 0x00000001899F2860-0x00000001899F28A0
	// [XID] // 0x00000001899F2860-0x00000001899F28A0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018135F7F0-0x000000018135F890
}

