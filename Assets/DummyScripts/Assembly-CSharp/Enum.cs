/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Enum : MessageBase, IMessage<Enum> // TypeDefIndex: 26463
{
	// Fields
	private static readonly MessageParser<Enum> _parser; // 0x00
	public const int NameFieldNumber = 1; // Metadata: 0x00B0C2F4
	private string name_; // 0x18
	public const int EnumvalueFieldNumber = 2; // Metadata: 0x00B0C2F8
	private static readonly FieldCodec<EnumValue> _repeated_enumvalue_codec; // 0x08
	private readonly RepeatedMessageField<EnumValue> enumvalue_; // 0x20
	public const int OptionsFieldNumber = 3; // Metadata: 0x00B0C2FC
	private static readonly FieldCodec<Option> _repeated_options_codec; // 0x10
	private readonly RepeatedMessageField<Option> options_; // 0x28
	public const int SourceContextFieldNumber = 4; // Metadata: 0x00B0C300
	private SourceContext sourceContext_; // 0x30
	public const int SyntaxFieldNumber = 5; // Metadata: 0x00B0C304
	private Syntax syntax_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Enum> Parser { /* [XID] */ /* 0x000000018975A960-0x000000018975A980 */ get => default; } // 0x0000000185214E90-0x0000000185214F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x00000001897624E0-0x0000000189762500 */ get => default; } // 0x0000000185214970-0x0000000185214A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189769B50-0x0000000189769B70 */ get => default; } // 0x00000001852142C0-0x0000000185214390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189771170-0x0000000189771190 */ get => default; } // 0x0000000185213430-0x00000001852134D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x00000001897789D0-0x00000001897789F0 */ get => default; } // 0x0000000185215620-0x0000000185215720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x000000018977FF70-0x000000018977FF90 */ get => default; } // 0x00000001852151F0-0x0000000185215290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x00000001897877E0-0x0000000189787800 */ get => default; } // 0x0000000185214C60-0x0000000185214D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x000000018978EEB0-0x000000018978EED0 */ get => default; } // 0x0000000185215580-0x0000000185215620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x00000001897966B0-0x00000001897966D0 */ get => default; } // 0x0000000185214470-0x0000000185214570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { /* [XID] */ /* 0x00000001897DDD20-0x00000001897DDD40 */ get => default; /* [XID] */ /* 0x00000001897E56D0-0x00000001897E56F0 */ set {} } // 0x00000001852141E0-0x00000001852142C0 0x0000000185213B40-0x0000000185213C30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<EnumValue> Enumvalue { /* [XID] */ /* 0x00000001897ED1E0-0x00000001897ED200 */ get => default; } // 0x0000000185214BC0-0x0000000185214C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Option> Options { /* [XID] */ /* 0x00000001897F49B0-0x00000001897F49D0 */ get => default; } // 0x0000000185215290-0x0000000185215330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SourceContext SourceContext { /* [XID] */ /* 0x00000001897FC430-0x00000001897FC450 */ get => default; /* [XID] */ /* 0x00000001898039D0-0x00000001898039F0 */ set {} } // 0x0000000185213A60-0x0000000185213B40 0x0000000185214890-0x0000000185214970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Syntax Syntax { /* [XID] */ /* 0x000000018980AEA0-0x000000018980AEC0 */ get => default; /* [XID] */ /* 0x00000001898124C0-0x00000001898124E0 */ set {} } // 0x00000001852147B0-0x0000000185214890 0x0000000185214A60-0x0000000185214B40

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Enum() {} // 0x0000000185215C00-0x0000000185215CC0
	static Enum() {} // 0x0000000185215AA0-0x0000000185215C00

	// Methods
	[DebuggerNonUserCode] // 0x000000018979E780-0x000000018979E7C0
	// [XID] // 0x000000018979E780-0x000000018979E7C0
	public Enum Clone() => default; // 0x0000000185214D60-0x0000000185214E90
	[DebuggerNonUserCode] // 0x00000001897A8A00-0x00000001897A8A40
	// [XID] // 0x00000001897A8A00-0x00000001897A8A40
	public Enum ShallowCopy() => default; // 0x0000000185214390-0x0000000185214470
	[DebuggerNonUserCode] // 0x00000001897B36F0-0x00000001897B3730
	// [XID] // 0x00000001897B36F0-0x00000001897B3730
	protected override void InternalSetInPool(bool value) {} // 0x00000001852137C0-0x0000000185213880
	[DebuggerNonUserCode] // 0x00000001897BEA10-0x00000001897BEA50
	// [XID] // 0x00000001897BEA10-0x00000001897BEA50
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185214FF0-0x00000001852150F0
	[DebuggerNonUserCode] // 0x00000001897C9020-0x00000001897C9060
	// [XID] // 0x00000001897C9020-0x00000001897C9060
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001852150F0-0x00000001852151F0
	[DebuggerNonUserCode] // 0x00000001897D35D0-0x00000001897D3610
	// [XID] // 0x00000001897D35D0-0x00000001897D3610
	public override void Reset() {} // 0x0000000185213880-0x00000001852139F0
	[DebuggerNonUserCode] // 0x000000018981A080-0x000000018981A0D0
	// [IDTag] // 0x000000018981A080-0x000000018981A0D0
	// [XID] // 0x000000018981A080-0x000000018981A0D0
	public override bool Equals(object other) => default; // 0x0000000185213C30-0x0000000185213D40
	[DebuggerNonUserCode] // 0x00000001898277C0-0x0000000189827810
	// [IDTag] // 0x00000001898277C0-0x0000000189827810
	// [XID] // 0x00000001898277C0-0x0000000189827810
	public bool Equals(Enum other) => default; // 0x0000000185213D40-0x0000000185213F70
	[DebuggerNonUserCode] // 0x0000000189834B00-0x0000000189834B40
	// [XID] // 0x0000000189834B00-0x0000000189834B40
	public override int GetHashCode() => default; // 0x0000000185214570-0x00000001852147B0
	[DebuggerNonUserCode] // 0x000000018983F130-0x000000018983F170
	// [XID] // 0x000000018983F130-0x000000018983F170
	public override string ToString() => default; // 0x0000000185215720-0x0000000185215AA0
	[DebuggerNonUserCode] // 0x0000000189849390-0x00000001898493D0
	// [XID] // 0x0000000189849390-0x00000001898493D0
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185215330-0x0000000185215580
	[DebuggerNonUserCode] // 0x00000001898535D0-0x0000000189853610
	// [XID] // 0x00000001898535D0-0x0000000189853610
	public override int CalculateSize() => default; // 0x0000000185213F70-0x00000001852141E0
	[DebuggerNonUserCode] // 0x000000018985D8D0-0x000000018985D910
	// [XID] // 0x000000018985D8D0-0x000000018985D910
	public void CopyFrom(Enum other) {} // 0x0000000185213540-0x00000001852137C0
	[DebuggerNonUserCode] // 0x0000000189868270-0x00000001898682B0
	// [XID] // 0x0000000189868270-0x00000001898682B0
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001852131C0-0x0000000185213430
}

