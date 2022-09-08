/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EvtAvatarStandUpNotify : MessageBase, IMessage<EvtAvatarStandUpNotify> // TypeDefIndex: 23101
{
	// Fields
	private static readonly MessageParser<EvtAvatarStandUpNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B03327
	private uint entityId_; // 0x18
	public const int DirectionFieldNumber = 2; // Metadata: 0x00B0332B
	private int direction_; // 0x1C
	public const int PerformIDFieldNumber = 3; // Metadata: 0x00B0332F
	private int performID_; // 0x20
	public const int ChairIdFieldNumber = 4; // Metadata: 0x00B03333
	private ulong chairId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EvtAvatarStandUpNotify> Parser { get => default; } // 0x0000000183CD6450-0x0000000183CD64E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183CD6140-0x0000000183CD61D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183CD5DD0-0x0000000183CD5E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183CD5520-0x0000000183CD5580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183CD69A0-0x0000000183CD6A90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183CD66B0-0x0000000183CD6710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183CD61D0-0x0000000183CD62C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183CD6950-0x0000000183CD69A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183CD5EF0-0x0000000183CD5FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000183CD6610-0x0000000183CD66B0 0x0000000183CD6A90-0x0000000183CD6B30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Direction { get => default; set {} } // 0x0000000183CD5850-0x0000000183CD58F0 0x0000000183CD5620-0x0000000183CD56C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int PerformID { get => default; set {} } // 0x0000000183CD5480-0x0000000183CD5520 0x0000000183CD6710-0x0000000183CD67B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong ChairId { get => default; set {} } // 0x0000000183CD63B0-0x0000000183CD6450 0x0000000183CD5580-0x0000000183CD5620

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23102
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23103
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 342
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAvatarStandUpNotify() {} // 0x0000000183CD6F10-0x0000000183CD6F70
	static EvtAvatarStandUpNotify() {} // 0x0000000183CD6E50-0x0000000183CD6F10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAvatarStandUpNotify Clone() => default; // 0x0000000183CD62C0-0x0000000183CD63B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EvtAvatarStandUpNotify ShallowCopy() => default; // 0x0000000183CD5E50-0x0000000183CD5EF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183CD58F0-0x0000000183CD5940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183CD6570-0x0000000183CD65C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183CD65C0-0x0000000183CD6610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183CD5940-0x0000000183CD59D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183CD59D0-0x0000000183CD5AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EvtAvatarStandUpNotify other) => default; // 0x0000000183CD5AA0-0x0000000183CD5C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183CD5FE0-0x0000000183CD6140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183CD6B30-0x0000000183CD6E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183CD67B0-0x0000000183CD6950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183CD5C00-0x0000000183CD5DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EvtAvatarStandUpNotify other) {} // 0x0000000183CD56C0-0x0000000183CD5850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183CD5350-0x0000000183CD5480
}

