/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PingReq : MessageBase, IMessage<PingReq> // TypeDefIndex: 23965
{
	// Fields
	private static readonly MessageParser<PingReq> _parser; // 0x00
	public const int SeqFieldNumber = 1; // Metadata: 0x00B053EB
	private uint seq_; // 0x18
	public const int ClientTimeFieldNumber = 2; // Metadata: 0x00B053EF
	private uint clientTime_; // 0x1C
	public const int ScDataFieldNumber = 3; // Metadata: 0x00B053F3
	private ByteString scData_; // 0x20
	public const int UeTimeFieldNumber = 4; // Metadata: 0x00B053F7
	private float ueTime_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PingReq> Parser { get => default; } // 0x00000001813E41E0-0x00000001813E4270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001813E3ED0-0x00000001813E3F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001813E3B20-0x00000001813E3BA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001813E30C0-0x00000001813E3120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001813E4750-0x00000001813E4840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001813E4440-0x00000001813E44A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001813E3F60-0x00000001813E4050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001813E4700-0x00000001813E4750 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001813E3C40-0x00000001813E3D30 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint Seq { get => default; set {} } // 0x00000001813E3370-0x00000001813E3410 0x00000001813E3A80-0x00000001813E3B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ClientTime { get => default; set {} } // 0x00000001813E44A0-0x00000001813E4540 0x00000001813E4050-0x00000001813E40F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public ByteString ScData { get => default; set {} } // 0x00000001813E4350-0x00000001813E43F0 0x00000001813E32C0-0x00000001813E3370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public float UeTime { get => default; set {} } // 0x00000001813E35C0-0x00000001813E3660 0x00000001813E3520-0x00000001813E35C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23966
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23967
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 5
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PingReq() {} // 0x00000001813E4C00-0x00000001813E4C90
	static PingReq() {} // 0x00000001813E4B40-0x00000001813E4C00

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PingReq Clone() => default; // 0x00000001813E40F0-0x00000001813E41E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PingReq ShallowCopy() => default; // 0x00000001813E3BA0-0x00000001813E3C40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001813E3410-0x00000001813E3460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001813E4300-0x00000001813E4350
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001813E43F0-0x00000001813E4440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001813E3460-0x00000001813E3520
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001813E3800-0x00000001813E38D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PingReq other) => default; // 0x00000001813E3660-0x00000001813E3800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001813E3D30-0x00000001813E3ED0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001813E4840-0x00000001813E4B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001813E4540-0x00000001813E4700
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001813E38D0-0x00000001813E3A80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PingReq other) {} // 0x00000001813E3120-0x00000001813E32C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001813E2F90-0x00000001813E30C0
}

