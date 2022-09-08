/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeBasicCompSnapshot : MessageBase, IMessage<HomeBasicCompSnapshot> // TypeDefIndex: 23406
{
	// Fields
	private static readonly MessageParser<HomeBasicCompSnapshot> _parser; // 0x00
	public const int ExpFieldNumber = 1; // Metadata: 0x00B03F43
	private ulong exp_; // 0x18
	public const int LevelFieldNumber = 2; // Metadata: 0x00B03F47
	private uint level_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeBasicCompSnapshot> Parser { get => default; } // 0x0000000180FD2040-0x0000000180FD20D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000180FD1DD0-0x0000000180FD1E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000180FD1A10-0x0000000180FD1A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000180FD1360-0x0000000180FD13C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000180FD2470-0x0000000180FD2560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000180FD22A0-0x0000000180FD2300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000180FD1E60-0x0000000180FD1F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000180FD2420-0x0000000180FD2470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000180FD1BD0-0x0000000180FD1CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong Exp { get => default; set {} } // 0x0000000180FD1650-0x0000000180FD16F0 0x0000000180FD2160-0x0000000180FD2200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Level { get => default; set {} } // 0x0000000180FD14F0-0x0000000180FD1590 0x0000000180FD1B30-0x0000000180FD1BD0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeBasicCompSnapshot() {} // 0x0000000180FD2820-0x0000000180FD2880
	static HomeBasicCompSnapshot() {} // 0x0000000180FD2760-0x0000000180FD2820

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeBasicCompSnapshot Clone() => default; // 0x0000000180FD1F50-0x0000000180FD2040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeBasicCompSnapshot ShallowCopy() => default; // 0x0000000180FD1A90-0x0000000180FD1B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000180FD1590-0x0000000180FD15E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180FD2200-0x0000000180FD2250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000180FD2250-0x0000000180FD22A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000180FD15E0-0x0000000180FD1650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000180FD1810-0x0000000180FD18E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeBasicCompSnapshot other) => default; // 0x0000000180FD16F0-0x0000000180FD1810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000180FD1CC0-0x0000000180FD1DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000180FD2560-0x0000000180FD2760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000180FD2300-0x0000000180FD2420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000180FD18E0-0x0000000180FD1A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeBasicCompSnapshot other) {} // 0x0000000180FD13C0-0x0000000180FD14F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000180FD1260-0x0000000180FD1360
}

