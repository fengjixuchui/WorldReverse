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

public sealed class CmdSpatialClearAll : ReusedAudioCmd // TypeDefIndex: 10890
{
	// Nested types
	public class Spawner : ISpawner<CmdSpatialClearAll> // TypeDefIndex: 10891
	{
		// Constructors
		public Spawner() {} // 0x00000001828BDD50-0x00000001828BDDB0

		// Methods
		// [XID] // 0x0000000189B57280-0x0000000189B572A0
		public CmdSpatialClearAll Spawn() => default; // 0x00000001828BDC50-0x00000001828BDD50
	}

	public class Polisher : IPolisher<CmdSpatialClearAll> // TypeDefIndex: 10892
	{
		// Constructors
		public Polisher() {} // 0x00000001828BD960-0x00000001828BD9C0

		// Methods
		// [XID] // 0x0000000189B5ECC0-0x0000000189B5ECE0
		public void Polish(CmdSpatialClearAll reused) {} // 0x00000001828BD8B0-0x00000001828BD960
	}

	// Constructors
	private CmdSpatialClearAll() {} // 0x00000001828A05E0-0x00000001828A0640

	// Methods
	// [XID] // 0x0000000189B40B30-0x0000000189B40B50
	public override void BeforeRecycle() {} // 0x00000001828A04A0-0x00000001828A0540
	// [XID] // 0x0000000189B48370-0x0000000189B48390
	public override void Execute(WorkerThreadContext context) {} // 0x00000001828A03D0-0x00000001828A04A0
	// [XID] // 0x0000000189B4FBD0-0x0000000189B4FBF0
	public override void Recycle() {} // 0x00000001828A0540-0x00000001828A05E0
}

