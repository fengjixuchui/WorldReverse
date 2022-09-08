/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SourceContext : MessageBase, IMessage<SourceContext> // TypeDefIndex: 26446
{
	// Fields
	private static readonly MessageParser<SourceContext> _parser; // 0x00
	public const int FileNameFieldNumber = 1; // Metadata: 0x00B0C1E8
	private string fileName_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SourceContext> Parser { /* [XID] */ /* 0x0000000189719420-0x0000000189719440 */ get => default; } // 0x0000000183FDF680-0x0000000183FDF750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { /* [XID] */ /* 0x00000001897209C0-0x00000001897209E0 */ get => default; } // 0x0000000183FDF2E0-0x0000000183FDF3D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { /* [XID] */ /* 0x0000000189727FC0-0x0000000189727FE0 */ get => default; } // 0x0000000183FDEE10-0x0000000183FDEEE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { /* [XID] */ /* 0x000000018972F660-0x000000018972F680 */ get => default; } // 0x0000000183FDE600-0x0000000183FDE6A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { /* [XID] */ /* 0x00000001897370D0-0x00000001897370F0 */ get => default; } // 0x0000000183FDFCB0-0x0000000183FDFDB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { /* [XID] */ /* 0x000000018973EC40-0x000000018973EC60 */ get => default; } // 0x0000000183FDFA30-0x0000000183FDFAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { /* [XID] */ /* 0x0000000189745EC0-0x0000000189745EE0 */ get => default; } // 0x0000000183FDF450-0x0000000183FDF550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { /* [XID] */ /* 0x000000018974D950-0x000000018974D970 */ get => default; } // 0x0000000183FDFC10-0x0000000183FDFCB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { /* [XID] */ /* 0x0000000189754F70-0x0000000189754F90 */ get => default; } // 0x0000000183FDF0A0-0x0000000183FDF1A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string FileName { /* [XID] */ /* 0x000000018979B740-0x000000018979B760 */ get => default; /* [XID] */ /* 0x00000001897A2B40-0x00000001897A2B60 */ set {} } // 0x0000000183FDEFC0-0x0000000183FDF0A0 0x0000000183FDF7E0-0x0000000183FDF8D0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SourceContext() {} // 0x0000000183FE0000-0x0000000183FE0070
	static SourceContext() {} // 0x0000000183FDFF40-0x0000000183FE0000

	// Methods
	[DebuggerNonUserCode] // 0x000000018975C120-0x000000018975C160
	// [XID] // 0x000000018975C120-0x000000018975C160
	public SourceContext Clone() => default; // 0x0000000183FDF550-0x0000000183FDF680
	[DebuggerNonUserCode] // 0x0000000189766AA0-0x0000000189766AE0
	// [XID] // 0x0000000189766AA0-0x0000000189766AE0
	public SourceContext ShallowCopy() => default; // 0x0000000183FDEEE0-0x0000000183FDEFC0
	[DebuggerNonUserCode] // 0x0000000189771190-0x00000001897711D0
	// [XID] // 0x0000000189771190-0x00000001897711D0
	protected override void InternalSetInPool(bool value) {} // 0x0000000183FDE880-0x0000000183FDE930
	[DebuggerNonUserCode] // 0x000000018977B660-0x000000018977B6A0
	// [XID] // 0x000000018977B660-0x000000018977B6A0
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FDF8D0-0x0000000183FDF980
	[DebuggerNonUserCode] // 0x0000000189785F70-0x0000000189785FB0
	// [XID] // 0x0000000189785F70-0x0000000189785FB0
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183FDF980-0x0000000183FDFA30
	[DebuggerNonUserCode] // 0x00000001897906B0-0x00000001897906F0
	// [XID] // 0x00000001897906B0-0x00000001897906F0
	public override void Reset() {} // 0x0000000183FDE930-0x0000000183FDE9E0
	[DebuggerNonUserCode] // 0x00000001897AA140-0x00000001897AA190
	// [IDTag] // 0x00000001897AA140-0x00000001897AA190
	// [XID] // 0x00000001897AA140-0x00000001897AA190
	public override bool Equals(object other) => default; // 0x0000000183FDEBC0-0x0000000183FDECD0
	[DebuggerNonUserCode] // 0x00000001897B8160-0x00000001897B81B0
	// [IDTag] // 0x00000001897B8160-0x00000001897B81B0
	// [XID] // 0x00000001897B8160-0x00000001897B81B0
	public bool Equals(SourceContext other) => default; // 0x0000000183FDEA50-0x0000000183FDEBC0
	[DebuggerNonUserCode] // 0x00000001897C6060-0x00000001897C60A0
	// [XID] // 0x00000001897C6060-0x00000001897C60A0
	public override int GetHashCode() => default; // 0x0000000183FDF1A0-0x0000000183FDF2E0
	[DebuggerNonUserCode] // 0x00000001897D0620-0x00000001897D0660
	// [XID] // 0x00000001897D0620-0x00000001897D0660
	public override string ToString() => default; // 0x0000000183FDFDB0-0x0000000183FDFF40
	[DebuggerNonUserCode] // 0x00000001897DB0D0-0x00000001897DB110
	// [XID] // 0x00000001897DB0D0-0x00000001897DB110
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183FDFAD0-0x0000000183FDFC10
	[DebuggerNonUserCode] // 0x00000001897E5730-0x00000001897E5770
	// [XID] // 0x00000001897E5730-0x00000001897E5770
	public override int CalculateSize() => default; // 0x0000000183FDECD0-0x0000000183FDEE10
	[DebuggerNonUserCode] // 0x00000001897F01B0-0x00000001897F01F0
	// [XID] // 0x00000001897F01B0-0x00000001897F01F0
	public void CopyFrom(SourceContext other) {} // 0x0000000183FDE710-0x0000000183FDE880
	[DebuggerNonUserCode] // 0x00000001897FACE0-0x00000001897FAD20
	// [XID] // 0x00000001897FACE0-0x00000001897FAD20
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183FDE4E0-0x0000000183FDE600
}

