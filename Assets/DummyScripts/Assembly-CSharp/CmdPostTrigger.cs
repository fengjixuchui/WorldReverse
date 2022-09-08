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

public sealed class CmdPostTrigger : ReusedAudioCmd // TypeDefIndex: 10838
{
	// Fields
	private uint _hashId; // 0x10
	private SyncId _syncId; // 0x18

	// Nested types
	public class Spawner : ISpawner<CmdPostTrigger, uint, SyncId> // TypeDefIndex: 10839
	{
		// Constructors
		public Spawner() {} // 0x0000000183793610-0x0000000183793670

		// Methods
		// [XID] // 0x0000000189764A70-0x0000000189764A90
		public CmdPostTrigger Spawn(uint param1, SyncId param2) => default; // 0x00000001837934B0-0x0000000183793610
	}

	public class Polisher : IPolisher<CmdPostTrigger, uint, SyncId> // TypeDefIndex: 10840
	{
		// Constructors
		public Polisher() {} // 0x0000000183793780-0x00000001837937E0

		// Methods
		// [XID] // 0x00000001898BC250-0x00000001898BC270
		public void Polish(CmdPostTrigger reused, uint param1, SyncId param2) {} // 0x0000000183793670-0x0000000183793780
	}

	// Constructors
	public CmdPostTrigger() {} // Dummy constructor
	private CmdPostTrigger(uint hashId, SyncId syncId) {} // 0x0000000183788E10-0x0000000183788EA0

	// Methods
	// [XID] // 0x000000018989DFF0-0x000000018989E010
	public override void BeforeRecycle() {} // 0x0000000183788C80-0x0000000183788D60
	// [XID] // 0x00000001898A5A70-0x00000001898A5A90
	public override void Execute(WorkerThreadContext context) {} // 0x0000000183788B90-0x0000000183788C80
	// [XID] // 0x000000018975D420-0x000000018975D440
	public override void Recycle() {} // 0x0000000183788D60-0x0000000183788E10
}

