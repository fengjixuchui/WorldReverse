/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneGalleryFallInfo : MessageBase, IMessage<SceneGalleryFallInfo> // TypeDefIndex: 23262
{
	// Fields
	private static readonly MessageParser<SceneGalleryFallInfo> _parser; // 0x00
	public const int ScenePlayerFallInfoMapFieldNumber = 1; // Metadata: 0x00B039FF
	private static readonly MapField<uint, FallPlayerInfo> _map_scenePlayerFallInfoMap_codec; // 0x08
	private readonly MapField<uint, FallPlayerInfo> scenePlayerFallInfoMap_; // 0x18
	public const int EndTimeFieldNumber = 2; // Metadata: 0x00B03A03
	private uint endTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneGalleryFallInfo> Parser { get => default; } // 0x00000001830261C0-0x0000000183026250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183025EB0-0x0000000183025F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183025B70-0x0000000183025BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001830254B0-0x0000000183025510 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183026610-0x0000000183026700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183026420-0x0000000183026480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183025F40-0x0000000183026030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001830265C0-0x0000000183026610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183025C90-0x0000000183025D80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, FallPlayerInfo> ScenePlayerFallInfoMap { get => default; } // 0x0000000183025B10-0x0000000183025B70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x0000000183026120-0x00000001830261C0 0x0000000183026380-0x0000000183026420

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryFallInfo() {} // 0x0000000183026A40-0x0000000183026AD0
	static SceneGalleryFallInfo() {} // 0x00000001830268E0-0x0000000183026A40

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryFallInfo Clone() => default; // 0x0000000183026030-0x0000000183026120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryFallInfo ShallowCopy() => default; // 0x0000000183025BF0-0x0000000183025C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183025640-0x0000000183025690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830262E0-0x0000000183026330
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183026330-0x0000000183026380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183025690-0x0000000183025760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183025900-0x00000001830259D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneGalleryFallInfo other) => default; // 0x0000000183025760-0x0000000183025900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183025D80-0x0000000183025EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183026700-0x00000001830268E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183026480-0x00000001830265C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001830259D0-0x0000000183025B10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneGalleryFallInfo other) {} // 0x0000000183025510-0x0000000183025640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183025350-0x00000001830254B0
}

