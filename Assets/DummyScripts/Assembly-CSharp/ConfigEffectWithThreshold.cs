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
public class ConfigEffectWithThreshold : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17920
{
	// Fields
	private SimpleSafeFloat thresholdRawNum; // 0x10
	private string _effectName; // 0x18

	// Properties
	public float threshold { /* [XID] */ /* 0x00000001899BFB90-0x00000001899BFBB0 */ get => default; /* [XID] */ /* 0x00000001899C7330-0x00000001899C7350 */ private set {} } // 0x000000018338CFD0-0x000000018338D0B0 0x000000018338DDB0-0x000000018338DE90
	public string effectName { /* [XID] */ /* 0x00000001899CE900-0x00000001899CE920 */ get => default; /* [XID] */ /* 0x00000001899D6070-0x00000001899D6090 */ private set {} } // 0x000000018338DD10-0x000000018338DDB0 0x000000018338C7F0-0x000000018338C8A0

	// Constructors
	public ConfigEffectWithThreshold() {} // 0x000000018338E180-0x000000018338E210

	// Methods
	// [XID] // 0x00000001899DD500-0x00000001899DD520
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018338DE90-0x000000018338DFA0
	// [XID] // 0x00000001899E5220-0x00000001899E5240
	public void InitEmpty() {} // 0x000000018338D6D0-0x000000018338D7D0
	[BlackList] // 0x00000001899EC590-0x00000001899EC5D0
	// [XID] // 0x00000001899EC590-0x00000001899EC5D0
	public bool FromJson(JSONNode node) => default; // 0x000000018338D350-0x000000018338D6D0
	// [XID] // 0x00000001899F6DD0-0x00000001899F6DF0
	private bool InternalFromJson(JSONNode node) => default; // 0x000000018338C8A0-0x000000018338CB90
	// [XID] // 0x00000001899736F0-0x0000000189973710
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF8209 */, bool useObjectPool = false /* Metadata: 0x00AF820D */) => default; // 0x000000018338D7D0-0x000000018338DAD0
	// [XID] // 0x0000000189A05E50-0x0000000189A05E70
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF820E */, bool useObjectPool = false /* Metadata: 0x00AF8212 */) => default; // 0x000000018338D0B0-0x000000018338D350
	[BlackList] // 0x0000000189A0D180-0x0000000189A0D1C0
	// [XID] // 0x0000000189A0D180-0x0000000189A0D1C0
	public bool ToBinary(ByteArray byteArray) => default; // 0x000000018338CB90-0x000000018338CE60
	// [XID] // 0x0000000189A174F0-0x0000000189A17510
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x000000018338DAD0-0x000000018338DD10
	[BlackList] // 0x0000000189A1EC90-0x0000000189A1ECD0
	// [XID] // 0x0000000189A1EC90-0x0000000189A1ECD0
	public virtual void AutoAllocTypeFields() {} // 0x000000018338CE60-0x000000018338CF00
	[BlackList] // 0x0000000189A290E0-0x0000000189A29120
	// [XID] // 0x0000000189A290E0-0x0000000189A29120
	public virtual void AutoRecycleTypeFields() {} // 0x000000018338CF00-0x000000018338CFD0
	[BlackList] // 0x0000000189A33640-0x0000000189A33680
	// [XID] // 0x0000000189A33640-0x0000000189A33680
	public virtual void ReturnToObjectPool() {} // 0x000000018338E0E0-0x000000018338E180
	[BlackList] // 0x0000000189A3DFD0-0x0000000189A3E010
	// [XID] // 0x0000000189A3DFD0-0x0000000189A3E010
	public virtual void OnPoolAllocated() {} // 0x000000018338E040-0x000000018338E0E0
	[BlackList] // 0x0000000189A48650-0x0000000189A48690
	// [XID] // 0x0000000189A48650-0x0000000189A48690
	public virtual void OnBeforePoolRecycled() {} // 0x000000018338DFA0-0x000000018338E040
}

