/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorldRoutineChangeNotify : MessageBase, IMessage<WorldRoutineChangeNotify> // TypeDefIndex: 24882
{
	// Fields
	private static readonly MessageParser<WorldRoutineChangeNotify> _parser; // 0x00
	public const int RoutineTypeFieldNumber = 1; // Metadata: 0x00B0770B
	private uint routineType_; // 0x18
	public const int RoutineInfoFieldNumber = 2; // Metadata: 0x00B0770F
	private WorldRoutineInfo routineInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WorldRoutineChangeNotify> Parser { get => default; } // 0x00000001843B4D60-0x00000001843B4DF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001843B49B0-0x00000001843B4A40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001843B4620-0x00000001843B46A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001843B3E50-0x00000001843B3EB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001843B51F0-0x00000001843B52E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001843B4F80-0x00000001843B4FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001843B4AE0-0x00000001843B4BD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001843B51A0-0x00000001843B51F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001843B4740-0x00000001843B4830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RoutineType { get => default; set {} } // 0x00000001843B4A40-0x00000001843B4AE0 0x00000001843B4030-0x00000001843B40D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldRoutineInfo RoutineInfo { get => default; set {} } // 0x00000001843B4CC0-0x00000001843B4D60 0x00000001843B5100-0x00000001843B51A0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24883
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24884
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3504
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldRoutineChangeNotify() {} // 0x00000001843B5580-0x00000001843B55E0
	static WorldRoutineChangeNotify() {} // 0x00000001843B54C0-0x00000001843B5580

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldRoutineChangeNotify Clone() => default; // 0x00000001843B4BD0-0x00000001843B4CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldRoutineChangeNotify ShallowCopy() => default; // 0x00000001843B46A0-0x00000001843B4740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001843B40D0-0x00000001843B4150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843B4E80-0x00000001843B4F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001843B4F00-0x00000001843B4F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001843B4150-0x00000001843B4280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001843B4280-0x00000001843B4350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WorldRoutineChangeNotify other) => default; // 0x00000001843B4350-0x00000001843B4480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001843B4830-0x00000001843B49B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001843B52E0-0x00000001843B54C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001843B4FE0-0x00000001843B5100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001843B4480-0x00000001843B4620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WorldRoutineChangeNotify other) {} // 0x00000001843B3EB0-0x00000001843B4030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001843B3D10-0x00000001843B3E50
}

