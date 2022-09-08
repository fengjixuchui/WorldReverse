/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ReunionDailyRefreshNotify : MessageBase, IMessage<ReunionDailyRefreshNotify> // TypeDefIndex: 24867
{
	// Fields
	private static readonly MessageParser<ReunionDailyRefreshNotify> _parser; // 0x00
	public const int ReunionBriefInfoFieldNumber = 1; // Metadata: 0x00B07697
	private ReunionBriefInfo reunionBriefInfo_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<ReunionDailyRefreshNotify> Parser { get => default; } // 0x000000018226A1D0-0x000000018226A260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182269EC0-0x0000000182269F50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182269B60-0x0000000182269BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001822694D0-0x0000000182269530 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018226A620-0x000000018226A710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018226A3F0-0x000000018226A450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182269FF0-0x000000018226A0E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018226A5D0-0x000000018226A620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182269C80-0x0000000182269D70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionBriefInfo ReunionBriefInfo { get => default; set {} } // 0x000000018226A450-0x000000018226A4F0 0x0000000182269F50-0x0000000182269FF0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24868
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24869
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5071
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionDailyRefreshNotify() {} // 0x000000018226A920-0x000000018226A980
	static ReunionDailyRefreshNotify() {} // 0x000000018226A860-0x000000018226A920

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionDailyRefreshNotify Clone() => default; // 0x000000018226A0E0-0x000000018226A1D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionDailyRefreshNotify ShallowCopy() => default; // 0x0000000182269BE0-0x0000000182269C80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182269690-0x0000000182269710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018226A2F0-0x000000018226A370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018226A370-0x000000018226A3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182269710-0x0000000182269830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182269830-0x0000000182269900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(ReunionDailyRefreshNotify other) => default; // 0x0000000182269900-0x0000000182269A10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182269D70-0x0000000182269EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018226A710-0x000000018226A860
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018226A4F0-0x000000018226A5D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182269A10-0x0000000182269B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(ReunionDailyRefreshNotify other) {} // 0x0000000182269530-0x0000000182269690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001822693C0-0x00000001822694D0
}

