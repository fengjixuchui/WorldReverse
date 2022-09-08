/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerRoutineInfo : MessageBase, IMessage<PlayerRoutineInfo> // TypeDefIndex: 24870
{
	// Fields
	private static readonly MessageParser<PlayerRoutineInfo> _parser; // 0x00
	public const int RoutineTypeFieldNumber = 1; // Metadata: 0x00B076AB
	private uint routineType_; // 0x18
	public const int FinishedNumFieldNumber = 2; // Metadata: 0x00B076AF
	private uint finishedNum_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerRoutineInfo> Parser { get => default; } // 0x0000000182D4A9E0-0x0000000182D4AA70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182D4A630-0x0000000182D4A6C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182D4A320-0x0000000182D4A3A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182D49C70-0x0000000182D49CD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182D4AD70-0x0000000182D4AE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182D4ABA0-0x0000000182D4AC00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182D4A760-0x0000000182D4A850 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182D4AD20-0x0000000182D4AD70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182D4A440-0x0000000182D4A530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RoutineType { get => default; set {} } // 0x0000000182D4A6C0-0x0000000182D4A760 0x0000000182D49EA0-0x0000000182D49F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FinishedNum { get => default; set {} } // 0x0000000182D4A940-0x0000000182D4A9E0 0x0000000182D49E00-0x0000000182D49EA0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerRoutineInfo() {} // 0x0000000182D4B120-0x0000000182D4B180
	static PlayerRoutineInfo() {} // 0x0000000182D4B060-0x0000000182D4B120

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerRoutineInfo Clone() => default; // 0x0000000182D4A850-0x0000000182D4A940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerRoutineInfo ShallowCopy() => default; // 0x0000000182D4A3A0-0x0000000182D4A440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182D49F40-0x0000000182D49F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D4AB00-0x0000000182D4AB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D4AB50-0x0000000182D4ABA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182D49F90-0x0000000182D4A000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182D4A120-0x0000000182D4A1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerRoutineInfo other) => default; // 0x0000000182D4A000-0x0000000182D4A120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182D4A530-0x0000000182D4A630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182D4AE60-0x0000000182D4B060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182D4AC00-0x0000000182D4AD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182D4A1F0-0x0000000182D4A320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerRoutineInfo other) {} // 0x0000000182D49CD0-0x0000000182D49E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182D49B70-0x0000000182D49C70
}

