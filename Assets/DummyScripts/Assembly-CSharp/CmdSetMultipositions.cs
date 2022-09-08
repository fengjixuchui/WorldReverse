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

public sealed class CmdSetMultipositions : ReusedAudioCmd // TypeDefIndex: 10911
{
	// Fields
	private ulong _gameObjectId; // 0x10
	private AudioPositionArray _positionArray; // 0x18
	private AkMultiPositionType _multiPositionType; // 0x38

	// Nested types
	public class Spawner : ISpawner<CmdSetMultipositions, SyncId, AudioPositionArray, AkMultiPositionType> // TypeDefIndex: 10912
	{
		// Constructors
		public Spawner() {} // 0x00000001825CCD40-0x00000001825CCDA0

		// Methods
		// [XID] // 0x0000000189661600-0x0000000189661620
		public CmdSetMultipositions Spawn(SyncId param1, AudioPositionArray param2, AkMultiPositionType param3) => default; // 0x00000001825CCBA0-0x00000001825CCD40
	}

	public class Polisher : IPolisher<CmdSetMultipositions, SyncId, AudioPositionArray, AkMultiPositionType> // TypeDefIndex: 10913
	{
		// Constructors
		public Polisher() {} // 0x00000001825CCB40-0x00000001825CCBA0

		// Methods
		// [XID] // 0x000000018976DBC0-0x000000018976DBE0
		public void Polish(CmdSetMultipositions reused, SyncId param1, AudioPositionArray param2, AkMultiPositionType param3) {} // 0x00000001825CC9F0-0x00000001825CCB40
	}

	// Constructors
	public CmdSetMultipositions() {} // Dummy constructor
	private CmdSetMultipositions(ulong gameObjectId, AudioPositionArray positionArray, AkMultiPositionType multiPositionType) {} // 0x00000001825AB780-0x00000001825AB810

	// Methods
	// [XID] // 0x00000001897083F0-0x0000000189708410
	public override void BeforeRecycle() {} // 0x00000001825AB600-0x00000001825AB6D0
	// [XID] // 0x000000018970FEB0-0x000000018970FED0
	public override void Execute(WorkerThreadContext context) {} // 0x00000001825AB500-0x00000001825AB600
	// [XID] // 0x0000000189659F90-0x0000000189659FB0
	public override void Recycle() {} // 0x00000001825AB6D0-0x00000001825AB780
}

