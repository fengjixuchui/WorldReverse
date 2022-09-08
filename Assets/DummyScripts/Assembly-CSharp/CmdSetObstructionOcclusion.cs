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

public sealed class CmdSetObstructionOcclusion : ReusedAudioCmd // TypeDefIndex: 10914
{
	// Fields
	private SyncId _sourceId; // 0x10
	private float _obstruction; // 0x28
	private float _occlusion; // 0x2C

	// Nested types
	public class Spawner : ISpawner<CmdSetObstructionOcclusion, SyncId, float, float> // TypeDefIndex: 10915
	{
		// Constructors
		public Spawner() {} // 0x0000000183291ED0-0x0000000183291F30

		// Methods
		// [XID] // 0x00000001897D7A40-0x00000001897D7A60
		public CmdSetObstructionOcclusion Spawn(SyncId param1, float param2, float param3) => default; // 0x0000000183291D50-0x0000000183291ED0
	}

	public class Polisher : IPolisher<CmdSetObstructionOcclusion, SyncId, float, float> // TypeDefIndex: 10916
	{
		// Constructors
		public Polisher() {} // 0x0000000183292060-0x00000001832920C0

		// Methods
		// [XID] // 0x0000000189792F50-0x0000000189792F70
		public void Polish(CmdSetObstructionOcclusion reused, SyncId param1, float param2, float param3) {} // 0x0000000183291F30-0x0000000183292060
	}

	// Constructors
	public CmdSetObstructionOcclusion() {} // Dummy constructor
	private CmdSetObstructionOcclusion(SyncId sourceId, float obstruction, float occlusion) {} // 0x00000001832AF1A0-0x00000001832AF250

	// Methods
	// [XID] // 0x0000000189670BC0-0x0000000189670BE0
	public override void BeforeRecycle() {} // 0x00000001832AF010-0x00000001832AF0F0
	// [XID] // 0x0000000189678410-0x0000000189678430
	public override void Execute(WorkerThreadContext context) {} // 0x00000001832AEF10-0x00000001832AF010
	// [XID] // 0x000000018978BA70-0x000000018978BA90
	public override void Recycle() {} // 0x00000001832AF0F0-0x00000001832AF1A0
}

