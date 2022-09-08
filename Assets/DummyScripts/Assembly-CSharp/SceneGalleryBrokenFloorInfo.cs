/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneGalleryBrokenFloorInfo : MessageBase, IMessage<SceneGalleryBrokenFloorInfo> // TypeDefIndex: 23265
{
	// Fields
	private static readonly MessageParser<SceneGalleryBrokenFloorInfo> _parser; // 0x00
	public const int FallCountMapFieldNumber = 1; // Metadata: 0x00B03A1B
	private static readonly MapField<uint, uint> _map_fallCountMap_codec; // 0x08
	private readonly MapField<uint, uint> fallCountMap_; // 0x18
	public const int EndTimeFieldNumber = 2; // Metadata: 0x00B03A1F
	private uint endTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneGalleryBrokenFloorInfo> Parser { get => default; } // 0x0000000182A55A80-0x0000000182A55B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182A55770-0x0000000182A55800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182A55430-0x0000000182A554B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182A54D70-0x0000000182A54DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182A55ED0-0x0000000182A55FC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182A55CE0-0x0000000182A55D40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182A55800-0x0000000182A558F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182A55E80-0x0000000182A55ED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182A55550-0x0000000182A55640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> FallCountMap { get => default; } // 0x0000000182A55020-0x0000000182A55080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x0000000182A559E0-0x0000000182A55A80 0x0000000182A55C40-0x0000000182A55CE0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryBrokenFloorInfo() {} // 0x0000000182A562D0-0x0000000182A56360
	static SceneGalleryBrokenFloorInfo() {} // 0x0000000182A561A0-0x0000000182A562D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryBrokenFloorInfo Clone() => default; // 0x0000000182A558F0-0x0000000182A559E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryBrokenFloorInfo ShallowCopy() => default; // 0x0000000182A554B0-0x0000000182A55550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182A54F00-0x0000000182A54F50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A55BA0-0x0000000182A55BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182A55BF0-0x0000000182A55C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182A54F50-0x0000000182A55020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182A55220-0x0000000182A552F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneGalleryBrokenFloorInfo other) => default; // 0x0000000182A55080-0x0000000182A55220
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182A55640-0x0000000182A55770
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182A55FC0-0x0000000182A561A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182A55D40-0x0000000182A55E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182A552F0-0x0000000182A55430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneGalleryBrokenFloorInfo other) {} // 0x0000000182A54DD0-0x0000000182A54F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182A54C10-0x0000000182A54D70
}

