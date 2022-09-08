/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class TowerLevelEndNotify : MessageBase, IMessage<TowerLevelEndNotify> // TypeDefIndex: 25746
{
	// Fields
	private static readonly MessageParser<TowerLevelEndNotify> _parser; // 0x00
	public const int IsSuccessFieldNumber = 1; // Metadata: 0x00B097BB
	private bool isSuccess_; // 0x18
	public const int FinishedStarCondListFieldNumber = 2; // Metadata: 0x00B097BF
	private static readonly FieldCodec<uint> _repeated_finishedStarCondList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> finishedStarCondList_; // 0x20
	public const int RewardItemListFieldNumber = 3; // Metadata: 0x00B097C3
	private static readonly FieldCodec<ItemParam> _repeated_rewardItemList_codec; // 0x10
	private readonly RepeatedMessageField<ItemParam> rewardItemList_; // 0x28
	public const int ContinueStateFieldNumber = 4; // Metadata: 0x00B097C7
	private uint continueState_; // 0x30
	public const int NextFloorIdFieldNumber = 5; // Metadata: 0x00B097CB
	private uint nextFloorId_; // 0x34

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<TowerLevelEndNotify> Parser { get => default; } // 0x0000000182B53E10-0x0000000182B53EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182B53B00-0x0000000182B53B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182B53770-0x0000000182B537F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182B52D40-0x0000000182B52DA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182B54440-0x0000000182B54530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182B54190-0x0000000182B541F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182B53C30-0x0000000182B53D20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182B543F0-0x0000000182B54440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182B53890-0x0000000182B53980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSuccess { get => default; set {} } // 0x0000000182B540F0-0x0000000182B54190 0x0000000182B52DA0-0x0000000182B52E40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> FinishedStarCondList { get => default; } // 0x0000000182B52E40-0x0000000182B52EA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ItemParam> RewardItemList { get => default; } // 0x0000000182B53490-0x0000000182B534F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ContinueState { get => default; set {} } // 0x0000000182B53EA0-0x0000000182B53F40 0x0000000182B52CA0-0x0000000182B52D40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint NextFloorId { get => default; set {} } // 0x0000000182B53B90-0x0000000182B53C30 0x0000000182B536D0-0x0000000182B53770

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25747
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25748
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2430
		}

		public enum ContinueStateType // TypeDefIndex: 25749
		{
			ContinueStateCanNotContinue = 0,
			ContinueStateCanEnterNextLevel = 1,
			ContinueStateCanEnterNextFloor = 2
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerLevelEndNotify() {} // 0x0000000182B549D0-0x0000000182B54A80
	static TowerLevelEndNotify() {} // 0x0000000182B548A0-0x0000000182B549D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerLevelEndNotify Clone() => default; // 0x0000000182B53D20-0x0000000182B53E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TowerLevelEndNotify ShallowCopy() => default; // 0x0000000182B537F0-0x0000000182B53890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182B53080-0x0000000182B530D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182B53FD0-0x0000000182B54060
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182B54060-0x0000000182B540F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182B530D0-0x0000000182B53230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182B533C0-0x0000000182B53490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(TowerLevelEndNotify other) => default; // 0x0000000182B53230-0x0000000182B533C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182B53980-0x0000000182B53B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182B54530-0x0000000182B548A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182B541F0-0x0000000182B543F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182B534F0-0x0000000182B536D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(TowerLevelEndNotify other) {} // 0x0000000182B52EA0-0x0000000182B53080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182B52A90-0x0000000182B52CA0
}

