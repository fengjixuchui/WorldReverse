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
public class DynamicInt : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14794
{
	// Fields
	private static Dictionary<float, DynamicInt> _defaultValueDict; // 0x00
	private bool _isDynamic; // 0x10
	private string _dynamicKey; // 0x18
	private SimpleSafeInt32 fixedValueRawNum; // 0x20

	// Properties
	public bool isDynamic { /* [XID] */ /* 0x000000018980A2F0-0x000000018980A310 */ get => default; /* [XID] */ /* 0x0000000189811A60-0x0000000189811A80 */ private set {} } // 0x0000000182EE8310-0x0000000182EE83B0 0x0000000182EE8260-0x0000000182EE8310
	public string dynamicKey { /* [XID] */ /* 0x0000000189819670-0x0000000189819690 */ get => default; /* [XID] */ /* 0x0000000189820D70-0x0000000189820D90 */ private set {} } // 0x0000000182EE87E0-0x0000000182EE8880 0x0000000182EE8730-0x0000000182EE87E0
	public int fixedValue { /* [XID] */ /* 0x0000000189828380-0x00000001898283A0 */ get => default; /* [XID] */ /* 0x000000018982F680-0x000000018982F6A0 */ private set {} } // 0x0000000182EE8190-0x0000000182EE8260 0x0000000182EE8650-0x0000000182EE8730

	// Constructors
	public DynamicInt() {} // 0x0000000182EE8C10-0x0000000182EE8CA0
	static DynamicInt() {} // 0x0000000182EE8B80-0x0000000182EE8C10

	// Methods
	// [XID] // 0x00000001897EC600-0x00000001897EC620
	public bool FromJson(JSONNode node) => default; // 0x0000000182EE7F70-0x0000000182EE8190
	// [XID] // 0x00000001897F3F70-0x00000001897F3F90
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF5C0 */, bool useObjectPool = false /* Metadata: 0x00AEF5C4 */) => default; // 0x0000000182EE84B0-0x0000000182EE8650
	// [XID] // 0x00000001897FB930-0x00000001897FB950
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000182EE7AA0-0x0000000182EE7C20
	// [XID] // 0x0000000189802D60-0x0000000189802D80
	public static implicit operator DynamicInt(int fixedValue) => default; // 0x0000000182EE76B0-0x0000000182EE7AA0
	// [XID] // 0x0000000189836FB0-0x0000000189836FD0
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000182EE8880-0x0000000182EE89A0
	// [XID] // 0x000000018983E3A0-0x000000018983E3C0
	public void Copy(DynamicInt other) {} // 0x0000000182EE7E60-0x0000000182EE7F70
	// [XID] // 0x0000000189845B70-0x0000000189845B90
	public void Reset() {} // 0x0000000182EE7D90-0x0000000182EE7E60
	// [XID] // 0x000000018984D0A0-0x000000018984D0C0
	public void InitEmpty() {} // 0x0000000182EE83B0-0x0000000182EE84B0
	[BlackList] // 0x00000001898541E0-0x0000000189854220
	// [XID] // 0x00000001898541E0-0x0000000189854220
	public virtual void AutoAllocTypeFields() {} // 0x0000000182EE7C20-0x0000000182EE7CC0
	[BlackList] // 0x000000018985E350-0x000000018985E390
	// [XID] // 0x000000018985E350-0x000000018985E390
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182EE7CC0-0x0000000182EE7D90
	[BlackList] // 0x0000000189868E10-0x0000000189868E50
	// [XID] // 0x0000000189868E10-0x0000000189868E50
	public virtual void ReturnToObjectPool() {} // 0x0000000182EE8AE0-0x0000000182EE8B80
	[BlackList] // 0x0000000189873150-0x0000000189873190
	// [XID] // 0x0000000189873150-0x0000000189873190
	public virtual void OnPoolAllocated() {} // 0x0000000182EE8A40-0x0000000182EE8AE0
	[BlackList] // 0x000000018987DD80-0x000000018987DDC0
	// [XID] // 0x000000018987DD80-0x000000018987DDC0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182EE89A0-0x0000000182EE8A40
}

