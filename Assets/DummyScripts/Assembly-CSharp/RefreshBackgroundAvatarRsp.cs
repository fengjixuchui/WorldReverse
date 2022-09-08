/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class RefreshBackgroundAvatarRsp : MessageBase, IMessage<RefreshBackgroundAvatarRsp> // TypeDefIndex: 22423
{
	// Fields
	private static readonly MessageParser<RefreshBackgroundAvatarRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B018A3
	private int retcode_; // 0x18
	public const int HpFullTimeMapFieldNumber = 2; // Metadata: 0x00B018A7
	private static readonly MapField<ulong, uint> _map_hpFullTimeMap_codec; // 0x08
	private readonly MapField<ulong, uint> hpFullTimeMap_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<RefreshBackgroundAvatarRsp> Parser { get => default; } // 0x0000000183621100-0x0000000183621190 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183620E90-0x0000000183620F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183620AE0-0x0000000183620B60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001836203B0-0x0000000183620410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001836214B0-0x00000001836215A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001836212C0-0x0000000183621320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183620F20-0x0000000183621010 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183621460-0x00000001836214B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183620C00-0x0000000183620CF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183620A40-0x0000000183620AE0 0x0000000183620650-0x00000001836206F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<ulong, uint> HpFullTimeMap { get => default; } // 0x0000000183620E30-0x0000000183620E90 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22424
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22425
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1714
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RefreshBackgroundAvatarRsp() {} // 0x00000001836218B0-0x0000000183621940
	static RefreshBackgroundAvatarRsp() {} // 0x0000000183621780-0x00000001836218B0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RefreshBackgroundAvatarRsp Clone() => default; // 0x0000000183621010-0x0000000183621100
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RefreshBackgroundAvatarRsp ShallowCopy() => default; // 0x0000000183620B60-0x0000000183620C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183620540-0x0000000183620590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183621220-0x0000000183621270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183621270-0x00000001836212C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183620590-0x0000000183620650
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183620830-0x0000000183620900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(RefreshBackgroundAvatarRsp other) => default; // 0x00000001836206F0-0x0000000183620830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183620CF0-0x0000000183620E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001836215A0-0x0000000183621780
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183621320-0x0000000183621460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183620900-0x0000000183620A40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(RefreshBackgroundAvatarRsp other) {} // 0x0000000183620410-0x0000000183620540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183620250-0x00000001836203B0
}

