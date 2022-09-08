/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetAreaExplorePointRsp : MessageBase, IMessage<GetAreaExplorePointRsp> // TypeDefIndex: 25008
{
	// Fields
	private static readonly MessageParser<GetAreaExplorePointRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B07C2F
	private int retcode_; // 0x18
	public const int AreaIdListFieldNumber = 2; // Metadata: 0x00B07C33
	private static readonly FieldCodec<uint> _repeated_areaIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> areaIdList_; // 0x20
	public const int ExplorePointListFieldNumber = 3; // Metadata: 0x00B07C37
	private static readonly FieldCodec<uint> _repeated_explorePointList_codec; // 0x10
	private readonly RepeatedPrimitiveField<uint> explorePointList_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetAreaExplorePointRsp> Parser { get => default; } // 0x0000000183B206D0-0x0000000183B20760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183B20400-0x0000000183B20490 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183B200D0-0x0000000183B20150 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183B1F8C0-0x0000000183B1F920 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183B20B10-0x0000000183B20C00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183B20890-0x0000000183B208F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183B20490-0x0000000183B20580 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183B20AC0-0x0000000183B20B10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183B201F0-0x0000000183B202E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000183B20030-0x0000000183B200D0 0x0000000183B1FBF0-0x0000000183B1FC90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> AreaIdList { get => default; } // 0x0000000183B20A60-0x0000000183B20AC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ExplorePointList { get => default; } // 0x0000000183B20670-0x0000000183B206D0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25009
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25010
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 239
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAreaExplorePointRsp() {} // 0x0000000183B20F60-0x0000000183B21010
	static GetAreaExplorePointRsp() {} // 0x0000000183B20E60-0x0000000183B20F60

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAreaExplorePointRsp Clone() => default; // 0x0000000183B20580-0x0000000183B20670
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAreaExplorePointRsp ShallowCopy() => default; // 0x0000000183B20150-0x0000000183B201F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183B1FA70-0x0000000183B1FAC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B207F0-0x0000000183B20840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183B20840-0x0000000183B20890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183B1FAC0-0x0000000183B1FBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183B1FDE0-0x0000000183B1FEB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetAreaExplorePointRsp other) => default; // 0x0000000183B1FC90-0x0000000183B1FDE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183B202E0-0x0000000183B20400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183B20C00-0x0000000183B20E60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183B208F0-0x0000000183B20A60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183B1FEB0-0x0000000183B20030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetAreaExplorePointRsp other) {} // 0x0000000183B1F920-0x0000000183B1FA70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183B1F6E0-0x0000000183B1F8C0
}

