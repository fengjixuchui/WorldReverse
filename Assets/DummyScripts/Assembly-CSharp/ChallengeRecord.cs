/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChallengeRecord : MessageBase, IMessage<ChallengeRecord> // TypeDefIndex: 22877
{
	// Fields
	private static readonly MessageParser<ChallengeRecord> _parser; // 0x00
	public const int ChallengeIndexFieldNumber = 1; // Metadata: 0x00B0296B
	private uint challengeIndex_; // 0x18
	public const int ChallengeIdFieldNumber = 2; // Metadata: 0x00B0296F
	private uint challengeId_; // 0x1C
	public const int ChallengeRecordTypeFieldNumber = 3; // Metadata: 0x00B02973
	private uint challengeRecordType_; // 0x20
	public const int BestValueFieldNumber = 4; // Metadata: 0x00B02977
	private uint bestValue_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChallengeRecord> Parser { get => default; } // 0x00000001837B8170-0x00000001837B8200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001837B7B40-0x00000001837B7BD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001837B7730-0x00000001837B77B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001837B6FE0-0x00000001837B7040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001837B8580-0x00000001837B8670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001837B8330-0x00000001837B8390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001837B7DB0-0x00000001837B7EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001837B8530-0x00000001837B8580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001837B7850-0x00000001837B7940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeIndex { get => default; set {} } // 0x00000001837B72A0-0x00000001837B7340 0x00000001837B7BD0-0x00000001837B7C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeId { get => default; set {} } // 0x00000001837B7AA0-0x00000001837B7B40 0x00000001837B7F90-0x00000001837B8030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeRecordType { get => default; set {} } // 0x00000001837B7D10-0x00000001837B7DB0 0x00000001837B80D0-0x00000001837B8170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BestValue { get => default; set {} } // 0x00000001837B8030-0x00000001837B80D0 0x00000001837B7C70-0x00000001837B7D10

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChallengeRecord() {} // 0x00000001837B8A50-0x00000001837B8AB0
	static ChallengeRecord() {} // 0x00000001837B8990-0x00000001837B8A50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChallengeRecord Clone() => default; // 0x00000001837B7EA0-0x00000001837B7F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChallengeRecord ShallowCopy() => default; // 0x00000001837B77B0-0x00000001837B7850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001837B71C0-0x00000001837B7210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837B8290-0x00000001837B82E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837B82E0-0x00000001837B8330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001837B7210-0x00000001837B72A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001837B7340-0x00000001837B7410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChallengeRecord other) => default; // 0x00000001837B7410-0x00000001837B7560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001837B7940-0x00000001837B7AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001837B8670-0x00000001837B8990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001837B8390-0x00000001837B8530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001837B7560-0x00000001837B7730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChallengeRecord other) {} // 0x00000001837B7040-0x00000001837B71C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001837B6EB0-0x00000001837B6FE0
}

