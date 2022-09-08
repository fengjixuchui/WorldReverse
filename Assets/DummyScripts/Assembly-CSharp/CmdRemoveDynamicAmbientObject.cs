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

public sealed class CmdRemoveDynamicAmbientObject : ReusedAudioCmd // TypeDefIndex: 10777
{
	// Fields
	private int _id; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdRemoveDynamicAmbientObject, int> // TypeDefIndex: 10778
	{
		// Constructors
		public Spawner() {} // 0x0000000184753820-0x0000000184753880

		// Methods
		// [XID] // 0x00000001898AB680-0x00000001898AB6A0
		public CmdRemoveDynamicAmbientObject Spawn(int param1) => default; // 0x0000000184753750-0x0000000184753820
	}

	public class Polisher : IPolisher<CmdRemoveDynamicAmbientObject, int> // TypeDefIndex: 10779
	{
		// Constructors
		public Polisher() {} // 0x00000001847536F0-0x0000000184753750

		// Methods
		// [XID] // 0x00000001899B73B0-0x00000001899B73D0
		public void Polish(CmdRemoveDynamicAmbientObject reused, int param1) {} // 0x0000000184753620-0x00000001847536F0
	}

	// Constructors
	public CmdRemoveDynamicAmbientObject() {} // Dummy constructor
	public CmdRemoveDynamicAmbientObject(int id) {} // 0x0000000184734D10-0x0000000184734D80

	// Methods
	// [XID] // 0x0000000189B89D70-0x0000000189B89D90
	public override void BeforeRecycle() {} // 0x0000000184734BC0-0x0000000184734C60
	// [XID] // 0x0000000189B91420-0x0000000189B91440
	public override void Execute(WorkerThreadContext context) {} // 0x0000000184734AE0-0x0000000184734BC0
	// [XID] // 0x0000000189B98630-0x0000000189B98650
	public override void Recycle() {} // 0x0000000184734C60-0x0000000184734D10
}

