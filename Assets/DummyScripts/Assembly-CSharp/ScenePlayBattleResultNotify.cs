/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScenePlayBattleResultNotify : MessageBase, IMessage<ScenePlayBattleResultNotify> // TypeDefIndex: 25404
{
	// Fields
	private static readonly MessageParser<ScenePlayBattleResultNotify> _parser; // 0x00
	public const int PlayIdFieldNumber = 1; // Metadata: 0x00B08A97
	private uint playId_; // 0x18
	public const int PlayTypeFieldNumber = 2; // Metadata: 0x00B08A9B
	private uint playType_; // 0x1C
	public const int IsWinFieldNumber = 3; // Metadata: 0x00B08A9F
	private bool isWin_; // 0x20
	public const int CostTimeFieldNumber = 4; // Metadata: 0x00B08AA3
	private uint costTime_; // 0x24
	public const int SettlePlayerInfoListFieldNumber = 5; // Metadata: 0x00B08AA7
	private static readonly FieldCodec<ScenePlayBattleSettlePlayerInfo> _repeated_settlePlayerInfoList_codec; // 0x08
	private readonly RepeatedMessageField<ScenePlayBattleSettlePlayerInfo> settlePlayerInfoList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ScenePlayBattleResultNotify> Parser { get => default; } // 0x000000018541B3A0-0x000000018541B430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018541B130-0x000000018541B1C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018541ACF0-0x000000018541AD70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018541A230-0x000000018541A290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018541B9C0-0x000000018541BAB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018541B680-0x000000018541B6E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018541B1C0-0x000000018541B2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018541B970-0x000000018541B9C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018541AE10-0x000000018541AF00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayId { get => default; set {} } // 0x000000018541AC50-0x000000018541ACF0 0x000000018541B090-0x000000018541B130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PlayType { get => default; set {} } // 0x000000018541B6E0-0x000000018541B780 0x000000018541A700-0x000000018541A7A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsWin { get => default; set {} } // 0x000000018541A290-0x000000018541A330 0x000000018541BAB0-0x000000018541BB50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CostTime { get => default; set {} } // 0x000000018541B4C0-0x000000018541B560 0x000000018541A330-0x000000018541A3D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<ScenePlayBattleSettlePlayerInfo> SettlePlayerInfoList { get => default; } // 0x000000018541ABF0-0x000000018541AC50 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25405
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25406
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4363
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayBattleResultNotify() {} // 0x000000018541BFF0-0x000000018541C080
	static ScenePlayBattleResultNotify() {} // 0x000000018541BEE0-0x000000018541BFF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayBattleResultNotify Clone() => default; // 0x000000018541B2B0-0x000000018541B3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayBattleResultNotify ShallowCopy() => default; // 0x000000018541AD70-0x000000018541AE10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018541A5A0-0x000000018541A5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018541B560-0x000000018541B5F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018541B5F0-0x000000018541B680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018541A5F0-0x000000018541A700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018541A930-0x000000018541AA00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ScenePlayBattleResultNotify other) => default; // 0x000000018541A7A0-0x000000018541A930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018541AF00-0x000000018541B090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018541BB50-0x000000018541BEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018541B780-0x000000018541B970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018541AA00-0x000000018541ABF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ScenePlayBattleResultNotify other) {} // 0x000000018541A3D0-0x000000018541A5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018541A070-0x000000018541A230
}

