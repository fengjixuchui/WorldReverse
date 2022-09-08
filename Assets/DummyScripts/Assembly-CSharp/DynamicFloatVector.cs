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
public class DynamicFloatVector : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 17789
{
	// Fields
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _x; // 0x10
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _y; // 0x18
	// [PooledField] // 0x0000000189951E30-0x0000000189951E50
	private DynamicFloat _z; // 0x20

	// Properties
	public DynamicFloat x { /* [XID] */ /* 0x00000001895FB170-0x00000001895FB190 */ get => default; /* [XID] */ /* 0x00000001896028D0-0x00000001896028F0 */ private set {} } // 0x0000000183AB0B60-0x0000000183AB0C00 0x0000000183AB10A0-0x0000000183AB1150
	public DynamicFloat y { /* [XID] */ /* 0x000000018960A270-0x000000018960A290 */ get => default; /* [XID] */ /* 0x00000001896119E0-0x0000000189611A00 */ private set {} } // 0x0000000183AB0690-0x0000000183AB0730 0x0000000183AB1150-0x0000000183AB1200
	public DynamicFloat z { /* [XID] */ /* 0x0000000189619360-0x0000000189619380 */ get => default; /* [XID] */ /* 0x0000000189620920-0x0000000189620940 */ private set {} } // 0x0000000183AB0C00-0x0000000183AB0CA0 0x0000000183AB0730-0x0000000183AB07E0

	// Constructors
	public DynamicFloatVector() {} // 0x0000000183AB1840-0x0000000183AB18A0

	// Methods
	// [XID] // 0x0000000189627E70-0x0000000189627E90
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000183AB1530-0x0000000183AB1660
	// [XID] // 0x000000018962F760-0x000000018962F780
	public void InitEmpty() {} // 0x0000000183AB0CA0-0x0000000183AB0DA0
	[BlackList] // 0x00000001896372C0-0x0000000189637300
	// [XID] // 0x00000001896372C0-0x0000000189637300
	public bool FromJson(JSONNode node) => default; // 0x0000000183AB07E0-0x0000000183AB0B60
	// [XID] // 0x0000000189641740-0x0000000189641760
	private bool InternalFromJson(JSONNode node) => default; // 0x0000000183AAF920-0x0000000183AAFD10
	// [XID] // 0x0000000189649080-0x00000001896490A0
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7C33 */, bool useObjectPool = false /* Metadata: 0x00AF7C37 */) => default; // 0x0000000183AB0DA0-0x0000000183AB10A0
	// [XID] // 0x00000001896506F0-0x0000000189650710
	private bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF7C38 */, bool useObjectPool = false /* Metadata: 0x00AF7C3C */) => default; // 0x0000000183AB02A0-0x0000000183AB0690
	[BlackList] // 0x0000000189658030-0x0000000189658070
	// [XID] // 0x0000000189658030-0x0000000189658070
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000183AAFD10-0x0000000183AAFFE0
	// [XID] // 0x0000000189662460-0x0000000189662480
	private bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000183AB1200-0x0000000183AB1530
	[BlackList] // 0x000000018966A080-0x000000018966A0C0
	// [XID] // 0x000000018966A080-0x000000018966A0C0
	public virtual void AutoAllocTypeFields() {} // 0x0000000183AAFFE0-0x0000000183AB0080
	[BlackList] // 0x0000000189674A70-0x0000000189674AB0
	// [XID] // 0x0000000189674A70-0x0000000189674AB0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183AB0080-0x0000000183AB02A0
	[BlackList] // 0x000000018967F0A0-0x000000018967F0E0
	// [XID] // 0x000000018967F0A0-0x000000018967F0E0
	public virtual void ReturnToObjectPool() {} // 0x0000000183AB17A0-0x0000000183AB1840
	[BlackList] // 0x0000000189689BB0-0x0000000189689BF0
	// [XID] // 0x0000000189689BB0-0x0000000189689BF0
	public virtual void OnPoolAllocated() {} // 0x0000000183AB1700-0x0000000183AB17A0
	[BlackList] // 0x0000000189694780-0x00000001896947C0
	// [XID] // 0x0000000189694780-0x00000001896947C0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183AB1660-0x0000000183AB1700
}

