/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarWearFlycloakRsp : MessageBase, IMessage<AvatarWearFlycloakRsp> // TypeDefIndex: 22509
{
	// Fields
	private static readonly MessageParser<AvatarWearFlycloakRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B01BDF
	private int retcode_; // 0x18
	public const int AvatarGuidFieldNumber = 2; // Metadata: 0x00B01BE3
	private ulong avatarGuid_; // 0x20
	public const int FlycloakIdFieldNumber = 3; // Metadata: 0x00B01BE7
	private uint flycloakId_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarWearFlycloakRsp> Parser { get => default; } // 0x00000001843401E0-0x0000000184340270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018433FE30-0x000000018433FEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018433FAE0-0x000000018433FB60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018433F2E0-0x000000018433F340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001843405B0-0x00000001843406A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001843403A0-0x0000000184340400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184340000-0x00000001843400F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184340560-0x00000001843405B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018433FC00-0x000000018433FCF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018433FA40-0x000000018433FAE0 0x000000018433F610-0x000000018433F6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x000000018433FEC0-0x000000018433FF60 0x000000018433F4A0-0x000000018433F540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FlycloakId { get => default; set {} } // 0x00000001843406A0-0x0000000184340740 0x000000018433FF60-0x0000000184340000

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22510
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22511
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1744
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarWearFlycloakRsp() {} // 0x0000000184340A90-0x0000000184340AF0
	static AvatarWearFlycloakRsp() {} // 0x00000001843409D0-0x0000000184340A90

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarWearFlycloakRsp Clone() => default; // 0x00000001843400F0-0x00000001843401E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarWearFlycloakRsp ShallowCopy() => default; // 0x000000018433FB60-0x000000018433FC00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018433F540-0x000000018433F590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184340300-0x0000000184340350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184340350-0x00000001843403A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018433F590-0x000000018433F610
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018433F6B0-0x000000018433F780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarWearFlycloakRsp other) => default; // 0x000000018433F780-0x000000018433F8C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018433FCF0-0x000000018433FE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184340740-0x00000001843409D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184340400-0x0000000184340560
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018433F8C0-0x000000018433FA40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarWearFlycloakRsp other) {} // 0x000000018433F340-0x000000018433F4A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018433F1D0-0x000000018433F2E0
}

