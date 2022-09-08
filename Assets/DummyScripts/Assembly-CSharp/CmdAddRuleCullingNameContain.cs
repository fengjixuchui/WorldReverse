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

public sealed class CmdAddRuleCullingNameContain : ReusedAudioCmd // TypeDefIndex: 10794
{
	// Fields
	private string _pattern; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdAddRuleCullingNameContain, string> // TypeDefIndex: 10795
	{
		// Constructors
		public Spawner() {} // 0x0000000182E81CA0-0x0000000182E81D70

		// Methods
		// [XID] // 0x000000018967E3A0-0x000000018967E3C0
		public CmdAddRuleCullingNameContain Spawn(string param1) => default; // 0x0000000182E81BD0-0x0000000182E81CA0
	}

	public class Polisher : IPolisher<CmdAddRuleCullingNameContain, string> // TypeDefIndex: 10796
	{
		// Constructors
		public Polisher() {} // 0x0000000182EA4D10-0x0000000182EA4D70

		// Methods
		// [XID] // 0x00000001896E3440-0x00000001896E3460
		public void Polish(CmdAddRuleCullingNameContain reused, string param1) {} // 0x0000000182EA4C40-0x0000000182EA4D10
	}

	// Constructors
	public CmdAddRuleCullingNameContain() {} // Dummy constructor
	public CmdAddRuleCullingNameContain(string pattern) {} // 0x0000000182EA1B20-0x0000000182EA1B90

	// Methods
	// [XID] // 0x0000000189667980-0x00000001896679A0
	public override void BeforeRecycle() {} // 0x0000000182EA19A0-0x0000000182EA1A70
	// [XID] // 0x000000018966F220-0x000000018966F240
	public override void Execute(WorkerThreadContext context) {} // 0x0000000182EA18C0-0x0000000182EA19A0
	// [XID] // 0x00000001896C73B0-0x00000001896C73D0
	public override void Recycle() {} // 0x0000000182EA1A70-0x0000000182EA1B20
}

