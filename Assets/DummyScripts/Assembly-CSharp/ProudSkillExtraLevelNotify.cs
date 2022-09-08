/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ProudSkillExtraLevelNotify : MessageBase, IMessage<ProudSkillExtraLevelNotify> // TypeDefIndex: 25519
{
	// Fields
	private static readonly MessageParser<ProudSkillExtraLevelNotify> _parser; // 0x00
	public const int AvatarGuidFieldNumber = 1; // Metadata: 0x00B08F3B
	private ulong avatarGuid_; // 0x18
	public const int TalentTypeFieldNumber = 2; // Metadata: 0x00B08F3F
	private uint talentType_; // 0x20
	public const int TalentIndexFieldNumber = 3; // Metadata: 0x00B08F43
	private uint talentIndex_; // 0x24
	public const int ExtraLevelFieldNumber = 4; // Metadata: 0x00B08F47
	private uint extraLevel_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ProudSkillExtraLevelNotify> Parser { get => default; } // 0x0000000182C017E0-0x0000000182C01870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182C01390-0x0000000182C01420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182C01020-0x0000000182C010A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182C00810-0x0000000182C00870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182C01DD0-0x0000000182C01EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182C01A40-0x0000000182C01AA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182C01600-0x0000000182C016F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182C01D80-0x0000000182C01DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182C01140-0x0000000182C01230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x0000000182C014C0-0x0000000182C01560 0x0000000182C00A00-0x0000000182C00AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TalentType { get => default; set {} } // 0x0000000182C01AA0-0x0000000182C01B40 0x0000000182C01420-0x0000000182C014C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TalentIndex { get => default; set {} } // 0x0000000182C019A0-0x0000000182C01A40 0x0000000182C00B80-0x0000000182C00C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ExtraLevel { get => default; set {} } // 0x0000000182C01560-0x0000000182C01600 0x0000000182C01CE0-0x0000000182C01D80

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25520
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25521
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1015
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ProudSkillExtraLevelNotify() {} // 0x0000000182C022A0-0x0000000182C02300
	static ProudSkillExtraLevelNotify() {} // 0x0000000182C021E0-0x0000000182C022A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ProudSkillExtraLevelNotify Clone() => default; // 0x0000000182C016F0-0x0000000182C017E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ProudSkillExtraLevelNotify ShallowCopy() => default; // 0x0000000182C010A0-0x0000000182C01140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182C00AA0-0x0000000182C00AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C01900-0x0000000182C01950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C01950-0x0000000182C019A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182C00AF0-0x0000000182C00B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182C00C20-0x0000000182C00CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ProudSkillExtraLevelNotify other) => default; // 0x0000000182C00CF0-0x0000000182C00E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182C01230-0x0000000182C01390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182C01EC0-0x0000000182C021E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182C01B40-0x0000000182C01CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182C00E50-0x0000000182C01020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ProudSkillExtraLevelNotify other) {} // 0x0000000182C00870-0x0000000182C00A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182C006E0-0x0000000182C00810
}

