/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarExpeditionGetRewardRsp : MessageBase, IMessage<AvatarExpeditionGetRewardRsp> // TypeDefIndex: 22477
{
	// Fields
	private static readonly MessageParser<AvatarExpeditionGetRewardRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B01A8B
	private int retcode_; // 0x18
	public const int ExpeditionInfoMapFieldNumber = 2; // Metadata: 0x00B01A8F
	private static readonly MapField<ulong, AvatarExpeditionInfo> _map_expeditionInfoMap_codec; // 0x08
	private readonly MapField<ulong, AvatarExpeditionInfo> expeditionInfoMap_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarExpeditionGetRewardRsp> Parser { get => default; } // 0x0000000184B7B3F0-0x0000000184B7B480 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000184B7B120-0x0000000184B7B1B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000184B7ADD0-0x0000000184B7AE50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184B7A6A0-0x0000000184B7A700 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184B7B7A0-0x0000000184B7B890 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184B7B5B0-0x0000000184B7B610 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184B7B210-0x0000000184B7B300 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184B7B750-0x0000000184B7B7A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000184B7AEF0-0x0000000184B7AFE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000184B7AD30-0x0000000184B7ADD0 0x0000000184B7A940-0x0000000184B7A9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<ulong, AvatarExpeditionInfo> ExpeditionInfoMap { get => default; } // 0x0000000184B7B1B0-0x0000000184B7B210 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22478
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22479
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1732
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarExpeditionGetRewardRsp() {} // 0x0000000184B7BBD0-0x0000000184B7BC60
	static AvatarExpeditionGetRewardRsp() {} // 0x0000000184B7BA70-0x0000000184B7BBD0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarExpeditionGetRewardRsp Clone() => default; // 0x0000000184B7B300-0x0000000184B7B3F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarExpeditionGetRewardRsp ShallowCopy() => default; // 0x0000000184B7AE50-0x0000000184B7AEF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184B7A830-0x0000000184B7A880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B7B510-0x0000000184B7B560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184B7B560-0x0000000184B7B5B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184B7A880-0x0000000184B7A940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184B7A9E0-0x0000000184B7AAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarExpeditionGetRewardRsp other) => default; // 0x0000000184B7AAB0-0x0000000184B7ABF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000184B7AFE0-0x0000000184B7B120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184B7B890-0x0000000184B7BA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184B7B610-0x0000000184B7B750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000184B7ABF0-0x0000000184B7AD30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarExpeditionGetRewardRsp other) {} // 0x0000000184B7A700-0x0000000184B7A830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184B7A540-0x0000000184B7A6A0
}

