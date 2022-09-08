/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class StartCoopPointRsp : MessageBase, IMessage<StartCoopPointRsp> // TypeDefIndex: 22729
{
	// Fields
	private static readonly MessageParser<StartCoopPointRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B023DB
	private int retcode_; // 0x18
	public const int CoopPointFieldNumber = 2; // Metadata: 0x00B023DF
	private uint coopPoint_; // 0x1C
	public const int IsStartFieldNumber = 3; // Metadata: 0x00B023E3
	private bool isStart_; // 0x20
	public const int StartMainCoopFieldNumber = 4; // Metadata: 0x00B023E7
	private MainCoop startMainCoop_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<StartCoopPointRsp> Parser { get => default; } // 0x0000000182E0E090-0x0000000182E0E120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182E0DCE0-0x0000000182E0DD70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182E0D8F0-0x0000000182E0D970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182E0CEE0-0x0000000182E0CF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182E0E640-0x0000000182E0E730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182E0E350-0x0000000182E0E3B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182E0DD70-0x0000000182E0DE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182E0E550-0x0000000182E0E5A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182E0DA10-0x0000000182E0DB00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000182E0D7B0-0x0000000182E0D850 0x0000000182E0D2E0-0x0000000182E0D380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CoopPoint { get => default; set {} } // 0x0000000182E0E2B0-0x0000000182E0E350 0x0000000182E0DFF0-0x0000000182E0E090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsStart { get => default; set {} } // 0x0000000182E0E5A0-0x0000000182E0E640 0x0000000182E0CE40-0x0000000182E0CEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MainCoop StartMainCoop { get => default; set {} } // 0x0000000182E0DF50-0x0000000182E0DFF0 0x0000000182E0D850-0x0000000182E0D8F0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22730
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22731
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1965
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StartCoopPointRsp() {} // 0x0000000182E0EAF0-0x0000000182E0EB50
	static StartCoopPointRsp() {} // 0x0000000182E0EA30-0x0000000182E0EAF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StartCoopPointRsp Clone() => default; // 0x0000000182E0DE60-0x0000000182E0DF50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public StartCoopPointRsp ShallowCopy() => default; // 0x0000000182E0D970-0x0000000182E0DA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182E0D110-0x0000000182E0D190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E0E1B0-0x0000000182E0E230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182E0E230-0x0000000182E0E2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182E0D190-0x0000000182E0D2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182E0D380-0x0000000182E0D450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(StartCoopPointRsp other) => default; // 0x0000000182E0D450-0x0000000182E0D5C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182E0DB00-0x0000000182E0DCE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182E0E730-0x0000000182E0EA30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182E0E3B0-0x0000000182E0E550
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182E0D5C0-0x0000000182E0D7B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(StartCoopPointRsp other) {} // 0x0000000182E0CF40-0x0000000182E0D110
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182E0CCC0-0x0000000182E0CE40
}

