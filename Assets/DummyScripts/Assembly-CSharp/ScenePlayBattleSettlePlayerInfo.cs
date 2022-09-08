/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ScenePlayBattleSettlePlayerInfo : MessageBase, IMessage<ScenePlayBattleSettlePlayerInfo> // TypeDefIndex: 25403
{
	// Fields
	private static readonly MessageParser<ScenePlayBattleSettlePlayerInfo> _parser; // 0x00
	public const int UidFieldNumber = 1; // Metadata: 0x00B08A7F
	private uint uid_; // 0x18
	public const int StatisticIdFieldNumber = 2; // Metadata: 0x00B08A83
	private uint statisticId_; // 0x1C
	public const int ParamFieldNumber = 3; // Metadata: 0x00B08A87
	private long param_; // 0x20
	public const int HeadImageFieldNumber = 4; // Metadata: 0x00B08A8B
	private uint headImage_; // 0x28
	public const int NicknameFieldNumber = 5; // Metadata: 0x00B08A8F
	private string nickname_; // 0x30
	public const int OnlineIdFieldNumber = 6; // Metadata: 0x00B08A93
	private string onlineId_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ScenePlayBattleSettlePlayerInfo> Parser { get => default; } // 0x00000001818334F0-0x0000000181833580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181832F50-0x0000000181832FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181832A90-0x0000000181832B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181831FE0-0x0000000181832040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181833AF0-0x0000000181833BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001818336B0-0x0000000181833710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001818331C0-0x00000001818332B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181833AA0-0x0000000181833AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181832BB0-0x0000000181832CA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Uid { get => default; set {} } // 0x00000001818329F0-0x0000000181832A90 0x0000000181833080-0x0000000181833120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint StatisticId { get => default; set {} } // 0x0000000181833BE0-0x0000000181833C80 0x0000000181833450-0x00000001818334F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public long Param { get => default; set {} } // 0x0000000181833710-0x00000001818337B0 0x00000001818337B0-0x0000000181833850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint HeadImage { get => default; set {} } // 0x0000000181832FE0-0x0000000181833080 0x0000000181832340-0x00000001818323E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Nickname { get => default; set {} } // 0x0000000181833120-0x00000001818331C0 0x00000001818323E0-0x0000000181832490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string OnlineId { get => default; set {} } // 0x0000000181832EB0-0x0000000181832F50 0x00000001818333A0-0x0000000181833450

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayBattleSettlePlayerInfo() {} // 0x0000000181834140-0x00000001818341C0
	static ScenePlayBattleSettlePlayerInfo() {} // 0x0000000181834080-0x0000000181834140

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayBattleSettlePlayerInfo Clone() => default; // 0x00000001818332B0-0x00000001818333A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ScenePlayBattleSettlePlayerInfo ShallowCopy() => default; // 0x0000000181832B10-0x0000000181832BB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181832240-0x0000000181832290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181833610-0x0000000181833660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181833660-0x00000001818336B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181832290-0x0000000181832340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181832690-0x0000000181832760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ScenePlayBattleSettlePlayerInfo other) => default; // 0x0000000181832490-0x0000000181832690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181832CA0-0x0000000181832EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181833C80-0x0000000181834080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181833850-0x0000000181833AA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181832760-0x00000001818329F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ScenePlayBattleSettlePlayerInfo other) {} // 0x0000000181832040-0x0000000181832240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181831E70-0x0000000181831FE0
}

