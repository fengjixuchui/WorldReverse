/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarExpeditionCallBackRsp : MessageBase, IMessage<AvatarExpeditionCallBackRsp> // TypeDefIndex: 22471
{
	// Fields
	private static readonly MessageParser<AvatarExpeditionCallBackRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B01A5B
	private int retcode_; // 0x18
	public const int ExpeditionInfoMapFieldNumber = 2; // Metadata: 0x00B01A5F
	private static readonly MapField<ulong, AvatarExpeditionInfo> _map_expeditionInfoMap_codec; // 0x08
	private readonly MapField<ulong, AvatarExpeditionInfo> expeditionInfoMap_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarExpeditionCallBackRsp> Parser { get => default; } // 0x0000000181E27510-0x0000000181E275A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181E27240-0x0000000181E272D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181E26EF0-0x0000000181E26F70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181E267C0-0x0000000181E26820 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181E278C0-0x0000000181E279B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181E276D0-0x0000000181E27730 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181E27330-0x0000000181E27420 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181E27870-0x0000000181E278C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181E27010-0x0000000181E27100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181E26E50-0x0000000181E26EF0 0x0000000181E26A60-0x0000000181E26B00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<ulong, AvatarExpeditionInfo> ExpeditionInfoMap { get => default; } // 0x0000000181E272D0-0x0000000181E27330 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22472
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22473
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1730
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarExpeditionCallBackRsp() {} // 0x0000000181E27CF0-0x0000000181E27D80
	static AvatarExpeditionCallBackRsp() {} // 0x0000000181E27B90-0x0000000181E27CF0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarExpeditionCallBackRsp Clone() => default; // 0x0000000181E27420-0x0000000181E27510
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarExpeditionCallBackRsp ShallowCopy() => default; // 0x0000000181E26F70-0x0000000181E27010
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181E26950-0x0000000181E269A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E27630-0x0000000181E27680
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E27680-0x0000000181E276D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181E269A0-0x0000000181E26A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181E26B00-0x0000000181E26BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarExpeditionCallBackRsp other) => default; // 0x0000000181E26BD0-0x0000000181E26D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181E27100-0x0000000181E27240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181E279B0-0x0000000181E27B90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181E27730-0x0000000181E27870
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181E26D10-0x0000000181E26E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarExpeditionCallBackRsp other) {} // 0x0000000181E26820-0x0000000181E26950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181E26660-0x0000000181E267C0
}

