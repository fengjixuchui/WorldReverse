/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SceneKickPlayerNotify : MessageBase, IMessage<SceneKickPlayerNotify> // TypeDefIndex: 25118
{
	// Fields
	private static readonly MessageParser<SceneKickPlayerNotify> _parser; // 0x00
	public const int KickerUidFieldNumber = 1; // Metadata: 0x00B08077
	private uint kickerUid_; // 0x18
	public const int TargetUidFieldNumber = 2; // Metadata: 0x00B0807B
	private uint targetUid_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SceneKickPlayerNotify> Parser { get => default; } // 0x0000000182C10670-0x0000000182C10700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000182C10400-0x0000000182C10490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000182C10050-0x0000000182C100D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000182C0F9A0-0x0000000182C0FA00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000182C10A00-0x0000000182C10AF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000182C10830-0x0000000182C10890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000182C10490-0x0000000182C10580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000182C109B0-0x0000000182C10A00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000182C10170-0x0000000182C10260 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint KickerUid { get => default; set {} } // 0x0000000182C0FBF0-0x0000000182C0FC90 0x0000000182C10AF0-0x0000000182C10B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x0000000182C10360-0x0000000182C10400 0x0000000182C0FFB0-0x0000000182C10050

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25119
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25120
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 273
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneKickPlayerNotify() {} // 0x0000000182C10E50-0x0000000182C10EB0
	static SceneKickPlayerNotify() {} // 0x0000000182C10D90-0x0000000182C10E50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneKickPlayerNotify Clone() => default; // 0x0000000182C10580-0x0000000182C10670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SceneKickPlayerNotify ShallowCopy() => default; // 0x0000000182C100D0-0x0000000182C10170
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000182C0FB30-0x0000000182C0FB80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C10790-0x0000000182C107E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000182C107E0-0x0000000182C10830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000182C0FB80-0x0000000182C0FBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000182C0FDB0-0x0000000182C0FE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SceneKickPlayerNotify other) => default; // 0x0000000182C0FC90-0x0000000182C0FDB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000182C10260-0x0000000182C10360
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000182C10B90-0x0000000182C10D90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000182C10890-0x0000000182C109B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000182C0FE80-0x0000000182C0FFB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SceneKickPlayerNotify other) {} // 0x0000000182C0FA00-0x0000000182C0FB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000182C0F8A0-0x0000000182C0F9A0
}

