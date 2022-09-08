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

public sealed class CmdRespondToQuestStatusChange : ReusedAudioCmd // TypeDefIndex: 10851
{
	// Fields
	private uint _id; // 0x10
	private QState _state; // 0x14

	// Nested types
	public class Spawner : ISpawner<CmdRespondToQuestStatusChange, uint, QState> // TypeDefIndex: 10852
	{
		// Constructors
		public Spawner() {} // 0x0000000182545E80-0x0000000182545EE0

		// Methods
		// [XID] // 0x00000001899613B0-0x00000001899613D0
		public CmdRespondToQuestStatusChange Spawn(uint param1, QState param2) => default; // 0x0000000182545DA0-0x0000000182545E80
	}

	public class Polisher : IPolisher<CmdRespondToQuestStatusChange, uint, QState> // TypeDefIndex: 10853
	{
		// Constructors
		public Polisher() {} // 0x0000000182525DE0-0x0000000182525E40

		// Methods
		// [XID] // 0x0000000189612520-0x0000000189612540
		public void Polish(CmdRespondToQuestStatusChange reused, uint param1, QState param2) {} // 0x0000000182525D00-0x0000000182525DE0
	}

	// Constructors
	public CmdRespondToQuestStatusChange() {} // Dummy constructor
	private CmdRespondToQuestStatusChange(uint id, QState state) {} // 0x000000018252FEF0-0x000000018252FF70

	// Methods
	// [XID] // 0x000000018989E2D0-0x000000018989E2F0
	public override void BeforeRecycle() {} // 0x000000018252FD90-0x000000018252FE40
	// [XID] // 0x00000001898A5D10-0x00000001898A5D30
	public override void Execute(WorkerThreadContext context) {} // 0x000000018252FCB0-0x000000018252FD90
	// [XID] // 0x0000000189B543B0-0x0000000189B543D0
	public override void Recycle() {} // 0x000000018252FE40-0x000000018252FEF0
}

