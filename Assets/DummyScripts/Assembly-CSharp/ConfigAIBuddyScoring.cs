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
public class ConfigAIBuddyScoring : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17497
{
	// Fields
	private SimpleSafeInt32 hpFactorRawNum; // 0x10
	private SimpleSafeFloat hpWeightRawNum; // 0x14
	private SimpleSafeFloat distFactorRawNum; // 0x18
	private SimpleSafeInt32 distWeightRawNum; // 0x1C
	private SimpleSafeFloat[] _roleScores; // 0x20

	// Properties
	public int hpFactor { /* [XID] */ /* 0x000000018987D8C0-0x000000018987D8E0 */ get => default; /* [XID] */ /* 0x00000001898847D0-0x00000001898847F0 */ private set {} } // 0x000000018307D450-0x000000018307D520 0x000000018307C9A0-0x000000018307CA80
	public float hpWeight { /* [XID] */ /* 0x000000018988BE40-0x000000018988BE60 */ get => default; /* [XID] */ /* 0x00000001898934D0-0x00000001898934F0 */ private set {} } // 0x000000018307C420-0x000000018307C500 0x000000018307D520-0x000000018307D600
	public float distFactor { /* [XID] */ /* 0x0000000189BCFAD0-0x0000000189BCFAF0 */ get => default; /* [XID] */ /* 0x00000001898A1E80-0x00000001898A1EA0 */ private set {} } // 0x000000018307DBF0-0x000000018307DCD0 0x000000018307CF50-0x000000018307D030
	public int distWeight { /* [XID] */ /* 0x00000001898A96B0-0x00000001898A96D0 */ get => default; /* [XID] */ /* 0x00000001898B0EC0-0x00000001898B0EE0 */ private set {} } // 0x000000018307CE80-0x000000018307CF50 0x000000018307DA60-0x000000018307DB40
	public SimpleSafeFloat[] roleScores { /* [XID] */ /* 0x0000000189803290-0x00000001898032B0 */ get => default; /* [XID] */ /* 0x00000001898BFE00-0x00000001898BFE20 */ private set {} } // 0x000000018307D030-0x000000018307D0D0 0x000000018307DB40-0x000000018307DBF0

	// Constructors
	public ConfigAIBuddyScoring() {} // 0x000000018307E480-0x000000018307E570

	// Methods
	// [XID] // 0x00000001898C76C0-0x00000001898C76E0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018307E140-0x000000018307E2A0
	// [XID] // 0x00000001898CECD0-0x00000001898CECF0
	public void InitEmpty() {} // 0x000000018307D600-0x000000018307D760
	[BlackList] // 0x00000001898D6680-0x00000001898D66C0
	// [XID] // 0x00000001898D6680-0x00000001898D66C0
	public bool FromJson(JSONNode node) => default; // 0x000000018307D0D0-0x000000018307D450
	// [XID] // 0x00000001898E1320-0x00000001898E1340
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018307BE50-0x000000018307C420
	// [XID] // 0x00000001898E8D40-0x00000001898E8D60
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF70B3 */, bool useObjectPool = false /* Metadata: 0x00AF70B7 */) => default; // 0x000000018307D760-0x000000018307DA60
	// [XID] // 0x00000001898F04A0-0x00000001898F04C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF70B8 */, bool useObjectPool = false /* Metadata: 0x00AF70BC */) => default; // 0x000000018307CA80-0x000000018307CE80
	[BlackList] // 0x00000001898F7EB0-0x00000001898F7EF0
	// [XID] // 0x00000001898F7EB0-0x00000001898F7EF0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018307C500-0x000000018307C7D0
	// [XID] // 0x0000000189902720-0x0000000189902740
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018307DCD0-0x000000018307E140
	[BlackList] // 0x0000000189909CC0-0x0000000189909D00
	// [XID] // 0x0000000189909CC0-0x0000000189909D00
	public virtual void AutoAllocTypeFields() {} // 0x000000018307C7D0-0x000000018307C870
	[BlackList] // 0x0000000189914660-0x00000001899146A0
	// [XID] // 0x0000000189914660-0x00000001899146A0
	public virtual void AutoRecycleTypeFields() {} // 0x000000018307C870-0x000000018307C9A0
	[BlackList] // 0x000000018991EF00-0x000000018991EF40
	// [XID] // 0x000000018991EF00-0x000000018991EF40
	public virtual void ReturnToObjectPool() {} // 0x000000018307E3E0-0x000000018307E480
	[BlackList] // 0x00000001899299A0-0x00000001899299E0
	// [XID] // 0x00000001899299A0-0x00000001899299E0
	public virtual void OnPoolAllocated() {} // 0x000000018307E340-0x000000018307E3E0
	[BlackList] // 0x0000000189933D20-0x0000000189933D60
	// [XID] // 0x0000000189933D20-0x0000000189933D60
	public virtual void OnBeforePoolRecycled() {} // 0x000000018307E2A0-0x000000018307E340
}

