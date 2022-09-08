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

public class SectrStreamLodData : ITaskData // TypeDefIndex: 26634
{
	// Fields
	private static int _nextDataId; // 0x00
	public const int staticTypeId = 10; // Metadata: 0x00B0C773
	private int _uid; // 0x14
	private int _groupId; // 0x18
	private SECTR_ThreadContext _context; // 0x20
	private SECTR_World _curWorld; // 0x28
	private Stopwatch stopWatch; // 0x30

	// Properties
	public static int nextDataId { /* [XID] */ /* 0x00000001897491E0-0x0000000189749200 */ get => default; } // 0x0000000180F830F0-0x0000000180F831C0 
	public int nodeIndex { /* [XID] */ /* 0x00000001897506F0-0x0000000189750730 */ get; /* [XID] */ /* 0x000000018975A890-0x000000018975A8D0 */ set; } // 0x0000000180F83350-0x0000000180F833B0 0x0000000180F834F0-0x0000000180F83550
	public int typeId { /* [XID] */ /* 0x0000000189765090-0x00000001897650B0 */ get => default; } // 0x0000000180F833B0-0x0000000180F83450 
	public int uid { /* [XID] */ /* 0x0000000189785F50-0x0000000189785F70 */ get => default; } // 0x0000000180F83450-0x0000000180F834F0 

	// Constructors
	public SectrStreamLodData() {} // 0x0000000180F832C0-0x0000000180F83350
	static SectrStreamLodData() {} // 0x0000000180F83260-0x0000000180F832C0

	// Methods
	// [IDTag] // 0x000000018976CA50-0x000000018976CA90
	// [XID] // 0x000000018976CA50-0x000000018976CA90
	public void Init() {} // 0x0000000180F82F80-0x0000000180F83040
	// [XID] // 0x0000000189777040-0x0000000189777060
	public void Write() {} // 0x0000000180F831C0-0x0000000180F83260
	// [XID] // 0x000000018977E760-0x000000018977E780
	public void Free() {} // 0x0000000180F828D0-0x0000000180F82980
	// [XID] // 0x000000018978D610-0x000000018978D630
	private void Clear() {} // 0x0000000180F82980-0x0000000180F82A20
	// [XID] // 0x0000000189794A30-0x0000000189794A50
	public void SetCurWorld(SECTR_World world) {} // 0x0000000180F82ED0-0x0000000180F82F80
	// [IDTag] // 0x000000018979CE90-0x000000018979CED0
	// [XID] // 0x000000018979CE90-0x000000018979CED0
	public void Init(int g, SECTR_ThreadContext t) {} // 0x0000000180F827F0-0x0000000180F828D0
	// [XID] // 0x00000001897A72F0-0x00000001897A7310
	public void Update(int index) {} // 0x0000000180F82A20-0x0000000180F82ED0
	// [XID] // 0x00000001897AEDA0-0x00000001897AEDC0
	public void Flush(int index) {} // 0x0000000180F83040-0x0000000180F830F0
}

