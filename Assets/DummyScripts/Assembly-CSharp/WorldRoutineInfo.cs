/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorldRoutineInfo : MessageBase, IMessage<WorldRoutineInfo> // TypeDefIndex: 24874
{
	// Fields
	private static readonly MessageParser<WorldRoutineInfo> _parser; // 0x00
	public const int RoutineIdFieldNumber = 1; // Metadata: 0x00B076C7
	private uint routineId_; // 0x18
	public const int ProgressFieldNumber = 2; // Metadata: 0x00B076CB
	private uint progress_; // 0x1C
	public const int FinishProgressFieldNumber = 3; // Metadata: 0x00B076CF
	private uint finishProgress_; // 0x20
	public const int IsFinishedFieldNumber = 4; // Metadata: 0x00B076D3
	private bool isFinished_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WorldRoutineInfo> Parser { get => default; } // 0x00000001836EFAD0-0x00000001836EFB60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001836EF720-0x00000001836EF7B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001836EF310-0x00000001836EF390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001836EEB50-0x00000001836EEBB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001836EFF80-0x00000001836F0070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001836EFD30-0x00000001836EFD90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001836EF850-0x00000001836EF940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001836EFF30-0x00000001836EFF80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001836EF4D0-0x00000001836EF5C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RoutineId { get => default; set {} } // 0x00000001836EEBB0-0x00000001836EEC50 0x00000001836F0070-0x00000001836F0110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Progress { get => default; set {} } // 0x00000001836EF7B0-0x00000001836EF850 0x00000001836EF430-0x00000001836EF4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FinishProgress { get => default; set {} } // 0x00000001836EFBF0-0x00000001836EFC90 0x00000001836F0110-0x00000001836F01B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFinished { get => default; set {} } // 0x00000001836EFA30-0x00000001836EFAD0 0x00000001836EEEB0-0x00000001836EEF50

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldRoutineInfo() {} // 0x00000001836F0590-0x00000001836F05F0
	static WorldRoutineInfo() {} // 0x00000001836F04D0-0x00000001836F0590

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldRoutineInfo Clone() => default; // 0x00000001836EF940-0x00000001836EFA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldRoutineInfo ShallowCopy() => default; // 0x00000001836EF390-0x00000001836EF430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001836EEDD0-0x00000001836EEE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836EFC90-0x00000001836EFCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001836EFCE0-0x00000001836EFD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001836EEE20-0x00000001836EEEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001836EEF50-0x00000001836EF020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WorldRoutineInfo other) => default; // 0x00000001836EF020-0x00000001836EF180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001836EF5C0-0x00000001836EF720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001836F01B0-0x00000001836F04D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001836EFD90-0x00000001836EFF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001836EF180-0x00000001836EF310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WorldRoutineInfo other) {} // 0x00000001836EEC50-0x00000001836EEDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001836EEA20-0x00000001836EEB50
}

