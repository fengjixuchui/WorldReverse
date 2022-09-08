/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorldRoutineTypeCloseNotify : MessageBase, IMessage<WorldRoutineTypeCloseNotify> // TypeDefIndex: 24885
{
	// Fields
	private static readonly MessageParser<WorldRoutineTypeCloseNotify> _parser; // 0x00
	public const int RoutineTypeFieldNumber = 1; // Metadata: 0x00B07723
	private uint routineType_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WorldRoutineTypeCloseNotify> Parser { get => default; } // 0x00000001841F4C70-0x00000001841F4D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001841F4960-0x00000001841F49F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001841F4670-0x00000001841F46F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001841F40E0-0x00000001841F4140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001841F4FC0-0x00000001841F50B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001841F4E30-0x00000001841F4E90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001841F4A90-0x00000001841F4B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001841F4F70-0x00000001841F4FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001841F4790-0x00000001841F4880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RoutineType { get => default; set {} } // 0x00000001841F49F0-0x00000001841F4A90 0x00000001841F4250-0x00000001841F42F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24886
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24887
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3505
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldRoutineTypeCloseNotify() {} // 0x00000001841F52E0-0x00000001841F5340
	static WorldRoutineTypeCloseNotify() {} // 0x00000001841F5220-0x00000001841F52E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldRoutineTypeCloseNotify Clone() => default; // 0x00000001841F4B80-0x00000001841F4C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldRoutineTypeCloseNotify ShallowCopy() => default; // 0x00000001841F46F0-0x00000001841F4790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001841F42F0-0x00000001841F4340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001841F4D90-0x00000001841F4DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001841F4DE0-0x00000001841F4E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001841F4340-0x00000001841F43B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001841F43B0-0x00000001841F4480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WorldRoutineTypeCloseNotify other) => default; // 0x00000001841F4480-0x00000001841F4580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001841F4880-0x00000001841F4960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001841F50B0-0x00000001841F5220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001841F4E90-0x00000001841F4F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001841F4580-0x00000001841F4670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WorldRoutineTypeCloseNotify other) {} // 0x00000001841F4140-0x00000001841F4250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001841F4000-0x00000001841F40E0
}

