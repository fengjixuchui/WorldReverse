/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class SharedByThreads // TypeDefIndex: 11219
{
	// Fields
	private const int TIME_LIMIT = 1; // Metadata: 0x00AE949D
	private readonly object _syncRoot; // 0x10

	// Nested types
	public struct SyncLock : IDisposable // TypeDefIndex: 11220
	{
		// Fields
		private readonly object _syncRoot; // 0x00

		// Properties
		public bool success { /* [XID] */ /* 0x000000018961CB80-0x000000018961CBC0 */ get; /* [XID] */ /* 0x0000000189626F10-0x0000000189626F50 */ set; } // 0x0000000184773500-0x0000000184773560 0x0000000184773560-0x00000001847735C0

		// Constructors
		public SyncLock(object syncRoot) : this() {
			_syncRoot = default;
		} // 0x00000001847735C0-0x0000000184773710

		// Methods
		// [XID] // 0x0000000189784390-0x00000001897843B0
		public void Dispose() {} // 0x0000000184773490-0x0000000184773500
	}

	// Constructors
	public SharedByThreads() {} // 0x0000000184779520-0x00000001847795B0

	// Methods
	// [XID] // 0x000000018960AD00-0x000000018960AD20
	public SyncLock TrySyncDo() => default; // 0x00000001847793A0-0x0000000184779520
}

