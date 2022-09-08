/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarSkillChangeNotify : MessageBase, IMessage<AvatarSkillChangeNotify> // TypeDefIndex: 25516
{
	// Fields
	private static readonly MessageParser<AvatarSkillChangeNotify> _parser; // 0x00
	public const int AvatarGuidFieldNumber = 1; // Metadata: 0x00B08F13
	private ulong avatarGuid_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B08F17
	private uint entityId_; // 0x20
	public const int SkillDepotIdFieldNumber = 3; // Metadata: 0x00B08F1B
	private uint skillDepotId_; // 0x24
	public const int AvatarSkillIdFieldNumber = 4; // Metadata: 0x00B08F1F
	private uint avatarSkillId_; // 0x28
	public const int OldLevelFieldNumber = 5; // Metadata: 0x00B08F23
	private uint oldLevel_; // 0x2C
	public const int CurLevelFieldNumber = 6; // Metadata: 0x00B08F27
	private uint curLevel_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarSkillChangeNotify> Parser { get => default; } // 0x0000000184A356F0-0x0000000184A35780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184A35200-0x0000000184A35290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184A34D90-0x0000000184A34E10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184A34450-0x0000000184A344B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184A35D60-0x0000000184A35E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184A35950-0x0000000184A359B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184A35330-0x0000000184A35420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184A35D10-0x0000000184A35D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184A34F50-0x0000000184A35040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x0000000184A35290-0x0000000184A35330 0x0000000184A34680-0x0000000184A34720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000184A358B0-0x0000000184A35950 0x0000000184A35E50-0x0000000184A35EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SkillDepotId { get => default; set {} } // 0x0000000184A359B0-0x0000000184A35A50 0x0000000184A34EB0-0x0000000184A34F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarSkillId { get => default; set {} } // 0x0000000184A34CF0-0x0000000184A34D90 0x0000000184A355B0-0x0000000184A35650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OldLevel { get => default; set {} } // 0x0000000184A35650-0x0000000184A356F0 0x0000000184A35510-0x0000000184A355B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurLevel { get => default; set {} } // 0x0000000184A343B0-0x0000000184A34450 0x0000000184A35A50-0x0000000184A35AF0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25517
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25518
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1014
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSkillChangeNotify() {} // 0x0000000184A363E0-0x0000000184A36440
	static AvatarSkillChangeNotify() {} // 0x0000000184A36320-0x0000000184A363E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSkillChangeNotify Clone() => default; // 0x0000000184A35420-0x0000000184A35510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSkillChangeNotify ShallowCopy() => default; // 0x0000000184A34E10-0x0000000184A34EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184A34720-0x0000000184A34770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A35810-0x0000000184A35860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A35860-0x0000000184A358B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184A34770-0x0000000184A34820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184A34820-0x0000000184A348F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarSkillChangeNotify other) => default; // 0x0000000184A348F0-0x0000000184A34A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184A35040-0x0000000184A35200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184A35EF0-0x0000000184A36320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184A35AF0-0x0000000184A35D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184A34A90-0x0000000184A34CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarSkillChangeNotify other) {} // 0x0000000184A344B0-0x0000000184A34680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184A34240-0x0000000184A343B0
}

