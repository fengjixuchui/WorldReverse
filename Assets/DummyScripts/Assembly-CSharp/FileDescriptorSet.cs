/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

internal sealed class FileDescriptorSet : MessageBase, IMessage<FileDescriptorSet> // TypeDefIndex: 26355
{
	// Fields
	private static readonly MessageParser<FileDescriptorSet> _parser; // 0x00
	public const int FileFieldNumber = 1; // Metadata: 0x00B0BEB9
	private static readonly FieldCodec<FileDescriptorProto> _repeated_file_codec; // 0x08
	private readonly RepeatedMessageField<FileDescriptorProto> file_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FileDescriptorSet> Parser { /* [XID] */ /* 0x0000000189A7B560-0x0000000189A7B580 */ get => default; } // 0x00000001813EBB70-0x00000001813EBC40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x0000000189A82CD0-0x0000000189A82CF0 */ get => default; } // 0x00000001813EB7D0-0x00000001813EB8C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189A8A690-0x0000000189A8A6B0 */ get => default; } // 0x00000001813EB420-0x00000001813EB4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x0000000189A91E70-0x0000000189A91E90 */ get => default; } // 0x00000001813EAB60-0x00000001813EAC00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x0000000189A99900-0x0000000189A99920 */ get => default; } // 0x00000001813EC0F0-0x00000001813EC1F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x0000000189AA08D0-0x0000000189AA08F0 */ get => default; } // 0x00000001813EBE70-0x00000001813EBF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189AA7ED0-0x0000000189AA7EF0 */ get => default; } // 0x00000001813EB940-0x00000001813EBA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x0000000189AAFB50-0x0000000189AAFB70 */ get => default; } // 0x00000001813EC050-0x00000001813EC0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189AB72F0-0x0000000189AB7310 */ get => default; } // 0x00000001813EB5D0-0x00000001813EB6D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<FileDescriptorProto> File { /* [XID] */ /* 0x0000000189AFE520-0x0000000189AFE540 */ get => default; } // 0x00000001813EAEA0-0x00000001813EAF40 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FileDescriptorSet() {} // 0x00000001813EC490-0x00000001813EC520
	static FileDescriptorSet() {} // 0x00000001813EC380-0x00000001813EC490

	// Methods
	[DebuggerNonUserCode] // 0x0000000189ABED20-0x0000000189ABED60
	// [XID] // 0x0000000189ABED20-0x0000000189ABED60
	public FileDescriptorSet Clone() => default; // 0x00000001813EBA40-0x00000001813EBB70
	[DebuggerNonUserCode] // 0x0000000189AC95D0-0x0000000189AC9610
	// [XID] // 0x0000000189AC95D0-0x0000000189AC9610
	public FileDescriptorSet ShallowCopy() => default; // 0x00000001813EB4F0-0x00000001813EB5D0
	[DebuggerNonUserCode] // 0x0000000189AD4240-0x0000000189AD4280
	// [XID] // 0x0000000189AD4240-0x0000000189AD4280
	protected override void InternalSetInPool(bool value) {} // 0x00000001813EADF0-0x00000001813EAEA0
	[DebuggerNonUserCode] // 0x0000000189ADED90-0x0000000189ADEDD0
	// [XID] // 0x0000000189ADED90-0x0000000189ADEDD0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001813EBCD0-0x00000001813EBDA0
	[DebuggerNonUserCode] // 0x0000000189AE94C0-0x0000000189AE9500
	// [XID] // 0x0000000189AE94C0-0x0000000189AE9500
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001813EBDA0-0x00000001813EBE70
	[DebuggerNonUserCode] // 0x0000000189AF3F70-0x0000000189AF3FB0
	// [XID] // 0x0000000189AF3F70-0x0000000189AF3FB0
	public override void Reset() {} // 0x00000001813EAF40-0x00000001813EB020
	[DebuggerNonUserCode] // 0x0000000189B05CD0-0x0000000189B05D20
	// [IDTag] // 0x0000000189B05CD0-0x0000000189B05D20
	// [XID] // 0x0000000189B05CD0-0x0000000189B05D20
	public override bool Equals(object other) => default; // 0x00000001813EB090-0x00000001813EB1A0
	[DebuggerNonUserCode] // 0x0000000189B13150-0x0000000189B131A0
	// [IDTag] // 0x0000000189B13150-0x0000000189B131A0
	// [XID] // 0x0000000189B13150-0x0000000189B131A0
	public bool Equals(FileDescriptorSet other) => default; // 0x00000001813EB1A0-0x00000001813EB2F0
	[DebuggerNonUserCode] // 0x0000000189B205B0-0x0000000189B205F0
	// [XID] // 0x0000000189B205B0-0x0000000189B205F0
	public override int GetHashCode() => default; // 0x00000001813EB6D0-0x00000001813EB7D0
	[DebuggerNonUserCode] // 0x0000000189B2AB70-0x0000000189B2ABB0
	// [XID] // 0x0000000189B2AB70-0x0000000189B2ABB0
	public override string ToString() => default; // 0x00000001813EC1F0-0x00000001813EC380
	[DebuggerNonUserCode] // 0x0000000189B34F20-0x0000000189B34F60
	// [XID] // 0x0000000189B34F20-0x0000000189B34F60
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001813EBF10-0x00000001813EC050
	[DebuggerNonUserCode] // 0x0000000189B3FB40-0x0000000189B3FB80
	// [XID] // 0x0000000189B3FB40-0x0000000189B3FB80
	public override int CalculateSize() => default; // 0x00000001813EB2F0-0x00000001813EB420
	[DebuggerNonUserCode] // 0x0000000189B4A510-0x0000000189B4A550
	// [XID] // 0x0000000189B4A510-0x0000000189B4A550
	public void CopyFrom(FileDescriptorSet other) {} // 0x00000001813EAC70-0x00000001813EADF0
	[DebuggerNonUserCode] // 0x0000000189B54AC0-0x0000000189B54B00
	// [XID] // 0x0000000189B54AC0-0x0000000189B54B00
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001813EA9E0-0x00000001813EAB60
}

