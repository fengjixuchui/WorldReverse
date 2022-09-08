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
public class ConfigAudioStageEvents : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17629
{
	// Fields
	private SimpleSafeInt32 idRawNum; // 0x10
	private string[] _stageCreateEvents; // 0x18
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAudioStageProgressEvent[] _stageProgressEvents; // 0x20
	private string[] _stageStartEvents; // 0x28
	private string[] _stageMatureEvents; // 0x30
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	private ConfigAudioStageProgressEvent[] _stageTeleportEvents; // 0x38
	private string[] _stageExitEvents; // 0x40
	private string _stateValue; // 0x48

	// Properties
	public int id { /* [XID] */ /* 0x0000000189B36EF0-0x0000000189B36F10 */ get => default; /* [XID] */ /* 0x0000000189B3E7A0-0x0000000189B3E7C0 */ private set {} } // 0x00000001851B2750-0x00000001851B2820 0x00000001851B1520-0x00000001851B1600
	public string[] stageCreateEvents { /* [XID] */ /* 0x0000000189B462E0-0x0000000189B46300 */ get => default; /* [XID] */ /* 0x0000000189B4D7F0-0x0000000189B4D810 */ private set {} } // 0x00000001851B1260-0x00000001851B1300 0x00000001851B16B0-0x00000001851B1760
	public ConfigAudioStageProgressEvent[] stageProgressEvents { /* [XID] */ /* 0x000000018966A930-0x000000018966A950 */ get => default; /* [XID] */ /* 0x0000000189B5CA10-0x0000000189B5CA30 */ private set {} } // 0x00000001851AF8A0-0x00000001851AF940 0x00000001851B1B10-0x00000001851B1BC0
	public string[] stageStartEvents { /* [XID] */ /* 0x0000000189B640D0-0x0000000189B640F0 */ get => default; /* [XID] */ /* 0x0000000189B6B830-0x0000000189B6B850 */ private set {} } // 0x00000001851B0E40-0x00000001851B0EE0 0x00000001851B1A60-0x00000001851B1B10
	public string[] stageMatureEvents { /* [XID] */ /* 0x0000000189B8C750-0x0000000189B8C770 */ get => default; /* [XID] */ /* 0x0000000189B7A450-0x0000000189B7A470 */ private set {} } // 0x00000001851B23C0-0x00000001851B2460 0x00000001851B0650-0x00000001851B0700
	public ConfigAudioStageProgressEvent[] stageTeleportEvents { /* [XID] */ /* 0x0000000189662D30-0x0000000189662D50 */ get => default; /* [XID] */ /* 0x0000000189B89330-0x0000000189B89350 */ private set {} } // 0x00000001851B0700-0x00000001851B07A0 0x00000001851B1300-0x00000001851B13B0
	public string[] stageExitEvents { /* [XID] */ /* 0x0000000189B90890-0x0000000189B908B0 */ get => default; /* [XID] */ /* 0x0000000189B97D60-0x0000000189B97D80 */ private set {} } // 0x00000001851B0410-0x00000001851B04B0 0x00000001851B1600-0x00000001851B16B0
	public string stateValue { /* [XID] */ /* 0x0000000189B9F130-0x0000000189B9F150 */ get => default; /* [XID] */ /* 0x0000000189BA69A0-0x0000000189BA69C0 */ private set {} } // 0x00000001851B2320-0x00000001851B23C0 0x00000001851B2270-0x00000001851B2320

	// Constructors
	public ConfigAudioStageEvents() {} // 0x00000001851B28C0-0x00000001851B2920

	// Methods
	// [XID] // 0x0000000189BADBE0-0x0000000189BADC00
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001851B2460-0x00000001851B2610
	// [XID] // 0x0000000189BB5390-0x0000000189BB53B0
	public void InitEmpty() {} // 0x00000001851B13B0-0x00000001851B1520
	[BlackList] // 0x0000000189BBCAB0-0x0000000189BBCAF0
	// [XID] // 0x0000000189BBCAB0-0x0000000189BBCAF0
	public bool FromJson(JSONNode node) => default; // 0x00000001851B0EE0-0x00000001851B1260
	// [XID] // 0x0000000189BC7560-0x0000000189BC7580
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001851AF940-0x00000001851B0140
	// [XID] // 0x0000000189BCF250-0x0000000189BCF270
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7559 */, bool useObjectPool = false /* Metadata: 0x00AF755D */) => default; // 0x00000001851B1760-0x00000001851B1A60
	// [XID] // 0x0000000189BD6500-0x0000000189BD6520
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF755E */, bool useObjectPool = false /* Metadata: 0x00AF7562 */) => default; // 0x00000001851B07A0-0x00000001851B0E40
	[BlackList] // 0x0000000189BDE140-0x0000000189BDE180
	// [XID] // 0x0000000189BDE140-0x0000000189BDE180
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001851B0140-0x00000001851B0410
	// [XID] // 0x00000001895EDB10-0x00000001895EDB30
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001851B1BC0-0x00000001851B2270
	[BlackList] // 0x00000001895F5390-0x00000001895F53D0
	// [XID] // 0x00000001895F5390-0x00000001895F53D0
	public virtual void AutoAllocTypeFields() {} // 0x00000001851B04B0-0x00000001851B0550
	[BlackList] // 0x00000001895FF890-0x00000001895FF8D0
	// [XID] // 0x00000001895FF890-0x00000001895FF8D0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001851B0550-0x00000001851B0650
	[BlackList] // 0x000000018960A2D0-0x000000018960A310
	// [XID] // 0x000000018960A2D0-0x000000018960A310
	public virtual void ReturnToObjectPool() {} // 0x00000001851B2820-0x00000001851B28C0
	[BlackList] // 0x00000001896148C0-0x0000000189614900
	// [XID] // 0x00000001896148C0-0x0000000189614900
	public virtual void OnPoolAllocated() {} // 0x00000001851B26B0-0x00000001851B2750
	[BlackList] // 0x000000018961F200-0x000000018961F240
	// [XID] // 0x000000018961F200-0x000000018961F240
	public virtual void OnBeforePoolRecycled() {} // 0x00000001851B2610-0x00000001851B26B0
}

