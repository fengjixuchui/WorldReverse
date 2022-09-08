/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlaceInfo : MessageBase, IMessage<PlaceInfo> // TypeDefIndex: 26010
{
	// Fields
	private static readonly MessageParser<PlaceInfo> _parser; // 0x00
	public const int PosFieldNumber = 1; // Metadata: 0x00B0AA97
	private Vector pos_; // 0x18
	public const int RotFieldNumber = 2; // Metadata: 0x00B0AA9B
	private Vector rot_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlaceInfo> Parser { get => default; } // 0x0000000184CBB470-0x0000000184CBB500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184CBB160-0x0000000184CBB1F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184CBAD60-0x0000000184CBADE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184CBA3F0-0x0000000184CBA450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184CBB9B0-0x0000000184CBBAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184CBB750-0x0000000184CBB7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184CBB290-0x0000000184CBB380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184CBB960-0x0000000184CBB9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184CBAE80-0x0000000184CBAF70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Pos { get => default; set {} } // 0x0000000184CBB6B0-0x0000000184CBB750 0x0000000184CBB8C0-0x0000000184CBB960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Rot { get => default; set {} } // 0x0000000184CBB1F0-0x0000000184CBB290 0x0000000184CBA450-0x0000000184CBA4F0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlaceInfo() {} // 0x0000000184CBBD20-0x0000000184CBBD80
	static PlaceInfo() {} // 0x0000000184CBBC60-0x0000000184CBBD20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlaceInfo Clone() => default; // 0x0000000184CBB380-0x0000000184CBB470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlaceInfo ShallowCopy() => default; // 0x0000000184CBADE0-0x0000000184CBAE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184CBA6D0-0x0000000184CBA760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184CBB590-0x0000000184CBB620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184CBB620-0x0000000184CBB6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184CBA760-0x0000000184CBA940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184CBAA80-0x0000000184CBAB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlaceInfo other) => default; // 0x0000000184CBA940-0x0000000184CBAA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184CBAF70-0x0000000184CBB160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184CBBAA0-0x0000000184CBBC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184CBB7B0-0x0000000184CBB8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184CBAB50-0x0000000184CBAD60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlaceInfo other) {} // 0x0000000184CBA4F0-0x0000000184CBA6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184CBA280-0x0000000184CBA3F0
}

