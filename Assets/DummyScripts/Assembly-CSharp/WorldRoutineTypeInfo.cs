/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorldRoutineTypeInfo : MessageBase, IMessage<WorldRoutineTypeInfo> // TypeDefIndex: 24875
{
	// Fields
	private static readonly MessageParser<WorldRoutineTypeInfo> _parser; // 0x00
	public const int RoutineTypeFieldNumber = 1; // Metadata: 0x00B076D7
	private uint routineType_; // 0x18
	public const int WorldRoutineInfoListFieldNumber = 2; // Metadata: 0x00B076DB
	private static readonly FieldCodec<WorldRoutineInfo> _repeated_worldRoutineInfoList_codec; // 0x08
	private readonly RepeatedMessageField<WorldRoutineInfo> worldRoutineInfoList_; // 0x20
	public const int NextRefreshTimeFieldNumber = 3; // Metadata: 0x00B076DF
	private uint nextRefreshTime_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WorldRoutineTypeInfo> Parser { get => default; } // 0x0000000181A63C90-0x0000000181A63D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181A638E0-0x0000000181A63970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181A635A0-0x0000000181A63620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181A62DC0-0x0000000181A62E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181A64100-0x0000000181A641F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181A63ED0-0x0000000181A63F30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181A63A10-0x0000000181A63B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181A640B0-0x0000000181A64100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181A636C0-0x0000000181A637B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RoutineType { get => default; set {} } // 0x0000000181A63970-0x0000000181A63A10 0x0000000181A62FB0-0x0000000181A63050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<WorldRoutineInfo> WorldRoutineInfoList { get => default; } // 0x0000000181A63540-0x0000000181A635A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextRefreshTime { get => default; set {} } // 0x0000000181A63BF0-0x0000000181A63C90 0x0000000181A641F0-0x0000000181A64290

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldRoutineTypeInfo() {} // 0x0000000181A64610-0x0000000181A646A0
	static WorldRoutineTypeInfo() {} // 0x0000000181A64500-0x0000000181A64610

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldRoutineTypeInfo Clone() => default; // 0x0000000181A63B00-0x0000000181A63BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldRoutineTypeInfo ShallowCopy() => default; // 0x0000000181A63620-0x0000000181A636C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181A63050-0x0000000181A630A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A63DB0-0x0000000181A63E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181A63E40-0x0000000181A63ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181A630A0-0x0000000181A63190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181A632E0-0x0000000181A633B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WorldRoutineTypeInfo other) => default; // 0x0000000181A63190-0x0000000181A632E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181A637B0-0x0000000181A638E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181A64290-0x0000000181A64500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181A63F30-0x0000000181A640B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181A633B0-0x0000000181A63540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WorldRoutineTypeInfo other) {} // 0x0000000181A62E20-0x0000000181A62FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181A62C40-0x0000000181A62DC0
}

