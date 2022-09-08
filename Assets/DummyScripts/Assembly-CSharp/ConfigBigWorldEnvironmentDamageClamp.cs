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
public class ConfigBigWorldEnvironmentDamageClamp : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 18123
{
	// Fields
	private SimpleSafeInt32 reduceLevelRawNum; // 0x10
	private SimpleSafeInt32 worldLevelCutThreshholdRawNum; // 0x14

	// Properties
	public int reduceLevel { /* [XID] */ /* 0x000000018992A1A0-0x000000018992A1C0 */ get => default; /* [XID] */ /* 0x0000000189990C30-0x0000000189990C50 */ private set {} } // 0x0000000182C63770-0x0000000182C63840 0x0000000182C63020-0x0000000182C63100
	public int worldLevelCutThreshhold { /* [XID] */ /* 0x0000000189998730-0x0000000189998750 */ get => default; /* [XID] */ /* 0x000000018999FFD0-0x000000018999FFF0 */ private set {} } // 0x0000000182C63400-0x0000000182C634D0 0x0000000182C62890-0x0000000182C62970

	// Constructors
	public ConfigBigWorldEnvironmentDamageClamp() {} // 0x0000000182C63B30-0x0000000182C63BD0

	// Methods
	// [XID] // 0x00000001899A7B60-0x00000001899A7B80
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182C63840-0x0000000182C63950
	// [XID] // 0x00000001899AF370-0x00000001899AF390
	public void InitEmpty() {} // 0x0000000182C62F40-0x0000000182C63020
	[BlackList] // 0x00000001899B67D0-0x00000001899B6810
	// [XID] // 0x00000001899B67D0-0x00000001899B6810
	public bool FromJson(JSONNode node) => default; // 0x0000000182C62BC0-0x0000000182C62F40
	// [XID] // 0x00000001899C1270-0x00000001899C1290
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182C62150-0x0000000182C62440
	// [XID] // 0x00000001899C8880-0x00000001899C88A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8BE5 */, bool useObjectPool = false /* Metadata: 0x00AF8BE9 */) => default; // 0x0000000182C63100-0x0000000182C63400
	// [XID] // 0x00000001899D0270-0x00000001899D0290
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8BEA */, bool useObjectPool = false /* Metadata: 0x00AF8BEE */) => default; // 0x0000000182C62970-0x0000000182C62BC0
	[BlackList] // 0x00000001899D7710-0x00000001899D7750
	// [XID] // 0x00000001899D7710-0x00000001899D7750
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182C62440-0x0000000182C62710
	// [XID] // 0x00000001899E2040-0x00000001899E2060
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182C634D0-0x0000000182C63770
	[BlackList] // 0x00000001899E94E0-0x00000001899E9520
	// [XID] // 0x00000001899E94E0-0x00000001899E9520
	public virtual void AutoAllocTypeFields() {} // 0x0000000182C62710-0x0000000182C627B0
	[BlackList] // 0x00000001899F41B0-0x00000001899F41F0
	// [XID] // 0x00000001899F41B0-0x00000001899F41F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182C627B0-0x0000000182C62890
	[BlackList] // 0x00000001899FE530-0x00000001899FE570
	// [XID] // 0x00000001899FE530-0x00000001899FE570
	public virtual void ReturnToObjectPool() {} // 0x0000000182C63A90-0x0000000182C63B30
	[BlackList] // 0x0000000189A08A10-0x0000000189A08A50
	// [XID] // 0x0000000189A08A10-0x0000000189A08A50
	public virtual void OnPoolAllocated() {} // 0x0000000182C639F0-0x0000000182C63A90
	[BlackList] // 0x0000000189A131A0-0x0000000189A131E0
	// [XID] // 0x0000000189A131A0-0x0000000189A131E0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182C63950-0x0000000182C639F0
}

