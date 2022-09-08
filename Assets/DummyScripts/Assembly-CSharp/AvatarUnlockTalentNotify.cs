/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarUnlockTalentNotify : MessageBase, IMessage<AvatarUnlockTalentNotify> // TypeDefIndex: 25483
{
	// Fields
	private static readonly MessageParser<AvatarUnlockTalentNotify> _parser; // 0x00
	public const int AvatarGuidFieldNumber = 1; // Metadata: 0x00B08DBB
	private ulong avatarGuid_; // 0x18
	public const int EntityIdFieldNumber = 2; // Metadata: 0x00B08DBF
	private uint entityId_; // 0x20
	public const int TalentIdFieldNumber = 3; // Metadata: 0x00B08DC3
	private uint talentId_; // 0x24
	public const int SkillDepotIdFieldNumber = 4; // Metadata: 0x00B08DC7
	private uint skillDepotId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarUnlockTalentNotify> Parser { get => default; } // 0x0000000183253A40-0x0000000183253AD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183253730-0x00000001832537C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183253320-0x00000001832533A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183252B10-0x0000000183252B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183253F90-0x0000000183254080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183253CA0-0x0000000183253D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183253860-0x0000000183253950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183253F40-0x0000000183253F90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001832534E0-0x00000001832535D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x00000001832537C0-0x0000000183253860 0x0000000183252DA0-0x0000000183252E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000183253C00-0x0000000183253CA0 0x0000000183254120-0x00000001832541C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TalentId { get => default; set {} } // 0x0000000183252B70-0x0000000183252C10 0x0000000183254080-0x0000000183254120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SkillDepotId { get => default; set {} } // 0x0000000183253D00-0x0000000183253DA0 0x0000000183253440-0x00000001832534E0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25484
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25485
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1003
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarUnlockTalentNotify() {} // 0x00000001832545A0-0x0000000183254600
	static AvatarUnlockTalentNotify() {} // 0x00000001832544E0-0x00000001832545A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarUnlockTalentNotify Clone() => default; // 0x0000000183253950-0x0000000183253A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarUnlockTalentNotify ShallowCopy() => default; // 0x00000001832533A0-0x0000000183253440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183252E40-0x0000000183252E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183253B60-0x0000000183253BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183253BB0-0x0000000183253C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183252E90-0x0000000183252F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183253080-0x0000000183253150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarUnlockTalentNotify other) => default; // 0x0000000183252F20-0x0000000183253080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001832535D0-0x0000000183253730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001832541C0-0x00000001832544E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183253DA0-0x0000000183253F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183253150-0x0000000183253320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarUnlockTalentNotify other) {} // 0x0000000183252C10-0x0000000183252DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001832529E0-0x0000000183252B10
}

