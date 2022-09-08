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

public sealed class CmdUpdateUInt32GameParam : CmdUpdateGameParam // TypeDefIndex: 10842
{
	// Fields
	private uint _value; // 0x18

	// Nested types
	public class Spawner : ISpawner<CmdUpdateUInt32GameParam, MusicGameParam, uint> // TypeDefIndex: 10843
	{
		// Constructors
		public Spawner() {} // 0x000000018226D170-0x000000018226D1D0

		// Methods
		// [XID] // 0x00000001898F0E20-0x00000001898F0E40
		public CmdUpdateUInt32GameParam Spawn(MusicGameParam param1, uint param2) => default; // 0x000000018226D090-0x000000018226D170
	}

	public class Polisher : IPolisher<CmdUpdateUInt32GameParam, MusicGameParam, uint> // TypeDefIndex: 10844
	{
		// Constructors
		public Polisher() {} // 0x000000018226D780-0x000000018226D7E0

		// Methods
		// [XID] // 0x00000001898F87E0-0x00000001898F8800
		public void Polish(CmdUpdateUInt32GameParam reused, MusicGameParam param1, uint param2) {} // 0x000000018226D690-0x000000018226D780
	}

	// Constructors
	public CmdUpdateUInt32GameParam() {} // Dummy constructor
	private CmdUpdateUInt32GameParam(MusicGameParam gameParam, uint value) {} // 0x000000018227F960-0x000000018227F9E0

	// Methods
	// [XID] // 0x00000001898D9F90-0x00000001898D9FB0
	public override void BeforeRecycle() {} // 0x000000018227F7A0-0x000000018227F850
	// [XID] // 0x00000001898E1C60-0x00000001898E1C80
	public override void Execute(WorkerThreadContext context) {} // 0x000000018227F6B0-0x000000018227F7A0
	// [XID] // 0x000000018972C010-0x000000018972C030
	public override void Recycle() {} // 0x000000018227F850-0x000000018227F900
}

