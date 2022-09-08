/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class FleurFairFallSettleNotify : MessageBase, IMessage<FleurFairFallSettleNotify> // TypeDefIndex: 22219
{
	// Fields
	private static readonly MessageParser<FleurFairFallSettleNotify> _parser; // 0x00
	public const int SettleInfoMapFieldNumber = 1; // Metadata: 0x00B0112F
	private static readonly MapField<uint, FleurFairFallSettleInfo> _map_settleInfoMap_codec; // 0x08
	private readonly MapField<uint, FleurFairFallSettleInfo> settleInfoMap_; // 0x18
	public const int MinigameIdFieldNumber = 2; // Metadata: 0x00B01133
	private uint minigameId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<FleurFairFallSettleNotify> Parser { get => default; } // 0x0000000184026AA0-0x0000000184026B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184026690-0x0000000184026720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184026350-0x00000001840263D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184025CF0-0x0000000184025D50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184026E50-0x0000000184026F40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184026C60-0x0000000184026CC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001840267C0-0x00000001840268B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184026E00-0x0000000184026E50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184026470-0x0000000184026560 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<uint, FleurFairFallSettleInfo> SettleInfoMap { get => default; } // 0x00000001840269A0-0x0000000184026A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MinigameId { get => default; set {} } // 0x0000000184026720-0x00000001840267C0 0x0000000184026A00-0x0000000184026AA0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22220
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22221
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 2182
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairFallSettleNotify() {} // 0x0000000184027280-0x0000000184027310
	static FleurFairFallSettleNotify() {} // 0x0000000184027120-0x0000000184027280

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairFallSettleNotify Clone() => default; // 0x00000001840268B0-0x00000001840269A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public FleurFairFallSettleNotify ShallowCopy() => default; // 0x00000001840263D0-0x0000000184026470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184025E80-0x0000000184025ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184026BC0-0x0000000184026C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184026C10-0x0000000184026C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184025ED0-0x0000000184025FA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184026140-0x0000000184026210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(FleurFairFallSettleNotify other) => default; // 0x0000000184025FA0-0x0000000184026140
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184026560-0x0000000184026690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184026F40-0x0000000184027120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184026CC0-0x0000000184026E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184026210-0x0000000184026350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(FleurFairFallSettleNotify other) {} // 0x0000000184025D50-0x0000000184025E80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184025B90-0x0000000184025CF0
}

