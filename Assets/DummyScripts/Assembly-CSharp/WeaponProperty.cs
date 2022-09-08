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
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[RecycleType] // 0x00000001898C45A0-0x00000001898C45C0
public class WeaponProperty : IAutoAllocRecycle // TypeDefIndex: 16270
{
	// Fields
	protected FightPropType _propType; // 0x10
	protected SimpleSafeFloat initValueRawNum; // 0x14
	protected GrowCurveType _type; // 0x18

	// Properties
	public FightPropType propType { /* [XID] */ /* 0x00000001895F0CC0-0x00000001895F0CE0 */ get => default; /* [XID] */ /* 0x00000001895F8630-0x00000001895F8650 */ protected set {} } // 0x0000000183E465C0-0x0000000183E46660 0x0000000183E46050-0x0000000183E46100
	public float initValue { /* [XID] */ /* 0x00000001895FFAB0-0x00000001895FFAD0 */ get => default; /* [XID] */ /* 0x0000000189607260-0x0000000189607280 */ protected set {} } // 0x0000000183E46920-0x0000000183E46A00 0x0000000183E46660-0x0000000183E46740
	public GrowCurveType type { /* [XID] */ /* 0x000000018960ECE0-0x000000018960ED00 */ get => default; /* [XID] */ /* 0x0000000189616320-0x0000000189616340 */ protected set {} } // 0x0000000183E46880-0x0000000183E46920 0x0000000183E46510-0x0000000183E465C0

	// Constructors
	public WeaponProperty() {} // 0x0000000183E46AA0-0x0000000183E46B00

	// Methods
	// [XID] // 0x000000018961DB90-0x000000018961DBB0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000183E45D80-0x0000000183E46050
	// [XID] // 0x0000000189624FB0-0x0000000189624FD0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF3608 */, bool useObjectPool = false /* Metadata: 0x00AF360C */) => default; // 0x0000000183E46100-0x0000000183E46510
	[BlackList] // 0x000000018962C810-0x000000018962C850
	// [XID] // 0x000000018962C810-0x000000018962C850
	public virtual void AutoAllocTypeFields() {} // 0x0000000183E45C00-0x0000000183E45CA0
	[BlackList] // 0x00000001896375A0-0x00000001896375E0
	// [XID] // 0x00000001896375A0-0x00000001896375E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000183E45CA0-0x0000000183E45D80
	[BlackList] // 0x0000000189641A80-0x0000000189641AC0
	// [XID] // 0x0000000189641A80-0x0000000189641AC0
	public virtual void ReturnToObjectPool() {} // 0x0000000183E46A00-0x0000000183E46AA0
	[BlackList] // 0x000000018964C3F0-0x000000018964C430
	// [XID] // 0x000000018964C3F0-0x000000018964C430
	public virtual void OnPoolAllocated() {} // 0x0000000183E467E0-0x0000000183E46880
	[BlackList] // 0x00000001896569D0-0x0000000189656A10
	// [XID] // 0x00000001896569D0-0x0000000189656A10
	public virtual void OnBeforePoolRecycled() {} // 0x0000000183E46740-0x0000000183E467E0
}

