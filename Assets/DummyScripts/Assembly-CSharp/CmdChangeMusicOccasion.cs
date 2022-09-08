/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Audio.Music;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CmdChangeMusicOccasion : ReusedAudioCmd // TypeDefIndex: 10825
{
	// Fields
	private MusicOccasion _occasion; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdChangeMusicOccasion, MusicOccasion> // TypeDefIndex: 10826
	{
		// Constructors
		public Spawner() {} // 0x000000018485D920-0x000000018485D980

		// Methods
		// [XID] // 0x000000018984EFB0-0x000000018984EFD0
		public CmdChangeMusicOccasion Spawn(MusicOccasion param1) => default; // 0x000000018485D850-0x000000018485D920
	}

	public class Polisher : IPolisher<CmdChangeMusicOccasion, MusicOccasion> // TypeDefIndex: 10827
	{
		// Constructors
		public Polisher() {} // 0x000000018485DD40-0x000000018485DDA0

		// Methods
		// [XID] // 0x0000000189840120-0x0000000189840140
		public void Polish(CmdChangeMusicOccasion reused, MusicOccasion param1) {} // 0x000000018485DC70-0x000000018485DD40
	}

	// Constructors
	public CmdChangeMusicOccasion() {} // Dummy constructor
	private CmdChangeMusicOccasion(MusicOccasion occasion) {} // 0x0000000184872110-0x0000000184872180

	// Methods
	// [XID] // 0x00000001897F42A0-0x00000001897F42C0
	public override void BeforeRecycle() {} // 0x0000000184871FB0-0x0000000184872050
	// [XID] // 0x00000001897FBDC0-0x00000001897FBDE0
	public override void Execute(WorkerThreadContext context) {} // 0x0000000184871ED0-0x0000000184871FB0
	// [XID] // 0x0000000189803210-0x0000000189803230
	public override void Recycle() {} // 0x0000000184872050-0x0000000184872110
}

