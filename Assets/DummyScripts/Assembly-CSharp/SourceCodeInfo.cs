/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class SourceCodeInfo : MessageBase, IMessage<SourceCodeInfo> // TypeDefIndex: 26389
{
	// Fields
	private static readonly MessageParser<SourceCodeInfo> _parser; // 0x00
	public const int LocationFieldNumber = 1; // Metadata: 0x00B0C0E9
	private static readonly FieldCodec<Types.Location> _repeated_location_codec; // 0x08
	private readonly RepeatedMessageField<Types.Location> location_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SourceCodeInfo> Parser { /* [XID] */ /* 0x0000000189A55970-0x0000000189A55990 */ get => default; } // 0x0000000185786400-0x00000001857864D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189A5D1D0-0x0000000189A5D1F0 */ get => default; } // 0x0000000185786060-0x0000000185786150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189A64AB0-0x0000000189A64AD0 */ get => default; } // 0x0000000185785CB0-0x0000000185785D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189A6C270-0x0000000189A6C290 */ get => default; } // 0x00000001857853F0-0x0000000185785490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189A73A80-0x0000000189A73AA0 */ get => default; } // 0x0000000185786980-0x0000000185786A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189A7B540-0x0000000189A7B560 */ get => default; } // 0x0000000185786700-0x00000001857867A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189A82C70-0x0000000189A82C90 */ get => default; } // 0x00000001857861D0-0x00000001857862D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x0000000189A8A670-0x0000000189A8A690 */ get => default; } // 0x00000001857868E0-0x0000000185786980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189A91E10-0x0000000189A91E30 */ get => default; } // 0x0000000185785E60-0x0000000185785F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Types.Location> Location { /* [XID] */ /* 0x0000000189AD8D10-0x0000000189AD8D30 */ get => default; } // 0x0000000185785C10-0x0000000185785CB0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 26390
	{
		// Nested types
		internal sealed class Location : MessageBase, IMessage<Location> // TypeDefIndex: 26391
		{
			// Fields
			private static readonly MessageParser<Location> _parser; // 0x00
			public const int PathFieldNumber = 1; // Metadata: 0x00B0C0ED
			private static readonly FieldCodec<int> _repeated_path_codec; // 0x08
			private readonly RepeatedPrimitiveField<int> path_; // 0x18
			public const int SpanFieldNumber = 2; // Metadata: 0x00B0C0F1
			private static readonly FieldCodec<int> _repeated_span_codec; // 0x10
			private readonly RepeatedPrimitiveField<int> span_; // 0x20
			public const int LeadingCommentsFieldNumber = 3; // Metadata: 0x00B0C0F5
			private string leadingComments_; // 0x28
			public const int TrailingCommentsFieldNumber = 4; // Metadata: 0x00B0C0F9
			private string trailingComments_; // 0x30
			public const int LeadingDetachedCommentsFieldNumber = 6; // Metadata: 0x00B0C0FD
			private static readonly FieldCodec<string> _repeated_leadingDetachedComments_codec; // 0x18
			private readonly RepeatedPrimitiveField<string> leadingDetachedComments_; // 0x38

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<Location> Parser { /* [XID] */ /* 0x0000000189B9A5C0-0x0000000189B9A5E0 */ get => default; } // 0x00000001857A1B90-0x00000001857A1C60 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189BA1D30-0x0000000189BA1D50 */ get => default; } // 0x00000001857A1810-0x00000001857A18E0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189BA90F0-0x0000000189BA9110 */ get => default; } // 0x00000001857A1360-0x00000001857A1430 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { /* [XID] */ /* 0x0000000189BB0860-0x0000000189BB0880 */ get => default; } // 0x00000001857A05B0-0x00000001857A0650 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { /* [XID] */ /* 0x0000000189BB7BE0-0x0000000189BB7C00 */ get => default; } // 0x00000001857A2300-0x00000001857A2400 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { /* [XID] */ /* 0x0000000189BBF200-0x0000000189BBF220 */ get => default; } // 0x00000001857A1F40-0x00000001857A1FE0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { /* [XID] */ /* 0x0000000189BC6ED0-0x0000000189BC6EF0 */ get => default; } // 0x00000001857A1960-0x00000001857A1A60 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { /* [XID] */ /* 0x0000000189BCEB40-0x0000000189BCEB60 */ get => default; } // 0x00000001857A2260-0x00000001857A2300 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { /* [XID] */ /* 0x0000000189BD5E80-0x0000000189BD5EA0 */ get => default; } // 0x00000001857A1510-0x00000001857A1610 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public RepeatedPrimitiveField<int> Path { /* [XID] */ /* 0x0000000189621970-0x0000000189621990 */ get => default; } // 0x00000001857A0510-0x00000001857A05B0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public RepeatedPrimitiveField<int> Span { /* [XID] */ /* 0x0000000189629240-0x0000000189629260 */ get => default; } // 0x00000001857A0C20-0x00000001857A0CC0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public string LeadingComments { /* [XID] */ /* 0x0000000189630BA0-0x0000000189630BC0 */ get => default; /* [XID] */ /* 0x0000000189638680-0x00000001896386A0 */ set {} } // 0x00000001857A0430-0x00000001857A0510 0x00000001857A0650-0x00000001857A0740
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public string TrailingComments { /* [XID] */ /* 0x000000018963FA40-0x000000018963FA60 */ get => default; /* [XID] */ /* 0x0000000189647260-0x0000000189647280 */ set {} } // 0x00000001857A0350-0x00000001857A0430 0x00000001857A1E50-0x00000001857A1F40
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public RepeatedPrimitiveField<string> LeadingDetachedComments { /* [XID] */ /* 0x000000018964E930-0x000000018964E950 */ get => default; } // 0x00000001857A0CC0-0x00000001857A0D60 

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public Location() {} // 0x00000001857A2880-0x00000001857A2970
			static Location() {} // 0x00000001857A2760-0x00000001857A2880

			// Methods
			[DebuggerNonUserCode] // 0x0000000189BDDAB0-0x0000000189BDDAF0
			// [XID] // 0x0000000189BDDAB0-0x0000000189BDDAF0
			public Location Clone() => default; // 0x00000001857A1A60-0x00000001857A1B90
			[DebuggerNonUserCode] // 0x00000001895ED5C0-0x00000001895ED600
			// [XID] // 0x00000001895ED5C0-0x00000001895ED600
			public Location ShallowCopy() => default; // 0x00000001857A1430-0x00000001857A1510
			[DebuggerNonUserCode] // 0x00000001895F7F30-0x00000001895F7F70
			// [XID] // 0x00000001895F7F30-0x00000001895F7F70
			protected override void InternalSetInPool(bool value) {} // 0x00000001857A09C0-0x00000001857A0A70
			[DebuggerNonUserCode] // 0x00000001896024B0-0x00000001896024F0
			// [XID] // 0x00000001896024B0-0x00000001896024F0
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001857A1CF0-0x00000001857A1DA0
			[DebuggerNonUserCode] // 0x000000018960CBB0-0x000000018960CBF0
			// [XID] // 0x000000018960CBB0-0x000000018960CBF0
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001857A1DA0-0x00000001857A1E50
			[DebuggerNonUserCode] // 0x0000000189617120-0x0000000189617160
			// [XID] // 0x0000000189617120-0x0000000189617160
			public override void Reset() {} // 0x00000001857A0A70-0x00000001857A0BB0
			[DebuggerNonUserCode] // 0x00000001896561A0-0x00000001896561F0
			// [IDTag] // 0x00000001896561A0-0x00000001896561F0
			// [XID] // 0x00000001896561A0-0x00000001896561F0
			public override bool Equals(object other) => default; // 0x00000001857A0FC0-0x00000001857A10D0
			[DebuggerNonUserCode] // 0x0000000189663870-0x00000001896638C0
			// [IDTag] // 0x0000000189663870-0x00000001896638C0
			// [XID] // 0x0000000189663870-0x00000001896638C0
			public bool Equals(Location other) => default; // 0x00000001857A0D60-0x00000001857A0FC0
			[DebuggerNonUserCode] // 0x00000001896716A0-0x00000001896716E0
			// [XID] // 0x00000001896716A0-0x00000001896716E0
			public override int GetHashCode() => default; // 0x00000001857A1610-0x00000001857A1810
			[DebuggerNonUserCode] // 0x000000018967BD30-0x000000018967BD70
			// [XID] // 0x000000018967BD30-0x000000018967BD70
			public override string ToString() => default; // 0x00000001857A2400-0x00000001857A2760
			[DebuggerNonUserCode] // 0x00000001896862E0-0x0000000189686320
			// [XID] // 0x00000001896862E0-0x0000000189686320
			public override void WriteTo(CodedOutputStream output) {} // 0x00000001857A1FE0-0x00000001857A2260
			[DebuggerNonUserCode] // 0x0000000189691410-0x0000000189691450
			// [XID] // 0x0000000189691410-0x0000000189691450
			public override int CalculateSize() => default; // 0x00000001857A10D0-0x00000001857A1360
			[DebuggerNonUserCode] // 0x000000018969B810-0x000000018969B850
			// [XID] // 0x000000018969B810-0x000000018969B850
			public void CopyFrom(Location other) {} // 0x00000001857A07B0-0x00000001857A09C0
			[DebuggerNonUserCode] // 0x00000001896A5A50-0x00000001896A5A90
			// [XID] // 0x00000001896A5A50-0x00000001896A5A90
			public override void MergeFrom(CodedInputStream input) {} // 0x00000001857A00A0-0x00000001857A0350
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SourceCodeInfo() {} // 0x0000000185786D20-0x0000000185786DB0
	static SourceCodeInfo() {} // 0x0000000185786C10-0x0000000185786D20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189A99880-0x0000000189A998C0
	// [XID] // 0x0000000189A99880-0x0000000189A998C0
	public SourceCodeInfo Clone() => default; // 0x00000001857862D0-0x0000000185786400
	[DebuggerNonUserCode] // 0x0000000189AA3B10-0x0000000189AA3B50
	// [XID] // 0x0000000189AA3B10-0x0000000189AA3B50
	public SourceCodeInfo ShallowCopy() => default; // 0x0000000185785D80-0x0000000185785E60
	[DebuggerNonUserCode] // 0x0000000189AAE240-0x0000000189AAE280
	// [XID] // 0x0000000189AAE240-0x0000000189AAE280
	protected override void InternalSetInPool(bool value) {} // 0x0000000185785680-0x0000000185785730
	[DebuggerNonUserCode] // 0x0000000189AB8880-0x0000000189AB88C0
	// [XID] // 0x0000000189AB8880-0x0000000189AB88C0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185786560-0x0000000185786630
	[DebuggerNonUserCode] // 0x0000000189AC3960-0x0000000189AC39A0
	// [XID] // 0x0000000189AC3960-0x0000000189AC39A0
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185786630-0x0000000185786700
	[DebuggerNonUserCode] // 0x0000000189ACDFC0-0x0000000189ACE000
	// [XID] // 0x0000000189ACDFC0-0x0000000189ACE000
	public override void Reset() {} // 0x0000000185785730-0x0000000185785810
	[DebuggerNonUserCode] // 0x0000000189AE0740-0x0000000189AE0790
	// [IDTag] // 0x0000000189AE0740-0x0000000189AE0790
	// [XID] // 0x0000000189AE0740-0x0000000189AE0790
	public override bool Equals(object other) => default; // 0x0000000185785880-0x0000000185785990
	[DebuggerNonUserCode] // 0x0000000189AEDFC0-0x0000000189AEE010
	// [IDTag] // 0x0000000189AEDFC0-0x0000000189AEE010
	// [XID] // 0x0000000189AEDFC0-0x0000000189AEE010
	public bool Equals(SourceCodeInfo other) => default; // 0x0000000185785990-0x0000000185785AE0
	[DebuggerNonUserCode] // 0x0000000189AFB5F0-0x0000000189AFB630
	// [XID] // 0x0000000189AFB5F0-0x0000000189AFB630
	public override int GetHashCode() => default; // 0x0000000185785F60-0x0000000185786060
	[DebuggerNonUserCode] // 0x0000000189B05C90-0x0000000189B05CD0
	// [XID] // 0x0000000189B05C90-0x0000000189B05CD0
	public override string ToString() => default; // 0x0000000185786A80-0x0000000185786C10
	[DebuggerNonUserCode] // 0x0000000189B105A0-0x0000000189B105E0
	// [XID] // 0x0000000189B105A0-0x0000000189B105E0
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001857867A0-0x00000001857868E0
	[DebuggerNonUserCode] // 0x0000000189B1A8B0-0x0000000189B1A8F0
	// [XID] // 0x0000000189B1A8B0-0x0000000189B1A8F0
	public override int CalculateSize() => default; // 0x0000000185785AE0-0x0000000185785C10
	[DebuggerNonUserCode] // 0x0000000189B24F20-0x0000000189B24F60
	// [XID] // 0x0000000189B24F20-0x0000000189B24F60
	public void CopyFrom(SourceCodeInfo other) {} // 0x0000000185785500-0x0000000185785680
	[DebuggerNonUserCode] // 0x0000000189B2EFF0-0x0000000189B2F030
	// [XID] // 0x0000000189B2EFF0-0x0000000189B2F030
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185785270-0x00000001857853F0
}

