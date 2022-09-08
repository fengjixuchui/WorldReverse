/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Api : MessageBase, IMessage<Api> // TypeDefIndex: 26436
{
	// Fields
	private static readonly MessageParser<Api> _parser; // 0x00
	public const int NameFieldNumber = 1; // Metadata: 0x00B0C17C
	private string name_; // 0x18
	public const int MethodsFieldNumber = 2; // Metadata: 0x00B0C180
	private static readonly FieldCodec<Method> _repeated_methods_codec; // 0x08
	private readonly RepeatedMessageField<Method> methods_; // 0x20
	public const int OptionsFieldNumber = 3; // Metadata: 0x00B0C184
	private static readonly FieldCodec<Option> _repeated_options_codec; // 0x10
	private readonly RepeatedMessageField<Option> options_; // 0x28
	public const int VersionFieldNumber = 4; // Metadata: 0x00B0C188
	private string version_; // 0x30
	public const int SourceContextFieldNumber = 5; // Metadata: 0x00B0C18C
	private SourceContext sourceContext_; // 0x38
	public const int MixinsFieldNumber = 6; // Metadata: 0x00B0C190
	private static readonly FieldCodec<Mixin> _repeated_mixins_codec; // 0x18
	private readonly RepeatedMessageField<Mixin> mixins_; // 0x40
	public const int SyntaxFieldNumber = 7; // Metadata: 0x00B0C194
	private Syntax syntax_; // 0x48

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Api> Parser { /* [XID] */ /* 0x00000001899DE5E0-0x00000001899DE600 */ get => default; } // 0x00000001838EA6A0-0x00000001838EA770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x00000001899E62E0-0x00000001899E6300 */ get => default; } // 0x00000001838E9FB0-0x00000001838EA0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x00000001899ED730-0x00000001899ED750 */ get => default; } // 0x00000001838E9890-0x00000001838E9960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x00000001899F5200-0x00000001899F5220 */ get => default; } // 0x00000001838E8800-0x00000001838E88A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x00000001899FC810-0x00000001899FC830 */ get => default; } // 0x00000001838EAFA0-0x00000001838EB0A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189A03DD0-0x0000000189A03DF0 */ get => default; } // 0x00000001838EAAC0-0x00000001838EAB60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189A0B330-0x0000000189A0B350 */ get => default; } // 0x00000001838EA2E0-0x00000001838EA3E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x0000000189A12C00-0x0000000189A12C20 */ get => default; } // 0x00000001838EAF00-0x00000001838EAFA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189A19F60-0x0000000189A19F80 */ get => default; } // 0x00000001838E9A40-0x00000001838E9B40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { /* [XID] */ /* 0x0000000189A602D0-0x0000000189A602F0 */ get => default; /* [XID] */ /* 0x0000000189A67E00-0x0000000189A67E20 */ set {} } // 0x00000001838E97B0-0x00000001838E9890 0x00000001838E8FE0-0x00000001838E90D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Method> Methods { /* [XID] */ /* 0x0000000189A6F210-0x0000000189A6F230 */ get => default; } // 0x00000001838EAA20-0x00000001838EAAC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Option> Options { /* [XID] */ /* 0x0000000189A76A70-0x0000000189A76A90 */ get => default; } // 0x00000001838EAB60-0x00000001838EAC00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Version { /* [XID] */ /* 0x0000000189A7E340-0x0000000189A7E360 */ get => default; /* [XID] */ /* 0x0000000189A85CC0-0x0000000189A85CE0 */ set {} } // 0x00000001838EA180-0x00000001838EA260 0x00000001838EA3E0-0x00000001838EA4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SourceContext SourceContext { /* [XID] */ /* 0x0000000189A8D5C0-0x0000000189A8D5E0 */ get => default; /* [XID] */ /* 0x0000000189A94B60-0x0000000189A94B80 */ set {} } // 0x00000001838E8F00-0x00000001838E8FE0 0x00000001838E9ED0-0x00000001838E9FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<Mixin> Mixins { /* [XID] */ /* 0x0000000189A9C3A0-0x0000000189A9C3C0 */ get => default; } // 0x00000001838EA4D0-0x00000001838EA570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Syntax Syntax { /* [XID] */ /* 0x0000000189AA3AF0-0x0000000189AA3B10 */ get => default; /* [XID] */ /* 0x0000000189AAB110-0x0000000189AAB130 */ set {} } // 0x00000001838E9DF0-0x00000001838E9ED0 0x00000001838EA0A0-0x00000001838EA180

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Api() {} // 0x00000001838EB6B0-0x00000001838EB7A0
	static Api() {} // 0x00000001838EB500-0x00000001838EB6B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189A214C0-0x0000000189A21500
	// [XID] // 0x0000000189A214C0-0x0000000189A21500
	public Api Clone() => default; // 0x00000001838EA570-0x00000001838EA6A0
	[DebuggerNonUserCode] // 0x0000000189A2BA00-0x0000000189A2BA40
	// [XID] // 0x0000000189A2BA00-0x0000000189A2BA40
	public Api ShallowCopy() => default; // 0x00000001838E9960-0x00000001838E9A40
	[DebuggerNonUserCode] // 0x0000000189A363C0-0x0000000189A36400
	// [XID] // 0x0000000189A363C0-0x0000000189A36400
	protected override void InternalSetInPool(bool value) {} // 0x00000001838E8C10-0x00000001838E8CD0
	[DebuggerNonUserCode] // 0x0000000189A409B0-0x0000000189A409F0
	// [XID] // 0x0000000189A409B0-0x0000000189A409F0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838EA800-0x00000001838EA910
	[DebuggerNonUserCode] // 0x0000000189A4B070-0x0000000189A4B0B0
	// [XID] // 0x0000000189A4B070-0x0000000189A4B0B0
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838EA910-0x00000001838EAA20
	[DebuggerNonUserCode] // 0x0000000189A55930-0x0000000189A55970
	// [XID] // 0x0000000189A55930-0x0000000189A55970
	public override void Reset() {} // 0x00000001838E8CD0-0x00000001838E8E90
	[DebuggerNonUserCode] // 0x0000000189AB2A60-0x0000000189AB2AB0
	// [IDTag] // 0x0000000189AB2A60-0x0000000189AB2AB0
	// [XID] // 0x0000000189AB2A60-0x0000000189AB2AB0
	public override bool Equals(object other) => default; // 0x00000001838E90D0-0x00000001838E91E0
	[DebuggerNonUserCode] // 0x0000000189AC04B0-0x0000000189AC0500
	// [IDTag] // 0x0000000189AC04B0-0x0000000189AC0500
	// [XID] // 0x0000000189AC04B0-0x0000000189AC0500
	public bool Equals(Api other) => default; // 0x00000001838E91E0-0x00000001838E9490
	[DebuggerNonUserCode] // 0x0000000189ACDF80-0x0000000189ACDFC0
	// [XID] // 0x0000000189ACDF80-0x0000000189ACDFC0
	public override int GetHashCode() => default; // 0x00000001838E9B40-0x00000001838E9DF0
	[DebuggerNonUserCode] // 0x0000000189AD8CD0-0x0000000189AD8D10
	// [XID] // 0x0000000189AD8CD0-0x0000000189AD8D10
	public override string ToString() => default; // 0x00000001838EB0A0-0x00000001838EB500
	[DebuggerNonUserCode] // 0x0000000189AE35C0-0x0000000189AE3600
	// [XID] // 0x0000000189AE35C0-0x0000000189AE3600
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001838EAC00-0x00000001838EAF00
	[DebuggerNonUserCode] // 0x0000000189AEDF80-0x0000000189AEDFC0
	// [XID] // 0x0000000189AEDF80-0x0000000189AEDFC0
	public override int CalculateSize() => default; // 0x00000001838E9490-0x00000001838E97B0
	[DebuggerNonUserCode] // 0x0000000189AF87C0-0x0000000189AF8800
	// [XID] // 0x0000000189AF87C0-0x0000000189AF8800
	public void CopyFrom(Api other) {} // 0x00000001838E8910-0x00000001838E8C10
	[DebuggerNonUserCode] // 0x0000000189B02DB0-0x0000000189B02DF0
	// [XID] // 0x0000000189B02DB0-0x0000000189B02DF0
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001838E8510-0x00000001838E8800
}

