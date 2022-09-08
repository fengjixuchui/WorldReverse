/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class UninterpretedOption : MessageBase, IMessage<UninterpretedOption> // TypeDefIndex: 26386
{
	// Fields
	private static readonly MessageParser<UninterpretedOption> _parser; // 0x00
	public const int NameFieldNumber = 2; // Metadata: 0x00B0C0C5
	private static readonly FieldCodec<Types.NamePart> _repeated_name_codec; // 0x08
	private readonly RepeatedMessageField<Types.NamePart> name_; // 0x18
	public const int IdentifierValueFieldNumber = 3; // Metadata: 0x00B0C0C9
	private string identifierValue_; // 0x20
	public const int PositiveIntValueFieldNumber = 4; // Metadata: 0x00B0C0CD
	private ulong positiveIntValue_; // 0x28
	public const int NegativeIntValueFieldNumber = 5; // Metadata: 0x00B0C0D1
	private long negativeIntValue_; // 0x30
	public const int DoubleValueFieldNumber = 6; // Metadata: 0x00B0C0D5
	private double doubleValue_; // 0x38
	public const int StringValueFieldNumber = 7; // Metadata: 0x00B0C0D9
	private ByteString stringValue_; // 0x40
	public const int AggregateValueFieldNumber = 8; // Metadata: 0x00B0C0DD
	private string aggregateValue_; // 0x48

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UninterpretedOption> Parser { /* [XID] */ /* 0x000000018972F680-0x000000018972F6A0 */ get => default; } // 0x00000001850AE720-0x00000001850AE7F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x00000001897370F0-0x0000000189737110 */ get => default; } // 0x00000001850AE2A0-0x00000001850AE390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x000000018973EC60-0x000000018973EC80 */ get => default; } // 0x00000001850ADA90-0x00000001850ADB60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189745EE0-0x0000000189745F00 */ get => default; } // 0x00000001850AC8F0-0x00000001850AC990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x000000018974D970-0x000000018974D990 */ get => default; } // 0x00000001850AF130-0x00000001850AF230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189754F90-0x0000000189754FB0 */ get => default; } // 0x00000001850AEB10-0x00000001850AEBB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x000000018975C160-0x000000018975C180 */ get => default; } // 0x00000001850AE410-0x00000001850AE510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x0000000189763B00-0x0000000189763B20 */ get => default; } // 0x00000001850AF090-0x00000001850AF130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x000000018976B2D0-0x000000018976B2F0 */ get => default; } // 0x00000001850ADD20-0x00000001850ADE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Types.NamePart> Name { /* [XID] */ /* 0x00000001897B1B60-0x00000001897B1B80 */ get => default; } // 0x00000001850AD9F0-0x00000001850ADA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string IdentifierValue { /* [XID] */ /* 0x00000001897B9640-0x00000001897B9660 */ get => default; /* [XID] */ /* 0x00000001897C15F0-0x00000001897C1610 */ set {} } // 0x00000001850AEC90-0x00000001850AED70 0x00000001850AD900-0x00000001850AD9F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong PositiveIntValue { /* [XID] */ /* 0x00000001897C90A0-0x00000001897C90C0 */ get => default; /* [XID] */ /* 0x00000001897D0660-0x00000001897D0680 */ set {} } // 0x00000001850AD500-0x00000001850AD5E0 0x00000001850ADB60-0x00000001850ADC40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public long NegativeIntValue { /* [XID] */ /* 0x00000001897D83F0-0x00000001897D8410 */ get => default; /* [XID] */ /* 0x00000001897DF400-0x00000001897DF420 */ set {} } // 0x00000001850AE640-0x00000001850AE720 0x00000001850AD040-0x00000001850AD120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public double DoubleValue { /* [XID] */ /* 0x00000001897E6CE0-0x00000001897E6D00 */ get => default; /* [XID] */ /* 0x00000001897EE970-0x00000001897EE990 */ set {} } // 0x00000001850ACA00-0x00000001850ACAF0 0x00000001850AEBB0-0x00000001850AEC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString StringValue { /* [XID] */ /* 0x00000001897F6100-0x00000001897F6120 */ get => default; /* [XID] */ /* 0x00000001897FD740-0x00000001897FD760 */ set {} } // 0x00000001850AE1C0-0x00000001850AE2A0 0x00000001850AE0D0-0x00000001850AE1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string AggregateValue { /* [XID] */ /* 0x0000000189804EB0-0x0000000189804ED0 */ get => default; /* [XID] */ /* 0x000000018980C450-0x000000018980C470 */ set {} } // 0x00000001850AC810-0x00000001850AC8F0 0x00000001850AE880-0x00000001850AE970

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 26387
	{
		// Nested types
		internal sealed class NamePart : MessageBase, IMessage<NamePart> // TypeDefIndex: 26388
		{
			// Fields
			private static readonly MessageParser<NamePart> _parser; // 0x00
			public const int NamePart_FieldNumber = 1; // Metadata: 0x00B0C0E1
			private string namePart_; // 0x18
			public const int IsExtensionFieldNumber = 2; // Metadata: 0x00B0C0E5
			private bool isExtension_; // 0x20

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<NamePart> Parser { /* [XID] */ /* 0x00000001898FA550-0x00000001898FA570 */ get => default; } // 0x00000001850BECC0-0x00000001850BED90 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189901F60-0x0000000189901F80 */ get => default; } // 0x00000001850BE940-0x00000001850BEA10 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189909770-0x0000000189909790 */ get => default; } // 0x00000001850BE440-0x00000001850BE510 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { /* [XID] */ /* 0x0000000189910D10-0x0000000189910D30 */ get => default; } // 0x00000001850BD9D0-0x00000001850BDA70 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { /* [XID] */ /* 0x0000000189918840-0x0000000189918860 */ get => default; } // 0x00000001850BF240-0x00000001850BF340 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { /* [XID] */ /* 0x0000000189920060-0x0000000189920080 */ get => default; } // 0x00000001850BEF80-0x00000001850BF020 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { /* [XID] */ /* 0x00000001899278A0-0x00000001899278C0 */ get => default; } // 0x00000001850BEA90-0x00000001850BEB90 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { /* [XID] */ /* 0x000000018992F050-0x000000018992F070 */ get => default; } // 0x00000001850BF1A0-0x00000001850BF240 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { /* [XID] */ /* 0x0000000189936430-0x0000000189936450 */ get => default; } // 0x00000001850BE5F0-0x00000001850BE6F0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public string NamePart_ { /* [XID] */ /* 0x000000018997C5E0-0x000000018997C600 */ get => default; /* [XID] */ /* 0x0000000189984340-0x0000000189984360 */ set {} } // 0x00000001850BDE60-0x00000001850BDF40 0x00000001850BDF40-0x00000001850BE030
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public bool IsExtension { /* [XID] */ /* 0x000000018998BE30-0x000000018998BE50 */ get => default; /* [XID] */ /* 0x0000000189993A50-0x0000000189993A70 */ set {} } // 0x00000001850BE860-0x00000001850BE940 0x00000001850BF340-0x00000001850BF420

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public NamePart() {} // 0x00000001850BF710-0x00000001850BF7E0
			static NamePart() {} // 0x00000001850BF650-0x00000001850BF710

			// Methods
			[DebuggerNonUserCode] // 0x000000018993DE90-0x000000018993DED0
			// [XID] // 0x000000018993DE90-0x000000018993DED0
			public NamePart Clone() => default; // 0x00000001850BEB90-0x00000001850BECC0
			[DebuggerNonUserCode] // 0x0000000189948490-0x00000001899484D0
			// [XID] // 0x0000000189948490-0x00000001899484D0
			public NamePart ShallowCopy() => default; // 0x00000001850BE510-0x00000001850BE5F0
			[DebuggerNonUserCode] // 0x0000000189952E00-0x0000000189952E40
			// [XID] // 0x0000000189952E00-0x0000000189952E40
			protected override void InternalSetInPool(bool value) {} // 0x00000001850BDC80-0x00000001850BDD30
			[DebuggerNonUserCode] // 0x000000018995D590-0x000000018995D5D0
			// [XID] // 0x000000018995D590-0x000000018995D5D0
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001850BEE20-0x00000001850BEED0
			[DebuggerNonUserCode] // 0x0000000189967D30-0x0000000189967D70
			// [XID] // 0x0000000189967D30-0x0000000189967D70
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001850BEED0-0x00000001850BEF80
			[DebuggerNonUserCode] // 0x00000001899726C0-0x0000000189972700
			// [XID] // 0x00000001899726C0-0x0000000189972700
			public override void Reset() {} // 0x00000001850BDD30-0x00000001850BDDF0
			[DebuggerNonUserCode] // 0x000000018999B380-0x000000018999B3D0
			// [IDTag] // 0x000000018999B380-0x000000018999B3D0
			// [XID] // 0x000000018999B380-0x000000018999B3D0
			public override bool Equals(object other) => default; // 0x00000001850BE030-0x00000001850BE140
			[DebuggerNonUserCode] // 0x00000001899A8D90-0x00000001899A8DE0
			// [IDTag] // 0x00000001899A8D90-0x00000001899A8DE0
			// [XID] // 0x00000001899A8D90-0x00000001899A8DE0
			public bool Equals(NamePart other) => default; // 0x00000001850BE140-0x00000001850BE2F0
			[DebuggerNonUserCode] // 0x00000001899B6180-0x00000001899B61C0
			// [XID] // 0x00000001899B6180-0x00000001899B61C0
			public override int GetHashCode() => default; // 0x00000001850BE6F0-0x00000001850BE860
			[DebuggerNonUserCode] // 0x00000001899C0BE0-0x00000001899C0C20
			// [XID] // 0x00000001899C0BE0-0x00000001899C0C20
			public override string ToString() => default; // 0x00000001850BF420-0x00000001850BF650
			[DebuggerNonUserCode] // 0x00000001899CB590-0x00000001899CB5D0
			// [XID] // 0x00000001899CB590-0x00000001899CB5D0
			public override void WriteTo(CodedOutputStream output) {} // 0x00000001850BF020-0x00000001850BF1A0
			[DebuggerNonUserCode] // 0x00000001899D5B40-0x00000001899D5B80
			// [XID] // 0x00000001899D5B40-0x00000001899D5B80
			public override int CalculateSize() => default; // 0x00000001850BE2F0-0x00000001850BE440
			[DebuggerNonUserCode] // 0x00000001899DFFC0-0x00000001899E0000
			// [XID] // 0x00000001899DFFC0-0x00000001899E0000
			public void CopyFrom(NamePart other) {} // 0x00000001850BDAE0-0x00000001850BDC80
			[DebuggerNonUserCode] // 0x00000001899EA670-0x00000001899EA6B0
			// [XID] // 0x00000001899EA670-0x00000001899EA6B0
			public override void MergeFrom(CodedInputStream input) {} // 0x00000001850BD890-0x00000001850BD9D0
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UninterpretedOption() {} // 0x00000001850AF7E0-0x00000001850AF8B0
	static UninterpretedOption() {} // 0x00000001850AF6D0-0x00000001850AF7E0

	// Methods
	[DebuggerNonUserCode] // 0x00000001897728E0-0x0000000189772920
	// [XID] // 0x00000001897728E0-0x0000000189772920
	public UninterpretedOption Clone() => default; // 0x00000001850AE510-0x00000001850AE640
	[DebuggerNonUserCode] // 0x000000018977D0D0-0x000000018977D110
	// [XID] // 0x000000018977D0D0-0x000000018977D110
	public UninterpretedOption ShallowCopy() => default; // 0x00000001850ADC40-0x00000001850ADD20
	[DebuggerNonUserCode] // 0x0000000189787820-0x0000000189787860
	// [XID] // 0x0000000189787820-0x0000000189787860
	protected override void InternalSetInPool(bool value) {} // 0x00000001850ACDB0-0x00000001850ACE60
	[DebuggerNonUserCode] // 0x0000000189791D70-0x0000000189791DB0
	// [XID] // 0x0000000189791D70-0x0000000189791DB0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001850AE970-0x00000001850AEA40
	[DebuggerNonUserCode] // 0x000000018979CF20-0x000000018979CF60
	// [XID] // 0x000000018979CF20-0x000000018979CF60
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001850AEA40-0x00000001850AEB10
	[DebuggerNonUserCode] // 0x00000001897A7330-0x00000001897A7370
	// [XID] // 0x00000001897A7330-0x00000001897A7370
	public override void Reset() {} // 0x00000001850ACE60-0x00000001850ACFD0
	[DebuggerNonUserCode] // 0x0000000189813C20-0x0000000189813C70
	// [IDTag] // 0x0000000189813C20-0x0000000189813C70
	// [XID] // 0x0000000189813C20-0x0000000189813C70
	public override bool Equals(object other) => default; // 0x00000001850AD120-0x00000001850AD230
	[DebuggerNonUserCode] // 0x0000000189821860-0x00000001898218B0
	// [IDTag] // 0x0000000189821860-0x00000001898218B0
	// [XID] // 0x0000000189821860-0x00000001898218B0
	public bool Equals(UninterpretedOption other) => default; // 0x00000001850AD230-0x00000001850AD500
	[DebuggerNonUserCode] // 0x000000018982EA00-0x000000018982EA40
	// [XID] // 0x000000018982EA00-0x000000018982EA40
	public override int GetHashCode() => default; // 0x00000001850ADE20-0x00000001850AE0D0
	[DebuggerNonUserCode] // 0x00000001898390C0-0x0000000189839100
	// [XID] // 0x00000001898390C0-0x0000000189839100
	public override string ToString() => default; // 0x00000001850AF230-0x00000001850AF6D0
	[DebuggerNonUserCode] // 0x0000000189843780-0x00000001898437C0
	// [XID] // 0x0000000189843780-0x00000001898437C0
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001850AED70-0x00000001850AF090
	[DebuggerNonUserCode] // 0x000000018984DD20-0x000000018984DD60
	// [XID] // 0x000000018984DD20-0x000000018984DD60
	public override int CalculateSize() => default; // 0x00000001850AD5E0-0x00000001850AD900
	[DebuggerNonUserCode] // 0x0000000189857F40-0x0000000189857F80
	// [XID] // 0x0000000189857F40-0x0000000189857F80
	public void CopyFrom(UninterpretedOption other) {} // 0x00000001850ACAF0-0x00000001850ACDB0
	[DebuggerNonUserCode] // 0x0000000189862520-0x0000000189862560
	// [XID] // 0x0000000189862520-0x0000000189862560
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001850AC5E0-0x00000001850AC810
}

