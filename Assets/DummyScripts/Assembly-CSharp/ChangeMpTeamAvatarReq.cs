/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ChangeMpTeamAvatarReq : MessageBase, IMessage<ChangeMpTeamAvatarReq> // TypeDefIndex: 22480
{
	// Fields
	private static readonly MessageParser<ChangeMpTeamAvatarReq> _parser; // 0x00
	public const int AvatarGuidListFieldNumber = 1; // Metadata: 0x00B01AA3
	private static readonly FieldCodec<ulong> _repeated_avatarGuidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<ulong> avatarGuidList_; // 0x18
	public const int CurAvatarGuidFieldNumber = 2; // Metadata: 0x00B01AA7
	private ulong curAvatarGuid_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ChangeMpTeamAvatarReq> Parser { get => default; } // 0x0000000181EFE9B0-0x0000000181EFEA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181EFE6E0-0x0000000181EFE770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181EFE3D0-0x0000000181EFE450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181EFDDF0-0x0000000181EFDE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181EFEEA0-0x0000000181EFEF90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181EFECB0-0x0000000181EFED10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181EFE770-0x0000000181EFE860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181EFEE50-0x0000000181EFEEA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181EFE4F0-0x0000000181EFE5E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<ulong> AvatarGuidList { get => default; } // 0x0000000181EFE950-0x0000000181EFE9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong CurAvatarGuid { get => default; set {} } // 0x0000000181EFEAE0-0x0000000181EFEB80 0x0000000181EFEA40-0x0000000181EFEAE0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22481
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22482
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 1734
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeMpTeamAvatarReq() {} // 0x0000000181EFF260-0x0000000181EFF2F0
	static ChangeMpTeamAvatarReq() {} // 0x0000000181EFF180-0x0000000181EFF260

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeMpTeamAvatarReq Clone() => default; // 0x0000000181EFE860-0x0000000181EFE950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ChangeMpTeamAvatarReq ShallowCopy() => default; // 0x0000000181EFE450-0x0000000181EFE4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181EFDF80-0x0000000181EFDFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181EFEC10-0x0000000181EFEC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181EFEC60-0x0000000181EFECB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181EFDFD0-0x0000000181EFE0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181EFE0A0-0x0000000181EFE170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ChangeMpTeamAvatarReq other) => default; // 0x0000000181EFE170-0x0000000181EFE290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181EFE5E0-0x0000000181EFE6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181EFEF90-0x0000000181EFF180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181EFED10-0x0000000181EFEE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181EFE290-0x0000000181EFE3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ChangeMpTeamAvatarReq other) {} // 0x0000000181EFDE50-0x0000000181EFDF80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181EFDC80-0x0000000181EFDDF0
}

