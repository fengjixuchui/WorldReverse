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
public class ConfigAIPrecombatSetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17388
{
	// Fields
	private SimpleSafeFloat bioClockSleepFromRawNum; // 0x10
	private SimpleSafeFloat bioClockSleepToRawNum; // 0x14
	private SimpleSafeFloat satietyTimeRawNum; // 0x18
	private Dictionary<ConfigWeatherType, NeuronName[]> _overrideWeatherNeuronMapping; // 0x20

	// Properties
	public float bioClockSleepFrom { /* [XID] */ /* 0x00000001897BA9D0-0x00000001897BA9F0 */ get => default; /* [XID] */ /* 0x0000000189ADDCA0-0x0000000189ADDCC0 */ private set {} } // 0x000000018193C650-0x000000018193C730 0x000000018193CAB0-0x000000018193CB90
	public float bioClockSleepTo { /* [XID] */ /* 0x0000000189AE56A0-0x0000000189AE56C0 */ get => default; /* [XID] */ /* 0x0000000189AECB40-0x0000000189AECB60 */ private set {} } // 0x000000018193BCE0-0x000000018193BDC0 0x000000018193D840-0x000000018193D920
	public float satietyTime { /* [XID] */ /* 0x0000000189AF4590-0x0000000189AF45B0 */ get => default; /* [XID] */ /* 0x0000000189AFBBE0-0x0000000189AFBC00 */ private set {} } // 0x000000018193CCC0-0x000000018193CDA0 0x000000018193D150-0x000000018193D230
	public Dictionary<ConfigWeatherType, NeuronName[]> overrideWeatherNeuronMapping { /* [XID] */ /* 0x0000000189B03370-0x0000000189B03390 */ get => default; /* [XID] */ /* 0x0000000189B0AB80-0x0000000189B0ABA0 */ private set {} } // 0x000000018193C5B0-0x000000018193C650 0x000000018193D0A0-0x000000018193D150

	// Constructors
	public ConfigAIPrecombatSetting() {} // 0x000000018193D9C0-0x000000018193DA80

	// Methods
	// [XID] // 0x0000000189B12280-0x0000000189B122A0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018193D5C0-0x000000018193D700
	// [XID] // 0x0000000189B195B0-0x0000000189B195D0
	public void InitEmpty() {} // 0x000000018193CB90-0x000000018193CCC0
	[BlackList] // 0x0000000189B20C30-0x0000000189B20C70
	// [XID] // 0x0000000189B20C30-0x0000000189B20C70
	public bool FromJson(JSONNode node) => default; // 0x000000018193C730-0x000000018193CAB0
	// [XID] // 0x0000000189B2B2D0-0x0000000189B2B2F0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018193B7F0-0x000000018193BCE0
	// [XID] // 0x0000000189B32880-0x0000000189B328A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6CD9 */, bool useObjectPool = false /* Metadata: 0x00AF6CDD */) => default; // 0x000000018193CDA0-0x000000018193D0A0
	// [XID] // 0x0000000189B3A190-0x0000000189B3A1B0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6CDE */, bool useObjectPool = false /* Metadata: 0x00AF6CE2 */) => default; // 0x000000018193C230-0x000000018193C5B0
	[BlackList] // 0x0000000189B41AF0-0x0000000189B41B30
	// [XID] // 0x0000000189B41AF0-0x0000000189B41B30
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018193BDC0-0x000000018193C090
	// [XID] // 0x0000000189B4C360-0x0000000189B4C380
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018193D230-0x000000018193D5C0
	[BlackList] // 0x0000000189B53920-0x0000000189B53960
	// [XID] // 0x0000000189B53920-0x0000000189B53960
	public virtual void AutoAllocTypeFields() {} // 0x000000018193C090-0x000000018193C130
	[BlackList] // 0x0000000189B5E4A0-0x0000000189B5E4E0
	// [XID] // 0x0000000189B5E4A0-0x0000000189B5E4E0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018193C130-0x000000018193C230
	[BlackList] // 0x0000000189B68A80-0x0000000189B68AC0
	// [XID] // 0x0000000189B68A80-0x0000000189B68AC0
	public virtual void ReturnToObjectPool() {} // 0x000000018193D920-0x000000018193D9C0
	[BlackList] // 0x0000000189B72F30-0x0000000189B72F70
	// [XID] // 0x0000000189B72F30-0x0000000189B72F70
	public virtual void OnPoolAllocated() {} // 0x000000018193D7A0-0x000000018193D840
	[BlackList] // 0x0000000189B7D360-0x0000000189B7D3A0
	// [XID] // 0x0000000189B7D360-0x0000000189B7D3A0
	public virtual void OnBeforePoolRecycled() {} // 0x000000018193D700-0x000000018193D7A0
}

