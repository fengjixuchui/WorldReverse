/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UpdateReunionWatcherNotify : MessageBase, IMessage<UpdateReunionWatcherNotify> // TypeDefIndex: 24843
{
	// Fields
	private static readonly MessageParser<UpdateReunionWatcherNotify> _parser; // 0x00
	public const int MissionIdFieldNumber = 1; // Metadata: 0x00B075DB
	private uint missionId_; // 0x18
	public const int WatcherInfoFieldNumber = 2; // Metadata: 0x00B075DF
	private ReunionWatcherInfo watcherInfo_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UpdateReunionWatcherNotify> Parser { get => default; } // 0x00000001832A91F0-0x00000001832A9280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001832A8EE0-0x00000001832A8F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001832A8AB0-0x00000001832A8B30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001832A8240-0x00000001832A82A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001832A95E0-0x00000001832A96D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001832A9410-0x00000001832A9470 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001832A9010-0x00000001832A9100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001832A9590-0x00000001832A95E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001832A8C70-0x00000001832A8D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint MissionId { get => default; set {} } // 0x00000001832A8340-0x00000001832A83E0 0x00000001832A8F70-0x00000001832A9010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ReunionWatcherInfo WatcherInfo { get => default; set {} } // 0x00000001832A8B30-0x00000001832A8BD0 0x00000001832A82A0-0x00000001832A8340

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24844
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24845
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5063
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdateReunionWatcherNotify() {} // 0x00000001832A9970-0x00000001832A99D0
	static UpdateReunionWatcherNotify() {} // 0x00000001832A98B0-0x00000001832A9970

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdateReunionWatcherNotify Clone() => default; // 0x00000001832A9100-0x00000001832A91F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdateReunionWatcherNotify ShallowCopy() => default; // 0x00000001832A8BD0-0x00000001832A8C70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001832A8560-0x00000001832A85E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832A9310-0x00000001832A9390
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001832A9390-0x00000001832A9410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001832A85E0-0x00000001832A8710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001832A8710-0x00000001832A87E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UpdateReunionWatcherNotify other) => default; // 0x00000001832A87E0-0x00000001832A8910
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001832A8D60-0x00000001832A8EE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001832A96D0-0x00000001832A98B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001832A9470-0x00000001832A9590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001832A8910-0x00000001832A8AB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UpdateReunionWatcherNotify other) {} // 0x00000001832A83E0-0x00000001832A8560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001832A8100-0x00000001832A8240
}

