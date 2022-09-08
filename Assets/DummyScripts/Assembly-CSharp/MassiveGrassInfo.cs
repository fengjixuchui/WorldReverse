/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MassiveGrassInfo : MessageBase, IMessage<MassiveGrassInfo> // TypeDefIndex: 26083
{
	// Fields
	private static readonly MessageParser<MassiveGrassInfo> _parser; // 0x00
	public const int IdFieldNumber = 1; // Metadata: 0x00B0B0EF
	private uint id_; // 0x18
	public const int CenterFieldNumber = 2; // Metadata: 0x00B0B0F3
	private Vector center_; // 0x20
	public const int SizeFieldNumber = 3; // Metadata: 0x00B0B0F7
	private Vector size_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MassiveGrassInfo> Parser { get => default; } // 0x000000018193AEA0-0x000000018193AF30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018193AAF0-0x000000018193AB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018193A620-0x000000018193A6A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181939C20-0x0000000181939C80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018193B380-0x000000018193B470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018193B180-0x000000018193B1E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018193AC20-0x000000018193AD10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018193B330-0x000000018193B380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018193A740-0x000000018193A830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Id { get => default; set {} } // 0x000000018193A580-0x000000018193A620 0x000000018193AF30-0x000000018193AFD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Center { get => default; set {} } // 0x00000001819399F0-0x0000000181939A90 0x000000018193AA50-0x000000018193AAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector Size { get => default; set {} } // 0x000000018193AE00-0x000000018193AEA0 0x000000018193AB80-0x000000018193AC20

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveGrassInfo() {} // 0x000000018193B790-0x000000018193B7F0
	static MassiveGrassInfo() {} // 0x000000018193B6D0-0x000000018193B790

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveGrassInfo Clone() => default; // 0x000000018193AD10-0x000000018193AE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MassiveGrassInfo ShallowCopy() => default; // 0x000000018193A6A0-0x000000018193A740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181939E80-0x0000000181939F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018193B060-0x000000018193B0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018193B0F0-0x000000018193B180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181939F10-0x000000018193A100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018193A260-0x000000018193A330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MassiveGrassInfo other) => default; // 0x000000018193A100-0x000000018193A260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018193A830-0x000000018193AA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018193B470-0x000000018193B6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018193B1E0-0x000000018193B330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018193A330-0x000000018193A580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MassiveGrassInfo other) {} // 0x0000000181939C80-0x0000000181939E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181939A90-0x0000000181939C20
}

