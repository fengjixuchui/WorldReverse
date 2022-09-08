/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class DailyTaskProgressNotify : MessageBase, IMessage<DailyTaskProgressNotify> // TypeDefIndex: 24442
{
	// Fields
	private static readonly MessageParser<DailyTaskProgressNotify> _parser; // 0x00
	public const int InfoFieldNumber = 1; // Metadata: 0x00B0672B
	private DailyTaskInfo info_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<DailyTaskProgressNotify> Parser { get => default; } // 0x0000000181094A70-0x0000000181094B00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181094800-0x0000000181094890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001810944A0-0x0000000181094520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181093D70-0x0000000181093DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181094EC0-0x0000000181094FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181094D30-0x0000000181094D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181094890-0x0000000181094980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181094E70-0x0000000181094EC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001810945C0-0x00000001810946B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DailyTaskInfo Info { get => default; set {} } // 0x00000001810940D0-0x0000000181094170 0x0000000181094C90-0x0000000181094D30

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24443
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24444
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 147
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DailyTaskProgressNotify() {} // 0x00000001810951C0-0x0000000181095220
	static DailyTaskProgressNotify() {} // 0x0000000181095100-0x00000001810951C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DailyTaskProgressNotify Clone() => default; // 0x0000000181094980-0x0000000181094A70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public DailyTaskProgressNotify ShallowCopy() => default; // 0x0000000181094520-0x00000001810945C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181093F30-0x0000000181093FB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181094B90-0x0000000181094C10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181094C10-0x0000000181094C90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181093FB0-0x00000001810940D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181094280-0x0000000181094350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(DailyTaskProgressNotify other) => default; // 0x0000000181094170-0x0000000181094280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001810946B0-0x0000000181094800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181094FB0-0x0000000181095100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181094D90-0x0000000181094E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181094350-0x00000001810944A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(DailyTaskProgressNotify other) {} // 0x0000000181093DD0-0x0000000181093F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181093C60-0x0000000181093D70
}

