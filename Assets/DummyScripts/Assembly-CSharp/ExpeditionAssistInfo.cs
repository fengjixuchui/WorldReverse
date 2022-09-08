/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ExpeditionAssistInfo : MessageBase, IMessage<ExpeditionAssistInfo> // TypeDefIndex: 22185
{
	// Fields
	private static readonly MessageParser<ExpeditionAssistInfo> _parser; // 0x00
	public const int AvatarIdFieldNumber = 1; // Metadata: 0x00B00FEF
	private uint avatarId_; // 0x18
	public const int AssistTimeFieldNumber = 2; // Metadata: 0x00B00FF3
	private uint assistTime_; // 0x1C
	public const int TargetNickNameFieldNumber = 3; // Metadata: 0x00B00FF7
	private string targetNickName_; // 0x20
	public const int OnlineIdFieldNumber = 4; // Metadata: 0x00B00FFB
	private string onlineId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ExpeditionAssistInfo> Parser { get => default; } // 0x0000000182E39A90-0x0000000182E39B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182E39770-0x0000000182E39800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182E39270-0x0000000182E392F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182E38860-0x0000000182E388C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182E39F80-0x0000000182E3A070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182E39C50-0x0000000182E39CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182E39800-0x0000000182E398F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182E39F30-0x0000000182E39F80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182E39390-0x0000000182E39480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AvatarId { get => default; set {} } // 0x0000000182E39130-0x0000000182E391D0 0x0000000182E391D0-0x0000000182E39270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AssistTime { get => default; set {} } // 0x0000000182E38A70-0x0000000182E38B10 0x0000000182E39630-0x0000000182E396D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string TargetNickName { get => default; set {} } // 0x0000000182E39090-0x0000000182E39130 0x0000000182E39CB0-0x0000000182E39D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string OnlineId { get => default; set {} } // 0x0000000182E396D0-0x0000000182E39770 0x0000000182E399E0-0x0000000182E39A90

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionAssistInfo() {} // 0x0000000182E3A410-0x0000000182E3A490
	static ExpeditionAssistInfo() {} // 0x0000000182E3A350-0x0000000182E3A410

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionAssistInfo Clone() => default; // 0x0000000182E398F0-0x0000000182E399E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionAssistInfo ShallowCopy() => default; // 0x0000000182E392F0-0x0000000182E39390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182E38B10-0x0000000182E38B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E39BB0-0x0000000182E39C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E39C00-0x0000000182E39C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182E38B60-0x0000000182E38C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182E38C00-0x0000000182E38CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ExpeditionAssistInfo other) => default; // 0x0000000182E38CD0-0x0000000182E38E90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182E39480-0x0000000182E39630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182E3A070-0x0000000182E3A350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182E39D60-0x0000000182E39F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182E38E90-0x0000000182E39090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ExpeditionAssistInfo other) {} // 0x0000000182E388C0-0x0000000182E38A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182E38730-0x0000000182E38860
}

