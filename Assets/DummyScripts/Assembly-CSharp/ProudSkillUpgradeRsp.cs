/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ProudSkillUpgradeRsp : MessageBase, IMessage<ProudSkillUpgradeRsp> // TypeDefIndex: 25504
{
	// Fields
	private static readonly MessageParser<ProudSkillUpgradeRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B08E93
	private int retcode_; // 0x18
	public const int AvatarGuidFieldNumber = 2; // Metadata: 0x00B08E97
	private ulong avatarGuid_; // 0x20
	public const int ProudSkillIdFieldNumber = 3; // Metadata: 0x00B08E9B
	private uint proudSkillId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ProudSkillUpgradeRsp> Parser { get => default; } // 0x00000001824F6710-0x00000001824F67A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001824F6360-0x00000001824F63F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001824F6010-0x00000001824F6090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001824F5770-0x00000001824F57D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001824F6AE0-0x00000001824F6BD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001824F68D0-0x00000001824F6930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001824F6530-0x00000001824F6620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001824F6A90-0x00000001824F6AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001824F6130-0x00000001824F6220 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001824F5F70-0x00000001824F6010 0x00000001824F5AA0-0x00000001824F5B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x00000001824F63F0-0x00000001824F6490 0x00000001824F5930-0x00000001824F59D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ProudSkillId { get => default; set {} } // 0x00000001824F6490-0x00000001824F6530 0x00000001824F5ED0-0x00000001824F5F70

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25505
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25506
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1010
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ProudSkillUpgradeRsp() {} // 0x00000001824F6F20-0x00000001824F6F80
	static ProudSkillUpgradeRsp() {} // 0x00000001824F6E60-0x00000001824F6F20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ProudSkillUpgradeRsp Clone() => default; // 0x00000001824F6620-0x00000001824F6710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ProudSkillUpgradeRsp ShallowCopy() => default; // 0x00000001824F6090-0x00000001824F6130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001824F59D0-0x00000001824F5A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824F6830-0x00000001824F6880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001824F6880-0x00000001824F68D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001824F5A20-0x00000001824F5AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001824F5C80-0x00000001824F5D50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ProudSkillUpgradeRsp other) => default; // 0x00000001824F5B40-0x00000001824F5C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001824F6220-0x00000001824F6360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001824F6BD0-0x00000001824F6E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001824F6930-0x00000001824F6A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001824F5D50-0x00000001824F5ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ProudSkillUpgradeRsp other) {} // 0x00000001824F57D0-0x00000001824F5930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001824F5660-0x00000001824F5770
}

