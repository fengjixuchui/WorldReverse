/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneGalleryBulletInfo : MessageBase, IMessage<SceneGalleryBulletInfo> // TypeDefIndex: 23264
{
	// Fields
	private static readonly MessageParser<SceneGalleryBulletInfo> _parser; // 0x00
	public const int HitCountMapFieldNumber = 1; // Metadata: 0x00B03A13
	private static readonly MapField<uint, uint> _map_hitCountMap_codec; // 0x08
	private readonly MapField<uint, uint> hitCountMap_; // 0x18
	public const int EndTimeFieldNumber = 2; // Metadata: 0x00B03A17
	private uint endTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneGalleryBulletInfo> Parser { get => default; } // 0x0000000184B1BA20-0x0000000184B1BAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184B1B710-0x0000000184B1B7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184B1B3D0-0x0000000184B1B450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184B1AD10-0x0000000184B1AD70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184B1BE70-0x0000000184B1BF60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184B1BC80-0x0000000184B1BCE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184B1B7A0-0x0000000184B1B890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184B1BE20-0x0000000184B1BE70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184B1B4F0-0x0000000184B1B5E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, uint> HitCountMap { get => default; } // 0x0000000184B1AEA0-0x0000000184B1AF00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x0000000184B1B980-0x0000000184B1BA20 0x0000000184B1BBE0-0x0000000184B1BC80

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryBulletInfo() {} // 0x0000000184B1C270-0x0000000184B1C300
	static SceneGalleryBulletInfo() {} // 0x0000000184B1C140-0x0000000184B1C270

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryBulletInfo Clone() => default; // 0x0000000184B1B890-0x0000000184B1B980
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryBulletInfo ShallowCopy() => default; // 0x0000000184B1B450-0x0000000184B1B4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184B1AF00-0x0000000184B1AF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B1BB40-0x0000000184B1BB90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B1BB90-0x0000000184B1BBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184B1AF50-0x0000000184B1B020
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184B1B020-0x0000000184B1B0F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneGalleryBulletInfo other) => default; // 0x0000000184B1B0F0-0x0000000184B1B290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184B1B5E0-0x0000000184B1B710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184B1BF60-0x0000000184B1C140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184B1BCE0-0x0000000184B1BE20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184B1B290-0x0000000184B1B3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneGalleryBulletInfo other) {} // 0x0000000184B1AD70-0x0000000184B1AEA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184B1ABB0-0x0000000184B1AD10
}

