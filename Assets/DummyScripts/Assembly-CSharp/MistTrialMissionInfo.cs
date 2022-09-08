/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class MistTrialMissionInfo : MessageBase, IMessage<MistTrialMissionInfo> // TypeDefIndex: 22340
{
	// Fields
	private static readonly MessageParser<MistTrialMissionInfo> _parser; // 0x00
	public const int WatcherListIdFieldNumber = 1; // Metadata: 0x00B015E7
	private uint watcherListId_; // 0x18
	public const int ParamFieldNumber = 2; // Metadata: 0x00B015EB
	private uint param_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<MistTrialMissionInfo> Parser { get => default; } // 0x0000000185548750-0x00000001855487E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001855484E0-0x0000000185548570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001855481D0-0x0000000185548250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000185547C60-0x0000000185547CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185548D60-0x0000000185548E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001855489B0-0x0000000185548A10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185548570-0x0000000185548660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185548D10-0x0000000185548D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001855482F0-0x00000001855483E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WatcherListId { get => default; set {} } // 0x00000001855487E0-0x0000000185548880 0x0000000185548AB0-0x0000000185548B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Param { get => default; set {} } // 0x0000000185548A10-0x0000000185548AB0 0x0000000185548B50-0x0000000185548BF0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialMissionInfo() {} // 0x0000000185549110-0x0000000185549170
	static MistTrialMissionInfo() {} // 0x0000000185549050-0x0000000185549110

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialMissionInfo Clone() => default; // 0x0000000185548660-0x0000000185548750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MistTrialMissionInfo ShallowCopy() => default; // 0x0000000185548250-0x00000001855482F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000185547DF0-0x0000000185547E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185548910-0x0000000185548960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185548960-0x00000001855489B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185547E40-0x0000000185547EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185547EB0-0x0000000185547F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(MistTrialMissionInfo other) => default; // 0x0000000185547F80-0x00000001855480A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001855483E0-0x00000001855484E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185548E50-0x0000000185549050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185548BF0-0x0000000185548D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001855480A0-0x00000001855481D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(MistTrialMissionInfo other) {} // 0x0000000185547CC0-0x0000000185547DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185547B60-0x0000000185547C60
}

