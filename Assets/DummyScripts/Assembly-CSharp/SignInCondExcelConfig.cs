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
public class SignInCondExcelConfig : IAutoAllocRecycle // TypeDefIndex: 16158
{
	// Fields
	protected SimpleSafeUInt32 configIdRawNum; // 0x10
	protected LogicType _condComb; // 0x14
	// [PooledField] // 0x0000000189B003D0-0x0000000189B003F0
	protected SignInCondConfig[] _condList; // 0x18
	protected SimpleSafeUInt32 totalDayCountRawNum; // 0x20

	// Properties
	public uint configId { /* [XID] */ /* 0x0000000189851530-0x0000000189851550 */ get => default; /* [XID] */ /* 0x0000000189858A60-0x0000000189858A80 */ protected set {} } // 0x0000000185B3A720-0x0000000185B3A7F0 0x0000000185B3AE30-0x0000000185B3AF10
	public LogicType condComb { /* [XID] */ /* 0x000000018985FBD0-0x000000018985FBF0 */ get => default; /* [XID] */ /* 0x00000001898672F0-0x0000000189867310 */ protected set {} } // 0x0000000185B3AF10-0x0000000185B3AFB0 0x0000000185B3ACA0-0x0000000185B3AD50
	public SignInCondConfig[] condList { /* [XID] */ /* 0x000000018986EA50-0x000000018986EA70 */ get => default; /* [XID] */ /* 0x0000000189875F60-0x0000000189875F80 */ protected set {} } // 0x0000000185B39AD0-0x0000000185B39B70 0x0000000185B39DD0-0x0000000185B39E80
	public uint totalDayCount { /* [XID] */ /* 0x000000018987DB20-0x000000018987DB40 */ get => default; /* [XID] */ /* 0x00000001898849D0-0x00000001898849F0 */ protected set {} } // 0x0000000185B39D00-0x0000000185B39DD0 0x0000000185B3AD50-0x0000000185B3AE30

	// Constructors
	public SignInCondExcelConfig() {} // 0x0000000185B3B190-0x0000000185B3B1F0

	// Methods
	// [IDTag] // 0x000000018988C040-0x000000018988C080
	// [XID] // 0x000000018988C040-0x000000018988C080
	public virtual bool ParseFromLine(string line) => default; // 0x0000000185B39E80-0x0000000185B3A320
	// [IDTag] // 0x0000000189896380-0x00000001898963C0
	// [XID] // 0x0000000189896380-0x00000001898963C0
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000185B3A320-0x0000000185B3A720
	// [XID] // 0x00000001898A0790-0x00000001898A07B0
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF32D6 */, bool useObjectPool = false /* Metadata: 0x00AF32DA */) => default; // 0x0000000185B3A7F0-0x0000000185B3ACA0
	[BlackList] // 0x00000001898A7F50-0x00000001898A7F90
	// [XID] // 0x00000001898A7F50-0x00000001898A7F90
	public virtual void AutoAllocTypeFields() {} // 0x0000000185B39B70-0x0000000185B39C10
	[BlackList] // 0x00000001898B26D0-0x00000001898B2710
	// [XID] // 0x00000001898B26D0-0x00000001898B2710
	public virtual void AutoRecycleTypeFields() {} // 0x0000000185B39C10-0x0000000185B39D00
	[BlackList] // 0x00000001898BD260-0x00000001898BD2A0
	// [XID] // 0x00000001898BD260-0x00000001898BD2A0
	public virtual void ReturnToObjectPool() {} // 0x0000000185B3B0F0-0x0000000185B3B190
	[BlackList] // 0x00000001898C7940-0x00000001898C7980
	// [XID] // 0x00000001898C7940-0x00000001898C7980
	public virtual void OnPoolAllocated() {} // 0x0000000185B3B050-0x0000000185B3B0F0
	[BlackList] // 0x00000001898D1FB0-0x00000001898D1FF0
	// [XID] // 0x00000001898D1FB0-0x00000001898D1FF0
	public virtual void OnBeforePoolRecycled() {} // 0x0000000185B3AFB0-0x0000000185B3B050
}

