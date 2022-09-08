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
public class DynamicArgument : IEmptyInitable, IHashable, IAutoAllocRecycle // TypeDefIndex: 14787
{
	// Fields
	private object _value; // 0x10

	// Properties
	public object value { /* [XID] */ /* 0x000000018962CB90-0x000000018962CBB0 */ get => default; /* [XID] */ /* 0x0000000189634870-0x0000000189634890 */ set {} } // 0x0000000184859900-0x00000001848599A0 0x0000000184859850-0x0000000184859900

	// Constructors
	public DynamicArgument() {} // 0x000000018485A370-0x000000018485A3D0

	// Methods
	// [IDTag] // 0x00000001895EC930-0x00000001895EC970
	// [XID] // 0x00000001895EC930-0x00000001895EC970
	public static explicit operator float(DynamicArgument arg) => default; // 0x00000001848595B0-0x00000001848596A0
	// [IDTag] // 0x00000001895F7280-0x00000001895F72C0
	// [XID] // 0x00000001895F7280-0x00000001895F72C0
	public static explicit operator int(DynamicArgument arg) => default; // 0x00000001848596A0-0x0000000184859780
	// [IDTag] // 0x0000000189601820-0x0000000189601860
	// [XID] // 0x0000000189601820-0x0000000189601860
	public static explicit operator uint(DynamicArgument arg) => default; // 0x00000001848594D0-0x00000001848595B0
	// [IDTag] // 0x000000018960C0C0-0x000000018960C100
	// [XID] // 0x000000018960C0C0-0x000000018960C100
	public static explicit operator string(DynamicArgument arg) => default; // 0x0000000184859780-0x0000000184859850
	// [XID] // 0x00000001899DC840-0x00000001899DC860
	public bool FromJson(JSONNode node) => default; // 0x00000001848599A0-0x0000000184859B70
	// [XID] // 0x0000000189A3D230-0x0000000189A3D250
	public bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AEF5A6 */, bool useObjectPool = false /* Metadata: 0x00AEF5AA */) => default; // 0x0000000184859C40-0x000000018485A0E0
	// [XID] // 0x00000001896253B0-0x00000001896253D0
	public bool ToBinary(ByteArray byteArray) => default; // 0x0000000184858D30-0x0000000184859390
	// [XID] // 0x00000001898EC640-0x00000001898EC660
	public virtual void ObjectContentHashOnto(ref int hash_code) {} // 0x000000018485A0E0-0x000000018485A190
	// [XID] // 0x00000001896436C0-0x00000001896436E0
	public void InitEmpty() {} // 0x0000000184859B70-0x0000000184859C40
	[BlackList] // 0x000000018964ACC0-0x000000018964AD00
	// [XID] // 0x000000018964ACC0-0x000000018964AD00
	public virtual void AutoAllocTypeFields() {} // 0x0000000184859390-0x0000000184859430
	[BlackList] // 0x00000001896555A0-0x00000001896555E0
	// [XID] // 0x00000001896555A0-0x00000001896555E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184859430-0x00000001848594D0
	[BlackList] // 0x000000018965FB00-0x000000018965FB40
	// [XID] // 0x000000018965FB00-0x000000018965FB40
	public virtual void ReturnToObjectPool() {} // 0x000000018485A2D0-0x000000018485A370
	[BlackList] // 0x000000018966A5A0-0x000000018966A5E0
	// [XID] // 0x000000018966A5A0-0x000000018966A5E0
	public virtual void OnPoolAllocated() {} // 0x000000018485A230-0x000000018485A2D0
	[BlackList] // 0x0000000189675230-0x0000000189675270
	// [XID] // 0x0000000189675230-0x0000000189675270
	public virtual void OnBeforePoolRecycled() {} // 0x000000018485A190-0x000000018485A230
}

