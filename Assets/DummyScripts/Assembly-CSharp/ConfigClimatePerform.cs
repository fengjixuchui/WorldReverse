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
public class ConfigClimatePerform : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17649
{
	// Fields
	private SimpleSafeFloat chanceRawNum; // 0x10
	private Dictionary<JsonClimateType, string> _performTriggers; // 0x18

	// Properties
	public float chance { /* [XID] */ /* 0x0000000189A89550-0x0000000189A89570 */ get => default; /* [XID] */ /* 0x0000000189A90D50-0x0000000189A90D70 */ private set {} } // 0x00000001820FC300-0x00000001820FC3E0 0x00000001820FB9F0-0x00000001820FBAD0
	public Dictionary<JsonClimateType, string> performTriggers { /* [XID] */ /* 0x0000000189A98520-0x0000000189A98540 */ get => default; /* [XID] */ /* 0x0000000189A9F910-0x0000000189A9F930 */ private set {} } // 0x00000001820FC8A0-0x00000001820FC940 0x00000001820FBE50-0x00000001820FBF00

	// Constructors
	public ConfigClimatePerform() {} // 0x00000001820FC9E0-0x00000001820FCA40

	// Methods
	// [XID] // 0x0000000189AA7140-0x0000000189AA7160
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x00000001820FC650-0x00000001820FC760
	// [XID] // 0x0000000189AAE7C0-0x0000000189AAE7E0
	public void InitEmpty() {} // 0x00000001820FBF00-0x00000001820FC000
	[BlackList] // 0x0000000189AB6040-0x0000000189AB6080
	// [XID] // 0x0000000189AB6040-0x0000000189AB6080
	public bool FromJson(JSONNode node) => default; // 0x00000001820FBAD0-0x00000001820FBE50
	// [XID] // 0x0000000189AC0AF0-0x0000000189AC0B10
	private bool InternalFromJson(JSONNode node) => default; // 0x00000001820FAFC0-0x00000001820FB2D0
	// [XID] // 0x0000000189AC84D0-0x0000000189AC84F0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7611 */, bool useObjectPool = false /* Metadata: 0x00AF7615 */) => default; // 0x00000001820FC000-0x00000001820FC300
	// [XID] // 0x0000000189ACFC10-0x0000000189ACFC30
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7616 */, bool useObjectPool = false /* Metadata: 0x00AF761A */) => default; // 0x00000001820FB720-0x00000001820FB9F0
	[BlackList] // 0x0000000189AD7960-0x0000000189AD79A0
	// [XID] // 0x0000000189AD7960-0x0000000189AD79A0
	public bool ToBinary(ByteArray byteArray) => default; // 0x00000001820FB2D0-0x00000001820FB5A0
	// [XID] // 0x0000000189AE2180-0x0000000189AE21A0
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x00000001820FC3E0-0x00000001820FC650
	[BlackList] // 0x0000000189AE9A30-0x0000000189AE9A70
	// [XID] // 0x0000000189AE9A30-0x0000000189AE9A70
	public virtual void AutoAllocTypeFields() {} // 0x00000001820FB5A0-0x00000001820FB640
	[BlackList] // 0x0000000189AF4530-0x0000000189AF4570
	// [XID] // 0x0000000189AF4530-0x0000000189AF4570
	public virtual void AutoRecycleTypeFields() {} // 0x00000001820FB640-0x00000001820FB720
	[BlackList] // 0x0000000189AFEC70-0x0000000189AFECB0
	// [XID] // 0x0000000189AFEC70-0x0000000189AFECB0
	public virtual void ReturnToObjectPool() {} // 0x00000001820FC940-0x00000001820FC9E0
	[BlackList] // 0x0000000189B091B0-0x0000000189B091F0
	// [XID] // 0x0000000189B091B0-0x0000000189B091F0
	public virtual void OnPoolAllocated() {} // 0x00000001820FC800-0x00000001820FC8A0
	[BlackList] // 0x0000000189B13830-0x0000000189B13870
	// [XID] // 0x0000000189B13830-0x0000000189B13870
	public virtual void OnBeforePoolRecycled() {} // 0x00000001820FC760-0x00000001820FC800
}

