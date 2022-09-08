/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneGalleryBalloonInfo : MessageBase, IMessage<SceneGalleryBalloonInfo> // TypeDefIndex: 23261
{
	// Fields
	private static readonly MessageParser<SceneGalleryBalloonInfo> _parser; // 0x00
	public const int ScenePlayerBalloonInfoMapFieldNumber = 1; // Metadata: 0x00B039F7
	private static readonly MapField<uint, BalloonPlayerInfo> _map_scenePlayerBalloonInfoMap_codec; // 0x08
	private readonly MapField<uint, BalloonPlayerInfo> scenePlayerBalloonInfoMap_; // 0x18
	public const int EndTimeFieldNumber = 2; // Metadata: 0x00B039FB
	private uint endTime_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneGalleryBalloonInfo> Parser { get => default; } // 0x0000000183019570-0x0000000183019600 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183019260-0x00000001830192F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183018F20-0x0000000183018FA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183018860-0x00000001830188C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001830199C0-0x0000000183019AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001830197D0-0x0000000183019830 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001830192F0-0x00000001830193E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183019970-0x00000001830199C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183019040-0x0000000183019130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, BalloonPlayerInfo> ScenePlayerBalloonInfoMap { get => default; } // 0x00000001830189F0-0x0000000183018A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EndTime { get => default; set {} } // 0x00000001830194D0-0x0000000183019570 0x0000000183019730-0x00000001830197D0

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryBalloonInfo() {} // 0x0000000183019DF0-0x0000000183019E80
	static SceneGalleryBalloonInfo() {} // 0x0000000183019C90-0x0000000183019DF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryBalloonInfo Clone() => default; // 0x00000001830193E0-0x00000001830194D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneGalleryBalloonInfo ShallowCopy() => default; // 0x0000000183018FA0-0x0000000183019040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183018A50-0x0000000183018AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183019690-0x00000001830196E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001830196E0-0x0000000183019730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183018AA0-0x0000000183018B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183018D10-0x0000000183018DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneGalleryBalloonInfo other) => default; // 0x0000000183018B70-0x0000000183018D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183019130-0x0000000183019260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183019AB0-0x0000000183019C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183019830-0x0000000183019970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183018DE0-0x0000000183018F20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneGalleryBalloonInfo other) {} // 0x00000001830188C0-0x00000001830189F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183018700-0x0000000183018860
}

