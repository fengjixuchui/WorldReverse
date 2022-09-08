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
using Newtonsoft.Json;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898422C0-0x00000001898422E0
public class ConfigAIBuddySetting : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17401
{
	// Fields
	private bool _enable; // 0x10
	private SimpleSafeUInt32[] _buddyConfigIDs; // 0x18
	public static Action<ConfigAIBuddySetting, bool> postProcessData; // 0x00
	public static Action<ConfigAIBuddySetting> postInitEmpty; // 0x08
	[BlackList] // 0x000000018972FDB0-0x000000018972FE00
	[JsonIgnore] // 0x000000018972FDB0-0x000000018972FE00
	// [PooledField] // 0x000000018972FDB0-0x000000018972FE00
	public List<uint> buddyConfigIDList; // 0x20

	// Properties
	public bool enable { /* [XID] */ /* 0x000000018983A1C0-0x000000018983A1E0 */ get => default; /* [XID] */ /* 0x0000000189753BA0-0x0000000189753BC0 */ private set {} } // 0x000000018296FA30-0x000000018296FAD0 0x0000000182970230-0x00000001829702E0
	public SimpleSafeUInt32[] buddyConfigIDs { /* [XID] */ /* 0x000000018975B0E0-0x000000018975B100 */ get => default; /* [XID] */ /* 0x0000000189762AB0-0x0000000189762AD0 */ private set {} } // 0x000000018296F2F0-0x000000018296F390 0x0000000182970800-0x00000001829708B0

	// Constructors
	public ConfigAIBuddySetting() {} // 0x0000000182970B30-0x0000000182970BA0
	static ConfigAIBuddySetting() {} // 0x0000000182970950-0x0000000182970B30

	// Methods
	// [XID] // 0x000000018991CC00-0x000000018991CC20
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182970550-0x0000000182970660
	// [XID] // 0x0000000189771970-0x0000000189771990
	public void InitEmpty() {} // 0x000000018296FBA0-0x000000018296FCF0
	[BlackList] // 0x0000000189779060-0x00000001897790A0
	// [XID] // 0x0000000189779060-0x00000001897790A0
	public bool FromJson(JSONNode node) => default; // 0x000000018296F630-0x000000018296FA30
	// [XID] // 0x00000001897837D0-0x00000001897837F0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018296EC30-0x000000018296EEE0
	// [XID] // 0x000000018978AF60-0x000000018978AF80
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D55 */, bool useObjectPool = false /* Metadata: 0x00AF6D59 */) => default; // 0x000000018296FCF0-0x0000000182970070
	// [XID] // 0x00000001897924E0-0x0000000189792500
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF6D5A */, bool useObjectPool = false /* Metadata: 0x00AF6D5E */) => default; // 0x000000018296F390-0x000000018296F630
	[BlackList] // 0x0000000189799B10-0x0000000189799B50
	// [XID] // 0x0000000189799B10-0x0000000189799B50
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018296EEE0-0x000000018296F1B0
	// [XID] // 0x00000001897A4AD0-0x00000001897A4AF0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001829702E0-0x0000000182970550
	// [XID] // 0x00000001897AC0E0-0x00000001897AC100
	public virtual void OnPoolAllocated() {} // 0x0000000182970760-0x0000000182970800
	// [XID] // 0x00000001897B4050-0x00000001897B4070
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182970660-0x0000000182970760
	// [XID] // 0x00000001897BBD90-0x00000001897BBDB0
	private static void OnPostInitEmpty(ConfigAIBuddySetting data) {} // 0x000000018296FAD0-0x000000018296FBA0
	// [XID] // 0x00000001897C3590-0x00000001897C35B0
	private static void OnPostProcessDataCallback(ConfigAIBuddySetting data, bool useObjectPool) {} // 0x0000000182970070-0x0000000182970230
	[BlackList] // 0x00000001897CADD0-0x00000001897CAE10
	// [XID] // 0x00000001897CADD0-0x00000001897CAE10
	public virtual void AutoAllocTypeFields() {} // 0x000000018296F1B0-0x000000018296F250
	[BlackList] // 0x00000001897D5430-0x00000001897D5470
	// [XID] // 0x00000001897D5430-0x00000001897D5470
	public virtual void AutoRecycleTypeFields() {} // 0x000000018296F250-0x000000018296F2F0
	[BlackList] // 0x00000001897DFD10-0x00000001897DFD50
	// [XID] // 0x00000001897DFD10-0x00000001897DFD50
	public virtual void ReturnToObjectPool() {} // 0x00000001829708B0-0x0000000182970950
}

