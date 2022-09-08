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

public sealed class CmdSetState : ReusedAudioCmd // TypeDefIndex: 10917
{
	// Fields
	private uint _hashId; // 0x10
	private uint _value; // 0x14

	// Nested types
	public class Spawner : ISpawner<CmdSetState, uint, uint> // TypeDefIndex: 10918
	{
		// Constructors
		public Spawner() {} // 0x0000000183315260-0x00000001833152C0

		// Methods
		// [XID] // 0x00000001896ACB80-0x00000001896ACBA0
		public CmdSetState Spawn(uint param1, uint param2) => default; // 0x0000000183315180-0x0000000183315260
	}

	public class Polisher : IPolisher<CmdSetState, uint, uint> // TypeDefIndex: 10919
	{
		// Constructors
		public Polisher() {} // 0x0000000183314CB0-0x0000000183314D10

		// Methods
		// [XID] // 0x00000001896B3E10-0x00000001896B3E30
		public void Polish(CmdSetState reused, uint param1, uint param2) {} // 0x0000000183314BD0-0x0000000183314CB0
	}

	// Constructors
	public CmdSetState() {} // Dummy constructor
	private CmdSetState(uint hashId, uint value) {} // 0x00000001832FC6F0-0x00000001832FC9C0

	// Methods
	// [XID] // 0x00000001897DEEF0-0x00000001897DEF10
	public override void BeforeRecycle() {} // 0x00000001832FC5A0-0x00000001832FC640
	// [XID] // 0x000000018979A610-0x000000018979A630
	public override void Execute(WorkerThreadContext context) {} // 0x00000001832FC4C0-0x00000001832FC5A0
	// [XID] // 0x00000001896A5290-0x00000001896A52B0
	public override void Recycle() {} // 0x00000001832FC640-0x00000001832FC6F0
}

