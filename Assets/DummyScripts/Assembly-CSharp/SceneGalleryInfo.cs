/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneGalleryInfo : MessageBase, IMessage<SceneGalleryInfo> // TypeDefIndex: 23267
{
	// Fields
	private static readonly MessageParser<SceneGalleryInfo> _parser; // 0x00
	public const int GalleryIdFieldNumber = 1; // Metadata: 0x00B03A2B
	private uint galleryId_; // 0x18
	public const int EndTimeFieldNumber = 2; // Metadata: 0x00B03A2F
	private uint endTime_; // 0x1C
	public const int BalloonInfoFieldNumber = 10; // Metadata: 0x00B03A33
	public const int FallInfoFieldNumber = 11; // Metadata: 0x00B03A37
	public const int FlowerInfoFieldNumber = 12; // Metadata: 0x00B03A3B
	public const int BulletInfoFieldNumber = 13; // Metadata: 0x00B03A3F
	public const int BrokenFloorInfoFieldNumber = 14; // Metadata: 0x00B03A43
	public const int HideAndSeekInfoFieldNumber = 15; // Metadata: 0x00B03A47
	public const int StageFieldNumber = 3; // Metadata: 0x00B03A4B
	private GalleryStageType stage_; // 0x20
	public const int PreStartEndTimeFieldNumber = 4; // Metadata: 0x00B03A4F
	private uint preStartEndTime_; // 0x24
	private object info_; // 0x28
	private InfoOneofCase infoCase_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneGalleryInfo> Parser { get => default; } // 0x0000000185511FA0-0x0000000185512030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185511810-0x00000001855118A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185511280-0x0000000185511300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018550FB10-0x000000018550FB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000185512CB0-0x0000000185512DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001855127A0-0x0000000185512800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185511AB0-0x0000000185511BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185512C60-0x0000000185512CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185511440-0x0000000185511530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GalleryId { get => default; set {} } // 0x000000018550FB70-0x000000018550FC10 0x000000018550FD50-0x000000018550FDF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x0000000185511C90-0x0000000185511D30 0x0000000185512700-0x00000001855127A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryBalloonInfo BalloonInfo { get => default; set {} } // 0x00000001855110E0-0x00000001855111B0 0x0000000185511940-0x00000001855119E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryFallInfo FallInfo { get => default; set {} } // 0x00000001855119E0-0x0000000185511AB0 0x00000001855120C0-0x0000000185512160
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryFlowerInfo FlowerInfo { get => default; set {} } // 0x00000001855128A0-0x0000000185512970 0x000000018550FC10-0x000000018550FCB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryBulletInfo BulletInfo { get => default; set {} } // 0x0000000185511ED0-0x0000000185511FA0 0x00000001855123E0-0x0000000185512480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryBrokenFloorInfo BrokenFloorInfo { get => default; set {} } // 0x0000000185510120-0x00000001855101F0 0x000000018550FCB0-0x000000018550FD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryHideAndSeekInfo HideAndSeekInfo { get => default; set {} } // 0x00000001855111B0-0x0000000185511280 0x0000000185511DD0-0x0000000185511E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GalleryStageType Stage { get => default; set {} } // 0x0000000185512800-0x00000001855128A0 0x00000001855118A0-0x0000000185511940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PreStartEndTime { get => default; set {} } // 0x0000000185511D30-0x0000000185511DD0 0x0000000185511300-0x00000001855113A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InfoOneofCase InfoCase { get => default; } // 0x0000000185511E70-0x0000000185511ED0 

	// Nested types
	public enum InfoOneofCase // TypeDefIndex: 23268
	{
		None = 0,
		BalloonInfo = 10,
		FallInfo = 11,
		FlowerInfo = 12,
		BulletInfo = 13,
		BrokenFloorInfo = 14,
		HideAndSeekInfo = 15
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryInfo() {} // 0x0000000185513560-0x00000001855135D0
	static SceneGalleryInfo() {} // 0x00000001855134A0-0x0000000185513560

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryInfo Clone() => default; // 0x0000000185511BA0-0x0000000185511C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryInfo ShallowCopy() => default; // 0x00000001855113A0-0x0000000185511440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001855101F0-0x0000000185510480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185512160-0x00000001855123E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185512480-0x0000000185512700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185510480-0x0000000185510520
	public void resetInfo() {} // 0x0000000185510580-0x0000000185510A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearInfo() {} // 0x0000000185510520-0x0000000185510580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000185510A20-0x0000000185510AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneGalleryInfo other) => default; // 0x0000000185510AF0-0x0000000185510D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185511530-0x0000000185511810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000185512DA0-0x00000001855134A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000185512970-0x0000000185512C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185510D80-0x00000001855110E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneGalleryInfo other) {} // 0x000000018550FDF0-0x0000000185510120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018550F6B0-0x000000018550FB10
}

