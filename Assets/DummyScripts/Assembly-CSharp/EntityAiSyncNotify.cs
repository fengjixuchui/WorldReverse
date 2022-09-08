/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class EntityAiSyncNotify : MessageBase, IMessage<EntityAiSyncNotify> // TypeDefIndex: 23143
{
	// Fields
	private static readonly MessageParser<EntityAiSyncNotify> _parser; // 0x00
	public const int InfoListFieldNumber = 1; // Metadata: 0x00B034A7
	private static readonly FieldCodec<AiSyncInfo> _repeated_infoList_codec; // 0x08
	private readonly RepeatedMessageField<AiSyncInfo> infoList_; // 0x18
	public const int LocalAvatarAlertedMonsterListFieldNumber = 2; // Metadata: 0x00B034AB
	private static readonly FieldCodec<uint> _repeated_localAvatarAlertedMonsterList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> localAvatarAlertedMonsterList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<EntityAiSyncNotify> Parser { get => default; } // 0x000000018222F060-0x000000018222F0F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018222ED90-0x000000018222EE20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018222EA90-0x000000018222EB10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018222E3D0-0x000000018222E430 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018222F480-0x000000018222F570 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018222F2A0-0x000000018222F300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018222EE20-0x000000018222EF10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018222F430-0x000000018222F480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018222EBB0-0x000000018222ECA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<AiSyncInfo> InfoList { get => default; } // 0x000000018222E710-0x000000018222E770 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> LocalAvatarAlertedMonsterList { get => default; } // 0x000000018222F000-0x000000018222F060 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23144
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23145
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 354
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityAiSyncNotify() {} // 0x000000018222F860-0x000000018222F910
	static EntityAiSyncNotify() {} // 0x000000018222F730-0x000000018222F860

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityAiSyncNotify Clone() => default; // 0x000000018222EF10-0x000000018222F000
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public EntityAiSyncNotify ShallowCopy() => default; // 0x000000018222EB10-0x000000018222EBB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018222E590-0x000000018222E5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018222F180-0x000000018222F210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018222F210-0x000000018222F2A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018222E5E0-0x000000018222E710
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018222E8A0-0x000000018222E970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(EntityAiSyncNotify other) => default; // 0x000000018222E770-0x000000018222E8A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018222ECA0-0x000000018222ED90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018222F570-0x000000018222F730
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018222F300-0x000000018222F430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018222E970-0x000000018222EA90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(EntityAiSyncNotify other) {} // 0x000000018222E430-0x000000018222E590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018222E220-0x000000018222E3D0
}

