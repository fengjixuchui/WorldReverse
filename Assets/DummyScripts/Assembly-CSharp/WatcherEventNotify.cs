/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class WatcherEventNotify : MessageBase, IMessage<WatcherEventNotify> // TypeDefIndex: 25773
{
	// Fields
	private static readonly MessageParser<WatcherEventNotify> _parser; // 0x00
	public const int WatcherIdFieldNumber = 1; // Metadata: 0x00B098B3
	private uint watcherId_; // 0x18
	public const int AddProgressFieldNumber = 2; // Metadata: 0x00B098B7
	private uint addProgress_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<WatcherEventNotify> Parser { get => default; } // 0x0000000181B9A2D0-0x0000000181B9A360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181B99E80-0x0000000181B99F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181B99B70-0x0000000181B99BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181B99560-0x0000000181B995C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181B9A660-0x0000000181B9A750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181B9A490-0x0000000181B9A4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181B9A050-0x0000000181B9A140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181B9A610-0x0000000181B9A660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181B99C90-0x0000000181B99D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint WatcherId { get => default; set {} } // 0x0000000181B99FB0-0x0000000181B9A050 0x0000000181B99F10-0x0000000181B99FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AddProgress { get => default; set {} } // 0x0000000181B995C0-0x0000000181B99660 0x0000000181B9A140-0x0000000181B9A1E0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25774
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25775
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 2203
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WatcherEventNotify() {} // 0x0000000181B9AA10-0x0000000181B9AA70
	static WatcherEventNotify() {} // 0x0000000181B9A950-0x0000000181B9AA10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WatcherEventNotify Clone() => default; // 0x0000000181B9A1E0-0x0000000181B9A2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public WatcherEventNotify ShallowCopy() => default; // 0x0000000181B99BF0-0x0000000181B99C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181B99790-0x0000000181B997E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B9A3F0-0x0000000181B9A440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181B9A440-0x0000000181B9A490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181B997E0-0x0000000181B99850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181B99970-0x0000000181B99A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(WatcherEventNotify other) => default; // 0x0000000181B99850-0x0000000181B99970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181B99D80-0x0000000181B99E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181B9A750-0x0000000181B9A950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181B9A4F0-0x0000000181B9A610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181B99A40-0x0000000181B99B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(WatcherEventNotify other) {} // 0x0000000181B99660-0x0000000181B99790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181B99460-0x0000000181B99560
}

