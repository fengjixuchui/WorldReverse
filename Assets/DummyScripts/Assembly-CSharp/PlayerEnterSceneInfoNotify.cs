/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerEnterSceneInfoNotify : MessageBase, IMessage<PlayerEnterSceneInfoNotify> // TypeDefIndex: 25103
{
	// Fields
	private static readonly MessageParser<PlayerEnterSceneInfoNotify> _parser; // 0x00
	public const int CurAvatarEntityIdFieldNumber = 1; // Metadata: 0x00B07FF3
	private uint curAvatarEntityId_; // 0x18
	public const int AvatarEnterInfoFieldNumber = 2; // Metadata: 0x00B07FF7
	private static readonly FieldCodec<AvatarEnterSceneInfo> _repeated_avatarEnterInfo_codec; // 0x08
	private readonly RepeatedMessageField<AvatarEnterSceneInfo> avatarEnterInfo_; // 0x20
	public const int TeamEnterInfoFieldNumber = 3; // Metadata: 0x00B07FFB
	private TeamEnterSceneInfo teamEnterInfo_; // 0x28
	public const int MpLevelEntityInfoFieldNumber = 4; // Metadata: 0x00B07FFF
	private MPLevelEntityInfo mpLevelEntityInfo_; // 0x30
	public const int EnterSceneTokenFieldNumber = 5; // Metadata: 0x00B08003
	private uint enterSceneToken_; // 0x38

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerEnterSceneInfoNotify> Parser { get => default; } // 0x000000018491C840-0x000000018491C8D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018491C490-0x000000018491C520 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018491BF70-0x000000018491BFF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018491B290-0x000000018491B2F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018491CF40-0x000000018491D030 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018491CC00-0x000000018491CC60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018491C660-0x000000018491C750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018491CEF0-0x000000018491CF40 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018491C090-0x000000018491C180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CurAvatarEntityId { get => default; set {} } // 0x000000018491C520-0x000000018491C5C0 0x000000018491BED0-0x000000018491BF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AvatarEnterSceneInfo> AvatarEnterInfo { get => default; } // 0x000000018491B2F0-0x000000018491B350 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public TeamEnterSceneInfo TeamEnterInfo { get => default; set {} } // 0x000000018491CE50-0x000000018491CEF0 0x000000018491C3F0-0x000000018491C490
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MPLevelEntityInfo MpLevelEntityInfo { get => default; set {} } // 0x000000018491CA10-0x000000018491CAB0 0x000000018491B350-0x000000018491B3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint EnterSceneToken { get => default; set {} } // 0x000000018491C5C0-0x000000018491C660 0x000000018491CB60-0x000000018491CC00

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25104
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25105
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 268
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerEnterSceneInfoNotify() {} // 0x000000018491D490-0x000000018491D520
	static PlayerEnterSceneInfoNotify() {} // 0x000000018491D380-0x000000018491D490

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerEnterSceneInfoNotify Clone() => default; // 0x000000018491C750-0x000000018491C840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerEnterSceneInfoNotify ShallowCopy() => default; // 0x000000018491BFF0-0x000000018491C090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018491B660-0x000000018491B6F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018491C960-0x000000018491CA10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018491CAB0-0x000000018491CB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018491B6F0-0x000000018491B960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018491BB10-0x000000018491BBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerEnterSceneInfoNotify other) => default; // 0x000000018491B960-0x000000018491BB10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018491C180-0x000000018491C3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018491D030-0x000000018491D380
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018491CC60-0x000000018491CE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018491BBE0-0x000000018491BED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerEnterSceneInfoNotify other) {} // 0x000000018491B3F0-0x000000018491B660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018491B070-0x000000018491B290
}

