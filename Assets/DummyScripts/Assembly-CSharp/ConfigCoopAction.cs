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
public class ConfigCoopAction : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17745
{
	// Fields
	private CoopActionType _actionType; // 0x10
	private int[] _param; // 0x18

	// Properties
	public CoopActionType actionType { /* [XID] */ /* 0x000000018985DCF0-0x000000018985DD10 */ get => default; /* [XID] */ /* 0x0000000189865790-0x00000001898657B0 */ private set {} } // 0x0000000182D0B090-0x0000000182D0B130 0x0000000182D0A5F0-0x0000000182D0A6A0
	public int[] param { /* [XID] */ /* 0x000000018986CC50-0x000000018986CC70 */ get => default; /* [XID] */ /* 0x00000001898740E0-0x0000000189874100 */ private set {} } // 0x0000000182D0B6A0-0x0000000182D0B740 0x0000000182D0B5F0-0x0000000182D0B6A0

	// Constructors
	public ConfigCoopAction() {} // 0x0000000182D0B7E0-0x0000000182D0B840

	// Methods
	// [XID] // 0x000000018987BC00-0x000000018987BC20
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182D0B3A0-0x0000000182D0B4B0
	// [XID] // 0x0000000189882D90-0x0000000189882DB0
	public void InitEmpty() {} // 0x0000000182D0ACC0-0x0000000182D0AD90
	[BlackList] // 0x000000018988A5D0-0x000000018988A610
	// [XID] // 0x000000018988A5D0-0x000000018988A610
	public bool FromJson(JSONNode node) => default; // 0x0000000182D0A940-0x0000000182D0ACC0
	// [XID] // 0x0000000189894AB0-0x0000000189894AD0
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000182D09F20-0x0000000182D0A1E0
	// [XID] // 0x000000018989C040-0x000000018989C060
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7AB1 */, bool useObjectPool = false /* Metadata: 0x00AF7AB5 */) => default; // 0x0000000182D0AD90-0x0000000182D0B090
	// [XID] // 0x00000001898A36E0-0x00000001898A3700
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7AB6 */, bool useObjectPool = false /* Metadata: 0x00AF7ABA */) => default; // 0x0000000182D0A6A0-0x0000000182D0A940
	[BlackList] // 0x00000001898AAB00-0x00000001898AAB40
	// [XID] // 0x00000001898AAB00-0x00000001898AAB40
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182D0A1E0-0x0000000182D0A4B0
	// [XID] // 0x00000001898B5450-0x00000001898B5470
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000182D0B130-0x0000000182D0B3A0
	[BlackList] // 0x00000001898BCF00-0x00000001898BCF40
	// [XID] // 0x00000001898BCF00-0x00000001898BCF40
	public virtual void AutoAllocTypeFields() {} // 0x0000000182D0A4B0-0x0000000182D0A550
	[BlackList] // 0x00000001898C7640-0x00000001898C7680
	// [XID] // 0x00000001898C7640-0x00000001898C7680
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182D0A550-0x0000000182D0A5F0
	[BlackList] // 0x00000001898D1D90-0x00000001898D1DD0
	// [XID] // 0x00000001898D1D90-0x00000001898D1DD0
	public virtual void ReturnToObjectPool() {} // 0x0000000182D0B740-0x0000000182D0B7E0
	[BlackList] // 0x00000001898DC750-0x00000001898DC790
	// [XID] // 0x00000001898DC750-0x00000001898DC790
	public virtual void OnPoolAllocated() {} // 0x0000000182D0B550-0x0000000182D0B5F0
	[BlackList] // 0x00000001898E7530-0x00000001898E7570
	// [XID] // 0x00000001898E7530-0x00000001898E7570
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182D0B4B0-0x0000000182D0B550
}

