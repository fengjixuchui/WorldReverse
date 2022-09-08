/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarFlycloakChangeNotify : MessageBase, IMessage<AvatarFlycloakChangeNotify> // TypeDefIndex: 22512
{
	// Fields
	private static readonly MessageParser<AvatarFlycloakChangeNotify> _parser; // 0x00
	public const int AvatarGuidFieldNumber = 1; // Metadata: 0x00B01BFB
	private ulong avatarGuid_; // 0x18
	public const int FlycloakIdFieldNumber = 2; // Metadata: 0x00B01BFF
	private uint flycloakId_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarFlycloakChangeNotify> Parser { get => default; } // 0x00000001823B9D00-0x00000001823B9D90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001823B9950-0x00000001823B99E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001823B9630-0x00000001823B96B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001823B9020-0x00000001823B9080 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001823BA090-0x00000001823BA180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001823B9EC0-0x00000001823B9F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001823B9B20-0x00000001823B9C10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001823BA040-0x00000001823BA090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001823B9750-0x00000001823B9840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ulong AvatarGuid { get => default; set {} } // 0x00000001823B99E0-0x00000001823B9A80 0x00000001823B91B0-0x00000001823B9250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint FlycloakId { get => default; set {} } // 0x00000001823BA180-0x00000001823BA220 0x00000001823B9A80-0x00000001823B9B20

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22513
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22514
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1745
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarFlycloakChangeNotify() {} // 0x00000001823BA4E0-0x00000001823BA540
	static AvatarFlycloakChangeNotify() {} // 0x00000001823BA420-0x00000001823BA4E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarFlycloakChangeNotify Clone() => default; // 0x00000001823B9C10-0x00000001823B9D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarFlycloakChangeNotify ShallowCopy() => default; // 0x00000001823B96B0-0x00000001823B9750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001823B9250-0x00000001823B92A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823B9E20-0x00000001823B9E70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001823B9E70-0x00000001823B9EC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001823B92A0-0x00000001823B9310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001823B9310-0x00000001823B93E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarFlycloakChangeNotify other) => default; // 0x00000001823B93E0-0x00000001823B9500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001823B9840-0x00000001823B9950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001823BA220-0x00000001823BA420
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001823B9F20-0x00000001823BA040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001823B9500-0x00000001823B9630
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarFlycloakChangeNotify other) {} // 0x00000001823B9080-0x00000001823B91B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001823B8F20-0x00000001823B9020
}

