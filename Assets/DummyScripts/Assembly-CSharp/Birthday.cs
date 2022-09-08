/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class Birthday : MessageBase, IMessage<Birthday> // TypeDefIndex: 26080
{
	// Fields
	private static readonly MessageParser<Birthday> _parser; // 0x00
	public const int MonthFieldNumber = 1; // Metadata: 0x00B0B0C7
	private uint month_; // 0x18
	public const int DayFieldNumber = 2; // Metadata: 0x00B0B0CB
	private uint day_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<Birthday> Parser { get => default; } // 0x0000000184B46870-0x0000000184B46900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184B46600-0x0000000184B46690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184B462F0-0x0000000184B46370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184B45BA0-0x0000000184B45C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184B46C00-0x0000000184B46CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184B46A30-0x0000000184B46A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184B46690-0x0000000184B46780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184B46BB0-0x0000000184B46C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184B46410-0x0000000184B46500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Month { get => default; set {} } // 0x0000000184B46080-0x0000000184B46120 0x0000000184B46CF0-0x0000000184B46D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Day { get => default; set {} } // 0x0000000184B46250-0x0000000184B462F0 0x0000000184B45DF0-0x0000000184B45E90

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Birthday() {} // 0x0000000184B47050-0x0000000184B470B0
	static Birthday() {} // 0x0000000184B46F90-0x0000000184B47050

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Birthday Clone() => default; // 0x0000000184B46780-0x0000000184B46870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Birthday ShallowCopy() => default; // 0x0000000184B46370-0x0000000184B46410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184B45D30-0x0000000184B45D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B46990-0x0000000184B469E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B469E0-0x0000000184B46A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184B45D80-0x0000000184B45DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184B45FB0-0x0000000184B46080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(Birthday other) => default; // 0x0000000184B45E90-0x0000000184B45FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184B46500-0x0000000184B46600
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184B46D90-0x0000000184B46F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184B46A90-0x0000000184B46BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184B46120-0x0000000184B46250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(Birthday other) {} // 0x0000000184B45C00-0x0000000184B45D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184B45AA0-0x0000000184B45BA0
}

