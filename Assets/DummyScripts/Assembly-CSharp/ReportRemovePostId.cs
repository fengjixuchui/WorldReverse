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

public sealed class ReportRemovePostId : ReusedAudioReport // TypeDefIndex: 10984
{
	// Fields
	private uint _postId; // 0x10
	private uint _playingId; // 0x14

	// Nested types
	public class Spawner : ISpawner<ReportRemovePostId, uint, uint> // TypeDefIndex: 10985
	{
		// Constructors
		public Spawner() {} // 0x0000000183E18BB0-0x0000000183E18C10

		// Methods
		// [XID] // 0x0000000189A15320-0x0000000189A15340
		public ReportRemovePostId Spawn(uint param1, uint param2) => default; // 0x0000000183E18AD0-0x0000000183E18BB0
	}

	public class Polisher : IPolisher<ReportRemovePostId, uint, uint> // TypeDefIndex: 10986
	{
		// Constructors
		public Polisher() {} // 0x0000000183DF6DC0-0x0000000183DF6E20

		// Methods
		// [XID] // 0x0000000189A1C590-0x0000000189A1C5B0
		public void Polish(ReportRemovePostId reused, uint param1, uint param2) {} // 0x0000000183DF6CE0-0x0000000183DF6DC0
	}

	// Constructors
	public ReportRemovePostId() {} // Dummy constructor
	private ReportRemovePostId(uint postId, uint playingId) {} // 0x0000000183E10C00-0x0000000183E10C80

	// Methods
	// [XID] // 0x00000001899FEEA0-0x00000001899FEEC0
	public override void BeforeRecycle() {} // 0x0000000183E10AB0-0x0000000183E10B50
	// [XID] // 0x0000000189A067A0-0x0000000189A067C0
	public override void Digest(CommandThreadContext context) {} // 0x0000000183E109D0-0x0000000183E10AB0
	// [XID] // 0x0000000189A0DCC0-0x0000000189A0DCE0
	public override void Recycle() {} // 0x0000000183E10B50-0x0000000183E10C00
}

