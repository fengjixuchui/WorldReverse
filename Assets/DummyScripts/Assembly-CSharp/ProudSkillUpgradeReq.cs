/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ProudSkillUpgradeReq : MessageBase, IMessage<ProudSkillUpgradeReq> // TypeDefIndex: 25501
{
	// Fields
	private static readonly MessageParser<ProudSkillUpgradeReq> _parser; // 0x00
	public const int AvatarGuidFieldNumber = 1; // Metadata: 0x00B08E73
	private ulong avatarGuid_; // 0x18
	public const int ProudSkillIdFieldNumber = 2; // Metadata: 0x00B08E77
	private uint proudSkillId_; // 0x20
	public const int OldProudSkillLevelFieldNumber = 3; // Metadata: 0x00B08E7B
	private uint oldProudSkillLevel_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ProudSkillUpgradeReq> Parser { get => default; } // 0x00000001843C5F30-0x00000001843C5FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001843C5B80-0x00000001843C5C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001843C5790-0x00000001843C5810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001843C4F90-0x00000001843C4FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001843C6300-0x00000001843C63F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001843C60F0-0x00000001843C6150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001843C5D50-0x00000001843C5E40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001843C62B0-0x00000001843C6300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001843C5950-0x00000001843C5A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x00000001843C5C10-0x00000001843C5CB0 0x00000001843C5150-0x00000001843C51F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ProudSkillId { get => default; set {} } // 0x00000001843C5CB0-0x00000001843C5D50 0x00000001843C5650-0x00000001843C56F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OldProudSkillLevel { get => default; set {} } // 0x00000001843C58B0-0x00000001843C5950 0x00000001843C56F0-0x00000001843C5790

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25502
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25503
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1009
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ProudSkillUpgradeReq() {} // 0x00000001843C6740-0x00000001843C67A0
	static ProudSkillUpgradeReq() {} // 0x00000001843C6680-0x00000001843C6740

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ProudSkillUpgradeReq Clone() => default; // 0x00000001843C5E40-0x00000001843C5F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ProudSkillUpgradeReq ShallowCopy() => default; // 0x00000001843C5810-0x00000001843C58B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001843C51F0-0x00000001843C5240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843C6050-0x00000001843C60A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843C60A0-0x00000001843C60F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001843C5240-0x00000001843C52C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001843C5400-0x00000001843C54D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ProudSkillUpgradeReq other) => default; // 0x00000001843C52C0-0x00000001843C5400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001843C5A40-0x00000001843C5B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001843C63F0-0x00000001843C6680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001843C6150-0x00000001843C62B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001843C54D0-0x00000001843C5650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ProudSkillUpgradeReq other) {} // 0x00000001843C4FF0-0x00000001843C5150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001843C4E80-0x00000001843C4F90
}

