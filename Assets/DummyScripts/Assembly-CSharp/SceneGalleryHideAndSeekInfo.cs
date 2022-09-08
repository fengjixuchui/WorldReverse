/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneGalleryHideAndSeekInfo : MessageBase, IMessage<SceneGalleryHideAndSeekInfo> // TypeDefIndex: 23266
{
	// Fields
	private static readonly MessageParser<SceneGalleryHideAndSeekInfo> _parser; // 0x00
	public const int VisibleUidListFieldNumber = 1; // Metadata: 0x00B03A23
	private static readonly FieldCodec<uint> _repeated_visibleUidList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> visibleUidList_; // 0x18
	public const int CaughtUidListFieldNumber = 2; // Metadata: 0x00B03A27
	private static readonly FieldCodec<uint> _repeated_caughtUidList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> caughtUidList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneGalleryHideAndSeekInfo> Parser { get => default; } // 0x0000000184FCE600-0x0000000184FCE690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184FCE390-0x0000000184FCE420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184FCE090-0x0000000184FCE110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184FCD9C0-0x0000000184FCDA20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184FCE9A0-0x0000000184FCEA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184FCE7C0-0x0000000184FCE820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184FCE420-0x0000000184FCE510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184FCE950-0x0000000184FCE9A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184FCE1B0-0x0000000184FCE2A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> VisibleUidList { get => default; } // 0x0000000184FCDD20-0x0000000184FCDD80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> CaughtUidList { get => default; } // 0x0000000184FCDA20-0x0000000184FCDA80 

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryHideAndSeekInfo() {} // 0x0000000184FCED50-0x0000000184FCEE00
	static SceneGalleryHideAndSeekInfo() {} // 0x0000000184FCEC50-0x0000000184FCED50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryHideAndSeekInfo Clone() => default; // 0x0000000184FCE510-0x0000000184FCE600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryHideAndSeekInfo ShallowCopy() => default; // 0x0000000184FCE110-0x0000000184FCE1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184FCDBB0-0x0000000184FCDC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184FCE720-0x0000000184FCE770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184FCE770-0x0000000184FCE7C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184FCDC00-0x0000000184FCDD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184FCDEA0-0x0000000184FCDF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneGalleryHideAndSeekInfo other) => default; // 0x0000000184FCDD80-0x0000000184FCDEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184FCE2A0-0x0000000184FCE390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184FCEA90-0x0000000184FCEC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184FCE820-0x0000000184FCE950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184FCDF70-0x0000000184FCE090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneGalleryHideAndSeekInfo other) {} // 0x0000000184FCDA80-0x0000000184FCDBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184FCD800-0x0000000184FCD9C0
}

