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

public sealed class CmdUpdateStringGameParam : CmdUpdateGameParam // TypeDefIndex: 10848
{
	// Fields
	private string _value; // 0x18

	// Nested types
	public class Spawner : ISpawner<CmdUpdateStringGameParam, MusicGameParam, string> // TypeDefIndex: 10849
	{
		// Constructors
		public Spawner() {} // 0x00000001827CF4F0-0x00000001827CF550

		// Methods
		// [XID] // 0x000000018993C130-0x000000018993C150
		public CmdUpdateStringGameParam Spawn(MusicGameParam param1, string param2) => default; // 0x00000001827CF410-0x00000001827CF4F0
	}

	public class Polisher : IPolisher<CmdUpdateStringGameParam, MusicGameParam, string> // TypeDefIndex: 10850
	{
		// Constructors
		public Polisher() {} // 0x00000001827AA6C0-0x00000001827AA720

		// Methods
		// [XID] // 0x00000001898823C0-0x00000001898823E0
		public void Polish(CmdUpdateStringGameParam reused, MusicGameParam param1, string param2) {} // 0x00000001827AA5D0-0x00000001827AA6C0
	}

	// Constructors
	public CmdUpdateStringGameParam() {} // Dummy constructor
	public CmdUpdateStringGameParam(MusicGameParam gameParam, string value) {} // 0x00000001827C3270-0x00000001827C32F0

	// Methods
	// [XID] // 0x0000000189925A20-0x0000000189925A40
	public override void BeforeRecycle() {} // 0x00000001827C3080-0x00000001827C3160
	// [XID] // 0x0000000189850540-0x0000000189850560
	public override void Execute(WorkerThreadContext context) {} // 0x00000001827C2F90-0x00000001827C3080
	// [XID] // 0x00000001899344C0-0x00000001899344E0
	public override void Recycle() {} // 0x00000001827C3160-0x00000001827C3210
}

