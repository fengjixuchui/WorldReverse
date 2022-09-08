/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Type : MessageBase, IMessage<Type> // TypeDefIndex: 26458
{
	// Fields
	private static readonly MessageParser<Type> _parser; // 0x00
	public const int NameFieldNumber = 1; // Metadata: 0x00B0C258
	private string name_; // 0x18
	public const int FieldsFieldNumber = 2; // Metadata: 0x00B0C25C
	private static readonly FieldCodec<Field> _repeated_fields_codec; // 0x08
	private readonly RepeatedMessageField<Field> fields_; // 0x20
	public const int OneofsFieldNumber = 3; // Metadata: 0x00B0C260
	private static readonly FieldCodec<string> _repeated_oneofs_codec; // 0x10
	private readonly RepeatedPrimitiveField<string> oneofs_; // 0x28
	public const int OptionsFieldNumber = 4; // Metadata: 0x00B0C264
	private static readonly FieldCodec<Option> _repeated_options_codec; // 0x18
	private readonly RepeatedMessageField<Option> options_; // 0x30
	public const int SourceContextFieldNumber = 5; // Metadata: 0x00B0C268
	private SourceContext sourceContext_; // 0x38
	public const int SyntaxFieldNumber = 6; // Metadata: 0x00B0C26C
	private Syntax syntax_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Type> Parser { /* [XID] */ /* 0x00000001898F5F40-0x00000001898F5F60 */ get => default; } // 0x000000018420A3C0-0x000000018420A490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x00000001898FD7E0-0x00000001898FD800 */ get => default; } // 0x0000000184209F40-0x000000018420A030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189905080-0x00000001899050A0 */ get => default; } // 0x0000000184209870-0x0000000184209940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x000000018990C8E0-0x000000018990C900 */ get => default; } // 0x00000001842087F0-0x0000000184208890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x00000001899140F0-0x0000000189914110 */ get => default; } // 0x000000018420AB80-0x000000018420AC80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x000000018991BB40-0x000000018991BB60 */ get => default; } // 0x000000018420A720-0x000000018420A7C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189923120-0x0000000189923140 */ get => default; } // 0x000000018420A190-0x000000018420A290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x000000018992A8F0-0x000000018992A910 */ get => default; } // 0x000000018420AAE0-0x000000018420AB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189931F70-0x0000000189931F90 */ get => default; } // 0x0000000184209A20-0x0000000184209B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { /* [XID] */ /* 0x00000001899788C0-0x00000001899788E0 */ get => default; /* [XID] */ /* 0x000000018997F9B0-0x000000018997F9D0 */ set {} } // 0x0000000184209790-0x0000000184209870 0x0000000184209090-0x0000000184209180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Field> Fields { /* [XID] */ /* 0x0000000189987320-0x0000000189987340 */ get => default; } // 0x0000000184208C60-0x0000000184208D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<string> Oneofs { /* [XID] */ /* 0x000000018998EDF0-0x000000018998EE10 */ get => default; } // 0x0000000184208F10-0x0000000184208FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Option> Options { /* [XID] */ /* 0x00000001899969B0-0x00000001899969D0 */ get => default; } // 0x000000018420A7C0-0x000000018420A860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SourceContext SourceContext { /* [XID] */ /* 0x000000018999E430-0x000000018999E450 */ get => default; /* [XID] */ /* 0x00000001899A5E70-0x00000001899A5E90 */ set {} } // 0x0000000184208FB0-0x0000000184209090 0x0000000184209E60-0x0000000184209F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Syntax Syntax { /* [XID] */ /* 0x00000001899AD4D0-0x00000001899AD4F0 */ get => default; /* [XID] */ /* 0x00000001899B4D90-0x00000001899B4DB0 */ set {} } // 0x0000000184209D80-0x0000000184209E60 0x000000018420A030-0x000000018420A110

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Type() {} // 0x000000018420B1F0-0x000000018420B2E0
	static Type() {} // 0x000000018420B070-0x000000018420B1F0

	// Methods
	[DebuggerNonUserCode] // 0x00000001899398A0-0x00000001899398E0
	// [XID] // 0x00000001899398A0-0x00000001899398E0
	public Type Clone() => default; // 0x000000018420A290-0x000000018420A3C0
	[DebuggerNonUserCode] // 0x0000000189943EF0-0x0000000189943F30
	// [XID] // 0x0000000189943EF0-0x0000000189943F30
	public Type ShallowCopy() => default; // 0x0000000184209940-0x0000000184209A20
	[DebuggerNonUserCode] // 0x000000018994E470-0x000000018994E4B0
	// [XID] // 0x000000018994E470-0x000000018994E4B0
	protected override void InternalSetInPool(bool value) {} // 0x0000000184208BA0-0x0000000184208C60
	[DebuggerNonUserCode] // 0x0000000189958C10-0x0000000189958C50
	// [XID] // 0x0000000189958C10-0x0000000189958C50
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018420A520-0x000000018420A620
	[DebuggerNonUserCode] // 0x00000001899635C0-0x0000000189963600
	// [XID] // 0x00000001899635C0-0x0000000189963600
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018420A620-0x000000018420A720
	[DebuggerNonUserCode] // 0x000000018996D880-0x000000018996D8C0
	// [XID] // 0x000000018996D880-0x000000018996D8C0
	public override void Reset() {} // 0x0000000184208D00-0x0000000184208EA0
	[DebuggerNonUserCode] // 0x00000001899BC4B0-0x00000001899BC500
	// [IDTag] // 0x00000001899BC4B0-0x00000001899BC500
	// [XID] // 0x00000001899BC4B0-0x00000001899BC500
	public override bool Equals(object other) => default; // 0x0000000184209180-0x0000000184209290
	[DebuggerNonUserCode] // 0x00000001899C9B60-0x00000001899C9BB0
	// [IDTag] // 0x00000001899C9B60-0x00000001899C9BB0
	// [XID] // 0x00000001899C9B60-0x00000001899C9BB0
	public bool Equals(Type other) => default; // 0x0000000184209290-0x00000001842094F0
	[DebuggerNonUserCode] // 0x00000001899D7110-0x00000001899D7150
	// [XID] // 0x00000001899D7110-0x00000001899D7150
	public override int GetHashCode() => default; // 0x0000000184209B20-0x0000000184209D80
	[DebuggerNonUserCode] // 0x00000001899E1B30-0x00000001899E1B70
	// [XID] // 0x00000001899E1B30-0x00000001899E1B70
	public override string ToString() => default; // 0x000000018420AC80-0x000000018420B070
	[DebuggerNonUserCode] // 0x00000001899EBF80-0x00000001899EBFC0
	// [XID] // 0x00000001899EBF80-0x00000001899EBFC0
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018420A860-0x000000018420AAE0
	[DebuggerNonUserCode] // 0x00000001899F6850-0x00000001899F6890
	// [XID] // 0x00000001899F6850-0x00000001899F6890
	public override int CalculateSize() => default; // 0x00000001842094F0-0x0000000184209790
	[DebuggerNonUserCode] // 0x0000000189A00BA0-0x0000000189A00BE0
	// [XID] // 0x0000000189A00BA0-0x0000000189A00BE0
	public void CopyFrom(Type other) {} // 0x0000000184208900-0x0000000184208BA0
	[DebuggerNonUserCode] // 0x0000000189A0B2F0-0x0000000189A0B330
	// [XID] // 0x0000000189A0B2F0-0x0000000189A0B330
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184208520-0x00000001842087F0
}

