/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeSnapshotNotify : MessageBase, IMessage<HomeSnapshotNotify> // TypeDefIndex: 23411
{
	// Fields
	private static readonly MessageParser<HomeSnapshotNotify> _parser; // 0x00
	public const int SnapshotFieldNumber = 1; // Metadata: 0x00B03F87
	private HomeSnapshot snapshot_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeSnapshotNotify> Parser { get => default; } // 0x0000000181BC4860-0x0000000181BC48F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181BC4550-0x0000000181BC45E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181BC41F0-0x0000000181BC4270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181BC3AC0-0x0000000181BC3B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181BC4C10-0x0000000181BC4D00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181BC4A80-0x0000000181BC4AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181BC45E0-0x0000000181BC46D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181BC4BC0-0x0000000181BC4C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181BC4310-0x0000000181BC4400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeSnapshot Snapshot { get => default; set {} } // 0x0000000181BC3E20-0x0000000181BC3EC0 0x0000000181BC47C0-0x0000000181BC4860

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23412
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23413
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4490
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeSnapshotNotify() {} // 0x0000000181BC4F10-0x0000000181BC4F70
	static HomeSnapshotNotify() {} // 0x0000000181BC4E50-0x0000000181BC4F10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeSnapshotNotify Clone() => default; // 0x0000000181BC46D0-0x0000000181BC47C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeSnapshotNotify ShallowCopy() => default; // 0x0000000181BC4270-0x0000000181BC4310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181BC3C80-0x0000000181BC3D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181BC4980-0x0000000181BC4A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181BC4A00-0x0000000181BC4A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181BC3D00-0x0000000181BC3E20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181BC3EC0-0x0000000181BC3F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeSnapshotNotify other) => default; // 0x0000000181BC3F90-0x0000000181BC40A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181BC4400-0x0000000181BC4550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181BC4D00-0x0000000181BC4E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181BC4AE0-0x0000000181BC4BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181BC40A0-0x0000000181BC41F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeSnapshotNotify other) {} // 0x0000000181BC3B20-0x0000000181BC3C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181BC39B0-0x0000000181BC3AC0
}

