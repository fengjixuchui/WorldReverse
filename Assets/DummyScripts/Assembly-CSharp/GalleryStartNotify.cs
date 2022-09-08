/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GalleryStartNotify : MessageBase, IMessage<GalleryStartNotify> // TypeDefIndex: 23237
{
	// Fields
	private static readonly MessageParser<GalleryStartNotify> _parser; // 0x00
	public const int GalleryIdFieldNumber = 1; // Metadata: 0x00B038E3
	private uint galleryId_; // 0x18
	public const int EndTimeFieldNumber = 2; // Metadata: 0x00B038E7
	private uint endTime_; // 0x1C
	public const int FlowerStartParamFieldNumber = 11; // Metadata: 0x00B038EB
	private object detail_; // 0x20
	private DetailOneofCase detailCase_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GalleryStartNotify> Parser { get => default; } // 0x0000000184A4A2F0-0x0000000184A4A380 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184A49F40-0x0000000184A49FD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184A49BF0-0x0000000184A49C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184A490E0-0x0000000184A49140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184A4A840-0x0000000184A4A930 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184A4A630-0x0000000184A4A690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184A49FD0-0x0000000184A4A0C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184A4A7F0-0x0000000184A4A840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184A49D10-0x0000000184A49E00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GalleryId { get => default; set {} } // 0x0000000184A49140-0x0000000184A491E0 0x0000000184A49240-0x0000000184A492E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x0000000184A4A1B0-0x0000000184A4A250 0x0000000184A4A590-0x0000000184A4A630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryFlowerStartParam FlowerStartParam { get => default; set {} } // 0x0000000184A49A00-0x0000000184A49AD0 0x0000000184A4A250-0x0000000184A4A2F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DetailOneofCase DetailCase { get => default; } // 0x0000000184A49560-0x0000000184A495C0 

	// Nested types
	public enum DetailOneofCase // TypeDefIndex: 23238
	{
		None = 0,
		FlowerStartParam = 11
	}

	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23239
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23240
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5501
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryStartNotify() {} // 0x0000000184A4ACB0-0x0000000184A4AD20
	static GalleryStartNotify() {} // 0x0000000184A4ABF0-0x0000000184A4ACB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryStartNotify Clone() => default; // 0x0000000184A4A0C0-0x0000000184A4A1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryStartNotify ShallowCopy() => default; // 0x0000000184A49C70-0x0000000184A49D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184A494A0-0x0000000184A49560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A4A410-0x0000000184A4A4D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A4A4D0-0x0000000184A4A590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184A495C0-0x0000000184A49640
	public void resetDetail() {} // 0x0000000184A49AD0-0x0000000184A49BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearDetail() {} // 0x0000000184A491E0-0x0000000184A49240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184A497B0-0x0000000184A49880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GalleryStartNotify other) => default; // 0x0000000184A49640-0x0000000184A497B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184A49E00-0x0000000184A49F40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184A4A930-0x0000000184A4ABF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184A4A690-0x0000000184A4A7F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184A49880-0x0000000184A49A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GalleryStartNotify other) {} // 0x0000000184A492E0-0x0000000184A494A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184A48F40-0x0000000184A490E0
}

