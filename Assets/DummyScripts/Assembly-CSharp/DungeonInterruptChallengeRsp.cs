/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DungeonInterruptChallengeRsp : MessageBase, IMessage<DungeonInterruptChallengeRsp> // TypeDefIndex: 22955
{
	// Fields
	private static readonly MessageParser<DungeonInterruptChallengeRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B02BE3
	private int retcode_; // 0x18
	public const int ChallengeIdFieldNumber = 2; // Metadata: 0x00B02BE7
	private uint challengeId_; // 0x1C
	public const int ChallengeIndexFieldNumber = 3; // Metadata: 0x00B02BEB
	private uint challengeIndex_; // 0x20
	public const int GroupIdFieldNumber = 4; // Metadata: 0x00B02BEF
	private uint groupId_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DungeonInterruptChallengeRsp> Parser { get => default; } // 0x0000000184095C50-0x0000000184095CE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184095800-0x0000000184095890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001840953F0-0x0000000184095470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184094AC0-0x0000000184094B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184096060-0x0000000184096150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184095E10-0x0000000184095E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184095930-0x0000000184095A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184096010-0x0000000184096060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184095510-0x0000000184095600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001840952B0-0x0000000184095350 0x0000000184094E20-0x0000000184094EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeId { get => default; set {} } // 0x0000000184095760-0x0000000184095800 0x0000000184095BB0-0x0000000184095C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ChallengeIndex { get => default; set {} } // 0x0000000184094D80-0x0000000184094E20 0x0000000184095890-0x0000000184095930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x0000000184095A20-0x0000000184095AC0 0x0000000184095350-0x00000001840953F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22956
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22957
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 949
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonInterruptChallengeRsp() {} // 0x0000000184096530-0x0000000184096590
	static DungeonInterruptChallengeRsp() {} // 0x0000000184096470-0x0000000184096530

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonInterruptChallengeRsp Clone() => default; // 0x0000000184095AC0-0x0000000184095BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DungeonInterruptChallengeRsp ShallowCopy() => default; // 0x0000000184095470-0x0000000184095510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184094CA0-0x0000000184094CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184095D70-0x0000000184095DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184095DC0-0x0000000184095E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184094CF0-0x0000000184094D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184095010-0x00000001840950E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DungeonInterruptChallengeRsp other) => default; // 0x0000000184094EC0-0x0000000184095010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184095600-0x0000000184095760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184096150-0x0000000184096470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184095E70-0x0000000184096010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001840950E0-0x00000001840952B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DungeonInterruptChallengeRsp other) {} // 0x0000000184094B20-0x0000000184094CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184094990-0x0000000184094AC0
}

