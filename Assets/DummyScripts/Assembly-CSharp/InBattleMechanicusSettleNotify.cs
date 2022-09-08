/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class InBattleMechanicusSettleNotify : MessageBase, IMessage<InBattleMechanicusSettleNotify> // TypeDefIndex: 24154
{
	// Fields
	private static readonly MessageParser<InBattleMechanicusSettleNotify> _parser; // 0x00
	public const int PlayIndexFieldNumber = 1; // Metadata: 0x00B05B83
	private uint playIndex_; // 0x18
	public const int GroupIdFieldNumber = 2; // Metadata: 0x00B05B87
	private uint groupId_; // 0x1C
	public const int WatcherListFieldNumber = 3; // Metadata: 0x00B05B8B
	private static readonly FieldCodec<MultistageSettleWatcherInfo> _repeated_watcherList_codec; // 0x08
	private readonly RepeatedMessageField<MultistageSettleWatcherInfo> watcherList_; // 0x20
	public const int TotalTokenFieldNumber = 4; // Metadata: 0x00B05B8F
	private uint totalToken_; // 0x28
	public const int RealTokenFieldNumber = 5; // Metadata: 0x00B05B93
	private uint realToken_; // 0x2C
	public const int DifficultyPercentageFieldNumber = 6; // Metadata: 0x00B05B97
	private uint difficultyPercentage_; // 0x30
	public const int IsSuccessFieldNumber = 7; // Metadata: 0x00B05B9B
	private bool isSuccess_; // 0x34
	public const int SceneTimeMsFieldNumber = 8; // Metadata: 0x00B05B9F
	private ulong sceneTimeMs_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<InBattleMechanicusSettleNotify> Parser { get => default; } // 0x000000018346C830-0x000000018346C8C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018346C340-0x000000018346C3D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018346BF30-0x000000018346BFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018346B160-0x000000018346B1C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018346CFC0-0x000000018346D0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018346CC50-0x000000018346CCB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018346C5B0-0x000000018346C6A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018346CF70-0x000000018346CFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018346C050-0x000000018346C140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayIndex { get => default; set {} } // 0x000000018346BDF0-0x000000018346BE90 0x000000018346C510-0x000000018346C5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint GroupId { get => default; set {} } // 0x000000018346C6A0-0x000000018346C740 0x000000018346BE90-0x000000018346BF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<MultistageSettleWatcherInfo> WatcherList { get => default; } // 0x000000018346B260-0x000000018346B2C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TotalToken { get => default; set {} } // 0x000000018346B0C0-0x000000018346B160 0x000000018346C470-0x000000018346C510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RealToken { get => default; set {} } // 0x000000018346BD50-0x000000018346BDF0 0x000000018346C8C0-0x000000018346C960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint DifficultyPercentage { get => default; set {} } // 0x000000018346CB10-0x000000018346CBB0 0x000000018346B690-0x000000018346B730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsSuccess { get => default; set {} } // 0x000000018346CBB0-0x000000018346CC50 0x000000018346B1C0-0x000000018346B260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong SceneTimeMs { get => default; set {} } // 0x000000018346C3D0-0x000000018346C470 0x000000018346BCB0-0x000000018346BD50

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24155
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24156
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5316
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusSettleNotify() {} // 0x000000018346D6F0-0x000000018346D780
	static InBattleMechanicusSettleNotify() {} // 0x000000018346D5E0-0x000000018346D6F0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusSettleNotify Clone() => default; // 0x000000018346C740-0x000000018346C830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public InBattleMechanicusSettleNotify ShallowCopy() => default; // 0x000000018346BFB0-0x000000018346C050
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018346B510-0x000000018346B560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018346C9F0-0x000000018346CA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018346CA80-0x000000018346CB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018346B560-0x000000018346B690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018346B730-0x000000018346B800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(InBattleMechanicusSettleNotify other) => default; // 0x000000018346B800-0x000000018346B9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018346C140-0x000000018346C340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018346D0B0-0x000000018346D5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018346CCB0-0x000000018346CF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018346B9E0-0x000000018346BCB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(InBattleMechanicusSettleNotify other) {} // 0x000000018346B2C0-0x000000018346B510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018346AEB0-0x000000018346B0C0
}

