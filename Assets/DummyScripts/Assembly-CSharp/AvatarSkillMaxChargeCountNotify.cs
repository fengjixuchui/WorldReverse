/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarSkillMaxChargeCountNotify : MessageBase, IMessage<AvatarSkillMaxChargeCountNotify> // TypeDefIndex: 25495
{
	// Fields
	private static readonly MessageParser<AvatarSkillMaxChargeCountNotify> _parser; // 0x00
	public const int AvatarGuidFieldNumber = 1; // Metadata: 0x00B08E3F
	private ulong avatarGuid_; // 0x18
	public const int SkillIdFieldNumber = 2; // Metadata: 0x00B08E43
	private uint skillId_; // 0x20
	public const int MaxChargeCountFieldNumber = 3; // Metadata: 0x00B08E47
	private uint maxChargeCount_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarSkillMaxChargeCountNotify> Parser { get => default; } // 0x00000001814FF300-0x00000001814FF390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001814FEE10-0x00000001814FEEA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001814FEA20-0x00000001814FEAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001814FE360-0x00000001814FE3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001814FF6D0-0x00000001814FF7C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001814FF4C0-0x00000001814FF520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001814FF080-0x00000001814FF170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001814FF680-0x00000001814FF6D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001814FEBE0-0x00000001814FECD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x00000001814FEFE0-0x00000001814FF080 0x00000001814FE520-0x00000001814FE5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SkillId { get => default; set {} } // 0x00000001814FEB40-0x00000001814FEBE0 0x00000001814FEEA0-0x00000001814FEF40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MaxChargeCount { get => default; set {} } // 0x00000001814FF170-0x00000001814FF210 0x00000001814FEF40-0x00000001814FEFE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25496
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25497
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1007
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSkillMaxChargeCountNotify() {} // 0x00000001814FFB10-0x00000001814FFB70
	static AvatarSkillMaxChargeCountNotify() {} // 0x00000001814FFA50-0x00000001814FFB10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSkillMaxChargeCountNotify Clone() => default; // 0x00000001814FF210-0x00000001814FF300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarSkillMaxChargeCountNotify ShallowCopy() => default; // 0x00000001814FEAA0-0x00000001814FEB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001814FE5C0-0x00000001814FE610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001814FF420-0x00000001814FF470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001814FF470-0x00000001814FF4C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001814FE610-0x00000001814FE690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001814FE7D0-0x00000001814FE8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarSkillMaxChargeCountNotify other) => default; // 0x00000001814FE690-0x00000001814FE7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001814FECD0-0x00000001814FEE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001814FF7C0-0x00000001814FFA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001814FF520-0x00000001814FF680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001814FE8A0-0x00000001814FEA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarSkillMaxChargeCountNotify other) {} // 0x00000001814FE3C0-0x00000001814FE520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001814FE250-0x00000001814FE360
}

