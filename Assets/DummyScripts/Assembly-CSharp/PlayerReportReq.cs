/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerReportReq : MessageBase, IMessage<PlayerReportReq> // TypeDefIndex: 25648
{
	// Fields
	private static readonly MessageParser<PlayerReportReq> _parser; // 0x00
	public const int TargetUidFieldNumber = 1; // Metadata: 0x00B093EB
	private uint targetUid_; // 0x18
	public const int ReasonFieldNumber = 2; // Metadata: 0x00B093EF
	private ReportReasonType reason_; // 0x1C
	public const int ContentFieldNumber = 3; // Metadata: 0x00B093F3
	private string content_; // 0x20
	public const int TargetHomeModuleIdFieldNumber = 4; // Metadata: 0x00B093F7
	private uint targetHomeModuleId_; // 0x28
	public const int TargetHomeModuleNameFieldNumber = 5; // Metadata: 0x00B093FB
	private string targetHomeModuleName_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerReportReq> Parser { get => default; } // 0x0000000182DE7580-0x0000000182DE7610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182DE71C0-0x0000000182DE7250 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182DE6CF0-0x0000000182DE6D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182DE6230-0x0000000182DE6290 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182DE7AA0-0x0000000182DE7B90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182DE77E0-0x0000000182DE7840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182DE7250-0x0000000182DE7340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182DE7A50-0x0000000182DE7AA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182DE6E10-0x0000000182DE6F00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x0000000182DE7120-0x0000000182DE71C0 0x0000000182DE6C50-0x0000000182DE6CF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReportReasonType Reason { get => default; set {} } // 0x0000000182DE74E0-0x0000000182DE7580 0x0000000182DE64C0-0x0000000182DE6560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string Content { get => default; set {} } // 0x0000000182DE76A0-0x0000000182DE7740 0x0000000182DE7430-0x0000000182DE74E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetHomeModuleId { get => default; set {} } // 0x0000000182DE6560-0x0000000182DE6600 0x0000000182DE6600-0x0000000182DE66A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public string TargetHomeModuleName { get => default; set {} } // 0x0000000182DE6190-0x0000000182DE6230 0x0000000182DE60E0-0x0000000182DE6190

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25649
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25650
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4041
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerReportReq() {} // 0x0000000182DE7FC0-0x0000000182DE8040
	static PlayerReportReq() {} // 0x0000000182DE7F00-0x0000000182DE7FC0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerReportReq Clone() => default; // 0x0000000182DE7340-0x0000000182DE7430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerReportReq ShallowCopy() => default; // 0x0000000182DE6D70-0x0000000182DE6E10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182DE6470-0x0000000182DE64C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182DE7740-0x0000000182DE7790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182DE7790-0x0000000182DE77E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182DE66A0-0x0000000182DE6750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182DE6930-0x0000000182DE6A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerReportReq other) => default; // 0x0000000182DE6750-0x0000000182DE6930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182DE6F00-0x0000000182DE7120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182DE7B90-0x0000000182DE7F00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182DE7840-0x0000000182DE7A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182DE6A00-0x0000000182DE6C50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerReportReq other) {} // 0x0000000182DE6290-0x0000000182DE6470
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182DE5F90-0x0000000182DE60E0
}

