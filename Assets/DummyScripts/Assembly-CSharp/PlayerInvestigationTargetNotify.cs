/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerInvestigationTargetNotify : MessageBase, IMessage<PlayerInvestigationTargetNotify> // TypeDefIndex: 23604
{
	// Fields
	private static readonly MessageParser<PlayerInvestigationTargetNotify> _parser; // 0x00
	public const int InvestigationTargetListFieldNumber = 1; // Metadata: 0x00B04637
	private static readonly FieldCodec<InvestigationTarget> _repeated_investigationTargetList_codec; // 0x08
	private readonly RepeatedMessageField<InvestigationTarget> investigationTargetList_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerInvestigationTargetNotify> Parser { get => default; } // 0x00000001833DBA80-0x00000001833DBB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001833DB810-0x00000001833DB8A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001833DB540-0x00000001833DB5C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001833DAFC0-0x00000001833DB020 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001833DBED0-0x00000001833DBFC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001833DBD20-0x00000001833DBD80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001833DB8A0-0x00000001833DB990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001833DBE80-0x00000001833DBED0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001833DB660-0x00000001833DB750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<InvestigationTarget> InvestigationTargetList { get => default; } // 0x00000001833DBCC0-0x00000001833DBD20 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23605
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23606
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1909
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerInvestigationTargetNotify() {} // 0x00000001833DC220-0x00000001833DC2B0
	static PlayerInvestigationTargetNotify() {} // 0x00000001833DC110-0x00000001833DC220

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerInvestigationTargetNotify Clone() => default; // 0x00000001833DB990-0x00000001833DBA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerInvestigationTargetNotify ShallowCopy() => default; // 0x00000001833DB5C0-0x00000001833DB660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001833DB150-0x00000001833DB1A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833DBBA0-0x00000001833DBC30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001833DBC30-0x00000001833DBCC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001833DB1A0-0x00000001833DB270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001833DB270-0x00000001833DB340
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerInvestigationTargetNotify other) => default; // 0x00000001833DB340-0x00000001833DB450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001833DB750-0x00000001833DB810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001833DBFC0-0x00000001833DC110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001833DBD80-0x00000001833DBE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001833DB450-0x00000001833DB540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerInvestigationTargetNotify other) {} // 0x00000001833DB020-0x00000001833DB150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001833DAE90-0x00000001833DAFC0
}

