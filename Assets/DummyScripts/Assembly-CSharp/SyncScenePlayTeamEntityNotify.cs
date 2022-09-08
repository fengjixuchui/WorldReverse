/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class SyncScenePlayTeamEntityNotify : MessageBase, IMessage<SyncScenePlayTeamEntityNotify> // TypeDefIndex: 25305
{
	// Fields
	private static readonly MessageParser<SyncScenePlayTeamEntityNotify> _parser; // 0x00
	public const int SceneIdFieldNumber = 1; // Metadata: 0x00B086A7
	private uint sceneId_; // 0x18
	public const int EntityInfoListFieldNumber = 2; // Metadata: 0x00B086AB
	private static readonly FieldCodec<PlayTeamEntityInfo> _repeated_entityInfoList_codec; // 0x08
	private readonly RepeatedMessageField<PlayTeamEntityInfo> entityInfoList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<SyncScenePlayTeamEntityNotify> Parser { get => default; } // 0x0000000183C15320-0x0000000183C153B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183C150B0-0x0000000183C15140 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183C14DA0-0x0000000183C14E20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183C145D0-0x0000000183C14630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183C15750-0x0000000183C15840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183C15560-0x0000000183C155C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183C15140-0x0000000183C15230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183C15700-0x0000000183C15750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183C14EC0-0x0000000183C14FB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000183C148C0-0x0000000183C14960 0x0000000183C14D00-0x0000000183C14DA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<PlayTeamEntityInfo> EntityInfoList { get => default; } // 0x0000000183C14CA0-0x0000000183C14D00 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25306
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25307
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 3050
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SyncScenePlayTeamEntityNotify() {} // 0x0000000183C15B30-0x0000000183C15BC0
	static SyncScenePlayTeamEntityNotify() {} // 0x0000000183C15A20-0x0000000183C15B30

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SyncScenePlayTeamEntityNotify Clone() => default; // 0x0000000183C15230-0x0000000183C15320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public SyncScenePlayTeamEntityNotify ShallowCopy() => default; // 0x0000000183C14E20-0x0000000183C14EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183C14790-0x0000000183C147E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C15440-0x0000000183C154D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183C154D0-0x0000000183C15560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183C147E0-0x0000000183C148C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183C14960-0x0000000183C14A30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(SyncScenePlayTeamEntityNotify other) => default; // 0x0000000183C14A30-0x0000000183C14B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183C14FB0-0x0000000183C150B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183C15840-0x0000000183C15A20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183C155C0-0x0000000183C15700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183C14B60-0x0000000183C14CA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(SyncScenePlayTeamEntityNotify other) {} // 0x0000000183C14630-0x0000000183C14790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183C14470-0x0000000183C145D0
}

