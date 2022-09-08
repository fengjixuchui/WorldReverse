/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class FileDescriptorProto : MessageBase, IMessage<FileDescriptorProto> // TypeDefIndex: 26356
{
	// Fields
	private static readonly MessageParser<FileDescriptorProto> _parser; // 0x00
	public const int NameFieldNumber = 1; // Metadata: 0x00B0BEBD
	private string name_; // 0x18
	public const int PackageFieldNumber = 2; // Metadata: 0x00B0BEC1
	private string package_; // 0x20
	public const int DependencyFieldNumber = 3; // Metadata: 0x00B0BEC5
	private static readonly FieldCodec<string> _repeated_dependency_codec; // 0x08
	private readonly RepeatedPrimitiveField<string> dependency_; // 0x28
	public const int PublicDependencyFieldNumber = 10; // Metadata: 0x00B0BEC9
	private static readonly FieldCodec<int> _repeated_publicDependency_codec; // 0x10
	private readonly RepeatedPrimitiveField<int> publicDependency_; // 0x30
	public const int WeakDependencyFieldNumber = 11; // Metadata: 0x00B0BECD
	private static readonly FieldCodec<int> _repeated_weakDependency_codec; // 0x18
	private readonly RepeatedPrimitiveField<int> weakDependency_; // 0x38
	public const int MessageTypeFieldNumber = 4; // Metadata: 0x00B0BED1
	private static readonly FieldCodec<DescriptorProto> _repeated_messageType_codec; // 0x20
	private readonly RepeatedMessageField<DescriptorProto> messageType_; // 0x40
	public const int EnumTypeFieldNumber = 5; // Metadata: 0x00B0BED5
	private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec; // 0x28
	private readonly RepeatedMessageField<EnumDescriptorProto> enumType_; // 0x48
	public const int ServiceFieldNumber = 6; // Metadata: 0x00B0BED9
	private static readonly FieldCodec<ServiceDescriptorProto> _repeated_service_codec; // 0x30
	private readonly RepeatedMessageField<ServiceDescriptorProto> service_; // 0x50
	public const int ExtensionFieldNumber = 7; // Metadata: 0x00B0BEDD
	private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec; // 0x38
	private readonly RepeatedMessageField<FieldDescriptorProto> extension_; // 0x58
	public const int OptionsFieldNumber = 8; // Metadata: 0x00B0BEE1
	private FileOptions options_; // 0x60
	public const int SourceCodeInfoFieldNumber = 9; // Metadata: 0x00B0BEE5
	private SourceCodeInfo sourceCodeInfo_; // 0x68
	public const int SyntaxFieldNumber = 12; // Metadata: 0x00B0BEE9
	private string syntax_; // 0x70

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FileDescriptorProto> Parser { /* [XID] */ /* 0x0000000189BB7C00-0x0000000189BB7C20 */ get => default; } // 0x0000000182EFD420-0x0000000182EFD4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189BBF240-0x0000000189BBF260 */ get => default; } // 0x0000000182EFCD30-0x0000000182EFCE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189BC6F10-0x0000000189BC6F30 */ get => default; } // 0x0000000182EFC4F0-0x0000000182EFC5C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189BCEB80-0x0000000189BCEBA0 */ get => default; } // 0x0000000182EFAE30-0x0000000182EFAED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189BD5EC0-0x0000000189BD5EE0 */ get => default; } // 0x0000000182EFDF00-0x0000000182EFE000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189BDDB10-0x0000000189BDDB30 */ get => default; } // 0x0000000182EFD820-0x0000000182EFD8C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x00000001895EA670-0x00000001895EA690 */ get => default; } // 0x0000000182EFD070-0x0000000182EFD170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x00000001895F1BD0-0x00000001895F1BF0 */ get => default; } // 0x0000000182EFDE60-0x0000000182EFDF00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x00000001895F95B0-0x00000001895F95D0 */ get => default; } // 0x0000000182EFC6A0-0x0000000182EFC7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Name { /* [XID] */ /* 0x000000018963FA60-0x000000018963FA80 */ get => default; /* [XID] */ /* 0x00000001896472A0-0x00000001896472C0 */ set {} } // 0x0000000182EFC410-0x0000000182EFC4F0 0x0000000182EFB8D0-0x0000000182EFB9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Package { /* [XID] */ /* 0x000000018964E970-0x000000018964E990 */ get => default; /* [XID] */ /* 0x0000000189656210-0x0000000189656230 */ set {} } // 0x0000000182EFB400-0x0000000182EFB4E0 0x0000000182EFB7E0-0x0000000182EFB8D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<string> Dependency { /* [XID] */ /* 0x000000018965D900-0x000000018965D920 */ get => default; } // 0x0000000182EFAD90-0x0000000182EFAE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<int> PublicDependency { /* [XID] */ /* 0x0000000189665020-0x0000000189665040 */ get => default; } // 0x0000000182EFC370-0x0000000182EFC410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<int> WeakDependency { /* [XID] */ /* 0x000000018966C620-0x000000018966C640 */ get => default; } // 0x0000000182EFD380-0x0000000182EFD420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<DescriptorProto> MessageType { /* [XID] */ /* 0x0000000189674520-0x0000000189674540 */ get => default; } // 0x0000000182EFCBB0-0x0000000182EFCC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<EnumDescriptorProto> EnumType { /* [XID] */ /* 0x000000018967BE20-0x000000018967BE40 */ get => default; } // 0x0000000182EFC2D0-0x0000000182EFC370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ServiceDescriptorProto> Service { /* [XID] */ /* 0x00000001896833D0-0x00000001896833F0 */ get => default; } // 0x0000000182EFD9A0-0x0000000182EFDA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<FieldDescriptorProto> Extension { /* [XID] */ /* 0x000000018968AF60-0x000000018968AF80 */ get => default; } // 0x0000000182EFCB10-0x0000000182EFCBB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FileOptions Options { /* [XID] */ /* 0x0000000189692CF0-0x0000000189692D10 */ get => default; /* [XID] */ /* 0x0000000189699F20-0x0000000189699F40 */ set {} } // 0x0000000182EFD8C0-0x0000000182EFD9A0 0x0000000182EFE000-0x0000000182EFE0E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SourceCodeInfo SourceCodeInfo { /* [XID] */ /* 0x00000001896A16F0-0x00000001896A1710 */ get => default; /* [XID] */ /* 0x00000001896A8C00-0x00000001896A8C20 */ set {} } // 0x0000000182EFCF90-0x0000000182EFD070 0x0000000182EFD2A0-0x0000000182EFD380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Syntax { /* [XID] */ /* 0x00000001896AFCA0-0x00000001896AFCC0 */ get => default; /* [XID] */ /* 0x00000001896B7670-0x00000001896B7690 */ set {} } // 0x0000000182EFCC50-0x0000000182EFCD30 0x0000000182EFCE20-0x0000000182EFCF10

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FileDescriptorProto() {} // 0x0000000182EFE9B0-0x0000000182EFEB30
	static FileDescriptorProto() {} // 0x0000000182EFE750-0x0000000182EFE9B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189600BA0-0x0000000189600BE0
	// [XID] // 0x0000000189600BA0-0x0000000189600BE0
	public FileDescriptorProto Clone() => default; // 0x0000000182EFD170-0x0000000182EFD2A0
	[DebuggerNonUserCode] // 0x000000018960B680-0x000000018960B6C0
	// [XID] // 0x000000018960B680-0x000000018960B6C0
	public FileDescriptorProto ShallowCopy() => default; // 0x0000000182EFC5C0-0x0000000182EFC6A0
	[DebuggerNonUserCode] // 0x0000000189615B00-0x0000000189615B40
	// [XID] // 0x0000000189615B00-0x0000000189615B40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182EFB330-0x0000000182EFB400
	[DebuggerNonUserCode] // 0x00000001896203B0-0x00000001896203F0
	// [XID] // 0x00000001896203B0-0x00000001896203F0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182EFD580-0x0000000182EFD6D0
	[DebuggerNonUserCode] // 0x000000018962A8D0-0x000000018962A910
	// [XID] // 0x000000018962A8D0-0x000000018962A910
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182EFD6D0-0x0000000182EFD820
	[DebuggerNonUserCode] // 0x0000000189635660-0x00000001896356A0
	// [XID] // 0x0000000189635660-0x00000001896356A0
	public override void Reset() {} // 0x0000000182EFB4E0-0x0000000182EFB770
	[DebuggerNonUserCode] // 0x00000001896BE800-0x00000001896BE850
	// [IDTag] // 0x00000001896BE800-0x00000001896BE850
	// [XID] // 0x00000001896BE800-0x00000001896BE850
	public override bool Equals(object other) => default; // 0x0000000182EFB9C0-0x0000000182EFBAD0
	[DebuggerNonUserCode] // 0x00000001896CBD30-0x00000001896CBD80
	// [IDTag] // 0x00000001896CBD30-0x00000001896CBD80
	// [XID] // 0x00000001896CBD30-0x00000001896CBD80
	public bool Equals(FileDescriptorProto other) => default; // 0x0000000182EFBAD0-0x0000000182EFBEA0
	[DebuggerNonUserCode] // 0x00000001896D9380-0x00000001896D93C0
	// [XID] // 0x00000001896D9380-0x00000001896D93C0
	public override int GetHashCode() => default; // 0x0000000182EFC7A0-0x0000000182EFCB10
	[DebuggerNonUserCode] // 0x00000001896E38C0-0x00000001896E3900
	// [XID] // 0x00000001896E38C0-0x00000001896E3900
	public override string ToString() => default; // 0x0000000182EFE0E0-0x0000000182EFE750
	[DebuggerNonUserCode] // 0x00000001896EDD20-0x00000001896EDD60
	// [XID] // 0x00000001896EDD20-0x00000001896EDD60
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182EFDA40-0x0000000182EFDE60
	[DebuggerNonUserCode] // 0x00000001896F82F0-0x00000001896F8330
	// [XID] // 0x00000001896F82F0-0x00000001896F8330
	public override int CalculateSize() => default; // 0x0000000182EFBEA0-0x0000000182EFC2D0
	[DebuggerNonUserCode] // 0x0000000189702CC0-0x0000000189702D00
	// [XID] // 0x0000000189702CC0-0x0000000189702D00
	public void CopyFrom(FileDescriptorProto other) {} // 0x0000000182EFAF40-0x0000000182EFB330
	[DebuggerNonUserCode] // 0x000000018970D450-0x000000018970D490
	// [XID] // 0x000000018970D450-0x000000018970D490
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182EFA890-0x0000000182EFAD90
}

