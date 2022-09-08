/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneEntityMoveNotify : MessageBase, IMessage<SceneEntityMoveNotify> // TypeDefIndex: 24928
{
	// Fields
	private static readonly MessageParser<SceneEntityMoveNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B0792F
	private uint entityId_; // 0x18
	public const int MotionInfoFieldNumber = 2; // Metadata: 0x00B07933
	private MotionInfo motionInfo_; // 0x20
	public const int SceneTimeFieldNumber = 3; // Metadata: 0x00B07937
	private uint sceneTime_; // 0x28
	public const int ReliableSeqFieldNumber = 4; // Metadata: 0x00B0793B
	private uint reliableSeq_; // 0x2C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneEntityMoveNotify> Parser { get => default; } // 0x0000000182D1CB10-0x0000000182D1CBA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182D1C800-0x0000000182D1C890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182D1C400-0x0000000182D1C480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182D1BAE0-0x0000000182D1BB40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182D1D2A0-0x0000000182D1D390 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182D1CFB0-0x0000000182D1D010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182D1C930-0x0000000182D1CA20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182D1D1B0-0x0000000182D1D200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182D1C520-0x0000000182D1C610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x0000000182D1CE70-0x0000000182D1CF10 0x0000000182D1D390-0x0000000182D1D430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MotionInfo MotionInfo { get => default; set {} } // 0x0000000182D1CF10-0x0000000182D1CFB0 0x0000000182D1CCD0-0x0000000182D1CD70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneTime { get => default; set {} } // 0x0000000182D1C890-0x0000000182D1C930 0x0000000182D1D200-0x0000000182D1D2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ReliableSeq { get => default; set {} } // 0x0000000182D1CC30-0x0000000182D1CCD0 0x0000000182D1BD20-0x0000000182D1BDC0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24929
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24930
		{
			None = 0,
			EnetChannelId = 1,
			EnetIsReliable = 1,
			CmdId = 212
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityMoveNotify() {} // 0x0000000182D1D7F0-0x0000000182D1D850
	static SceneEntityMoveNotify() {} // 0x0000000182D1D730-0x0000000182D1D7F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityMoveNotify Clone() => default; // 0x0000000182D1CA20-0x0000000182D1CB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneEntityMoveNotify ShallowCopy() => default; // 0x0000000182D1C480-0x0000000182D1C520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182D1BDC0-0x0000000182D1BE40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D1CD70-0x0000000182D1CDF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182D1CDF0-0x0000000182D1CE70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182D1BE40-0x0000000182D1BF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182D1BF90-0x0000000182D1C060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneEntityMoveNotify other) => default; // 0x0000000182D1C060-0x0000000182D1C1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182D1C610-0x0000000182D1C800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182D1D430-0x0000000182D1D730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182D1D010-0x0000000182D1D1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182D1C1D0-0x0000000182D1C400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneEntityMoveNotify other) {} // 0x0000000182D1BB40-0x0000000182D1BD20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182D1B970-0x0000000182D1BAE0
}

