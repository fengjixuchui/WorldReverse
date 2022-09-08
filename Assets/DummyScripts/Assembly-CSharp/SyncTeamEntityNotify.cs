/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SyncTeamEntityNotify : MessageBase, IMessage<SyncTeamEntityNotify> // TypeDefIndex: 23120
{
	// Fields
	private static readonly MessageParser<SyncTeamEntityNotify> _parser; // 0x00
	public const int SceneIdFieldNumber = 1; // Metadata: 0x00B033C7
	private uint sceneId_; // 0x18
	public const int TeamEntityInfoListFieldNumber = 2; // Metadata: 0x00B033CB
	private static readonly FieldCodec<TeamEntityInfo> _repeated_teamEntityInfoList_codec; // 0x08
	private readonly RepeatedMessageField<TeamEntityInfo> teamEntityInfoList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SyncTeamEntityNotify> Parser { get => default; } // 0x0000000184A83680-0x0000000184A83710 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184A833B0-0x0000000184A83440 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184A830A0-0x0000000184A83120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184A82930-0x0000000184A82990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184A83AB0-0x0000000184A83BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184A838C0-0x0000000184A83920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184A834A0-0x0000000184A83590 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184A83A60-0x0000000184A83AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184A831C0-0x0000000184A832B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000184A82C20-0x0000000184A82CC0 0x0000000184A83000-0x0000000184A830A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<TeamEntityInfo> TeamEntityInfoList { get => default; } // 0x0000000184A83440-0x0000000184A834A0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23121
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23122
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 348
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SyncTeamEntityNotify() {} // 0x0000000184A83E90-0x0000000184A83F20
	static SyncTeamEntityNotify() {} // 0x0000000184A83D80-0x0000000184A83E90

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SyncTeamEntityNotify Clone() => default; // 0x0000000184A83590-0x0000000184A83680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SyncTeamEntityNotify ShallowCopy() => default; // 0x0000000184A83120-0x0000000184A831C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184A82AF0-0x0000000184A82B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A837A0-0x0000000184A83830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184A83830-0x0000000184A838C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184A82B40-0x0000000184A82C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184A82DF0-0x0000000184A82EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SyncTeamEntityNotify other) => default; // 0x0000000184A82CC0-0x0000000184A82DF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184A832B0-0x0000000184A833B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184A83BA0-0x0000000184A83D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184A83920-0x0000000184A83A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184A82EC0-0x0000000184A83000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SyncTeamEntityNotify other) {} // 0x0000000184A82990-0x0000000184A82AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184A827D0-0x0000000184A82930
}

