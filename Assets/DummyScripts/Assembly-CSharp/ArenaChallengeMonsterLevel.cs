/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ArenaChallengeMonsterLevel : MessageBase, IMessage<ArenaChallengeMonsterLevel> // TypeDefIndex: 22240
{
	// Fields
	private static readonly MessageParser<ArenaChallengeMonsterLevel> _parser; // 0x00
	public const int ArenaChallengeIdFieldNumber = 1; // Metadata: 0x00B011EB
	private uint arenaChallengeId_; // 0x18
	public const int ArenaChallengeLevelFieldNumber = 2; // Metadata: 0x00B011EF
	private uint arenaChallengeLevel_; // 0x1C
	public const int MonsterLevelFieldNumber = 3; // Metadata: 0x00B011F3
	private uint monsterLevel_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ArenaChallengeMonsterLevel> Parser { get => default; } // 0x0000000182064190-0x0000000182064220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182063E80-0x0000000182063F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182063960-0x00000001820639E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001820632A0-0x0000000182063300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182064600-0x00000001820646F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182064350-0x00000001820643B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182063F10-0x0000000182064000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001820645B0-0x0000000182064600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182063BC0-0x0000000182063CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ArenaChallengeId { get => default; set {} } // 0x0000000182063530-0x00000001820635D0 0x0000000182063DE0-0x0000000182063E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ArenaChallengeLevel { get => default; set {} } // 0x0000000182063B20-0x0000000182063BC0 0x0000000182064510-0x00000001820645B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MonsterLevel { get => default; set {} } // 0x00000001820640F0-0x0000000182064190 0x0000000182063A80-0x0000000182063B20

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ArenaChallengeMonsterLevel() {} // 0x0000000182064A40-0x0000000182064AA0
	static ArenaChallengeMonsterLevel() {} // 0x0000000182064980-0x0000000182064A40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ArenaChallengeMonsterLevel Clone() => default; // 0x0000000182064000-0x00000001820640F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ArenaChallengeMonsterLevel ShallowCopy() => default; // 0x00000001820639E0-0x0000000182063A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182063460-0x00000001820634B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001820642B0-0x0000000182064300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182064300-0x0000000182064350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001820634B0-0x0000000182063530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001820635D0-0x00000001820636A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ArenaChallengeMonsterLevel other) => default; // 0x00000001820636A0-0x00000001820637E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182063CB0-0x0000000182063DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001820646F0-0x0000000182064980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001820643B0-0x0000000182064510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001820637E0-0x0000000182063960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ArenaChallengeMonsterLevel other) {} // 0x0000000182063300-0x0000000182063460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182063190-0x00000001820632A0
}

