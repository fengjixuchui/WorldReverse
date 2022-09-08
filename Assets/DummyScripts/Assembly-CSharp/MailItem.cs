/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MailItem : MessageBase, IMessage<MailItem> // TypeDefIndex: 26077
{
	// Fields
	private static readonly MessageParser<MailItem> _parser; // 0x00
	public const int EquipParamFieldNumber = 1; // Metadata: 0x00B0B06B
	private EquipParam equipParam_; // 0x18
	public const int DeleteInfoFieldNumber = 2; // Metadata: 0x00B0B06F
	private MaterialDeleteInfo deleteInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MailItem> Parser { get => default; } // 0x0000000181D212A0-0x0000000181D21330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181D20F90-0x0000000181D21020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181D20B90-0x0000000181D20C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181D20220-0x0000000181D20280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181D21740-0x0000000181D21830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181D214E0-0x0000000181D21540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181D210C0-0x0000000181D211B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181D216F0-0x0000000181D21740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181D20CB0-0x0000000181D20DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EquipParam EquipParam { get => default; set {} } // 0x0000000181D21540-0x0000000181D215E0 0x0000000181D21020-0x0000000181D210C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MaterialDeleteInfo DeleteInfo { get => default; set {} } // 0x0000000181D20460-0x0000000181D20500 0x0000000181D20180-0x0000000181D20220

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MailItem() {} // 0x0000000181D21AB0-0x0000000181D21B10
	static MailItem() {} // 0x0000000181D219F0-0x0000000181D21AB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MailItem Clone() => default; // 0x0000000181D211B0-0x0000000181D212A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MailItem ShallowCopy() => default; // 0x0000000181D20C10-0x0000000181D20CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181D20500-0x0000000181D20590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D213C0-0x0000000181D21450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181D21450-0x0000000181D214E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181D20590-0x0000000181D20770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181D208B0-0x0000000181D20980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MailItem other) => default; // 0x0000000181D20770-0x0000000181D208B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181D20DA0-0x0000000181D20F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181D21830-0x0000000181D219F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181D215E0-0x0000000181D216F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181D20980-0x0000000181D20B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MailItem other) {} // 0x0000000181D20280-0x0000000181D20460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181D20010-0x0000000181D20180
}

