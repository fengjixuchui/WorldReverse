/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HuntingStartNotify : MessageBase, IMessage<HuntingStartNotify> // TypeDefIndex: 23547
{
	// Fields
	private static readonly MessageParser<HuntingStartNotify> _parser; // 0x00
	public const int HuntingPairFieldNumber = 1; // Metadata: 0x00B0441F
	private HuntingPair huntingPair_; // 0x18
	public const int CluePositionFieldNumber = 2; // Metadata: 0x00B04423
	private Vector cluePosition_; // 0x20
	public const int FailTimeFieldNumber = 3; // Metadata: 0x00B04427
	private uint failTime_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HuntingStartNotify> Parser { get => default; } // 0x0000000182513860-0x00000001825138F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001825134B0-0x0000000182513540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182513080-0x0000000182513100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001825125E0-0x0000000182512640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182513D40-0x0000000182513E30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182513B40-0x0000000182513BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182513680-0x0000000182513770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182513CF0-0x0000000182513D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001825131A0-0x0000000182513290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingPair HuntingPair { get => default; set {} } // 0x0000000182512840-0x00000001825128E0 0x00000001825123B0-0x0000000182512450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public Vector CluePosition { get => default; set {} } // 0x0000000182513980-0x0000000182513A20 0x0000000182512B60-0x0000000182512C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FailTime { get => default; set {} } // 0x00000001825135E0-0x0000000182513680 0x0000000182513540-0x00000001825135E0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23548
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23549
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4307
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingStartNotify() {} // 0x0000000182514150-0x00000001825141B0
	static HuntingStartNotify() {} // 0x0000000182514090-0x0000000182514150

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingStartNotify Clone() => default; // 0x0000000182513770-0x0000000182513860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HuntingStartNotify ShallowCopy() => default; // 0x0000000182513100-0x00000001825131A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001825128E0-0x0000000182512970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182513A20-0x0000000182513AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182513AB0-0x0000000182513B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182512970-0x0000000182512B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182512C00-0x0000000182512CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HuntingStartNotify other) => default; // 0x0000000182512CD0-0x0000000182512E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182513290-0x00000001825134B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182513E30-0x0000000182514090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182513BA0-0x0000000182513CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182512E30-0x0000000182513080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HuntingStartNotify other) {} // 0x0000000182512640-0x0000000182512840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182512450-0x00000001825125E0
}

