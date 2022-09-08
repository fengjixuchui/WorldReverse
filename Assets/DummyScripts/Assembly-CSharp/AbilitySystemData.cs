/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class AbilitySystemData : ITaskData // TypeDefIndex: 26562
{
	// Fields
	private static int _nextDataId; // 0x00
	public const int staticTypeId = 21; // Metadata: 0x00B0C4DC
	private int _uid; // 0x14
	private IndexHandleObjectList<IAbilityExecute> _executes; // 0x18

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x0000000189B92F80-0x0000000189B92FA0 */ get => default; } // 0x0000000181C2F730-0x0000000181C2F860 
	public int nodeIndex { /* [XID] */ /* 0x0000000189B9A560-0x0000000189B9A5A0 */ get; /* [XID] */ /* 0x0000000189BA4CB0-0x0000000189BA4CF0 */ set; } // 0x0000000181C2FAA0-0x0000000181C2FB00 0x0000000181C2FC40-0x0000000181C2FCA0
	public int typeId { /* [XID] */ /* 0x0000000189BAEE50-0x0000000189BAEE70 */ get => default; } // 0x0000000181C2FB00-0x0000000181C2FBA0 
	public int uid { /* [XID] */ /* 0x0000000189BCD320-0x0000000189BCD340 */ get => default; } // 0x0000000181C2FBA0-0x0000000181C2FC40 

	// Constructors
	public AbilitySystemData() {} // 0x0000000181C2FA00-0x0000000181C2FAA0
	static AbilitySystemData() {} // 0x0000000181C2F9A0-0x0000000181C2FA00

	// Methods
	// [XID] // 0x0000000189BB6500-0x0000000189BB6520
	public void Init() {} // 0x0000000181C2F670-0x0000000181C2F730
	// [XID] // 0x0000000189BBDB80-0x0000000189BBDBA0
	public void Write() {} // 0x0000000181C2F900-0x0000000181C2F9A0
	// [XID] // 0x0000000189BC5880-0x0000000189BC58A0
	public void Free() {} // 0x0000000181C2F410-0x0000000181C2F4C0
	// [XID] // 0x0000000189BD47E0-0x0000000189BD4800
	public IndexHandleObjectList<IAbilityExecute> GetExecutes() => default; // 0x0000000181C2F860-0x0000000181C2F900
	// [XID] // 0x0000000189BDC350-0x0000000189BDC370
	public void AddExecute(IAbilityExecute execute) {} // 0x0000000181C2F570-0x0000000181C2F670
	// [XID] // 0x00000001895E8BB0-0x00000001895E8BD0
	public void RemoveExecute(IAbilityExecute execute) {} // 0x0000000181C2F250-0x0000000181C2F350
	// [XID] // 0x00000001895F0440-0x00000001895F0460
	public bool HasExecute() => default; // 0x0000000181C2F350-0x0000000181C2F410
	// [XID] // 0x00000001895F7E90-0x00000001895F7EB0
	private void Clear() {} // 0x0000000181C2F4C0-0x0000000181C2F570
}

