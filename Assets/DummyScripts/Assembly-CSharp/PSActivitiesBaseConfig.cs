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
public class PSActivitiesBaseConfig : IAutoAllocRecycle // TypeDefIndex: 15956
{
	// Fields
	protected SimpleSafeUInt32 IDRawNum; // 0x10
	protected string _objectID; // 0x18

	// Properties
	public uint ID { /* [XID] */ /* 0x00000001897E76D0-0x00000001897E76F0 */ get => default; /* [XID] */ /* 0x00000001897EF2B0-0x00000001897EF2D0 */ protected set {} } // 0x0000000182799A60-0x0000000182799B30 0x00000001827995E0-0x00000001827996C0
	public string objectID { /* [XID] */ /* 0x00000001897F68E0-0x00000001897F6900 */ get => default; /* [XID] */ /* 0x00000001897FDFE0-0x00000001897FE000 */ protected set {} } // 0x000000018279A090-0x000000018279A130 0x0000000182799B30-0x0000000182799BE0

	// Constructors
	public PSActivitiesBaseConfig() {} // 0x000000018279A1D0-0x000000018279A230

	// Methods
	// [XID] // 0x00000001898057B0-0x00000001898057D0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000182799840-0x0000000182799A60
	// [XID] // 0x000000018980CE10-0x000000018980CE30
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF2C34 */, bool useObjectPool = false /* Metadata: 0x00AF2C38 */) => default; // 0x0000000182799BE0-0x0000000182799F50
	[BlackList] // 0x00000001898145F0-0x0000000189814630
	// [XID] // 0x00000001898145F0-0x0000000189814630
	public virtual void AutoAllocTypeFields() {} // 0x00000001827996C0-0x0000000182799760
	[BlackList] // 0x000000018981F1A0-0x000000018981F1E0
	// [XID] // 0x000000018981F1A0-0x000000018981F1E0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000182799760-0x0000000182799840
	[BlackList] // 0x0000000189829710-0x0000000189829750
	// [XID] // 0x0000000189829710-0x0000000189829750
	public virtual void ReturnToObjectPool() {} // 0x000000018279A130-0x000000018279A1D0
	[BlackList] // 0x0000000189833D00-0x0000000189833D40
	// [XID] // 0x0000000189833D00-0x0000000189833D40
	public virtual void OnPoolAllocated() {} // 0x0000000182799FF0-0x000000018279A090
	[BlackList] // 0x000000018983E020-0x000000018983E060
	// [XID] // 0x000000018983E020-0x000000018983E060
	public virtual void OnBeforePoolRecycled() {} // 0x0000000182799F50-0x0000000182799FF0
}

