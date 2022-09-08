/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BargainStartNotify : MessageBase, IMessage<BargainStartNotify> // TypeDefIndex: 24630
{
	// Fields
	private static readonly MessageParser<BargainStartNotify> _parser; // 0x00
	public const int BargainIdFieldNumber = 1; // Metadata: 0x00B06E17
	private uint bargainId_; // 0x18
	public const int SnapshotFieldNumber = 2; // Metadata: 0x00B06E1B
	private BargainSnapshot snapshot_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<BargainStartNotify> Parser { get => default; } // 0x00000001844EF980-0x00000001844EFA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001844EF670-0x00000001844EF700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001844EF2E0-0x00000001844EF360 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001844EEA70-0x00000001844EEAD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001844EFD70-0x00000001844EFE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001844EFBA0-0x00000001844EFC00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001844EF700-0x00000001844EF7F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001844EFD20-0x00000001844EFD70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001844EF400-0x00000001844EF4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint BargainId { get => default; set {} } // 0x00000001844EFE60-0x00000001844EFF00 0x00000001844EEE00-0x00000001844EEEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BargainSnapshot Snapshot { get => default; set {} } // 0x00000001844EEEA0-0x00000001844EEF40 0x00000001844EF8E0-0x00000001844EF980

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24631
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24632
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 423
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BargainStartNotify() {} // 0x00000001844F01A0-0x00000001844F0200
	static BargainStartNotify() {} // 0x00000001844F00E0-0x00000001844F01A0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BargainStartNotify Clone() => default; // 0x00000001844EF7F0-0x00000001844EF8E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public BargainStartNotify ShallowCopy() => default; // 0x00000001844EF360-0x00000001844EF400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001844EEC50-0x00000001844EECD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001844EFAA0-0x00000001844EFB20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001844EFB20-0x00000001844EFBA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001844EECD0-0x00000001844EEE00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001844EEF40-0x00000001844EF010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(BargainStartNotify other) => default; // 0x00000001844EF010-0x00000001844EF140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001844EF4F0-0x00000001844EF670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001844EFF00-0x00000001844F00E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001844EFC00-0x00000001844EFD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001844EF140-0x00000001844EF2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(BargainStartNotify other) {} // 0x00000001844EEAD0-0x00000001844EEC50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001844EE930-0x00000001844EEA70
}

