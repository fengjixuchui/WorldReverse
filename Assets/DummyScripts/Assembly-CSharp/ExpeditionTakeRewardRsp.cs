/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ExpeditionTakeRewardRsp : MessageBase, IMessage<ExpeditionTakeRewardRsp> // TypeDefIndex: 22182
{
	// Fields
	private static readonly MessageParser<ExpeditionTakeRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B00FD3
	private int retcode_; // 0x18
	public const int PathIdFieldNumber = 2; // Metadata: 0x00B00FD7
	private uint pathId_; // 0x1C
	public const int IsBonusFieldNumber = 3; // Metadata: 0x00B00FDB
	private bool isBonus_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ExpeditionTakeRewardRsp> Parser { get => default; } // 0x00000001835FCDF0-0x00000001835FCE80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001835FCAE0-0x00000001835FCB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001835FC7A0-0x00000001835FC820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001835FBF30-0x00000001835FBF90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001835FD1C0-0x00000001835FD2B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001835FCFB0-0x00000001835FD010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001835FCB70-0x00000001835FCC60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001835FD170-0x00000001835FD1C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001835FC8C0-0x00000001835FC9B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001835FC700-0x00000001835FC7A0 0x00000001835FC300-0x00000001835FC3A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint PathId { get => default; set {} } // 0x00000001835FC260-0x00000001835FC300 0x00000001835FBE90-0x00000001835FBF30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsBonus { get => default; set {} } // 0x00000001835FBF90-0x00000001835FC030 0x00000001835FCD50-0x00000001835FCDF0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22183
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22184
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2166
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionTakeRewardRsp() {} // 0x00000001835FD600-0x00000001835FD660
	static ExpeditionTakeRewardRsp() {} // 0x00000001835FD540-0x00000001835FD600

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionTakeRewardRsp Clone() => default; // 0x00000001835FCC60-0x00000001835FCD50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ExpeditionTakeRewardRsp ShallowCopy() => default; // 0x00000001835FC820-0x00000001835FC8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001835FC190-0x00000001835FC1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835FCF10-0x00000001835FCF60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001835FCF60-0x00000001835FCFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001835FC1E0-0x00000001835FC260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001835FC4E0-0x00000001835FC5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ExpeditionTakeRewardRsp other) => default; // 0x00000001835FC3A0-0x00000001835FC4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001835FC9B0-0x00000001835FCAE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001835FD2B0-0x00000001835FD540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001835FD010-0x00000001835FD170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001835FC5B0-0x00000001835FC700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ExpeditionTakeRewardRsp other) {} // 0x00000001835FC030-0x00000001835FC190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001835FBD80-0x00000001835FBE90
}

