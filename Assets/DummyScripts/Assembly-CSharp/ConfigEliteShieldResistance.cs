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
public class ConfigEliteShieldResistance : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18107
{
	// Fields
	private string _type; // 0x10
	private SimpleSafeFloat[] _damageRatio; // 0x18
	private SimpleSafeFloat[] _damageSufferRatio; // 0x20

	// Properties
	public string type { /* [XID] */ /* 0x00000001898CBB90-0x00000001898CBBB0 */ get => default; /* [XID] */ /* 0x00000001898D3370-0x00000001898D3390 */ private set {} } // 0x00000001814D2870-0x00000001814D2910 0x00000001814D2240-0x00000001814D22F0
	public SimpleSafeFloat[] damageRatio { /* [XID] */ /* 0x00000001898DAC00-0x00000001898DAC20 */ get => default; /* [XID] */ /* 0x00000001898E2AA0-0x00000001898E2AC0 */ private set {} } // 0x00000001814D18E0-0x00000001814D1980 0x00000001814D1830-0x00000001814D18E0
	public SimpleSafeFloat[] damageSufferRatio { /* [XID] */ /* 0x00000001898EA5D0-0x00000001898EA5F0 */ get => default; /* [XID] */ /* 0x00000001898F1CD0-0x00000001898F1CF0 */ private set {} } // 0x00000001814D21A0-0x00000001814D2240 0x00000001814D1D00-0x00000001814D1DB0

	// Constructors
	public ConfigEliteShieldResistance() {} // 0x00000001814D29B0-0x00000001814D2A10

	// Methods
	// [XID] // 0x00000001898F9510-0x00000001898F9530
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001814D2610-0x00000001814D2730
	// [XID] // 0x0000000189900EB0-0x0000000189900ED0
	public void InitEmpty() {} // 0x00000001814D1DB0-0x00000001814D1EA0
	[BlackList] // 0x0000000189908630-0x0000000189908670
	// [XID] // 0x0000000189908630-0x0000000189908670
	public bool FromJson(JSONNode node) => default; // 0x00000001814D1980-0x00000001814D1D00
	// [XID] // 0x00000001899130C0-0x00000001899130E0
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001814D0D00-0x00000001814D10B0
	// [XID] // 0x000000018991A8B0-0x000000018991A8D0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B45 */, bool useObjectPool = false /* Metadata: 0x00AF8B49 */) => default; // 0x00000001814D1EA0-0x00000001814D21A0
	// [XID] // 0x00000001899220A0-0x00000001899220C0
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8B4A */, bool useObjectPool = false /* Metadata: 0x00AF8B4E */) => default; // 0x00000001814D14D0-0x00000001814D1830
	[BlackList] // 0x0000000189929800-0x0000000189929840
	// [XID] // 0x0000000189929800-0x0000000189929840
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001814D10B0-0x00000001814D1380
	// [XID] // 0x0000000189933B80-0x0000000189933BA0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001814D22F0-0x00000001814D2610
	[BlackList] // 0x000000018993B770-0x000000018993B7B0
	// [XID] // 0x000000018993B770-0x000000018993B7B0
	public virtual void AutoAllocTypeFields() {} // 0x00000001814D1380-0x00000001814D1420
	[BlackList] // 0x0000000189945B60-0x0000000189945BA0
	// [XID] // 0x0000000189945B60-0x0000000189945BA0
	public virtual void AutoRecycleTypeFields() {} // 0x00000001814D1420-0x00000001814D14D0
	[BlackList] // 0x00000001899502B0-0x00000001899502F0
	// [XID] // 0x00000001899502B0-0x00000001899502F0
	public virtual void ReturnToObjectPool() {} // 0x00000001814D2910-0x00000001814D29B0
	[BlackList] // 0x000000018995A8F0-0x000000018995A930
	// [XID] // 0x000000018995A8F0-0x000000018995A930
	public virtual void OnPoolAllocated() {} // 0x00000001814D27D0-0x00000001814D2870
	[BlackList] // 0x00000001899652B0-0x00000001899652F0
	// [XID] // 0x00000001899652B0-0x00000001899652F0
	public virtual void OnBeforePoolRecycled() {} // 0x00000001814D2730-0x00000001814D27D0
}

