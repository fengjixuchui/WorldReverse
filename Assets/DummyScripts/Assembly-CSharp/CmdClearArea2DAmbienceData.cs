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

internal sealed class CmdClearArea2DAmbienceData : ReusedAudioCmd // TypeDefIndex: 10774
{
	// Nested types
	public class Spawner : ISpawner<CmdClearArea2DAmbienceData> // TypeDefIndex: 10775
	{
		// Constructors
		public Spawner() {} // 0x00000001828BD740-0x00000001828BD7A0

		// Methods
		// [XID] // 0x0000000189968C70-0x0000000189968C90
		public CmdClearArea2DAmbienceData Spawn() => default; // 0x00000001828BD640-0x00000001828BD740
	}

	public class Polisher : IPolisher<CmdClearArea2DAmbienceData> // TypeDefIndex: 10776
	{
		// Constructors
		public Polisher() {} // 0x00000001828BD850-0x00000001828BD8B0

		// Methods
		// [XID] // 0x0000000189970420-0x0000000189970440
		public void Polish(CmdClearArea2DAmbienceData reused) {} // 0x00000001828BD7A0-0x00000001828BD850
	}

	// Constructors
	private CmdClearArea2DAmbienceData() {} // 0x000000018289C7A0-0x000000018289C8A0

	// Methods
	// [XID] // 0x0000000189B64B30-0x0000000189B64B50
	public override void BeforeRecycle() {} // 0x000000018289C650-0x000000018289C6F0
	// [XID] // 0x000000018994ADB0-0x000000018994ADD0
	public override void Execute(WorkerThreadContext context) {} // 0x000000018289C560-0x000000018289C650
	// [XID] // 0x0000000189B73850-0x0000000189B73870
	public override void Recycle() {} // 0x000000018289C6F0-0x000000018289C7A0
}

