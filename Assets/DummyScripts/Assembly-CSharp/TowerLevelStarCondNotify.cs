/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerLevelStarCondNotify : MessageBase, IMessage<TowerLevelStarCondNotify> // TypeDefIndex: 25751
{
	// Fields
	private static readonly MessageParser<TowerLevelStarCondNotify> _parser; // 0x00
	public const int FloorIdFieldNumber = 1; // Metadata: 0x00B097F7
	private uint floorId_; // 0x18
	public const int LevelIndexFieldNumber = 2; // Metadata: 0x00B097FB
	private uint levelIndex_; // 0x1C
	public const int CondDataListFieldNumber = 3; // Metadata: 0x00B097FF
	private static readonly FieldCodec<TowerLevelStarCondData> _repeated_condDataList_codec; // 0x08
	private readonly RepeatedMessageField<TowerLevelStarCondData> condDataList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerLevelStarCondNotify> Parser { get => default; } // 0x0000000181E2D1D0-0x0000000181E2D260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181E2CF60-0x0000000181E2CFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181E2CC20-0x0000000181E2CCA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181E2C360-0x0000000181E2C3C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181E2D730-0x0000000181E2D820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181E2D510-0x0000000181E2D570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181E2CFF0-0x0000000181E2D0E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181E2D6E0-0x0000000181E2D730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181E2CD40-0x0000000181E2CE30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FloorId { get => default; set {} } // 0x0000000181E2D2F0-0x0000000181E2D390 0x0000000181E2C7D0-0x0000000181E2C870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LevelIndex { get => default; set {} } // 0x0000000181E2C3C0-0x0000000181E2C460 0x0000000181E2C730-0x0000000181E2C7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<TowerLevelStarCondData> CondDataList { get => default; } // 0x0000000181E2D4B0-0x0000000181E2D510 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25752
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25753
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2431
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerLevelStarCondNotify() {} // 0x0000000181E2DBA0-0x0000000181E2DC30
	static TowerLevelStarCondNotify() {} // 0x0000000181E2DA90-0x0000000181E2DBA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerLevelStarCondNotify Clone() => default; // 0x0000000181E2D0E0-0x0000000181E2D1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerLevelStarCondNotify ShallowCopy() => default; // 0x0000000181E2CCA0-0x0000000181E2CD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181E2C5F0-0x0000000181E2C640
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E2D390-0x0000000181E2D420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E2D420-0x0000000181E2D4B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181E2C640-0x0000000181E2C730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181E2C9C0-0x0000000181E2CA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerLevelStarCondNotify other) => default; // 0x0000000181E2C870-0x0000000181E2C9C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181E2CE30-0x0000000181E2CF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181E2D820-0x0000000181E2DA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181E2D570-0x0000000181E2D6E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181E2CA90-0x0000000181E2CC20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerLevelStarCondNotify other) {} // 0x0000000181E2C460-0x0000000181E2C5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181E2C1E0-0x0000000181E2C360
}

