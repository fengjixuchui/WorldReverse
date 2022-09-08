/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarUpgradeReq : MessageBase, IMessage<AvatarUpgradeReq> // TypeDefIndex: 22432
{
	// Fields
	private static readonly MessageParser<AvatarUpgradeReq> _parser; // 0x00
	public const int ItemIdFieldNumber = 1; // Metadata: 0x00B018FB
	private uint itemId_; // 0x18
	public const int CountFieldNumber = 2; // Metadata: 0x00B018FF
	private uint count_; // 0x1C
	public const int AvatarGuidFieldNumber = 3; // Metadata: 0x00B01903
	private ulong avatarGuid_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarUpgradeReq> Parser { get => default; } // 0x0000000183B2CAC0-0x0000000183B2CB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183B2C7B0-0x0000000183B2C840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183B2C460-0x0000000183B2C4E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183B2BDA0-0x0000000183B2BE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183B2D070-0x0000000183B2D160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183B2CDC0-0x0000000183B2CE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183B2C8E0-0x0000000183B2C9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183B2CF80-0x0000000183B2CFD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183B2C580-0x0000000183B2C670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemId { get => default; set {} } // 0x0000000183B2CBE0-0x0000000183B2CC80 0x0000000183B2CFD0-0x0000000183B2D070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Count { get => default; set {} } // 0x0000000183B2CC80-0x0000000183B2CD20 0x0000000183B2BD00-0x0000000183B2BDA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x0000000183B2C840-0x0000000183B2C8E0 0x0000000183B2BF60-0x0000000183B2C000

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22433
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22434
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1717
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarUpgradeReq() {} // 0x0000000183B2D4B0-0x0000000183B2D510
	static AvatarUpgradeReq() {} // 0x0000000183B2D3F0-0x0000000183B2D4B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarUpgradeReq Clone() => default; // 0x0000000183B2C9D0-0x0000000183B2CAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarUpgradeReq ShallowCopy() => default; // 0x0000000183B2C4E0-0x0000000183B2C580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183B2C000-0x0000000183B2C050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B2CD20-0x0000000183B2CD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B2CD70-0x0000000183B2CDC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183B2C050-0x0000000183B2C0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183B2C0D0-0x0000000183B2C1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarUpgradeReq other) => default; // 0x0000000183B2C1A0-0x0000000183B2C2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183B2C670-0x0000000183B2C7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183B2D160-0x0000000183B2D3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183B2CE20-0x0000000183B2CF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183B2C2E0-0x0000000183B2C460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarUpgradeReq other) {} // 0x0000000183B2BE00-0x0000000183B2BF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183B2BBF0-0x0000000183B2BD00
}

