/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetOnlinePlayerInfoRsp : MessageBase, IMessage<GetOnlinePlayerInfoRsp> // TypeDefIndex: 24000
{
	// Fields
	private static readonly MessageParser<GetOnlinePlayerInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B05523
	private int retcode_; // 0x18
	public const int TargetUidFieldNumber = 2; // Metadata: 0x00B05527
	private uint targetUid_; // 0x1C
	public const int TargetPlayerInfoFieldNumber = 3; // Metadata: 0x00B0552B
	private OnlinePlayerInfo targetPlayerInfo_; // 0x20
	public const int ParamFieldNumber = 4; // Metadata: 0x00B0552F
	private uint param_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetOnlinePlayerInfoRsp> Parser { get => default; } // 0x0000000183EB4B60-0x0000000183EB4BF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183EB48F0-0x0000000183EB4980 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183EB4450-0x0000000183EB44D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183EB38B0-0x0000000183EB3910 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183EB5110-0x0000000183EB5200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183EB4D80-0x0000000183EB4DE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183EB4980-0x0000000183EB4A70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183EB50C0-0x0000000183EB5110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183EB4570-0x0000000183EB4660 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183EB43B0-0x0000000183EB4450 0x0000000183EB3CC0-0x0000000183EB3D60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint TargetUid { get => default; set {} } // 0x0000000183EB4850-0x0000000183EB48F0 0x0000000183EB4310-0x0000000183EB43B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public OnlinePlayerInfo TargetPlayerInfo { get => default; set {} } // 0x0000000183EB3E00-0x0000000183EB3EA0 0x0000000183EB3D60-0x0000000183EB3E00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Param { get => default; set {} } // 0x0000000183EB4DE0-0x0000000183EB4E80 0x0000000183EB4E80-0x0000000183EB4F20

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24001
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24002
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 18
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetOnlinePlayerInfoRsp() {} // 0x0000000183EB55C0-0x0000000183EB5620
	static GetOnlinePlayerInfoRsp() {} // 0x0000000183EB5500-0x0000000183EB55C0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetOnlinePlayerInfoRsp Clone() => default; // 0x0000000183EB4A70-0x0000000183EB4B60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetOnlinePlayerInfoRsp ShallowCopy() => default; // 0x0000000183EB44D0-0x0000000183EB4570
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183EB3AF0-0x0000000183EB3B70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183EB4C80-0x0000000183EB4D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183EB4D00-0x0000000183EB4D80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183EB3B70-0x0000000183EB3CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183EB4010-0x0000000183EB40E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetOnlinePlayerInfoRsp other) => default; // 0x0000000183EB3EA0-0x0000000183EB4010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183EB4660-0x0000000183EB4850
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183EB5200-0x0000000183EB5500
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183EB4F20-0x0000000183EB50C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183EB40E0-0x0000000183EB4310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetOnlinePlayerInfoRsp other) {} // 0x0000000183EB3910-0x0000000183EB3AF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183EB3730-0x0000000183EB38B0
}

