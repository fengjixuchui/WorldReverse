/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairMinigameInfo : MessageBase, IMessage<FleurFairMinigameInfo> // TypeDefIndex: 22210
{
	// Fields
	private static readonly MessageParser<FleurFairMinigameInfo> _parser; // 0x00
	public const int MinigameIdFieldNumber = 1; // Metadata: 0x00B010B3
	private uint minigameId_; // 0x18
	public const int OpenTimeFieldNumber = 2; // Metadata: 0x00B010B7
	private uint openTime_; // 0x1C
	public const int IsOpenFieldNumber = 3; // Metadata: 0x00B010BB
	private bool isOpen_; // 0x20
	public const int BalloonInfoFieldNumber = 11; // Metadata: 0x00B010BF
	public const int FallInfoFieldNumber = 12; // Metadata: 0x00B010C3
	public const int MusicInfoFieldNumber = 13; // Metadata: 0x00B010C7
	private object detail_; // 0x28
	private DetailOneofCase detailCase_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FleurFairMinigameInfo> Parser { get => default; } // 0x00000001831E8DD0-0x00000001831E8E60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001831E88B0-0x00000001831E8940 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001831E8430-0x00000001831E84B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001831E7480-0x00000001831E74E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001831E9670-0x00000001831E9760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001831E9310-0x00000001831E9370 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001831E8B50-0x00000001831E8C40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001831E9620-0x00000001831E9670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001831E85F0-0x00000001831E86E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MinigameId { get => default; set {} } // 0x00000001831E8940-0x00000001831E89E0 0x00000001831E8D30-0x00000001831E8DD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint OpenTime { get => default; set {} } // 0x00000001831E7F70-0x00000001831E8010 0x00000001831E9270-0x00000001831E9310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsOpen { get => default; set {} } // 0x00000001831E9370-0x00000001831E9410 0x00000001831E7540-0x00000001831E75E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairBalloonInfo BalloonInfo { get => default; set {} } // 0x00000001831E8010-0x00000001831E80E0 0x00000001831E89E0-0x00000001831E8A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairFallInfo FallInfo { get => default; set {} } // 0x00000001831E8A80-0x00000001831E8B50 0x00000001831E8EF0-0x00000001831E8F90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairMusicGameInfo MusicInfo { get => default; set {} } // 0x00000001831E8360-0x00000001831E8430 0x00000001831E84B0-0x00000001831E8550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DetailOneofCase DetailCase { get => default; } // 0x00000001831E79B0-0x00000001831E7A10 

	// Nested types
	public enum DetailOneofCase // TypeDefIndex: 22211
	{
		None = 0,
		BalloonInfo = 11,
		FallInfo = 12,
		MusicInfo = 13
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairMinigameInfo() {} // 0x00000001831E9CB0-0x00000001831E9D20
	static FleurFairMinigameInfo() {} // 0x00000001831E9BF0-0x00000001831E9CB0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairMinigameInfo Clone() => default; // 0x00000001831E8C40-0x00000001831E8D30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairMinigameInfo ShallowCopy() => default; // 0x00000001831E8550-0x00000001831E85F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001831E7830-0x00000001831E79B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831E8F90-0x00000001831E9100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001831E9100-0x00000001831E9270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001831E7A10-0x00000001831E7AA0
	public void resetDetail() {} // 0x00000001831E80E0-0x00000001831E8360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void ClearDetail() {} // 0x00000001831E74E0-0x00000001831E7540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001831E7AA0-0x00000001831E7B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FleurFairMinigameInfo other) => default; // 0x00000001831E7B70-0x00000001831E7D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001831E86E0-0x00000001831E88B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001831E9760-0x00000001831E9BF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001831E9410-0x00000001831E9620
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001831E7D60-0x00000001831E7F70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FleurFairMinigameInfo other) {} // 0x00000001831E75E0-0x00000001831E7830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001831E71C0-0x00000001831E7480
}

