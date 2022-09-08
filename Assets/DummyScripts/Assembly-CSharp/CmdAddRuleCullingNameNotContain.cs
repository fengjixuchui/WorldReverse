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

public sealed class CmdAddRuleCullingNameNotContain : ReusedAudioCmd // TypeDefIndex: 10797
{
	// Fields
	private string _pattern; // 0x10

	// Nested types
	public class Spawner : ISpawner<CmdAddRuleCullingNameNotContain, string> // TypeDefIndex: 10798
	{
		// Constructors
		public Spawner() {} // 0x0000000182F68040-0x0000000182F68100

		// Methods
		// [XID] // 0x00000001896A3D90-0x00000001896A3DB0
		public CmdAddRuleCullingNameNotContain Spawn(string param1) => default; // 0x0000000182F67F70-0x0000000182F68040
	}

	public class Polisher : IPolisher<CmdAddRuleCullingNameNotContain, string> // TypeDefIndex: 10799
	{
		// Constructors
		public Polisher() {} // 0x0000000182F68BA0-0x0000000182F68C00

		// Methods
		// [XID] // 0x00000001896AB0C0-0x00000001896AB0E0
		public void Polish(CmdAddRuleCullingNameNotContain reused, string param1) {} // 0x0000000182F68AD0-0x0000000182F68BA0
	}

	// Constructors
	public CmdAddRuleCullingNameNotContain() {} // Dummy constructor
	public CmdAddRuleCullingNameNotContain(string pattern) {} // 0x0000000182F4A7F0-0x0000000182F4A860

	// Methods
	// [XID] // 0x00000001896EA960-0x00000001896EA980
	public override void BeforeRecycle() {} // 0x0000000182F4A670-0x0000000182F4A740
	// [XID] // 0x00000001896F1A30-0x00000001896F1A50
	public override void Execute(WorkerThreadContext context) {} // 0x0000000182F4A590-0x0000000182F4A670
	// [XID] // 0x000000018970FED0-0x000000018970FEF0
	public override void Recycle() {} // 0x0000000182F4A740-0x0000000182F4A7F0
}

