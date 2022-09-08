/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class AvatarExpeditionAllDataRsp : MessageBase, IMessage<AvatarExpeditionAllDataRsp> // TypeDefIndex: 22459
{
	// Fields
	private static readonly MessageParser<AvatarExpeditionAllDataRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B019EB
	private int retcode_; // 0x18
	public const int ExpeditionInfoMapFieldNumber = 2; // Metadata: 0x00B019EF
	private static readonly MapField<ulong, AvatarExpeditionInfo> _map_expeditionInfoMap_codec; // 0x08
	private readonly MapField<ulong, AvatarExpeditionInfo> expeditionInfoMap_; // 0x20
	public const int OpenExpeditionListFieldNumber = 3; // Metadata: 0x00B019F3
	private static readonly FieldCodec<uint> _repeated_openExpeditionList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> openExpeditionList_; // 0x28
	public const int ExpeditionCountLimitFieldNumber = 4; // Metadata: 0x00B019F7
	private uint expeditionCountLimit_; // 0x30

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<AvatarExpeditionAllDataRsp> Parser { get => default; } // 0x00000001854232A0-0x0000000185423330 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000185422F70-0x0000000185423000 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000185422AA0-0x0000000185422B20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001854221E0-0x0000000185422240 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001854236C0-0x00000001854237B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000185423460-0x00000001854234C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000185423060-0x0000000185423150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000185423670-0x00000001854236C0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000185422BC0-0x0000000185422CB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000185422A00-0x0000000185422AA0 0x0000000185422540-0x00000001854225E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public MapField<ulong, AvatarExpeditionInfo> ExpeditionInfoMap { get => default; } // 0x0000000185423000-0x0000000185423060 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> OpenExpeditionList { get => default; } // 0x0000000185423240-0x00000001854232A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint ExpeditionCountLimit { get => default; set {} } // 0x0000000185422E30-0x0000000185422ED0 0x0000000185422ED0-0x0000000185422F70

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 22460
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 22461
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 1726
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarExpeditionAllDataRsp() {} // 0x0000000185423C10-0x0000000185423CC0
	static AvatarExpeditionAllDataRsp() {} // 0x0000000185423A90-0x0000000185423C10

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarExpeditionAllDataRsp Clone() => default; // 0x0000000185423150-0x0000000185423240
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public AvatarExpeditionAllDataRsp ShallowCopy() => default; // 0x0000000185422B20-0x0000000185422BC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001854223C0-0x0000000185422410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001854233C0-0x0000000185423410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000185423410-0x0000000185423460
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000185422410-0x0000000185422540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001854225E0-0x00000001854226B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(AvatarExpeditionAllDataRsp other) => default; // 0x00000001854226B0-0x0000000185422840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000185422CB0-0x0000000185422E30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001854237B0-0x0000000185423A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001854234C0-0x0000000185423670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000185422840-0x0000000185422A00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(AvatarExpeditionAllDataRsp other) {} // 0x0000000185422240-0x00000001854223C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000185421FE0-0x00000001854221E0
}

