/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetSceneAreaRsp : MessageBase, IMessage<GetSceneAreaRsp> // TypeDefIndex: 24963
{
	// Fields
	private static readonly MessageParser<GetSceneAreaRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B07A9B
	private int retcode_; // 0x18
	public const int SceneIdFieldNumber = 2; // Metadata: 0x00B07A9F
	private uint sceneId_; // 0x1C
	public const int AreaIdListFieldNumber = 3; // Metadata: 0x00B07AA3
	private static readonly FieldCodec<uint> _repeated_areaIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> areaIdList_; // 0x20
	public const int CityInfoListFieldNumber = 4; // Metadata: 0x00B07AA7
	private static readonly FieldCodec<CityInfo> _repeated_cityInfoList_codec; // 0x10
	private readonly RepeatedMessageField<CityInfo> cityInfoList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetSceneAreaRsp> Parser { get => default; } // 0x000000018211C0A0-0x000000018211C130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018211BE30-0x000000018211BEC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018211BAD0-0x000000018211BB50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018211B0A0-0x000000018211B100 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x000000018211C5A0-0x000000018211C690 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018211C2E0-0x000000018211C340 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018211BEC0-0x000000018211BFB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x000000018211C550-0x000000018211C5A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018211BBF0-0x000000018211BCE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x000000018211B990-0x000000018211BA30 0x000000018211B4F0-0x000000018211B590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x000000018211B450-0x000000018211B4F0 0x000000018211BA30-0x000000018211BAD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> AreaIdList { get => default; } // 0x000000018211C4F0-0x000000018211C550 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<CityInfo> CityInfoList { get => default; } // 0x000000018211B040-0x000000018211B0A0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24964
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24965
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 223
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetSceneAreaRsp() {} // 0x000000018211CAA0-0x000000018211CB50
	static GetSceneAreaRsp() {} // 0x000000018211C970-0x000000018211CAA0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetSceneAreaRsp Clone() => default; // 0x000000018211BFB0-0x000000018211C0A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetSceneAreaRsp ShallowCopy() => default; // 0x000000018211BB50-0x000000018211BBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018211B2B0-0x000000018211B300
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018211C1C0-0x000000018211C250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018211C250-0x000000018211C2E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018211B300-0x000000018211B450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018211B590-0x000000018211B660
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetSceneAreaRsp other) => default; // 0x000000018211B660-0x000000018211B7D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018211BCE0-0x000000018211BE30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x000000018211C690-0x000000018211C970
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x000000018211C340-0x000000018211C4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018211B7D0-0x000000018211B990
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetSceneAreaRsp other) {} // 0x000000018211B100-0x000000018211B2B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018211AE40-0x000000018211B040
}

