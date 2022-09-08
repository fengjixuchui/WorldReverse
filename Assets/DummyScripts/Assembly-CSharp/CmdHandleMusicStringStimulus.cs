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

public sealed class CmdHandleMusicStringStimulus : CmdHandleMusicParameterizedStimulus // TypeDefIndex: 10835
{
	// Fields
	private string _parameter; // 0x18

	// Nested types
	public class Spawner : ISpawner<CmdHandleMusicStringStimulus, MusicStimulus, string> // TypeDefIndex: 10836
	{
		// Constructors
		public Spawner() {} // 0x0000000182CB34B0-0x0000000182CB3510

		// Methods
		// [XID] // 0x000000018988F660-0x000000018988F680
		public CmdHandleMusicStringStimulus Spawn(MusicStimulus param1, string param2) => default; // 0x0000000182CB33D0-0x0000000182CB34B0
	}

	public class Polisher : IPolisher<CmdHandleMusicStringStimulus, MusicStimulus, string> // TypeDefIndex: 10837
	{
		// Constructors
		public Polisher() {} // 0x0000000182CD2950-0x0000000182CD29B0

		// Methods
		// [XID] // 0x0000000189896BC0-0x0000000189896BE0
		public void Polish(CmdHandleMusicStringStimulus reused, MusicStimulus param1, string param2) {} // 0x0000000182CD2860-0x0000000182CD2950
	}

	// Constructors
	public CmdHandleMusicStringStimulus() {} // Dummy constructor
	private CmdHandleMusicStringStimulus(MusicStimulus stimulus, string parameter) {} // 0x0000000182CCB830-0x0000000182CCB8C0

	// Methods
	// [XID] // 0x00000001896D4530-0x00000001896D4550
	public override void BeforeRecycle() {} // 0x0000000182CCB640-0x0000000182CCB720
	// [XID] // 0x00000001896DBD60-0x00000001896DBD80
	public override void Execute(WorkerThreadContext context) {} // 0x0000000182CCB550-0x0000000182CCB640
	// [XID] // 0x00000001898880C0-0x00000001898880E0
	public override void Recycle() {} // 0x0000000182CCB720-0x0000000182CCB7D0
}

