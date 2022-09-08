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
public class ActivityMistTrialStatisticsListExcelConfig : IAutoAllocRecycle // TypeDefIndex: 15143
{
	// Fields
	protected SimpleSafeUInt32 IdRawNum; // 0x10
	protected SimpleSafeUInt32 scheduleIdRawNum; // 0x14
	protected MistTrialStatisticType _statName; // 0x18
	protected string[] _param; // 0x20

	// Properties
	public uint Id { /* [XID] */ /* 0x0000000189B02190-0x0000000189B021B0 */ get => default; /* [XID] */ /* 0x0000000189B095D0-0x0000000189B095F0 */ protected set {} } // 0x0000000184B4ADE0-0x0000000184B4AEB0 0x0000000184B4B4F0-0x0000000184B4B5D0
	public uint scheduleId { /* [XID] */ /* 0x0000000189B11170-0x0000000189B11190 */ get => default; /* [XID] */ /* 0x0000000189B183A0-0x0000000189B183C0 */ protected set {} } // 0x0000000184B4A2E0-0x0000000184B4A3B0 0x0000000184B4B410-0x0000000184B4B4F0
	public MistTrialStatisticType statName { /* [XID] */ /* 0x0000000189B1FA80-0x0000000189B1FAA0 */ get => default; /* [XID] */ /* 0x0000000189B27280-0x0000000189B272A0 */ protected set {} } // 0x0000000184B4B7C0-0x0000000184B4B860 0x0000000184B4AEB0-0x0000000184B4AF60
	public string[] param { /* [XID] */ /* 0x0000000189B2E410-0x0000000189B2E430 */ get => default; /* [XID] */ /* 0x0000000189B35900-0x0000000189B35920 */ protected set {} } // 0x0000000184B4B860-0x0000000184B4B900 0x0000000184B4B710-0x0000000184B4B7C0

	// Constructors
	public ActivityMistTrialStatisticsListExcelConfig() {} // 0x0000000184B4B9A0-0x0000000184B4BA00

	// Methods
	// [IDTag] // 0x0000000189B3D0A0-0x0000000189B3D0E0
	// [XID] // 0x0000000189B3D0A0-0x0000000189B3D0E0
	public virtual bool ParseFromLine(string line) => default; // 0x0000000184B4A970-0x0000000184B4ADE0
	// [IDTag] // 0x0000000189B47D20-0x0000000189B47D60
	// [XID] // 0x0000000189B47D20-0x0000000189B47D60
	public virtual bool ParseFromLine(string[] words, ref int index) => default; // 0x0000000184B4A540-0x0000000184B4A970
	// [XID] // 0x0000000189B52420-0x0000000189B52440
	public virtual bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF0212 */, bool useObjectPool = false /* Metadata: 0x00AF0216 */) => default; // 0x0000000184B4AF60-0x0000000184B4B410
	[BlackList] // 0x0000000189B59DC0-0x0000000189B59E00
	// [XID] // 0x0000000189B59DC0-0x0000000189B59E00
	public virtual void AutoAllocTypeFields() {} // 0x0000000184B4A3B0-0x0000000184B4A450
	[BlackList] // 0x0000000189B645B0-0x0000000189B645F0
	// [XID] // 0x0000000189B645B0-0x0000000189B645F0
	public virtual void AutoRecycleTypeFields() {} // 0x0000000184B4A450-0x0000000184B4A540
	[BlackList] // 0x0000000189B6EA00-0x0000000189B6EA40
	// [XID] // 0x0000000189B6EA00-0x0000000189B6EA40
	public virtual void ReturnToObjectPool() {} // 0x0000000184B4B900-0x0000000184B4B9A0
	[BlackList] // 0x0000000189B790C0-0x0000000189B79100
	// [XID] // 0x0000000189B790C0-0x0000000189B79100
	public virtual void OnPoolAllocated() {} // 0x0000000184B4B670-0x0000000184B4B710
	[BlackList] // 0x0000000189B839C0-0x0000000189B83A00
	// [XID] // 0x0000000189B839C0-0x0000000189B83A00
	public virtual void OnBeforePoolRecycled() {} // 0x0000000184B4B5D0-0x0000000184B4B670
}

