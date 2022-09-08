/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Field : MessageBase, IMessage<Field> // TypeDefIndex: 26459
{
	// Fields
	private static readonly MessageParser<Field> _parser; // 0x00
	public const int KindFieldNumber = 1; // Metadata: 0x00B0C270
	private Types.Kind kind_; // 0x18
	public const int CardinalityFieldNumber = 2; // Metadata: 0x00B0C274
	private Types.Cardinality cardinality_; // 0x1C
	public const int NumberFieldNumber = 3; // Metadata: 0x00B0C278
	private int number_; // 0x20
	public const int NameFieldNumber = 4; // Metadata: 0x00B0C27C
	private string name_; // 0x28
	public const int TypeUrlFieldNumber = 6; // Metadata: 0x00B0C280
	private string typeUrl_; // 0x30
	public const int OneofIndexFieldNumber = 7; // Metadata: 0x00B0C284
	private int oneofIndex_; // 0x38
	public const int PackedFieldNumber = 8; // Metadata: 0x00B0C288
	private bool packed_; // 0x3C
	public const int OptionsFieldNumber = 9; // Metadata: 0x00B0C28C
	private static readonly FieldCodec<Option> _repeated_options_codec; // 0x08
	private readonly RepeatedMessageField<Option> options_; // 0x40
	public const int JsonNameFieldNumber = 10; // Metadata: 0x00B0C290
	private string jsonName_; // 0x48
	public const int DefaultValueFieldNumber = 11; // Metadata: 0x00B0C294
	private string defaultValue_; // 0x50

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Field> Parser { /* [XID] */ /* 0x0000000189A94B00-0x0000000189A94B20 */ get => default; } // 0x000000018170BB80-0x000000018170BC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189A9C380-0x0000000189A9C3A0 */ get => default; } // 0x000000018170B2A0-0x000000018170B390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189AA3AD0-0x0000000189AA3AF0 */ get => default; } // 0x000000018170A890-0x000000018170A960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189AAB0F0-0x0000000189AAB110 */ get => default; } // 0x0000000181709780-0x0000000181709820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189AB2A40-0x0000000189AB2A60 */ get => default; } // 0x000000018170C8B0-0x000000018170C9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189ABA5F0-0x0000000189ABA610 */ get => default; } // 0x000000018170C120-0x000000018170C1C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189AC1F80-0x0000000189AC1FA0 */ get => default; } // 0x000000018170B790-0x000000018170B890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x0000000189AC9550-0x0000000189AC9570 */ get => default; } // 0x000000018170C810-0x000000018170C8B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189AD0F20-0x0000000189AD0F40 */ get => default; } // 0x000000018170AB20-0x000000018170AC20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.Kind Kind { /* [XID] */ /* 0x0000000189B176E0-0x0000000189B17700 */ get => default; /* [XID] */ /* 0x0000000189B1EF70-0x0000000189B1EF90 */ set {} } // 0x000000018170B5D0-0x000000018170B6B0 0x000000018170B470-0x000000018170B550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Types.Cardinality Cardinality { /* [XID] */ /* 0x0000000189B26970-0x0000000189B26990 */ get => default; /* [XID] */ /* 0x0000000189B2DAE0-0x0000000189B2DB00 */ set {} } // 0x000000018170B9C0-0x000000018170BAA0 0x000000018170C730-0x000000018170C810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Number { /* [XID] */ /* 0x0000000189B34EE0-0x0000000189B34F00 */ get => default; /* [XID] */ /* 0x0000000189B3C7B0-0x0000000189B3C7D0 */ set {} } // 0x000000018170B0E0-0x000000018170B1C0 0x000000018170B6B0-0x000000018170B790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { /* [XID] */ /* 0x0000000189B44550-0x0000000189B44570 */ get => default; /* [XID] */ /* 0x0000000189B4BBF0-0x0000000189B4BC10 */ set {} } // 0x000000018170A7B0-0x000000018170A890 0x0000000181709E60-0x0000000181709F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string TypeUrl { /* [XID] */ /* 0x0000000189B531B0-0x0000000189B531D0 */ get => default; /* [XID] */ /* 0x0000000189B5AB40-0x0000000189B5AB60 */ set {} } // 0x000000018170BDB0-0x000000018170BE90 0x000000018170AFF0-0x000000018170B0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int OneofIndex { /* [XID] */ /* 0x0000000189B61F10-0x0000000189B61F30 */ get => default; /* [XID] */ /* 0x0000000189B69BC0-0x0000000189B69BE0 */ set {} } // 0x000000018170AA40-0x000000018170AB20 0x000000018170BF60-0x000000018170C040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Packed { /* [XID] */ /* 0x0000000189B71160-0x0000000189B71180 */ get => default; /* [XID] */ /* 0x0000000189B78770-0x0000000189B78790 */ set {} } // 0x000000018170B1C0-0x000000018170B2A0 0x000000018170BAA0-0x000000018170BB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Option> Options { /* [XID] */ /* 0x0000000189B7FD30-0x0000000189B7FD50 */ get => default; } // 0x000000018170C1C0-0x000000018170C260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string JsonName { /* [XID] */ /* 0x0000000189B877A0-0x0000000189B877C0 */ get => default; /* [XID] */ /* 0x0000000189B8E950-0x0000000189B8E970 */ set {} } // 0x000000018170B390-0x000000018170B470 0x000000018170C640-0x000000018170C730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string DefaultValue { /* [XID] */ /* 0x0000000189B95DF0-0x0000000189B95E10 */ get => default; /* [XID] */ /* 0x0000000189B9D330-0x0000000189B9D350 */ set {} } // 0x000000018170C040-0x000000018170C120 0x000000018170C9B0-0x000000018170CAA0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 26460
	{
		// Nested types
		public enum Kind // TypeDefIndex: 26461
		{
			TypeUnknown = 0,
			TypeDouble = 1,
			TypeFloat = 2,
			TypeInt64 = 3,
			TypeUint64 = 4,
			TypeInt32 = 5,
			TypeFixed64 = 6,
			TypeFixed32 = 7,
			TypeBool = 8,
			TypeString = 9,
			TypeGroup = 10,
			TypeMessage = 11,
			TypeBytes = 12,
			TypeUint32 = 13,
			TypeEnum = 14,
			TypeSfixed32 = 15,
			TypeSfixed64 = 16,
			TypeSint32 = 17,
			TypeSint64 = 18
		}

		public enum Cardinality // TypeDefIndex: 26462
		{
			Unknown = 0,
			Optional = 1,
			Required = 2,
			Repeated = 3
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Field() {} // 0x000000018170D1D0-0x000000018170D290
	static Field() {} // 0x000000018170D0C0-0x000000018170D1D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189AD8C50-0x0000000189AD8C90
	// [XID] // 0x0000000189AD8C50-0x0000000189AD8C90
	public Field Clone() => default; // 0x000000018170B890-0x000000018170B9C0
	[DebuggerNonUserCode] // 0x0000000189AE3540-0x0000000189AE3580
	// [XID] // 0x0000000189AE3540-0x0000000189AE3580
	public Field ShallowCopy() => default; // 0x000000018170A960-0x000000018170AA40
	[DebuggerNonUserCode] // 0x0000000189AEDEF0-0x0000000189AEDF30
	// [XID] // 0x0000000189AEDEF0-0x0000000189AEDF30
	protected override void InternalSetInPool(bool value) {} // 0x0000000181709BD0-0x0000000181709C80
	[DebuggerNonUserCode] // 0x0000000189AF8780-0x0000000189AF87C0
	// [XID] // 0x0000000189AF8780-0x0000000189AF87C0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018170BCE0-0x000000018170BDB0
	[DebuggerNonUserCode] // 0x0000000189B02D70-0x0000000189B02DB0
	// [XID] // 0x0000000189B02D70-0x0000000189B02DB0
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018170BE90-0x000000018170BF60
	[DebuggerNonUserCode] // 0x0000000189B0D460-0x0000000189B0D4A0
	// [XID] // 0x0000000189B0D460-0x0000000189B0D4A0
	public override void Reset() {} // 0x0000000181709C80-0x0000000181709DF0
	[DebuggerNonUserCode] // 0x0000000189BA4D10-0x0000000189BA4D60
	// [IDTag] // 0x0000000189BA4D10-0x0000000189BA4D60
	// [XID] // 0x0000000189BA4D10-0x0000000189BA4D60
	public override bool Equals(object other) => default; // 0x000000018170A2A0-0x000000018170A3B0
	[DebuggerNonUserCode] // 0x0000000189BB1F10-0x0000000189BB1F60
	// [IDTag] // 0x0000000189BB1F10-0x0000000189BB1F60
	// [XID] // 0x0000000189BB1F10-0x0000000189BB1F60
	public bool Equals(Field other) => default; // 0x0000000181709F50-0x000000018170A2A0
	[DebuggerNonUserCode] // 0x0000000189BBF1A0-0x0000000189BBF1E0
	// [XID] // 0x0000000189BBF1A0-0x0000000189BBF1E0
	public override int GetHashCode() => default; // 0x000000018170AC20-0x000000018170AFF0
	[DebuggerNonUserCode] // 0x0000000189BCA3E0-0x0000000189BCA420
	// [XID] // 0x0000000189BCA3E0-0x0000000189BCA420
	public override string ToString() => default; // 0x000000018170CAA0-0x000000018170D0C0
	[DebuggerNonUserCode] // 0x0000000189BD4840-0x0000000189BD4880
	// [XID] // 0x0000000189BD4840-0x0000000189BD4880
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018170C260-0x000000018170C640
	[DebuggerNonUserCode] // 0x0000000189BDF1F0-0x0000000189BDF230
	// [XID] // 0x0000000189BDF1F0-0x0000000189BDF230
	public override int CalculateSize() => default; // 0x000000018170A3B0-0x000000018170A7B0
	[DebuggerNonUserCode] // 0x00000001895EEB60-0x00000001895EEBA0
	// [XID] // 0x00000001895EEB60-0x00000001895EEBA0
	public void CopyFrom(Field other) {} // 0x0000000181709890-0x0000000181709BD0
	[DebuggerNonUserCode] // 0x00000001895F9510-0x00000001895F9550
	// [XID] // 0x00000001895F9510-0x00000001895F9550
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181709500-0x0000000181709780
}

