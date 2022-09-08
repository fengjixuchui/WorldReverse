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

public sealed class CmdSetGlobalRtpcValue : ReusedAudioCmd // TypeDefIndex: 10905
{
	// Fields
	private uint _nameId; // 0x10
	private float _value; // 0x14

	// Nested types
	public class Spawner : ISpawner<CmdSetGlobalRtpcValue, uint, float> // TypeDefIndex: 10906
	{
		// Constructors
		public Spawner() {} // 0x000000018303B220-0x000000018303B280

		// Methods
		// [XID] // 0x0000000189616970-0x0000000189616990
		public CmdSetGlobalRtpcValue Spawn(uint param1, float param2) => default; // 0x000000018303B140-0x000000018303B220
	}

	public class Polisher : IPolisher<CmdSetGlobalRtpcValue, uint, float> // TypeDefIndex: 10907
	{
		// Constructors
		public Polisher() {} // 0x000000018303B0E0-0x000000018303B140

		// Methods
		// [XID] // 0x000000018961E280-0x000000018961E2A0
		public void Polish(CmdSetGlobalRtpcValue reused, uint param1, float param2) {} // 0x000000018303AFF0-0x000000018303B0E0
	}

	// Constructors
	public CmdSetGlobalRtpcValue() {} // Dummy constructor
	private CmdSetGlobalRtpcValue(uint nameId, float value) {} // 0x000000018304BF90-0x000000018304C010

	// Methods
	// [XID] // 0x00000001896999F0-0x0000000189699A10
	public override void BeforeRecycle() {} // 0x000000018304BE40-0x000000018304BEE0
	// [XID] // 0x00000001896A1070-0x00000001896A1090
	public override void Execute(WorkerThreadContext context) {} // 0x000000018304BD60-0x000000018304BE40
	// [XID] // 0x0000000189A611D0-0x0000000189A611F0
	public override void Recycle() {} // 0x000000018304BEE0-0x000000018304BF90
}

