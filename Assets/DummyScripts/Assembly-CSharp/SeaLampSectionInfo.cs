/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SeaLampSectionInfo : MessageBase, IMessage<SeaLampSectionInfo> // TypeDefIndex: 21917
{
	// Fields
	private static readonly MessageParser<SeaLampSectionInfo> _parser; // 0x00
	public const int SectionIdFieldNumber = 1; // Metadata: 0x00B0057B
	private uint sectionId_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SeaLampSectionInfo> Parser { get => default; } // 0x0000000182DE1510-0x0000000182DE15A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182DE1200-0x0000000182DE1290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182DE0F10-0x0000000182DE0F90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182DE0980-0x0000000182DE09E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182DE1860-0x0000000182DE1950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182DE16D0-0x0000000182DE1730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182DE1290-0x0000000182DE1380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182DE1810-0x0000000182DE1860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182DE1030-0x0000000182DE1120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SectionId { get => default; set {} } // 0x0000000182DE0E70-0x0000000182DE0F10 0x0000000182DE1470-0x0000000182DE1510

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampSectionInfo() {} // 0x0000000182DE1B80-0x0000000182DE1BE0
	static SeaLampSectionInfo() {} // 0x0000000182DE1AC0-0x0000000182DE1B80

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampSectionInfo Clone() => default; // 0x0000000182DE1380-0x0000000182DE1470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SeaLampSectionInfo ShallowCopy() => default; // 0x0000000182DE0F90-0x0000000182DE1030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182DE0AF0-0x0000000182DE0B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182DE1630-0x0000000182DE1680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182DE1680-0x0000000182DE16D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182DE0B40-0x0000000182DE0BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182DE0BB0-0x0000000182DE0C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SeaLampSectionInfo other) => default; // 0x0000000182DE0C80-0x0000000182DE0D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182DE1120-0x0000000182DE1200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182DE1950-0x0000000182DE1AC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182DE1730-0x0000000182DE1810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182DE0D80-0x0000000182DE0E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SeaLampSectionInfo other) {} // 0x0000000182DE09E0-0x0000000182DE0AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182DE08A0-0x0000000182DE0980
}

