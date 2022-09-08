/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScenePlayGuestReplyInviteRsp : MessageBase, IMessage<ScenePlayGuestReplyInviteRsp> // TypeDefIndex: 25387
{
	// Fields
	private static readonly MessageParser<ScenePlayGuestReplyInviteRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B089EF
	private int retcode_; // 0x18
	public const int PlayIdFieldNumber = 2; // Metadata: 0x00B089F3
	private uint playId_; // 0x1C
	public const int IsAgreeFieldNumber = 3; // Metadata: 0x00B089F7
	private bool isAgree_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ScenePlayGuestReplyInviteRsp> Parser { get => default; } // 0x0000000181B1CD60-0x0000000181B1CDF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181B1CA50-0x0000000181B1CAE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181B1C670-0x0000000181B1C6F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181B1BEA0-0x0000000181B1BF00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181B1D1D0-0x0000000181B1D2C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181B1CFC0-0x0000000181B1D020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181B1CAE0-0x0000000181B1CBD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181B1D180-0x0000000181B1D1D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181B1C790-0x0000000181B1C880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181B1C530-0x0000000181B1C5D0 0x0000000181B1C130-0x0000000181B1C1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayId { get => default; set {} } // 0x0000000181B1C5D0-0x0000000181B1C670 0x0000000181B1C9B0-0x0000000181B1CA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAgree { get => default; set {} } // 0x0000000181B1CCC0-0x0000000181B1CD60 0x0000000181B1CDF0-0x0000000181B1CE90

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25388
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25389
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4358
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayGuestReplyInviteRsp() {} // 0x0000000181B1D610-0x0000000181B1D670
	static ScenePlayGuestReplyInviteRsp() {} // 0x0000000181B1D550-0x0000000181B1D610

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayGuestReplyInviteRsp Clone() => default; // 0x0000000181B1CBD0-0x0000000181B1CCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayGuestReplyInviteRsp ShallowCopy() => default; // 0x0000000181B1C6F0-0x0000000181B1C790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181B1C060-0x0000000181B1C0B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B1CF20-0x0000000181B1CF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B1CF70-0x0000000181B1CFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181B1C0B0-0x0000000181B1C130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181B1C310-0x0000000181B1C3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ScenePlayGuestReplyInviteRsp other) => default; // 0x0000000181B1C1D0-0x0000000181B1C310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181B1C880-0x0000000181B1C9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181B1D2C0-0x0000000181B1D550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181B1D020-0x0000000181B1D180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181B1C3E0-0x0000000181B1C530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ScenePlayGuestReplyInviteRsp other) {} // 0x0000000181B1BF00-0x0000000181B1C060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181B1BD90-0x0000000181B1BEA0
}

