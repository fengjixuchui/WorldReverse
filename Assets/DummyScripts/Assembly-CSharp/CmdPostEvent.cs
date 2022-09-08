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

public sealed class CmdPostEvent : ReusedAudioCmd // TypeDefIndex: 10808
{
	// Fields
	private EventParams _params; // 0x10
	private uint _postId; // 0x60

	// Nested types
	public class Spawner : ISpawner<CmdPostEvent, EventParams, uint> // TypeDefIndex: 10809
	{
		// Constructors
		public Spawner() {} // 0x00000001831229E0-0x0000000183122A40

		// Methods
		// [XID] // 0x00000001897306F0-0x0000000189730710
		public CmdPostEvent Spawn(EventParams param1, uint param2) => default; // 0x0000000183122810-0x00000001831229E0
	}

	public class Polisher : IPolisher<CmdPostEvent, EventParams, uint> // TypeDefIndex: 10810
	{
		// Constructors
		public Polisher() {} // 0x0000000183144680-0x00000001831446E0

		// Methods
		// [XID] // 0x0000000189854750-0x0000000189854770
		public void Polish(CmdPostEvent reused, EventParams param1, uint param2) {} // 0x0000000183144540-0x0000000183144680
	}

	// Constructors
	public CmdPostEvent() {} // Dummy constructor
	public CmdPostEvent(EventParams @params, uint postId) {} // 0x0000000183125660-0x0000000183125710

	// Methods
	// [XID] // 0x000000018971A390-0x000000018971A3B0
	public override void BeforeRecycle() {} // 0x00000001831254C0-0x00000001831255B0
	// [XID] // 0x00000001897216A0-0x00000001897216C0
	public override void Execute(WorkerThreadContext context) {} // 0x00000001831253A0-0x00000001831254C0
	// [XID] // 0x00000001898461C0-0x00000001898461E0
	public override void Recycle() {} // 0x00000001831255B0-0x0000000183125660
}

