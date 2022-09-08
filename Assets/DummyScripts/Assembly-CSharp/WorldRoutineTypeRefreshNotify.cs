/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WorldRoutineTypeRefreshNotify : MessageBase, IMessage<WorldRoutineTypeRefreshNotify> // TypeDefIndex: 24879
{
	// Fields
	private static readonly MessageParser<WorldRoutineTypeRefreshNotify> _parser; // 0x00
	public const int WorldRoutineTypeFieldNumber = 1; // Metadata: 0x00B076F7
	private WorldRoutineTypeInfo worldRoutineType_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WorldRoutineTypeRefreshNotify> Parser { get => default; } // 0x00000001827BA250-0x00000001827BA2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001827B9F40-0x00000001827B9FD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001827B9BE0-0x00000001827B9C60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001827B9550-0x00000001827B95B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001827BA6A0-0x00000001827BA790 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001827BA470-0x00000001827BA4D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001827B9FD0-0x00000001827BA0C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001827BA650-0x00000001827BA6A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001827B9D00-0x00000001827B9DF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldRoutineTypeInfo WorldRoutineType { get => default; set {} } // 0x00000001827BA5B0-0x00000001827BA650 0x00000001827BA1B0-0x00000001827BA250

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24880
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24881
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3503
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldRoutineTypeRefreshNotify() {} // 0x00000001827BA9A0-0x00000001827BAA00
	static WorldRoutineTypeRefreshNotify() {} // 0x00000001827BA8E0-0x00000001827BA9A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldRoutineTypeRefreshNotify Clone() => default; // 0x00000001827BA0C0-0x00000001827BA1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WorldRoutineTypeRefreshNotify ShallowCopy() => default; // 0x00000001827B9C60-0x00000001827B9D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001827B9710-0x00000001827B9790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001827BA370-0x00000001827BA3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001827BA3F0-0x00000001827BA470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001827B9790-0x00000001827B98B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001827B99C0-0x00000001827B9A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WorldRoutineTypeRefreshNotify other) => default; // 0x00000001827B98B0-0x00000001827B99C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001827B9DF0-0x00000001827B9F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001827BA790-0x00000001827BA8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001827BA4D0-0x00000001827BA5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001827B9A90-0x00000001827B9BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WorldRoutineTypeRefreshNotify other) {} // 0x00000001827B95B0-0x00000001827B9710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001827B9440-0x00000001827B9550
}

