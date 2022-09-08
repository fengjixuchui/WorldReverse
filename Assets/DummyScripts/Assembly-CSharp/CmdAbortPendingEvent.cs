/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CmdAbortPendingEvent : ReusedAudioCmd // TypeDefIndex: 10791
{
	// Fields
	private uint _postId; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdAbortPendingEvent, uint> // TypeDefIndex: 10792
	{
		// Constructors
		public Spawner() {} // 0x00000001840C6350-0x00000001840C63B0

		// Methods
		// [XID] // 0x0000000189658850-0x0000000189658870
		public CmdAbortPendingEvent Spawn(uint param1) => default; // 0x00000001840C6280-0x00000001840C6350
	}

	public class Polisher : IPolisher<CmdAbortPendingEvent, uint> // TypeDefIndex: 10793
	{
		// Constructors
		public Polisher() {} // 0x00000001840E58C0-0x00000001840E59B0

		// Methods
		// [XID] // 0x000000018965FE60-0x000000018965FE80
		public void Polish(CmdAbortPendingEvent reused, uint param1) {} // 0x00000001840E57F0-0x00000001840E58C0
	}

	// Constructors
	public CmdAbortPendingEvent() {} // Dummy constructor
	public CmdAbortPendingEvent(uint postId) {} // 0x00000001840CD720-0x00000001840CD790

	// Methods
	// [XID] // 0x0000000189642210-0x0000000189642230
	public override void BeforeRecycle() {} // 0x00000001840CD5D0-0x00000001840CD670
	// [XID] // 0x0000000189649A20-0x0000000189649A40
	public override void Execute(WorkerThreadContext context) {} // 0x00000001840CD4F0-0x00000001840CD5D0
	// [XID] // 0x0000000189634DC0-0x0000000189634DE0
	public override void Recycle() {} // 0x00000001840CD670-0x00000001840CD720
}

