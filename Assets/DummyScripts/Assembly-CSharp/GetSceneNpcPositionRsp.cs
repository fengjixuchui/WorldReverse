/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetSceneNpcPositionRsp : MessageBase, IMessage<GetSceneNpcPositionRsp> // TypeDefIndex: 24210
{
	// Fields
	private static readonly MessageParser<GetSceneNpcPositionRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B05DBB
	private int retcode_; // 0x18
	public const int SceneIdFieldNumber = 2; // Metadata: 0x00B05DBF
	private uint sceneId_; // 0x1C
	public const int NpcInfoListFieldNumber = 3; // Metadata: 0x00B05DC3
	private static readonly FieldCodec<NpcPositionInfo> _repeated_npcInfoList_codec; // 0x08
	private readonly RepeatedMessageField<NpcPositionInfo> npcInfoList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetSceneNpcPositionRsp> Parser { get => default; } // 0x0000000181546810-0x00000001815468A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001815465A0-0x0000000181546630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181546200-0x0000000181546280 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001815458A0-0x0000000181545900 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181546C70-0x0000000181546D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181546A50-0x0000000181546AB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181546630-0x0000000181546720 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181546C20-0x0000000181546C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181546320-0x0000000181546410 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001815460C0-0x0000000181546160 0x0000000181545C70-0x0000000181545D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000181545BD0-0x0000000181545C70 0x0000000181546160-0x0000000181546200
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<NpcPositionInfo> NpcInfoList { get => default; } // 0x0000000181546540-0x00000001815465A0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24211
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24212
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 505
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetSceneNpcPositionRsp() {} // 0x00000001815470E0-0x0000000181547170
	static GetSceneNpcPositionRsp() {} // 0x0000000181546FD0-0x00000001815470E0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetSceneNpcPositionRsp Clone() => default; // 0x0000000181546720-0x0000000181546810
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetSceneNpcPositionRsp ShallowCopy() => default; // 0x0000000181546280-0x0000000181546320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181545A90-0x0000000181545AE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181546930-0x00000001815469C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001815469C0-0x0000000181546A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181545AE0-0x0000000181545BD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181545D10-0x0000000181545DE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetSceneNpcPositionRsp other) => default; // 0x0000000181545DE0-0x0000000181545F30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181546410-0x0000000181546540
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181546D60-0x0000000181546FD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181546AB0-0x0000000181546C20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181545F30-0x00000001815460C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetSceneNpcPositionRsp other) {} // 0x0000000181545900-0x0000000181545A90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181545720-0x00000001815458A0
}

