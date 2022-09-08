/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Equip : MessageBase, IMessage<Equip> // TypeDefIndex: 25981
{
	// Fields
	private static readonly MessageParser<Equip> _parser; // 0x00
	public const int ReliquaryFieldNumber = 1; // Metadata: 0x00B0A8DF
	public const int WeaponFieldNumber = 2; // Metadata: 0x00B0A8E3
	public const int IsLockedFieldNumber = 3; // Metadata: 0x00B0A8E7
	private bool isLocked_; // 0x18
	private object detail_; // 0x20
	private DetailOneofCase detailCase_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Equip> Parser { get => default; } // 0x00000001812204C0-0x0000000181220550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001812200E0-0x0000000181220170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018121FD90-0x000000018121FE10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018121F1A0-0x000000018121F200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181220A20-0x0000000181220B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181220820-0x0000000181220880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181220170-0x0000000181220260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001812209D0-0x0000000181220A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018121FEB0-0x000000018121FFA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Reliquary Reliquary { get => default; set {} } // 0x000000018121F200-0x000000018121F2D0 0x0000000181220B10-0x0000000181220BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Weapon Weapon { get => default; set {} } // 0x00000001812203F0-0x00000001812204C0 0x0000000181220260-0x0000000181220300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsLocked { get => default; set {} } // 0x000000018121F790-0x000000018121F830 0x000000018121F330-0x000000018121F3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DetailOneofCase DetailCase { get => default; } // 0x000000018121F6C0-0x000000018121F720 

	// Nested types
	public enum DetailOneofCase // TypeDefIndex: 25982
	{
		None = 0,
		Reliquary = 1,
		Weapon = 2
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Equip() {} // 0x0000000181220F20-0x0000000181220F90
	static Equip() {} // 0x0000000181220E60-0x0000000181220F20

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Equip Clone() => default; // 0x0000000181220300-0x00000001812203F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Equip ShallowCopy() => default; // 0x000000018121FE10-0x000000018121FEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018121F5A0-0x000000018121F6C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001812205E0-0x0000000181220700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181220700-0x0000000181220820
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018121F720-0x000000018121F790
	public void resetDetail() {} // 0x000000018121FBC0-0x000000018121FD90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearDetail() {} // 0x000000018121F2D0-0x000000018121F330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018121F9B0-0x000000018121FA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(Equip other) => default; // 0x000000018121F830-0x000000018121F9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018121FFA0-0x00000001812200E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181220BB0-0x0000000181220E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181220880-0x00000001812209D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018121FA80-0x000000018121FBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(Equip other) {} // 0x000000018121F3D0-0x000000018121F5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018121EFA0-0x000000018121F1A0
}

