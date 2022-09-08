/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class GeneratedCodeInfo : MessageBase, IMessage<GeneratedCodeInfo> // TypeDefIndex: 26392
{
	// Fields
	private static readonly MessageParser<GeneratedCodeInfo> _parser; // 0x00
	public const int AnnotationFieldNumber = 1; // Metadata: 0x00B0C101
	private static readonly FieldCodec<Types.Annotation> _repeated_annotation_codec; // 0x08
	private readonly RepeatedMessageField<Types.Annotation> annotation_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GeneratedCodeInfo> Parser { /* [XID] */ /* 0x0000000189726850-0x0000000189726870 */ get => default; } // 0x0000000183308410-0x00000001833084E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x000000018972DDE0-0x000000018972DE00 */ get => default; } // 0x0000000183308070-0x0000000183308160 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189735450-0x0000000189735470 */ get => default; } // 0x0000000183307CC0-0x0000000183307D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x000000018973CF40-0x000000018973CF60 */ get => default; } // 0x00000001833074A0-0x0000000183307540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x00000001897444F0-0x0000000189744510 */ get => default; } // 0x0000000183308990-0x0000000183308A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x000000018974C180-0x000000018974C1A0 */ get => default; } // 0x0000000183308710-0x00000001833087B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189753470-0x0000000189753490 */ get => default; } // 0x00000001833081E0-0x00000001833082E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x000000018975A9A0-0x000000018975A9C0 */ get => default; } // 0x00000001833088F0-0x0000000183308990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189762520-0x0000000189762540 */ get => default; } // 0x0000000183307E70-0x0000000183307F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Types.Annotation> Annotation { /* [XID] */ /* 0x00000001897A8A80-0x00000001897A8AA0 */ get => default; } // 0x0000000183307400-0x00000001833074A0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 26393
	{
		// Nested types
		internal sealed class Annotation : MessageBase, IMessage<Annotation> // TypeDefIndex: 26394
		{
			// Fields
			private static readonly MessageParser<Annotation> _parser; // 0x00
			public const int PathFieldNumber = 1; // Metadata: 0x00B0C105
			private static readonly FieldCodec<int> _repeated_path_codec; // 0x08
			private readonly RepeatedPrimitiveField<int> path_; // 0x18
			public const int SourceFileFieldNumber = 2; // Metadata: 0x00B0C109
			private string sourceFile_; // 0x20
			public const int BeginFieldNumber = 3; // Metadata: 0x00B0C10D
			private int begin_; // 0x28
			public const int EndFieldNumber = 4; // Metadata: 0x00B0C111
			private int end_; // 0x2C

			// Properties
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageParser<Annotation> Parser { /* [XID] */ /* 0x000000018986B2F0-0x000000018986B310 */ get => default; } // 0x0000000183316AF0-0x0000000183316BC0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189872680-0x00000001898726A0 */ get => default; } // 0x00000001833164C0-0x0000000183316590 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override MessageDescriptor Descriptor { /* [XID] */ /* 0x000000018987A230-0x000000018987A250 */ get => default; } // 0x0000000183315F70-0x0000000183316040 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticClassName { /* [XID] */ /* 0x0000000189881430-0x0000000189881450 */ get => default; } // 0x0000000183315530-0x00000001833155D0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string ClassName { /* [XID] */ /* 0x0000000189888980-0x00000001898889A0 */ get => default; } // 0x00000001833172D0-0x00000001833173D0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static string StaticFullClassName { /* [XID] */ /* 0x000000018988FD00-0x000000018988FD20 */ get => default; } // 0x0000000183316DB0-0x0000000183316E50 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override string FullClassName { /* [XID] */ /* 0x0000000189897240-0x0000000189897260 */ get => default; } // 0x0000000183316700-0x0000000183316800 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public static ushort StaticCmdId { /* [XID] */ /* 0x000000018989E720-0x000000018989E740 */ get => default; } // 0x0000000183317230-0x00000001833172D0 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public override ushort CmdId { /* [XID] */ /* 0x00000001898A6280-0x00000001898A62A0 */ get => default; } // 0x0000000183316120-0x0000000183316220 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public RepeatedPrimitiveField<int> Path { /* [XID] */ /* 0x00000001898ECCE0-0x00000001898ECD00 */ get => default; } // 0x0000000183315490-0x0000000183315530 
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public string SourceFile { /* [XID] */ /* 0x00000001898F4650-0x00000001898F4670 */ get => default; /* [XID] */ /* 0x00000001898FBE70-0x00000001898FBE90 */ set {} } // 0x00000001833163E0-0x00000001833164C0 0x0000000183316610-0x0000000183316700
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public int Begin { /* [XID] */ /* 0x00000001899038C0-0x00000001899038E0 */ get => default; /* [XID] */ /* 0x000000018990AE40-0x000000018990AE60 */ set {} } // 0x0000000183316A10-0x0000000183316AF0 0x0000000183317150-0x0000000183317230
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public int End { /* [XID] */ /* 0x0000000189912AB0-0x0000000189912AD0 */ get => default; /* [XID] */ /* 0x000000018991A350-0x000000018991A370 */ set {} } // 0x0000000183316E50-0x0000000183316F30 0x0000000183316930-0x0000000183316A10

			// Constructors
			[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
			public Annotation() {} // 0x00000001833177D0-0x0000000183317870
			static Annotation() {} // 0x00000001833176F0-0x00000001833177D0

			// Methods
			[DebuggerNonUserCode] // 0x00000001898AD980-0x00000001898AD9C0
			// [XID] // 0x00000001898AD980-0x00000001898AD9C0
			public Annotation Clone() => default; // 0x0000000183316800-0x0000000183316930
			[DebuggerNonUserCode] // 0x00000001898B8050-0x00000001898B8090
			// [XID] // 0x00000001898B8050-0x00000001898B8090
			public Annotation ShallowCopy() => default; // 0x0000000183316040-0x0000000183316120
			[DebuggerNonUserCode] // 0x00000001898C2640-0x00000001898C2680
			// [XID] // 0x00000001898C2640-0x00000001898C2680
			protected override void InternalSetInPool(bool value) {} // 0x0000000183315820-0x00000001833158D0
			[DebuggerNonUserCode] // 0x00000001898CCD00-0x00000001898CCD40
			// [XID] // 0x00000001898CCD00-0x00000001898CCD40
			protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183316C50-0x0000000183316D00
			[DebuggerNonUserCode] // 0x00000001898D7910-0x00000001898D7950
			// [XID] // 0x00000001898D7910-0x00000001898D7950
			protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183316D00-0x0000000183316DB0
			[DebuggerNonUserCode] // 0x00000001898E2560-0x00000001898E25A0
			// [XID] // 0x00000001898E2560-0x00000001898E25A0
			public override void Reset() {} // 0x00000001833158D0-0x00000001833159C0
			[DebuggerNonUserCode] // 0x0000000189921B60-0x0000000189921BB0
			// [IDTag] // 0x0000000189921B60-0x0000000189921BB0
			// [XID] // 0x0000000189921B60-0x0000000189921BB0
			public override bool Equals(object other) => default; // 0x0000000183315C20-0x0000000183315D30
			[DebuggerNonUserCode] // 0x000000018992F000-0x000000018992F050
			// [IDTag] // 0x000000018992F000-0x000000018992F050
			// [XID] // 0x000000018992F000-0x000000018992F050
			public bool Equals(Annotation other) => default; // 0x0000000183315A30-0x0000000183315C20
			[DebuggerNonUserCode] // 0x000000018993C980-0x000000018993C9C0
			// [XID] // 0x000000018993C980-0x000000018993C9C0
			public override int GetHashCode() => default; // 0x0000000183316220-0x00000001833163E0
			[DebuggerNonUserCode] // 0x0000000189946E80-0x0000000189946EC0
			// [XID] // 0x0000000189946E80-0x0000000189946EC0
			public override string ToString() => default; // 0x00000001833173D0-0x00000001833176F0
			[DebuggerNonUserCode] // 0x00000001899516A0-0x00000001899516E0
			// [XID] // 0x00000001899516A0-0x00000001899516E0
			public override void WriteTo(CodedOutputStream output) {} // 0x0000000183316F30-0x0000000183317150
			[DebuggerNonUserCode] // 0x000000018995BA70-0x000000018995BAB0
			// [XID] // 0x000000018995BA70-0x000000018995BAB0
			public override int CalculateSize() => default; // 0x0000000183315D30-0x0000000183315F70
			[DebuggerNonUserCode] // 0x0000000189966460-0x00000001899664A0
			// [XID] // 0x0000000189966460-0x00000001899664A0
			public void CopyFrom(Annotation other) {} // 0x0000000183315640-0x0000000183315820
			[DebuggerNonUserCode] // 0x0000000189970F90-0x0000000189970FD0
			// [XID] // 0x0000000189970F90-0x0000000189970FD0
			public override void MergeFrom(CodedInputStream input) {} // 0x00000001833152C0-0x0000000183315490
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GeneratedCodeInfo() {} // 0x0000000183308D30-0x0000000183308DC0
	static GeneratedCodeInfo() {} // 0x0000000183308C20-0x0000000183308D30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189769B90-0x0000000189769BD0
	// [XID] // 0x0000000189769B90-0x0000000189769BD0
	public GeneratedCodeInfo Clone() => default; // 0x00000001833082E0-0x0000000183308410
	[DebuggerNonUserCode] // 0x0000000189773F30-0x0000000189773F70
	// [XID] // 0x0000000189773F30-0x0000000189773F70
	public GeneratedCodeInfo ShallowCopy() => default; // 0x0000000183307D90-0x0000000183307E70
	[DebuggerNonUserCode] // 0x000000018977E7A0-0x000000018977E7E0
	// [XID] // 0x000000018977E7A0-0x000000018977E7E0
	protected override void InternalSetInPool(bool value) {} // 0x0000000183307730-0x00000001833077E0
	[DebuggerNonUserCode] // 0x0000000189789070-0x00000001897890B0
	// [XID] // 0x0000000189789070-0x00000001897890B0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183308570-0x0000000183308640
	[DebuggerNonUserCode] // 0x00000001897934D0-0x0000000189793510
	// [XID] // 0x00000001897934D0-0x0000000189793510
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183308640-0x0000000183308710
	[DebuggerNonUserCode] // 0x000000018979E800-0x000000018979E840
	// [XID] // 0x000000018979E800-0x000000018979E840
	public override void Reset() {} // 0x00000001833077E0-0x00000001833078C0
	[DebuggerNonUserCode] // 0x00000001897B03E0-0x00000001897B0430
	// [IDTag] // 0x00000001897B03E0-0x00000001897B0430
	// [XID] // 0x00000001897B03E0-0x00000001897B0430
	public override bool Equals(object other) => default; // 0x0000000183307A80-0x0000000183307B90
	[DebuggerNonUserCode] // 0x00000001897BEA90-0x00000001897BEAE0
	// [IDTag] // 0x00000001897BEA90-0x00000001897BEAE0
	// [XID] // 0x00000001897BEA90-0x00000001897BEAE0
	public bool Equals(GeneratedCodeInfo other) => default; // 0x0000000183307930-0x0000000183307A80
	[DebuggerNonUserCode] // 0x00000001897CBC40-0x00000001897CBC80
	// [XID] // 0x00000001897CBC40-0x00000001897CBC80
	public override int GetHashCode() => default; // 0x0000000183307F70-0x0000000183308070
	[DebuggerNonUserCode] // 0x00000001897D64E0-0x00000001897D6520
	// [XID] // 0x00000001897D64E0-0x00000001897D6520
	public override string ToString() => default; // 0x0000000183308A90-0x0000000183308C20
	[DebuggerNonUserCode] // 0x00000001897E0E10-0x00000001897E0E50
	// [XID] // 0x00000001897E0E10-0x00000001897E0E50
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001833087B0-0x00000001833088F0
	[DebuggerNonUserCode] // 0x00000001897EBA80-0x00000001897EBAC0
	// [XID] // 0x00000001897EBA80-0x00000001897EBAC0
	public override int CalculateSize() => default; // 0x0000000183307B90-0x0000000183307CC0
	[DebuggerNonUserCode] // 0x00000001897F60C0-0x00000001897F6100
	// [XID] // 0x00000001897F60C0-0x00000001897F6100
	public void CopyFrom(GeneratedCodeInfo other) {} // 0x00000001833075B0-0x0000000183307730
	[DebuggerNonUserCode] // 0x0000000189800920-0x0000000189800960
	// [XID] // 0x0000000189800920-0x0000000189800960
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183307280-0x0000000183307400
}

