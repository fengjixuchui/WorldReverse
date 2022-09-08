/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GalleryPreStartNotify : MessageBase, IMessage<GalleryPreStartNotify> // TypeDefIndex: 23278
{
	// Fields
	private static readonly MessageParser<GalleryPreStartNotify> _parser; // 0x00
	public const int GalleryIdFieldNumber = 1; // Metadata: 0x00B03AB7
	private uint galleryId_; // 0x18
	public const int PreStartEndTimeFieldNumber = 2; // Metadata: 0x00B03ABB
	private uint preStartEndTime_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GalleryPreStartNotify> Parser { get => default; } // 0x00000001814DA930-0x00000001814DA9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001814DA620-0x00000001814DA6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001814DA270-0x00000001814DA2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001814D9BC0-0x00000001814D9C20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001814DACC0-0x00000001814DADB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001814DAAF0-0x00000001814DAB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001814DA6B0-0x00000001814DA7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001814DAC70-0x00000001814DACC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001814DA430-0x00000001814DA520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GalleryId { get => default; set {} } // 0x00000001814D9C20-0x00000001814D9CC0 0x00000001814D9CC0-0x00000001814D9D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PreStartEndTime { get => default; set {} } // 0x00000001814DA890-0x00000001814DA930 0x00000001814DA2F0-0x00000001814DA390

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23279
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23280
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5510
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryPreStartNotify() {} // 0x00000001814DB070-0x00000001814DB0D0
	static GalleryPreStartNotify() {} // 0x00000001814DAFB0-0x00000001814DB070

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryPreStartNotify Clone() => default; // 0x00000001814DA7A0-0x00000001814DA890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryPreStartNotify ShallowCopy() => default; // 0x00000001814DA390-0x00000001814DA430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001814D9E90-0x00000001814D9EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001814DAA50-0x00000001814DAAA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001814DAAA0-0x00000001814DAAF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001814D9EE0-0x00000001814D9F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001814DA070-0x00000001814DA140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GalleryPreStartNotify other) => default; // 0x00000001814D9F50-0x00000001814DA070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001814DA520-0x00000001814DA620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001814DADB0-0x00000001814DAFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001814DAB50-0x00000001814DAC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001814DA140-0x00000001814DA270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GalleryPreStartNotify other) {} // 0x00000001814D9D60-0x00000001814D9E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001814D9AC0-0x00000001814D9BC0
}

