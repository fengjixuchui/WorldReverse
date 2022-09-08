/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MailData : MessageBase, IMessage<MailData> // TypeDefIndex: 26078
{
	// Fields
	private static readonly MessageParser<MailData> _parser; // 0x00
	public const int MailIdFieldNumber = 1; // Metadata: 0x00B0B073
	private uint mailId_; // 0x18
	public const int MailTextContentFieldNumber = 4; // Metadata: 0x00B0B077
	private MailTextContent mailTextContent_; // 0x20
	public const int ItemListFieldNumber = 7; // Metadata: 0x00B0B07B
	private static readonly FieldCodec<MailItem> _repeated_itemList_codec; // 0x08
	private readonly RepeatedMessageField<MailItem> itemList_; // 0x28
	public const int SendTimeFieldNumber = 8; // Metadata: 0x00B0B07F
	private uint sendTime_; // 0x30
	public const int ExpireTimeFieldNumber = 9; // Metadata: 0x00B0B083
	private uint expireTime_; // 0x34
	public const int ImportanceFieldNumber = 10; // Metadata: 0x00B0B087
	private uint importance_; // 0x38
	public const int IsReadFieldNumber = 11; // Metadata: 0x00B0B08B
	private bool isRead_; // 0x3C
	public const int IsAttachmentGotFieldNumber = 12; // Metadata: 0x00B0B08F
	private bool isAttachmentGot_; // 0x3D
	public const int ConfigIdFieldNumber = 13; // Metadata: 0x00B0B093
	private uint configId_; // 0x40
	public const int ArgumentListFieldNumber = 14; // Metadata: 0x00B0B097
	private static readonly FieldCodec<string> _repeated_argumentList_codec; // 0x10
	private readonly RepeatedPrimitiveField<string> argumentList_; // 0x48

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MailData> Parser { get => default; } // 0x000000018309C3C0-0x000000018309C450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018309C050-0x000000018309C0E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018309BA30-0x000000018309BAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018309A700-0x000000018309A760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018309CC00-0x000000018309CCF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018309C6C0-0x000000018309C720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018309C1E0-0x000000018309C2D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018309CBB0-0x000000018309CC00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018309BB50-0x000000018309BC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MailId { get => default; set {} } // 0x000000018309BF10-0x000000018309BFB0 0x000000018309B8F0-0x000000018309B990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MailTextContent MailTextContent { get => default; set {} } // 0x000000018309C720-0x000000018309C7C0 0x000000018309B1C0-0x000000018309B260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<MailItem> ItemList { get => default; } // 0x000000018309C0E0-0x000000018309C140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SendTime { get => default; set {} } // 0x000000018309AC20-0x000000018309ACC0 0x000000018309C620-0x000000018309C6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ExpireTime { get => default; set {} } // 0x000000018309B990-0x000000018309BA30 0x000000018309AFE0-0x000000018309B080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Importance { get => default; set {} } // 0x000000018309A8A0-0x000000018309A940 0x000000018309B120-0x000000018309B1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsRead { get => default; set {} } // 0x000000018309CB10-0x000000018309CBB0 0x000000018309A800-0x000000018309A8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsAttachmentGot { get => default; set {} } // 0x000000018309BFB0-0x000000018309C050 0x000000018309B080-0x000000018309B120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ConfigId { get => default; set {} } // 0x000000018309C140-0x000000018309C1E0 0x000000018309A760-0x000000018309A800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<string> ArgumentList { get => default; } // 0x000000018309ACC0-0x000000018309AD20 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MailData() {} // 0x000000018309D430-0x000000018309D4E0
	static MailData() {} // 0x000000018309D300-0x000000018309D430

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MailData Clone() => default; // 0x000000018309C2D0-0x000000018309C3C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MailData ShallowCopy() => default; // 0x000000018309BAB0-0x000000018309BB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018309AD20-0x000000018309ADA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018309C4E0-0x000000018309C580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018309C580-0x000000018309C620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018309ADA0-0x000000018309AFE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018309B4A0-0x000000018309B570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MailData other) => default; // 0x000000018309B260-0x000000018309B4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018309BC40-0x000000018309BF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018309CCF0-0x000000018309D300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018309C7C0-0x000000018309CB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018309B570-0x000000018309B8F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MailData other) {} // 0x000000018309A940-0x000000018309AC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018309A420-0x000000018309A700
}

