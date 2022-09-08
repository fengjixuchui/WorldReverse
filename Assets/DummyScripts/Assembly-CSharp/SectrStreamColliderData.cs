/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using miHoYoThread;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SectrStreamColliderData : ITaskData // TypeDefIndex: 26629
{
	// Fields
	private static int _nextDataId; // 0x00
	public const int staticTypeId = 11; // Metadata: 0x00B0C73C
	private int _uid; // 0x14
	private int _groupId; // 0x18
	private SECTR_ThreadContext _context; // 0x20
	private SECTR_World _curWorld; // 0x28
	private Stopwatch stopWatch; // 0x30

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x0000000189B85F60-0x0000000189B85F80 */ get => default; } // 0x00000001817CE2C0-0x00000001817CE390 
	public int nodeIndex { /* [XID] */ /* 0x0000000189B8CFB0-0x0000000189B8CFF0 */ get; /* [XID] */ /* 0x0000000189B97660-0x0000000189B976A0 */ set; } // 0x00000001817CE520-0x00000001817CE580 0x00000001817CE6C0-0x00000001817CE720
	public int typeId { /* [XID] */ /* 0x0000000189BA1CD0-0x0000000189BA1CF0 */ get => default; } // 0x00000001817CE580-0x00000001817CE620 
	public int uid { /* [XID] */ /* 0x0000000189BC2CB0-0x0000000189BC2CD0 */ get => default; } // 0x00000001817CE620-0x00000001817CE6C0 

	// Constructors
	public SectrStreamColliderData() {} // 0x00000001817CE490-0x00000001817CE520
	static SectrStreamColliderData() {} // 0x00000001817CE430-0x00000001817CE490

	// Methods
	// [IDTag] // 0x0000000189BA9070-0x0000000189BA90B0
	// [XID] // 0x0000000189BA9070-0x0000000189BA90B0
	public void Init() {} // 0x00000001817CE150-0x00000001817CE210
	// [XID] // 0x0000000189BB3680-0x0000000189BB36A0
	public void Write() {} // 0x00000001817CE390-0x00000001817CE430
	// [XID] // 0x0000000189BBACC0-0x0000000189BBACE0
	public void Free() {} // 0x00000001817CDAA0-0x00000001817CDB50
	// [XID] // 0x0000000189BCA380-0x0000000189BCA3A0
	private void Clear() {} // 0x00000001817CDB50-0x00000001817CDBF0
	// [XID] // 0x0000000189BD1A30-0x0000000189BD1A50
	public void SetCurWorld(SECTR_World world) {} // 0x00000001817CE0A0-0x00000001817CE150
	// [IDTag] // 0x0000000189BD9020-0x0000000189BD9060
	// [XID] // 0x0000000189BD9020-0x0000000189BD9060
	public void Init(int g, SECTR_ThreadContext t) {} // 0x00000001817CD9C0-0x00000001817CDAA0
	// [XID] // 0x00000001895E8B90-0x00000001895E8BB0
	public void Update(int index) {} // 0x00000001817CDBF0-0x00000001817CE0A0
	// [XID] // 0x00000001895F0420-0x00000001895F0440
	public void Flush(int index) {} // 0x00000001817CE210-0x00000001817CE2C0
}

