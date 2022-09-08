/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class PositionReminder // TypeDefIndex: 11246
{
	// Fields
	private const int REMINDER_DELAY = 30; // Metadata: 0x00AE9526
	private const int COUNT_LIMIT = 6; // Metadata: 0x00AE952A
	private readonly RecycledLinkedList<Record> _list; // 0x10

	// Nested types
	private struct Record // TypeDefIndex: 11247
	{
		// Properties
		public IMonoAudioDispositioned mono { /* [XID] */ /* 0x0000000189B82590-0x0000000189B825D0 */ get; /* [XID] */ /* 0x0000000189B8C6B0-0x0000000189B8C6F0 */ set; } // 0x00000001832B1DE0-0x00000001832B1E40 0x00000001832B1D80-0x00000001832B1DE0
		public int dueFrame { /* [XID] */ /* 0x000000018975EFB0-0x000000018975EFF0 */ get; /* [XID] */ /* 0x0000000189BA1320-0x0000000189BA1360 */ set; } // 0x00000001832B1EA0-0x00000001832B1F20 0x00000001832B1E40-0x00000001832B1EA0
	}

	// Constructors
	public PositionReminder() {} // 0x00000001832A25D0-0x00000001832A2660

	// Methods
	// [XID] // 0x0000000189B4FBB0-0x0000000189B4FBD0
	public void Register(IMonoAudioDispositioned mono) {} // 0x00000001832A2460-0x00000001832A25D0
	// [XID] // 0x0000000189BAD220-0x0000000189BAD240
	public void Unregister(IMonoAudioDispositioned mono) {} // 0x00000001832A2120-0x00000001832A2460
	// [XID] // 0x0000000189B5ECA0-0x0000000189B5ECC0
	public void Tick() {} // 0x00000001832A1E40-0x00000001832A2070
	// [XID] // 0x0000000189A2E450-0x0000000189A2E470
	public void Clear() {} // 0x00000001832A2070-0x00000001832A2120
}

