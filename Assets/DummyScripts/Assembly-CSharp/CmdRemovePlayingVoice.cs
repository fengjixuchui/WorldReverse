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

public sealed class CmdRemovePlayingVoice : ReusedAudioCmd // TypeDefIndex: 10932
{
	// Fields
	private uint _playingId; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdRemovePlayingVoice, uint> // TypeDefIndex: 10933
	{
		// Constructors
		public Spawner() {} // 0x00000001838FBDA0-0x00000001838FBE00

		// Methods
		// [XID] // 0x00000001897661D0-0x00000001897661F0
		public CmdRemovePlayingVoice Spawn(uint param1) => default; // 0x00000001838FBCD0-0x00000001838FBDA0
	}

	public class Polisher : IPolisher<CmdRemovePlayingVoice, uint> // TypeDefIndex: 10934
	{
		// Constructors
		public Polisher() {} // 0x00000001838FC270-0x00000001838FC2D0

		// Methods
		// [XID] // 0x000000018976D9E0-0x000000018976DA00
		public void Polish(CmdRemovePlayingVoice reused, uint param1) {} // 0x00000001838FC1A0-0x00000001838FC270
	}

	// Constructors
	public CmdRemovePlayingVoice() {} // Dummy constructor
	private CmdRemovePlayingVoice(uint playingId) {} // 0x0000000183902480-0x00000001839024F0

	// Methods
	// [XID] // 0x000000018974FDF0-0x000000018974FE10
	public override void BeforeRecycle() {} // 0x0000000183902330-0x00000001839023D0
	// [XID] // 0x00000001897574E0-0x0000000189757500
	public override void Execute(WorkerThreadContext context) {} // 0x0000000183902250-0x0000000183902330
	// [XID] // 0x000000018975ED10-0x000000018975ED30
	public override void Recycle() {} // 0x00000001839023D0-0x0000000183902480
}

