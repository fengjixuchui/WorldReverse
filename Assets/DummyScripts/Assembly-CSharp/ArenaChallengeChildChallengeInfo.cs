/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ArenaChallengeChildChallengeInfo : MessageBase, IMessage<ArenaChallengeChildChallengeInfo> // TypeDefIndex: 22248
{
	// Fields
	private static readonly MessageParser<ArenaChallengeChildChallengeInfo> _parser; // 0x00
	public const int ChallengeIndexFieldNumber = 1; // Metadata: 0x00B01243
	private uint challengeIndex_; // 0x18
	public const int ChallengeIdFieldNumber = 2; // Metadata: 0x00B01247
	private uint challengeId_; // 0x1C
	public const int ChallengeTypeFieldNumber = 3; // Metadata: 0x00B0124B
	private uint challengeType_; // 0x20
	public const int IsSuccessFieldNumber = 4; // Metadata: 0x00B0124F
	private bool isSuccess_; // 0x24
	public const int IsSettledFieldNumber = 5; // Metadata: 0x00B01253
	private bool isSettled_; // 0x25

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ArenaChallengeChildChallengeInfo> Parser { get => default; } // 0x0000000181793880-0x0000000181793910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181793430-0x00000001817934C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181792F50-0x0000000181792FD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181792690-0x00000001817926F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181793E10-0x0000000181793F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181793AE0-0x0000000181793B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181793600-0x00000001817936F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181793DC0-0x0000000181793E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181793070-0x0000000181793160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeIndex { get => default; set {} } // 0x0000000181792A30-0x0000000181792AD0 0x00000001817934C0-0x0000000181793560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeId { get => default; set {} } // 0x00000001817932F0-0x0000000181793390 0x00000001817937E0-0x0000000181793880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeType { get => default; set {} } // 0x0000000181793390-0x0000000181793430 0x0000000181792EB0-0x0000000181792F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSuccess { get => default; set {} } // 0x0000000181793A40-0x0000000181793AE0 0x00000001817926F0-0x0000000181792790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSettled { get => default; set {} } // 0x0000000181793D20-0x0000000181793DC0 0x0000000181793560-0x0000000181793600

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ArenaChallengeChildChallengeInfo() {} // 0x0000000181794360-0x00000001817943C0
	static ArenaChallengeChildChallengeInfo() {} // 0x00000001817942A0-0x0000000181794360

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ArenaChallengeChildChallengeInfo Clone() => default; // 0x00000001817936F0-0x00000001817937E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ArenaChallengeChildChallengeInfo ShallowCopy() => default; // 0x0000000181792FD0-0x0000000181793070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181792940-0x0000000181792990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001817939A0-0x00000001817939F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001817939F0-0x0000000181793A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181792990-0x0000000181792A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181792C40-0x0000000181792D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ArenaChallengeChildChallengeInfo other) => default; // 0x0000000181792AD0-0x0000000181792C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181793160-0x00000001817932F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181793F00-0x00000001817942A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181793B40-0x0000000181793D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181792D10-0x0000000181792EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ArenaChallengeChildChallengeInfo other) {} // 0x0000000181792790-0x0000000181792940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181792540-0x0000000181792690
}

