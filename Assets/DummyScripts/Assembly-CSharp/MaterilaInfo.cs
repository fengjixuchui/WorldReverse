/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MaterilaInfo : MessageBase, IMessage<MaterilaInfo> // TypeDefIndex: 23751
{
	// Fields
	private static readonly MessageParser<MaterilaInfo> _parser; // 0x00
	public const int GuidFieldNumber = 1; // Metadata: 0x00B04BF3
	private ulong guid_; // 0x18
	public const int CountFieldNumber = 2; // Metadata: 0x00B04BF7
	private uint count_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MaterilaInfo> Parser { get => default; } // 0x0000000182D85950-0x0000000182D859E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182D856E0-0x0000000182D85770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182D853C0-0x0000000182D85440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182D84D10-0x0000000182D84D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182D85D80-0x0000000182D85E70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182D85BB0-0x0000000182D85C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182D85770-0x0000000182D85860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182D85D30-0x0000000182D85D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182D854E0-0x0000000182D855D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong Guid { get => default; set {} } // 0x0000000182D84EA0-0x0000000182D84F40 0x0000000182D85000-0x0000000182D850A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Count { get => default; set {} } // 0x0000000182D85A70-0x0000000182D85B10 0x0000000182D84C70-0x0000000182D84D10

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MaterilaInfo() {} // 0x0000000182D86130-0x0000000182D86190
	static MaterilaInfo() {} // 0x0000000182D86070-0x0000000182D86130

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MaterilaInfo Clone() => default; // 0x0000000182D85860-0x0000000182D85950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MaterilaInfo ShallowCopy() => default; // 0x0000000182D85440-0x0000000182D854E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182D84F40-0x0000000182D84F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D85B10-0x0000000182D85B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D85B60-0x0000000182D85BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182D84F90-0x0000000182D85000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182D850A0-0x0000000182D85170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MaterilaInfo other) => default; // 0x0000000182D85170-0x0000000182D85290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182D855D0-0x0000000182D856E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182D85E70-0x0000000182D86070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182D85C10-0x0000000182D85D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182D85290-0x0000000182D853C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MaterilaInfo other) {} // 0x0000000182D84D70-0x0000000182D84EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182D84B70-0x0000000182D84C70
}

