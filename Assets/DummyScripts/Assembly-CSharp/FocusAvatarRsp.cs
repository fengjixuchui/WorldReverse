/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FocusAvatarRsp : MessageBase, IMessage<FocusAvatarRsp> // TypeDefIndex: 22499
{
	// Fields
	private static readonly MessageParser<FocusAvatarRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B01B87
	private int retcode_; // 0x18
	public const int IsFocusFieldNumber = 2; // Metadata: 0x00B01B8B
	private bool isFocus_; // 0x1C
	public const int AvatarGuidFieldNumber = 3; // Metadata: 0x00B01B8F
	private ulong avatarGuid_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FocusAvatarRsp> Parser { get => default; } // 0x000000018317A600-0x000000018317A690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018317A2F0-0x000000018317A380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183179FA0-0x000000018317A020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183179740-0x00000001831797A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018317A9D0-0x000000018317AAC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018317A7C0-0x000000018317A820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018317A420-0x000000018317A510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018317A980-0x000000018317A9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018317A0C0-0x000000018317A1B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183179F00-0x0000000183179FA0 0x0000000183179A70-0x0000000183179B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFocus { get => default; set {} } // 0x0000000183179E60-0x0000000183179F00 0x000000018317AAC0-0x000000018317AB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x000000018317A380-0x000000018317A420 0x0000000183179900-0x00000001831799A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22500
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22501
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1741
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FocusAvatarRsp() {} // 0x000000018317AEB0-0x000000018317AF10
	static FocusAvatarRsp() {} // 0x000000018317ADF0-0x000000018317AEB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FocusAvatarRsp Clone() => default; // 0x000000018317A510-0x000000018317A600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FocusAvatarRsp ShallowCopy() => default; // 0x000000018317A020-0x000000018317A0C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001831799A0-0x00000001831799F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018317A720-0x000000018317A770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018317A770-0x000000018317A7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001831799F0-0x0000000183179A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183179B10-0x0000000183179BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FocusAvatarRsp other) => default; // 0x0000000183179BE0-0x0000000183179D20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018317A1B0-0x000000018317A2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018317AB60-0x000000018317ADF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018317A820-0x000000018317A980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183179D20-0x0000000183179E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FocusAvatarRsp other) {} // 0x00000001831797A0-0x0000000183179900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183179630-0x0000000183179740
}

