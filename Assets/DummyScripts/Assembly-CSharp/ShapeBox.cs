/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ShapeBox : MessageBase, IMessage<ShapeBox> // TypeDefIndex: 26088
{
	// Fields
	private static readonly MessageParser<ShapeBox> _parser; // 0x00
	public const int CenterFieldNumber = 1; // Metadata: 0x00B0B147
	private Vector center_; // 0x18
	public const int Axis0FieldNumber = 2; // Metadata: 0x00B0B14B
	private Vector axis0_; // 0x20
	public const int Axis1FieldNumber = 3; // Metadata: 0x00B0B14F
	private Vector axis1_; // 0x28
	public const int Axis2FieldNumber = 4; // Metadata: 0x00B0B153
	private Vector axis2_; // 0x30
	public const int ExtentsFieldNumber = 5; // Metadata: 0x00B0B157
	private Vector extents_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ShapeBox> Parser { get => default; } // 0x00000001820913A0-0x0000000182091430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182091090-0x0000000182091120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182090A00-0x0000000182090A80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018208F980-0x000000018208F9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182091A10-0x0000000182091B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001820917A0-0x0000000182091800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182091120-0x0000000182091210 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001820919C0-0x0000000182091A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182090B20-0x0000000182090C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Center { get => default; set {} } // 0x000000018208F680-0x000000018208F720 0x0000000182090FF0-0x0000000182091090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Axis0 { get => default; set {} } // 0x0000000182091BA0-0x0000000182091C40 0x0000000182091C40-0x0000000182091CE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Axis1 { get => default; set {} } // 0x0000000182091700-0x00000001820917A0 0x00000001820902A0-0x0000000182090340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Axis2 { get => default; set {} } // 0x0000000182091430-0x00000001820914D0 0x000000018208F9E0-0x000000018208FA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Extents { get => default; set {} } // 0x0000000182091300-0x00000001820913A0 0x0000000182091B00-0x0000000182091BA0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShapeBox() {} // 0x00000001820920C0-0x0000000182092120
	static ShapeBox() {} // 0x0000000182092000-0x00000001820920C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShapeBox Clone() => default; // 0x0000000182091210-0x0000000182091300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShapeBox ShallowCopy() => default; // 0x0000000182090A80-0x0000000182090B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018208FDB0-0x000000018208FE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182091560-0x0000000182091630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182091630-0x0000000182091700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018208FE80-0x00000001820902A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182090340-0x0000000182090410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ShapeBox other) => default; // 0x0000000182090410-0x00000001820905E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182090C10-0x0000000182090FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182091CE0-0x0000000182092000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182091800-0x00000001820919C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001820905E0-0x0000000182090A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ShapeBox other) {} // 0x000000018208FA80-0x000000018208FDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018208F720-0x000000018208F980
}

