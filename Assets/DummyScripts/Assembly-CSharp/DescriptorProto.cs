/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class DescriptorProto : MessageBase, IMessage<DescriptorProto> // TypeDefIndex: 26357
{
	// Fields
	private static readonly MessageParser<DescriptorProto> _parser; // 0x00
	public const int NameFieldNumber = 1; // Metadata: 0x00B0BEED
	private string name_; // 0x18
	public const int FieldFieldNumber = 2; // Metadata: 0x00B0BEF1
	private static readonly FieldCodec<FieldDescriptorProto> _repeated_field_codec; // 0x08
	private readonly RepeatedMessageField<FieldDescriptorProto> field_; // 0x20
	public const int ExtensionFieldNumber = 6; // Metadata: 0x00B0BEF5
	private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec; // 0x10
	private readonly RepeatedMessageField<FieldDescriptorProto> extension_; // 0x28
	public const int NestedTypeFieldNumber = 3; // Metadata: 0x00B0BEF9
	private static readonly FieldCodec<DescriptorProto> _repeated_nestedType_codec; // 0x18
	private readonly RepeatedMessageField<DescriptorProto> nestedType_; // 0x30
	public const int EnumTypeFieldNumber = 4; // Metadata: 0x00B0BEFD
	private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec; // 0x20
	private readonly RepeatedMessageField<EnumDescriptorProto> enumType_; // 0x38
	public const int ExtensionRangeFieldNumber = 5; // Metadata: 0x00B0BF01
	private static readonly FieldCodec<Types.ExtensionRange> _repeated_extensionRange_codec; // 0x28
	private readonly RepeatedMessageField<Types.ExtensionRange> extensionRange_; // 0x40
	public const int OneofDeclFieldNumber = 8; // Metadata: 0x00B0BF05
	private static readonly FieldCodec<OneofDescriptorProto> _repeated_oneofDecl_codec; // 0x30
	private readonly RepeatedMessageField<OneofDescriptorProto> oneofDecl_; // 0x48
	public const int OptionsFieldNumber = 7; // Metadata: 0x00B0BF09
	private MessageOptions options_; // 0x50
	public const int ReservedRangeFieldNumber = 9; // Metadata: 0x00B0BF0D
	private static readonly FieldCodec<Types.ReservedRange> _repeated_reservedRange_codec; // 0x38
	private readonly RepeatedMessageField<Types.ReservedRange> reservedRange_; // 0x58
	public const int ReservedNameFieldNumber = 10; // Metadata: 0x00B0BF11
	private static readonly FieldCodec<string> _repeated_reservedName_codec; // 0x40
	private readonly RepeatedPrimitiveField<string> reservedName_; // 0x60

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DescriptorProto> Parser { /* [XID] */ /* 0x00000001897C4480-0x00000001897C44A0 */ get => default; } // 0x00000001843070B0-0x0000000184307180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x00000001897CBC80-0x00000001897CBCA0 */ get => default; } // 0x0000000184306D10-0x0000000184306E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x00000001897D3650-0x00000001897D3670 */ get => default; } // 0x0000000184306670-0x0000000184306740 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x00000001897DB110-0x00000001897DB130 */ get => default; } // 0x00000001843052C0-0x0000000184305360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x00000001897E2780-0x00000001897E27A0 */ get => default; } // 0x0000000184307B70-0x0000000184307C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x00000001897E9E90-0x00000001897E9EB0 */ get => default; } // 0x00000001843075F0-0x0000000184307690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x00000001897F1B90-0x00000001897F1BB0 */ get => default; } // 0x0000000184306E80-0x0000000184306F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x00000001897F93C0-0x00000001897F93E0 */ get => default; } // 0x0000000184307AD0-0x0000000184307B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189800960-0x0000000189800980 */ get => default; } // 0x0000000184306820-0x0000000184306920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { /* [XID] */ /* 0x0000000189846790-0x00000001898467B0 */ get => default; /* [XID] */ /* 0x000000018984DD60-0x000000018984DD80 */ set {} } // 0x0000000184306590-0x0000000184306670 0x0000000184305B10-0x0000000184305C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<FieldDescriptorProto> Field { /* [XID] */ /* 0x0000000189854E40-0x0000000189854E60 */ get => default; } // 0x0000000184305C00-0x0000000184305CA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<FieldDescriptorProto> Extension { /* [XID] */ /* 0x000000018985C5E0-0x000000018985C600 */ get => default; } // 0x0000000184306C70-0x0000000184306D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<DescriptorProto> NestedType { /* [XID] */ /* 0x0000000189863F60-0x0000000189863F80 */ get => default; } // 0x0000000184307C70-0x0000000184307D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<EnumDescriptorProto> EnumType { /* [XID] */ /* 0x000000018986B310-0x000000018986B330 */ get => default; } // 0x00000001843064F0-0x0000000184306590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Types.ExtensionRange> ExtensionRange { /* [XID] */ /* 0x00000001898726A0-0x00000001898726C0 */ get => default; } // 0x0000000184306920-0x00000001843069C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<OneofDescriptorProto> OneofDecl { /* [XID] */ /* 0x000000018987A290-0x000000018987A2B0 */ get => default; } // 0x00000001843057C0-0x0000000184305860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MessageOptions Options { /* [XID] */ /* 0x0000000189881450-0x0000000189881470 */ get => default; /* [XID] */ /* 0x00000001898889A0-0x00000001898889C0 */ set {} } // 0x0000000184307690-0x0000000184307770 0x0000000184307D10-0x0000000184307DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Types.ReservedRange> ReservedRange { /* [XID] */ /* 0x000000018988FD20-0x000000018988FD40 */ get => default; } // 0x0000000184307550-0x00000001843075F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<string> ReservedName { /* [XID] */ /* 0x0000000189897290-0x00000001898972B0 */ get => default; } // 0x0000000184305CA0-0x0000000184305D40 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 26358
	{
		// Nested types
		internal sealed class ExtensionRange : MessageBase, IMessage<ExtensionRange> // TypeDefIndex: 26359
		{
			// Fields
			private static readonly MessageParser<ExtensionRange> _parser; // 0x00
			public const int StartFieldNumber = 1; // Metadata: 0x00B0BF15
			private int start_; // 0x18
			public const int EndFieldNumber = 2; // Metadata: 0x00B0BF19
			private int end_; // 0x1C
			public const int OptionsFieldNumber = 3; // Metadata: 0x00B0BF1D
			private ExtensionRangeOptions options_; // 0x20

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<ExtensionRange> Parser { /* [XID] */ /* 0x000000018999E4A0-0x000000018999E4C0 */ get => default; } // 0x0000000184318DF0-0x0000000184318EC0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x00000001899A5E90-0x00000001899A5EB0 */ get => default; } // 0x00000001843187D0-0x00000001843188A0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { /* [XID] */ /* 0x00000001899AD530-0x00000001899AD550 */ get => default; } // 0x00000001843183A0-0x0000000184318470 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { /* [XID] */ /* 0x00000001899B4DB0-0x00000001899B4DD0 */ get => default; } // 0x0000000184317A00-0x0000000184317AA0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { /* [XID] */ /* 0x00000001899BC500-0x00000001899BC520 */ get => default; } // 0x0000000184319570-0x0000000184319670 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { /* [XID] */ /* 0x00000001899C3E10-0x00000001899C3E30 */ get => default; } // 0x00000001843190D0-0x0000000184319170 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { /* [XID] */ /* 0x00000001899CB650-0x00000001899CB670 */ get => default; } // 0x0000000184318AE0-0x0000000184318BE0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { /* [XID] */ /* 0x00000001899D29E0-0x00000001899D2A00 */ get => default; } // 0x00000001843194D0-0x0000000184319570 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { /* [XID] */ /* 0x00000001899DA0D0-0x00000001899DA0F0 */ get => default; } // 0x0000000184318550-0x0000000184318650 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public int Start { /* [XID] */ /* 0x0000000189A1FF60-0x0000000189A1FF80 */ get => default; /* [XID] */ /* 0x0000000189A272F0-0x0000000189A27310 */ set {} } // 0x0000000184318A00-0x0000000184318AE0 0x00000001843188A0-0x0000000184318980
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public int End { /* [XID] */ /* 0x0000000189A2EAD0-0x0000000189A2EAF0 */ get => default; /* [XID] */ /* 0x0000000189A36420-0x0000000189A36440 */ set {} } // 0x0000000184319250-0x0000000184319330 0x0000000184318D10-0x0000000184318DF0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public ExtensionRangeOptions Options { /* [XID] */ /* 0x0000000189A3D9A0-0x0000000189A3D9C0 */ get => default; /* [XID] */ /* 0x0000000189A45140-0x0000000189A45160 */ set {} } // 0x0000000184319170-0x0000000184319250 0x0000000184319670-0x0000000184319750

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public ExtensionRange() {} // 0x0000000184319AC0-0x0000000184319B20
			static ExtensionRange() {} // 0x0000000184319A00-0x0000000184319AC0

			// Methods
			[DebuggerNonUserCode] // 0x00000001899E1B70-0x00000001899E1BB0
			// [XID] // 0x00000001899E1B70-0x00000001899E1BB0
			public ExtensionRange Clone() => default; // 0x0000000184318BE0-0x0000000184318D10
			[DebuggerNonUserCode] // 0x00000001899EC000-0x00000001899EC040
			// [XID] // 0x00000001899EC000-0x00000001899EC040
			public ExtensionRange ShallowCopy() => default; // 0x0000000184318470-0x0000000184318550
			[DebuggerNonUserCode] // 0x00000001899F68C0-0x00000001899F6900
			// [XID] // 0x00000001899F68C0-0x00000001899F6900
			protected override void InternalSetInPool(bool value) {} // 0x0000000184317D00-0x0000000184317DC0
			[DebuggerNonUserCode] // 0x0000000189A00BE0-0x0000000189A00C20
			// [XID] // 0x0000000189A00BE0-0x0000000189A00C20
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184318F50-0x0000000184319010
			[DebuggerNonUserCode] // 0x0000000189A0B370-0x0000000189A0B3B0
			// [XID] // 0x0000000189A0B370-0x0000000189A0B3B0
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184319010-0x00000001843190D0
			[DebuggerNonUserCode] // 0x0000000189A15B30-0x0000000189A15B70
			// [XID] // 0x0000000189A15B30-0x0000000189A15B70
			public override void Reset() {} // 0x0000000184317DC0-0x0000000184317ED0
			[DebuggerNonUserCode] // 0x0000000189A4C840-0x0000000189A4C890
			// [IDTag] // 0x0000000189A4C840-0x0000000189A4C890
			// [XID] // 0x0000000189A4C840-0x0000000189A4C890
			public override bool Equals(object other) => default; // 0x0000000184317F40-0x0000000184318050
			[DebuggerNonUserCode] // 0x0000000189A5A0C0-0x0000000189A5A110
			// [IDTag] // 0x0000000189A5A0C0-0x0000000189A5A110
			// [XID] // 0x0000000189A5A0C0-0x0000000189A5A110
			public bool Equals(ExtensionRange other) => default; // 0x0000000184318050-0x00000001843181E0
			[DebuggerNonUserCode] // 0x0000000189A67E20-0x0000000189A67E60
			// [XID] // 0x0000000189A67E20-0x0000000189A67E60
			public override int GetHashCode() => default; // 0x0000000184318650-0x00000001843187D0
			[DebuggerNonUserCode] // 0x0000000189A72380-0x0000000189A723C0
			// [XID] // 0x0000000189A72380-0x0000000189A723C0
			public override string ToString() => default; // 0x0000000184319750-0x0000000184319A00
			[DebuggerNonUserCode] // 0x0000000189A7CC20-0x0000000189A7CC60
			// [XID] // 0x0000000189A7CC20-0x0000000189A7CC60
			public override void WriteTo(CodedOutputStream output) {} // 0x0000000184319330-0x00000001843194D0
			[DebuggerNonUserCode] // 0x0000000189A87700-0x0000000189A87740
			// [XID] // 0x0000000189A87700-0x0000000189A87740
			public override int CalculateSize() => default; // 0x00000001843181E0-0x00000001843183A0
			[DebuggerNonUserCode] // 0x0000000189A91E30-0x0000000189A91E70
			// [XID] // 0x0000000189A91E30-0x0000000189A91E70
			public void CopyFrom(ExtensionRange other) {} // 0x0000000184317B10-0x0000000184317D00
			[DebuggerNonUserCode] // 0x0000000189A9C3E0-0x0000000189A9C420
			// [XID] // 0x0000000189A9C3E0-0x0000000189A9C420
			public override void MergeFrom(CodedInputStream input) {} // 0x0000000184317850-0x0000000184317A00
		}

		internal sealed class ReservedRange : MessageBase, IMessage<ReservedRange> // TypeDefIndex: 26360
		{
			// Fields
			private static readonly MessageParser<ReservedRange> _parser; // 0x00
			public const int StartFieldNumber = 1; // Metadata: 0x00B0BF21
			private int start_; // 0x18
			public const int EndFieldNumber = 2; // Metadata: 0x00B0BF25
			private int end_; // 0x1C

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<ReservedRange> Parser { /* [XID] */ /* 0x0000000189B105E0-0x0000000189B10600 */ get => default; } // 0x00000001842FA010-0x00000001842FA0E0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189B17760-0x0000000189B17780 */ get => default; } // 0x00000001842F99F0-0x00000001842F9AC0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189B1EFD0-0x0000000189B1EFF0 */ get => default; } // 0x00000001842F95F0-0x00000001842F96C0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { /* [XID] */ /* 0x0000000189B269B0-0x0000000189B269D0 */ get => default; } // 0x00000001842F8DA0-0x00000001842F8E40 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { /* [XID] */ /* 0x0000000189B2DB00-0x0000000189B2DB20 */ get => default; } // 0x00000001842FA650-0x00000001842FA750 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { /* [XID] */ /* 0x0000000189B34F00-0x0000000189B34F20 */ get => default; } // 0x00000001842FA2D0-0x00000001842FA370 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { /* [XID] */ /* 0x0000000189B3C810-0x0000000189B3C830 */ get => default; } // 0x00000001842F9D00-0x00000001842F9E00 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { /* [XID] */ /* 0x0000000189B44570-0x0000000189B44590 */ get => default; } // 0x00000001842FA5B0-0x00000001842FA650 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { /* [XID] */ /* 0x0000000189B4BC90-0x0000000189B4BCB0 */ get => default; } // 0x00000001842F97A0-0x00000001842F98A0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public int Start { /* [XID] */ /* 0x0000000189B91AE0-0x0000000189B91B00 */ get => default; /* [XID] */ /* 0x0000000189B98F40-0x0000000189B98F60 */ set {} } // 0x00000001842F9C20-0x00000001842F9D00 0x00000001842F9AC0-0x00000001842F9BA0
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public int End { /* [XID] */ /* 0x0000000189BA02C0-0x0000000189BA02E0 */ get => default; /* [XID] */ /* 0x0000000189BA7B00-0x0000000189BA7B20 */ set {} } // 0x00000001842FA370-0x00000001842FA450 0x00000001842F9F30-0x00000001842FA010

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public ReservedRange() {} // 0x00000001842FAA50-0x00000001842FAAB0
			static ReservedRange() {} // 0x00000001842FA990-0x00000001842FAA50

			// Methods
			[DebuggerNonUserCode] // 0x0000000189B531D0-0x0000000189B53210
			// [XID] // 0x0000000189B531D0-0x0000000189B53210
			public ReservedRange Clone() => default; // 0x00000001842F9E00-0x00000001842F9F30
			[DebuggerNonUserCode] // 0x0000000189B5DC50-0x0000000189B5DC90
			// [XID] // 0x0000000189B5DC50-0x0000000189B5DC90
			public ReservedRange ShallowCopy() => default; // 0x00000001842F96C0-0x00000001842F97A0
			[DebuggerNonUserCode] // 0x0000000189B68470-0x0000000189B684B0
			// [XID] // 0x0000000189B68470-0x0000000189B684B0
			protected override void InternalSetInPool(bool value) {} // 0x00000001842F9030-0x00000001842F90E0
			[DebuggerNonUserCode] // 0x0000000189B72960-0x0000000189B729A0
			// [XID] // 0x0000000189B72960-0x0000000189B729A0
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842FA170-0x00000001842FA220
			[DebuggerNonUserCode] // 0x0000000189B7CB40-0x0000000189B7CB80
			// [XID] // 0x0000000189B7CB40-0x0000000189B7CB80
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001842FA220-0x00000001842FA2D0
			[DebuggerNonUserCode] // 0x0000000189B877C0-0x0000000189B87800
			// [XID] // 0x0000000189B877C0-0x0000000189B87800
			public override void Reset() {} // 0x00000001842F90E0-0x00000001842F9190
			[DebuggerNonUserCode] // 0x0000000189BAEEB0-0x0000000189BAEF00
			// [IDTag] // 0x0000000189BAEEB0-0x0000000189BAEF00
			// [XID] // 0x0000000189BAEEB0-0x0000000189BAEF00
			public override bool Equals(object other) => default; // 0x00000001842F9370-0x00000001842F9480
			[DebuggerNonUserCode] // 0x0000000189BBC440-0x0000000189BBC490
			// [IDTag] // 0x0000000189BBC440-0x0000000189BBC490
			// [XID] // 0x0000000189BBC440-0x0000000189BBC490
			public bool Equals(ReservedRange other) => default; // 0x00000001842F9200-0x00000001842F9370
			[DebuggerNonUserCode] // 0x0000000189BCA440-0x0000000189BCA480
			// [XID] // 0x0000000189BCA440-0x0000000189BCA480
			public override int GetHashCode() => default; // 0x00000001842F98A0-0x00000001842F99F0
			[DebuggerNonUserCode] // 0x0000000189BD48A0-0x0000000189BD48E0
			// [XID] // 0x0000000189BD48A0-0x0000000189BD48E0
			public override string ToString() => default; // 0x00000001842FA750-0x00000001842FA990
			[DebuggerNonUserCode] // 0x0000000189BDF270-0x0000000189BDF2B0
			// [XID] // 0x0000000189BDF270-0x0000000189BDF2B0
			public override void WriteTo(CodedOutputStream output) {} // 0x00000001842FA450-0x00000001842FA5B0
			[DebuggerNonUserCode] // 0x00000001895EEBA0-0x00000001895EEBE0
			// [XID] // 0x00000001895EEBA0-0x00000001895EEBE0
			public override int CalculateSize() => default; // 0x00000001842F9480-0x00000001842F95F0
			[DebuggerNonUserCode] // 0x00000001895F9570-0x00000001895F95B0
			// [XID] // 0x00000001895F9570-0x00000001895F95B0
			public void CopyFrom(ReservedRange other) {} // 0x00000001842F8EB0-0x00000001842F9030
			[DebuggerNonUserCode] // 0x0000000189603D40-0x0000000189603D80
			// [XID] // 0x0000000189603D40-0x0000000189603D80
			public override void MergeFrom(CodedInputStream input) {} // 0x00000001842F8C60-0x00000001842F8DA0
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DescriptorProto() {} // 0x0000000184308650-0x00000001843087E0
	static DescriptorProto() {} // 0x0000000184308380-0x0000000184308650

	// Methods
	[DebuggerNonUserCode] // 0x0000000189807F30-0x0000000189807F70
	// [XID] // 0x0000000189807F30-0x0000000189807F70
	public DescriptorProto Clone() => default; // 0x0000000184306F80-0x00000001843070B0
	[DebuggerNonUserCode] // 0x00000001898124E0-0x0000000189812520
	// [XID] // 0x00000001898124E0-0x0000000189812520
	public DescriptorProto ShallowCopy() => default; // 0x0000000184306740-0x0000000184306820
	[DebuggerNonUserCode] // 0x000000018981D010-0x000000018981D050
	// [XID] // 0x000000018981D010-0x000000018981D050
	protected override void InternalSetInPool(bool value) {} // 0x0000000184305700-0x00000001843057C0
	[DebuggerNonUserCode] // 0x0000000189827830-0x0000000189827870
	// [XID] // 0x0000000189827830-0x0000000189827870
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184307210-0x00000001843073B0
	[DebuggerNonUserCode] // 0x0000000189831A70-0x0000000189831AB0
	// [XID] // 0x0000000189831A70-0x0000000189831AB0
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843073B0-0x0000000184307550
	[DebuggerNonUserCode] // 0x000000018983C1F0-0x000000018983C230
	// [XID] // 0x000000018983C1F0-0x000000018983C230
	public override void Reset() {} // 0x0000000184305860-0x0000000184305AA0
	[DebuggerNonUserCode] // 0x000000018989E770-0x000000018989E7C0
	// [IDTag] // 0x000000018989E770-0x000000018989E7C0
	// [XID] // 0x000000018989E770-0x000000018989E7C0
	public override bool Equals(object other) => default; // 0x0000000184305D40-0x0000000184305E50
	[DebuggerNonUserCode] // 0x00000001898ABEC0-0x00000001898ABF10
	// [IDTag] // 0x00000001898ABEC0-0x00000001898ABF10
	// [XID] // 0x00000001898ABEC0-0x00000001898ABF10
	public bool Equals(DescriptorProto other) => default; // 0x0000000184305E50-0x0000000184306180
	[DebuggerNonUserCode] // 0x00000001898B9CD0-0x00000001898B9D10
	// [XID] // 0x00000001898B9CD0-0x00000001898B9D10
	public override int GetHashCode() => default; // 0x00000001843069C0-0x0000000184306C70
	[DebuggerNonUserCode] // 0x00000001898C3FC0-0x00000001898C4000
	// [XID] // 0x00000001898C3FC0-0x00000001898C4000
	public override string ToString() => default; // 0x0000000184307DF0-0x0000000184308380
	[DebuggerNonUserCode] // 0x00000001898CE560-0x00000001898CE5A0
	// [XID] // 0x00000001898CE560-0x00000001898CE5A0
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184307770-0x0000000184307AD0
	[DebuggerNonUserCode] // 0x00000001898D8F70-0x00000001898D8FB0
	// [XID] // 0x00000001898D8F70-0x00000001898D8FB0
	public override int CalculateSize() => default; // 0x0000000184306180-0x00000001843064F0
	[DebuggerNonUserCode] // 0x00000001898E3A80-0x00000001898E3AC0
	// [XID] // 0x00000001898E3A80-0x00000001898E3AC0
	public void CopyFrom(DescriptorProto other) {} // 0x00000001843053D0-0x0000000184305700
	[DebuggerNonUserCode] // 0x00000001898EE7F0-0x00000001898EE830
	// [XID] // 0x00000001898EE7F0-0x00000001898EE830
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184304E10-0x00000001843052C0
}

