/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
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
public class ConfigAudioMIDI : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17594
{
	// Fields
	private Dictionary<SimpleSafeInt32, Dictionary<SimpleSafeInt32, ConfigWwiseString>> _instruments; // 0x10
	private Dictionary<SimpleSafeInt32, SimpleSafeInt32> _freeplay_buttons; // 0x18
	private SimpleSafeFloat freeplay_timeoutRawNum; // 0x20
	private SimpleSafeFloat freeplay_max_distanceRawNum; // 0x24

	// Properties
	public Dictionary<SimpleSafeInt32, Dictionary<SimpleSafeInt32, ConfigWwiseString>> instruments { /* [XID] */ /* 0x0000000189A18DD0-0x0000000189A18DF0 */ get => default; /* [XID] */ /* 0x0000000189A204F0-0x0000000189A20510 */ private set {} } // 0x0000000181D30440-0x0000000181D304E0 0x0000000181D304E0-0x0000000181D30590
	public Dictionary<SimpleSafeInt32, SimpleSafeInt32> freeplay_buttons { /* [XID] */ /* 0x0000000189A27940-0x0000000189A27960 */ get => default; /* [XID] */ /* 0x0000000189A2F0D0-0x0000000189A2F0F0 */ private set {} } // 0x0000000181D2EEB0-0x0000000181D2EF50 0x0000000181D2F690-0x0000000181D2F740
	public float freeplay_timeout { /* [XID] */ /* 0x0000000189A36A90-0x0000000189A36AB0 */ get => default; /* [XID] */ /* 0x0000000189A3E130-0x0000000189A3E150 */ private set {} } // 0x0000000181D2FAC0-0x0000000181D2FBA0 0x0000000181D2F1B0-0x0000000181D2F290
	public float freeplay_max_distance { /* [XID] */ /* 0x0000000189A45840-0x0000000189A45860 */ get => default; /* [XID] */ /* 0x0000000189A4CE40-0x0000000189A4CE60 */ private set {} } // 0x0000000181D2EDD0-0x0000000181D2EEB0 0x0000000181D30360-0x0000000181D30440
	public float freeplayMaxDistanceSqr { /* [XID] */ /* 0x0000000189AA5940-0x0000000189AA5960 */ get => default; } // 0x0000000181D2F0E0-0x0000000181D2F1B0 

	// Constructors
	public ConfigAudioMIDI() {} // 0x0000000181D30C70-0x0000000181D30CD0

	// Methods
	// [XID] // 0x0000000189A545D0-0x0000000189A545F0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000181D30950-0x0000000181D30A90
	// [XID] // 0x0000000189A5C0C0-0x0000000189A5C0E0
	public void InitEmpty() {} // 0x0000000181D2FBA0-0x0000000181D2FCD0
	[BlackList] // 0x0000000189A63970-0x0000000189A639B0
	// [XID] // 0x0000000189A63970-0x0000000189A639B0
	public bool FromJson(JSONNode node) => default; // 0x0000000181D2F740-0x0000000181D2FAC0
	// [XID] // 0x0000000189A6E180-0x0000000189A6E1A0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000181D2E5F0-0x0000000181D2EB00
	// [XID] // 0x0000000189A75670-0x0000000189A75690
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF741F */, bool useObjectPool = false /* Metadata: 0x00AF7423 */) => default; // 0x0000000181D2FF20-0x0000000181D30220
	// [XID] // 0x0000000189A7D370-0x0000000189A7D390
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7424 */, bool useObjectPool = false /* Metadata: 0x00AF7428 */) => default; // 0x0000000181D2F290-0x0000000181D2F690
	[BlackList] // 0x0000000189A84BA0-0x0000000189A84BE0
	// [XID] // 0x0000000189A84BA0-0x0000000189A84BE0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000181D2EB00-0x0000000181D2EDD0
	// [XID] // 0x0000000189A8F530-0x0000000189A8F550
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000181D30590-0x0000000181D30950
	// [XID] // 0x0000000189947F10-0x0000000189947F30
	public uint GetMidiEvent(int instrument, int note) => default; // 0x0000000181D2FCD0-0x0000000181D2FF20
	// [XID] // 0x0000000189A9DEB0-0x0000000189A9DED0
	public int GetMidiNoteByButtonIndex(int index) => default; // 0x0000000181D30220-0x0000000181D30360
	[BlackList] // 0x0000000189AACF80-0x0000000189AACFC0
	// [XID] // 0x0000000189AACF80-0x0000000189AACFC0
	public virtual void AutoAllocTypeFields() {} // 0x0000000181D2EF50-0x0000000181D2EFF0
	[BlackList] // 0x0000000189AB7890-0x0000000189AB78D0
	// [XID] // 0x0000000189AB7890-0x0000000189AB78D0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000181D2EFF0-0x0000000181D2F0E0
	[BlackList] // 0x0000000189AC2640-0x0000000189AC2680
	// [XID] // 0x0000000189AC2640-0x0000000189AC2680
	public virtual void ReturnToObjectPool() {} // 0x0000000181D30BD0-0x0000000181D30C70
	[BlackList] // 0x0000000189ACCB20-0x0000000189ACCB60
	// [XID] // 0x0000000189ACCB20-0x0000000189ACCB60
	public virtual void OnPoolAllocated() {} // 0x0000000181D30B30-0x0000000181D30BD0
	[BlackList] // 0x0000000189AD79A0-0x0000000189AD79E0
	// [XID] // 0x0000000189AD79A0-0x0000000189AD79E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000181D30A90-0x0000000181D30B30
}

