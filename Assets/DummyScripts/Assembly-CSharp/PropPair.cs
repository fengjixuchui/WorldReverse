/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PropPair : MessageBase, IMessage<PropPair> // TypeDefIndex: 26048
{
	// Fields
	private static readonly MessageParser<PropPair> _parser; // 0x00
	public const int TypeFieldNumber = 1; // Metadata: 0x00B0AE23
	private uint type_; // 0x18
	public const int PropValueFieldNumber = 2; // Metadata: 0x00B0AE27
	private PropValue propValue_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PropPair> Parser { get => default; } // 0x0000000182FDFE30-0x0000000182FDFEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182FDFBC0-0x0000000182FDFC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182FDF830-0x0000000182FDF8B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182FDF060-0x0000000182FDF0C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182FE0360-0x0000000182FE0450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182FE00F0-0x0000000182FE0150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182FDFC50-0x0000000182FDFD40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182FE0270-0x0000000182FE02C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182FDF950-0x0000000182FDFA40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Type { get => default; set {} } // 0x0000000182FDEE80-0x0000000182FDEF20 0x0000000182FE02C0-0x0000000182FE0360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PropValue PropValue { get => default; set {} } // 0x0000000182FDF0C0-0x0000000182FDF160 0x0000000182FDFF50-0x0000000182FDFFF0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PropPair() {} // 0x0000000182FE06F0-0x0000000182FE0750
	static PropPair() {} // 0x0000000182FE0630-0x0000000182FE06F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PropPair Clone() => default; // 0x0000000182FDFD40-0x0000000182FDFE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PropPair ShallowCopy() => default; // 0x0000000182FDF8B0-0x0000000182FDF950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182FDF2E0-0x0000000182FDF360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182FDFFF0-0x0000000182FE0070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182FE0070-0x0000000182FE00F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182FDF360-0x0000000182FDF490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182FDF5C0-0x0000000182FDF690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PropPair other) => default; // 0x0000000182FDF490-0x0000000182FDF5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182FDFA40-0x0000000182FDFBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182FE0450-0x0000000182FE0630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182FE0150-0x0000000182FE0270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182FDF690-0x0000000182FDF830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PropPair other) {} // 0x0000000182FDF160-0x0000000182FDF2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182FDEF20-0x0000000182FDF060
}

