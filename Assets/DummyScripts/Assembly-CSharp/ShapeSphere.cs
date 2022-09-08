/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ShapeSphere : MessageBase, IMessage<ShapeSphere> // TypeDefIndex: 26087
{
	// Fields
	private static readonly MessageParser<ShapeSphere> _parser; // 0x00
	public const int CenterFieldNumber = 1; // Metadata: 0x00B0B13F
	private Vector center_; // 0x18
	public const int RadiusFieldNumber = 2; // Metadata: 0x00B0B143
	private float radius_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ShapeSphere> Parser { get => default; } // 0x0000000183742440-0x00000001837424D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001837421D0-0x0000000183742260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183741CF0-0x0000000183741D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183741520-0x0000000183741580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183742830-0x0000000183742920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183742660-0x00000001837426C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183742260-0x0000000183742350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001837427E0-0x0000000183742830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183741EB0-0x0000000183741FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Center { get => default; set {} } // 0x0000000183741350-0x00000001837413F0 0x0000000183742130-0x00000001837421D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float Radius { get => default; set {} } // 0x0000000183741E10-0x0000000183741EB0 0x00000001837418D0-0x0000000183741970

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShapeSphere() {} // 0x0000000183742BD0-0x0000000183742C30
	static ShapeSphere() {} // 0x0000000183742B10-0x0000000183742BD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShapeSphere Clone() => default; // 0x0000000183742350-0x0000000183742440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShapeSphere ShallowCopy() => default; // 0x0000000183741D70-0x0000000183741E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183741720-0x00000001837417A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183742560-0x00000001837425E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001837425E0-0x0000000183742660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001837417A0-0x00000001837418D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183741970-0x0000000183741A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ShapeSphere other) => default; // 0x0000000183741A40-0x0000000183741B80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183741FA0-0x0000000183742130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183742920-0x0000000183742B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001837426C0-0x00000001837427E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183741B80-0x0000000183741CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ShapeSphere other) {} // 0x0000000183741580-0x0000000183741720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001837413F0-0x0000000183741520
}

