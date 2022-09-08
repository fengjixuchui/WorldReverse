/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneGalleryFlowerInfo : MessageBase, IMessage<SceneGalleryFlowerInfo> // TypeDefIndex: 23263
{
	// Fields
	private static readonly MessageParser<SceneGalleryFlowerInfo> _parser; // 0x00
	public const int CurScoreFieldNumber = 1; // Metadata: 0x00B03A07
	private uint curScore_; // 0x18
	public const int TargetScoreFieldNumber = 2; // Metadata: 0x00B03A0B
	private uint targetScore_; // 0x1C
	public const int EndTimeFieldNumber = 3; // Metadata: 0x00B03A0F
	private uint endTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneGalleryFlowerInfo> Parser { get => default; } // 0x0000000182783780-0x0000000182783810 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001827833D0-0x0000000182783460 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182782FF0-0x0000000182783070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001827829D0-0x0000000182782A30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182783D30-0x0000000182783E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182783A80-0x0000000182783AE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182783500-0x00000001827835F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182783C40-0x0000000182783C90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001827831B0-0x00000001827832A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurScore { get => default; set {} } // 0x0000000182783C90-0x0000000182783D30 0x0000000182783110-0x00000001827831B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetScore { get => default; set {} } // 0x0000000182783940-0x00000001827839E0 0x0000000182783460-0x0000000182783500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x00000001827836E0-0x0000000182783780 0x00000001827839E0-0x0000000182783A80

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryFlowerInfo() {} // 0x0000000182784170-0x00000001827841D0
	static SceneGalleryFlowerInfo() {} // 0x00000001827840B0-0x0000000182784170

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryFlowerInfo Clone() => default; // 0x00000001827835F0-0x00000001827836E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryFlowerInfo ShallowCopy() => default; // 0x0000000182783070-0x0000000182783110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182782B90-0x0000000182782BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001827838A0-0x00000001827838F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001827838F0-0x0000000182783940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182782BE0-0x0000000182782C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182782C60-0x0000000182782D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneGalleryFlowerInfo other) => default; // 0x0000000182782D30-0x0000000182782E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001827832A0-0x00000001827833D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182783E20-0x00000001827840B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182783AE0-0x0000000182783C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182782E70-0x0000000182782FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneGalleryFlowerInfo other) {} // 0x0000000182782A30-0x0000000182782B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001827828C0-0x00000001827829D0
}

