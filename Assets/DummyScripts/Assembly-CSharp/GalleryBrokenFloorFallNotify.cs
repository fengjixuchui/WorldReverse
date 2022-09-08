/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GalleryBrokenFloorFallNotify : MessageBase, IMessage<GalleryBrokenFloorFallNotify> // TypeDefIndex: 23284
{
	// Fields
	private static readonly MessageParser<GalleryBrokenFloorFallNotify> _parser; // 0x00
	public const int GalleryIdFieldNumber = 1; // Metadata: 0x00B03AE7
	private uint galleryId_; // 0x18
	public const int FallCountFieldNumber = 2; // Metadata: 0x00B03AEB
	private uint fallCount_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GalleryBrokenFloorFallNotify> Parser { get => default; } // 0x00000001828DCA00-0x00000001828DCA90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001828DC6F0-0x00000001828DC780 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001828DC3E0-0x00000001828DC460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001828DBC90-0x00000001828DBCF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001828DCD90-0x00000001828DCE80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001828DCBC0-0x00000001828DCC20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001828DC780-0x00000001828DC870 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001828DCD40-0x00000001828DCD90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001828DC500-0x00000001828DC5F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GalleryId { get => default; set {} } // 0x00000001828DBCF0-0x00000001828DBD90 0x00000001828DBD90-0x00000001828DBE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FallCount { get => default; set {} } // 0x00000001828DC960-0x00000001828DCA00 0x00000001828DC020-0x00000001828DC0C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23285
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23286
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5512
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryBrokenFloorFallNotify() {} // 0x00000001828DD140-0x00000001828DD1A0
	static GalleryBrokenFloorFallNotify() {} // 0x00000001828DD080-0x00000001828DD140

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryBrokenFloorFallNotify Clone() => default; // 0x00000001828DC870-0x00000001828DC960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryBrokenFloorFallNotify ShallowCopy() => default; // 0x00000001828DC460-0x00000001828DC500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001828DBF60-0x00000001828DBFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001828DCB20-0x00000001828DCB70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001828DCB70-0x00000001828DCBC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001828DBFB0-0x00000001828DC020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001828DC0C0-0x00000001828DC190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GalleryBrokenFloorFallNotify other) => default; // 0x00000001828DC190-0x00000001828DC2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001828DC5F0-0x00000001828DC6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001828DCE80-0x00000001828DD080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001828DCC20-0x00000001828DCD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001828DC2B0-0x00000001828DC3E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GalleryBrokenFloorFallNotify other) {} // 0x00000001828DBE30-0x00000001828DBF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001828DBB90-0x00000001828DBC90
}

