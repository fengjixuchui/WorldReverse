/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarSkillUpgradeRsp : MessageBase, IMessage<AvatarSkillUpgradeRsp> // TypeDefIndex: 25513
{
	// Fields
	private static readonly MessageParser<AvatarSkillUpgradeRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B08EEF
	private int retcode_; // 0x18
	public const int AvatarGuidFieldNumber = 2; // Metadata: 0x00B08EF3
	private ulong avatarGuid_; // 0x20
	public const int AvatarSkillIdFieldNumber = 3; // Metadata: 0x00B08EF7
	private uint avatarSkillId_; // 0x28
	public const int OldLevelFieldNumber = 4; // Metadata: 0x00B08EFB
	private uint oldLevel_; // 0x2C
	public const int CurLevelFieldNumber = 5; // Metadata: 0x00B08EFF
	private uint curLevel_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarSkillUpgradeRsp> Parser { get => default; } // 0x000000018195E820-0x000000018195E8B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018195E330-0x000000018195E3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018195DF90-0x000000018195E010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018195D5C0-0x000000018195D620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018195ED10-0x000000018195EE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018195E9E0-0x000000018195EA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018195E460-0x000000018195E550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018195ECC0-0x000000018195ED10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018195E0B0-0x000000018195E1A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018195DEF0-0x000000018195DF90 0x000000018195D960-0x000000018195DA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x000000018195E3C0-0x000000018195E460 0x000000018195D7D0-0x000000018195D870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarSkillId { get => default; set {} } // 0x000000018195DE50-0x000000018195DEF0 0x000000018195E6E0-0x000000018195E780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OldLevel { get => default; set {} } // 0x000000018195E780-0x000000018195E820 0x000000018195E640-0x000000018195E6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurLevel { get => default; set {} } // 0x000000018195D520-0x000000018195D5C0 0x000000018195EA40-0x000000018195EAE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25514
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25515
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1013
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSkillUpgradeRsp() {} // 0x000000018195F260-0x000000018195F2C0
	static AvatarSkillUpgradeRsp() {} // 0x000000018195F1A0-0x000000018195F260

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSkillUpgradeRsp Clone() => default; // 0x000000018195E550-0x000000018195E640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSkillUpgradeRsp ShallowCopy() => default; // 0x000000018195E010-0x000000018195E0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018195D870-0x000000018195D8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018195E940-0x000000018195E990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018195E990-0x000000018195E9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018195D8C0-0x000000018195D960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018195DB70-0x000000018195DC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarSkillUpgradeRsp other) => default; // 0x000000018195DA00-0x000000018195DB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018195E1A0-0x000000018195E330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018195EE00-0x000000018195F1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018195EAE0-0x000000018195ECC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018195DC40-0x000000018195DE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarSkillUpgradeRsp other) {} // 0x000000018195D620-0x000000018195D7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018195D3D0-0x000000018195D520
}

