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

public sealed class CmdUpdateFloatGameParam : CmdUpdateGameParam // TypeDefIndex: 10845
{
	// Fields
	private float _value; // 0x18

	// Nested types
	public class Spawner : ISpawner<CmdUpdateFloatGameParam, MusicGameParam, float> // TypeDefIndex: 10846
	{
		// Constructors
		public Spawner() {} // 0x00000001848C57B0-0x00000001848C5810

		// Methods
		// [XID] // 0x0000000189916980-0x00000001899169A0
		public CmdUpdateFloatGameParam Spawn(MusicGameParam param1, float param2) => default; // 0x00000001848C56D0-0x00000001848C57B0
	}

	public class Polisher : IPolisher<CmdUpdateFloatGameParam, MusicGameParam, float> // TypeDefIndex: 10847
	{
		// Constructors
		public Polisher() {} // 0x00000001848C5900-0x00000001848C5960

		// Methods
		// [XID] // 0x000000018991E110-0x000000018991E130
		public void Polish(CmdUpdateFloatGameParam reused, MusicGameParam param1, float param2) {} // 0x00000001848C5810-0x00000001848C5900
	}

	// Constructors
	public CmdUpdateFloatGameParam() {} // Dummy constructor
	public CmdUpdateFloatGameParam(MusicGameParam gameParam, float value) {} // 0x00000001848E29C0-0x00000001848E2A40

	// Methods
	// [XID] // 0x0000000189818060-0x0000000189818080
	public override void BeforeRecycle() {} // 0x00000001848E2800-0x00000001848E28B0
	// [XID] // 0x0000000189907700-0x0000000189907720
	public override void Execute(WorkerThreadContext context) {} // 0x00000001848E2710-0x00000001848E2800
	// [XID] // 0x000000018990F070-0x000000018990F090
	public override void Recycle() {} // 0x00000001848E28B0-0x00000001848E2960
}

