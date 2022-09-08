/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ResinCardData : MessageBase, IMessage<ResinCardData> // TypeDefIndex: 24706
{
	// Fields
	private static readonly MessageParser<ResinCardData> _parser; // 0x00
	public const int ConfigIdFieldNumber = 1; // Metadata: 0x00B070AF
	private uint configId_; // 0x18
	public const int RemainRewardDaysFieldNumber = 2; // Metadata: 0x00B070B3
	private uint remainRewardDays_; // 0x1C
	public const int LastDailyRewardTimeFieldNumber = 3; // Metadata: 0x00B070B7
	private uint lastDailyRewardTime_; // 0x20
	public const int ExpireTimeFieldNumber = 4; // Metadata: 0x00B070BB
	private uint expireTime_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ResinCardData> Parser { get => default; } // 0x0000000182997AF0-0x0000000182997B80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001829976A0-0x0000000182997730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182997330-0x00000001829973B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182996960-0x00000001829969C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182997F00-0x0000000182997FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182997CB0-0x0000000182997D10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001829977D0-0x00000001829978C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182997EB0-0x0000000182997F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182997450-0x0000000182997540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ConfigId { get => default; set {} } // 0x0000000182997730-0x00000001829977D0 0x00000001829969C0-0x0000000182996A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RemainRewardDays { get => default; set {} } // 0x00000001829979B0-0x0000000182997A50 0x0000000182996BE0-0x0000000182996C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint LastDailyRewardTime { get => default; set {} } // 0x0000000182997A50-0x0000000182997AF0 0x0000000182996E00-0x0000000182996EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ExpireTime { get => default; set {} } // 0x0000000182997290-0x0000000182997330 0x0000000182996D60-0x0000000182996E00

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ResinCardData() {} // 0x00000001829983D0-0x0000000182998430
	static ResinCardData() {} // 0x0000000182998310-0x00000001829983D0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ResinCardData Clone() => default; // 0x00000001829978C0-0x00000001829979B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ResinCardData ShallowCopy() => default; // 0x00000001829973B0-0x0000000182997450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182996C80-0x0000000182996CD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182997C10-0x0000000182997C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182997C60-0x0000000182997CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182996CD0-0x0000000182996D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182996FF0-0x00000001829970C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ResinCardData other) => default; // 0x0000000182996EA0-0x0000000182996FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182997540-0x00000001829976A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182997FF0-0x0000000182998310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182997D10-0x0000000182997EB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001829970C0-0x0000000182997290
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ResinCardData other) {} // 0x0000000182996A60-0x0000000182996BE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182996830-0x0000000182996960
}

