/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BattlePassCycle : MessageBase, IMessage<BattlePassCycle> // TypeDefIndex: 22538
{
	// Fields
	private static readonly MessageParser<BattlePassCycle> _parser; // 0x00
	public const int CycleIdxFieldNumber = 1; // Metadata: 0x00B01CFB
	private uint cycleIdx_; // 0x18
	public const int BeginTimeFieldNumber = 2; // Metadata: 0x00B01CFF
	private uint beginTime_; // 0x1C
	public const int EndTimeFieldNumber = 3; // Metadata: 0x00B01D03
	private uint endTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BattlePassCycle> Parser { get => default; } // 0x00000001838DF5B0-0x00000001838DF640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001838DF2A0-0x00000001838DF330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001838DEF60-0x00000001838DEFE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001838DE800-0x00000001838DE860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001838DFB60-0x00000001838DFC50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001838DF8B0-0x00000001838DF910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001838DF330-0x00000001838DF420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001838DFB10-0x00000001838DFB60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001838DF080-0x00000001838DF170 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CycleIdx { get => default; set {} } // 0x00000001838DEA60-0x00000001838DEB00 0x00000001838DE860-0x00000001838DE900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BeginTime { get => default; set {} } // 0x00000001838DFA70-0x00000001838DFB10 0x00000001838DF770-0x00000001838DF810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x00000001838DF510-0x00000001838DF5B0 0x00000001838DF810-0x00000001838DF8B0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassCycle() {} // 0x00000001838DFFA0-0x00000001838E0000
	static BattlePassCycle() {} // 0x00000001838DFEE0-0x00000001838DFFA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassCycle Clone() => default; // 0x00000001838DF420-0x00000001838DF510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BattlePassCycle ShallowCopy() => default; // 0x00000001838DEFE0-0x00000001838DF080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001838DEB00-0x00000001838DEB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838DF6D0-0x00000001838DF720
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001838DF720-0x00000001838DF770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001838DEB50-0x00000001838DEBD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001838DEBD0-0x00000001838DECA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BattlePassCycle other) => default; // 0x00000001838DECA0-0x00000001838DEDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001838DF170-0x00000001838DF2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001838DFC50-0x00000001838DFEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001838DF910-0x00000001838DFA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001838DEDE0-0x00000001838DEF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BattlePassCycle other) {} // 0x00000001838DE900-0x00000001838DEA60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001838DE6F0-0x00000001838DE800
}

