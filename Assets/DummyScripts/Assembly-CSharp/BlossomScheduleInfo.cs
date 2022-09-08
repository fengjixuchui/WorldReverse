/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BlossomScheduleInfo : MessageBase, IMessage<BlossomScheduleInfo> // TypeDefIndex: 22605
{
	// Fields
	private static readonly MessageParser<BlossomScheduleInfo> _parser; // 0x00
	public const int RefreshIdFieldNumber = 1; // Metadata: 0x00B01F93
	private uint refreshId_; // 0x18
	public const int CircleCampIdFieldNumber = 2; // Metadata: 0x00B01F97
	private uint circleCampId_; // 0x1C
	public const int RoundFieldNumber = 3; // Metadata: 0x00B01F9B
	private uint round_; // 0x20
	public const int StateFieldNumber = 4; // Metadata: 0x00B01F9F
	private uint state_; // 0x24
	public const int ProgressFieldNumber = 5; // Metadata: 0x00B01FA3
	private uint progress_; // 0x28
	public const int FinishProgressFieldNumber = 6; // Metadata: 0x00B01FA7
	private uint finishProgress_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BlossomScheduleInfo> Parser { get => default; } // 0x0000000184C24D40-0x0000000184C24DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184C24990-0x0000000184C24A20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184C24480-0x0000000184C24500 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184C23A10-0x0000000184C23A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184C25310-0x0000000184C25400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184C25040-0x0000000184C250A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184C24AC0-0x0000000184C24BB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184C252C0-0x0000000184C25310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184C24640-0x0000000184C24730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RefreshId { get => default; set {} } // 0x0000000184C23A70-0x0000000184C23B10 0x0000000184C24CA0-0x0000000184C24D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CircleCampId { get => default; set {} } // 0x0000000184C248F0-0x0000000184C24990 0x0000000184C25400-0x0000000184C254A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Round { get => default; set {} } // 0x0000000184C24F50-0x0000000184C24FF0 0x0000000184C23B10-0x0000000184C23BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint State { get => default; set {} } // 0x0000000184C24340-0x0000000184C243E0 0x0000000184C243E0-0x0000000184C24480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Progress { get => default; set {} } // 0x0000000184C24A20-0x0000000184C24AC0 0x0000000184C245A0-0x0000000184C24640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FinishProgress { get => default; set {} } // 0x0000000184C24E60-0x0000000184C24F00 0x0000000184C254A0-0x0000000184C25540

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlossomScheduleInfo() {} // 0x0000000184C25A30-0x0000000184C25A90
	static BlossomScheduleInfo() {} // 0x0000000184C25970-0x0000000184C25A30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlossomScheduleInfo Clone() => default; // 0x0000000184C24BB0-0x0000000184C24CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BlossomScheduleInfo ShallowCopy() => default; // 0x0000000184C24500-0x0000000184C245A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184C23D80-0x0000000184C23DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184C24F00-0x0000000184C24F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184C24FF0-0x0000000184C25040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184C23DD0-0x0000000184C23E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184C24010-0x0000000184C240E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BlossomScheduleInfo other) => default; // 0x0000000184C23E80-0x0000000184C24010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184C24730-0x0000000184C248F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184C25540-0x0000000184C25970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184C250A0-0x0000000184C252C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184C240E0-0x0000000184C24340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BlossomScheduleInfo other) {} // 0x0000000184C23BB0-0x0000000184C23D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184C238A0-0x0000000184C23A10
}

