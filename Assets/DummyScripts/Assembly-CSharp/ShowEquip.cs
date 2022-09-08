/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ShowEquip : MessageBase, IMessage<ShowEquip> // TypeDefIndex: 26071
{
	// Fields
	private static readonly MessageParser<ShowEquip> _parser; // 0x00
	public const int ItemIdFieldNumber = 1; // Metadata: 0x00B0AFDB
	private uint itemId_; // 0x18
	public const int ReliquaryFieldNumber = 2; // Metadata: 0x00B0AFDF
	public const int WeaponFieldNumber = 3; // Metadata: 0x00B0AFE3
	private object detail_; // 0x20
	private DetailOneofCase detailCase_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ShowEquip> Parser { get => default; } // 0x000000018479EB20-0x000000018479EBB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018479E740-0x000000018479E7D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018479E3F0-0x000000018479E470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018479D900-0x000000018479D960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018479F1C0-0x000000018479F2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018479EF20-0x000000018479EF80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018479E7D0-0x000000018479E8C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018479F0D0-0x000000018479F120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018479E510-0x000000018479E600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ItemId { get => default; set {} } // 0x000000018479EC40-0x000000018479ECE0 0x000000018479F120-0x000000018479F1C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Reliquary Reliquary { get => default; set {} } // 0x000000018479D960-0x000000018479DA30 0x000000018479F2B0-0x000000018479F350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Weapon Weapon { get => default; set {} } // 0x000000018479EA50-0x000000018479EB20 0x000000018479E8C0-0x000000018479E960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DetailOneofCase DetailCase { get => default; } // 0x000000018479DD80-0x000000018479DDE0 

	// Nested types
	public enum DetailOneofCase // TypeDefIndex: 26072
	{
		None = 0,
		Reliquary = 2,
		Weapon = 3
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShowEquip() {} // 0x000000018479F6C0-0x000000018479F730
	static ShowEquip() {} // 0x000000018479F600-0x000000018479F6C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShowEquip Clone() => default; // 0x000000018479E960-0x000000018479EA50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ShowEquip ShallowCopy() => default; // 0x000000018479E470-0x000000018479E510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018479DC60-0x000000018479DD80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018479ECE0-0x000000018479EE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018479EE00-0x000000018479EF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018479DDE0-0x000000018479DE50
	public void resetDetail() {} // 0x000000018479E220-0x000000018479E3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearDetail() {} // 0x000000018479DA30-0x000000018479DA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018479DE50-0x000000018479DF20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ShowEquip other) => default; // 0x000000018479DF20-0x000000018479E0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018479E600-0x000000018479E740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018479F350-0x000000018479F600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018479EF80-0x000000018479F0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018479E0A0-0x000000018479E220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ShowEquip other) {} // 0x000000018479DA90-0x000000018479DC60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018479D700-0x000000018479D900
}

