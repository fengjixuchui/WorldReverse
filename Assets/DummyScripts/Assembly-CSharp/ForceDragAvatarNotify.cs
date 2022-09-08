/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ForceDragAvatarNotify : MessageBase, IMessage<ForceDragAvatarNotify> // TypeDefIndex: 25337
{
	// Fields
	private static readonly MessageParser<ForceDragAvatarNotify> _parser; // 0x00
	public const int EntityIdFieldNumber = 1; // Metadata: 0x00B087C7
	private uint entityId_; // 0x18
	public const int MotionInfoFieldNumber = 2; // Metadata: 0x00B087CB
	private MotionInfo motionInfo_; // 0x20
	public const int SceneTimeFieldNumber = 3; // Metadata: 0x00B087CF
	private uint sceneTime_; // 0x28
	public const int LastMoveTimeMsFieldNumber = 4; // Metadata: 0x00B087D3
	private ulong lastMoveTimeMs_; // 0x30
	public const int DeltaTimeMsFieldNumber = 5; // Metadata: 0x00B087D7
	private ulong deltaTimeMs_; // 0x38
	public const int IsFirstValidFieldNumber = 6; // Metadata: 0x00B087DB
	private bool isFirstValid_; // 0x40

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ForceDragAvatarNotify> Parser { get => default; } // 0x000000018403F1A0-0x000000018403F230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018403ED50-0x000000018403EDE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018403E850-0x000000018403E8D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018403DDA0-0x000000018403DE00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018403F9B0-0x000000018403FAA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018403F640-0x000000018403F6A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018403EFC0-0x000000018403F0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018403F8C0-0x000000018403F910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018403EA10-0x000000018403EB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EntityId { get => default; set {} } // 0x000000018403F500-0x000000018403F5A0 0x000000018403FAA0-0x000000018403FB40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MotionInfo MotionInfo { get => default; set {} } // 0x000000018403F5A0-0x000000018403F640 0x000000018403F360-0x000000018403F400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneTime { get => default; set {} } // 0x000000018403EE80-0x000000018403EF20 0x000000018403F910-0x000000018403F9B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong LastMoveTimeMs { get => default; set {} } // 0x000000018403DE00-0x000000018403DEA0 0x000000018403EDE0-0x000000018403EE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong DeltaTimeMs { get => default; set {} } // 0x000000018403EF20-0x000000018403EFC0 0x000000018403F230-0x000000018403F2D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsFirstValid { get => default; set {} } // 0x000000018403E970-0x000000018403EA10 0x000000018403E150-0x000000018403E1F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25338
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25339
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3060
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForceDragAvatarNotify() {} // 0x0000000184040020-0x0000000184040080
	static ForceDragAvatarNotify() {} // 0x000000018403FF60-0x0000000184040020

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForceDragAvatarNotify Clone() => default; // 0x000000018403F0B0-0x000000018403F1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ForceDragAvatarNotify ShallowCopy() => default; // 0x000000018403E8D0-0x000000018403E970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018403E0D0-0x000000018403E150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018403F400-0x000000018403F480
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018403F480-0x000000018403F500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018403E1F0-0x000000018403E350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018403E350-0x000000018403E420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ForceDragAvatarNotify other) => default; // 0x000000018403E420-0x000000018403E5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018403EB00-0x000000018403ED50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018403FB40-0x000000018403FF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018403F6A0-0x000000018403F8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018403E5D0-0x000000018403E850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ForceDragAvatarNotify other) {} // 0x000000018403DEA0-0x000000018403E0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018403DBF0-0x000000018403DDA0
}

