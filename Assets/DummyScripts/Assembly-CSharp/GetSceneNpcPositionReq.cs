/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetSceneNpcPositionReq : MessageBase, IMessage<GetSceneNpcPositionReq> // TypeDefIndex: 24207
{
	// Fields
	private static readonly MessageParser<GetSceneNpcPositionReq> _parser; // 0x00
	public const int SceneIdFieldNumber = 1; // Metadata: 0x00B05D9F
	private uint sceneId_; // 0x18
	public const int NpcIdListFieldNumber = 2; // Metadata: 0x00B05DA3
	private static readonly FieldCodec<uint> _repeated_npcIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> npcIdList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetSceneNpcPositionReq> Parser { get => default; } // 0x0000000184036B50-0x0000000184036BE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001840368E0-0x0000000184036970 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001840365D0-0x0000000184036650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184035EB0-0x0000000184035F10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184036F60-0x0000000184037050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184036D70-0x0000000184036DD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184036970-0x0000000184036A60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184036F10-0x0000000184036F60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001840366F0-0x00000001840367E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint SceneId { get => default; set {} } // 0x0000000184036150-0x00000001840361F0 0x0000000184036530-0x00000001840365D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> NpcIdList { get => default; } // 0x0000000184036D10-0x0000000184036D70 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24208
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24209
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 504
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetSceneNpcPositionReq() {} // 0x0000000184037310-0x00000001840373A0
	static GetSceneNpcPositionReq() {} // 0x0000000184037230-0x0000000184037310

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetSceneNpcPositionReq Clone() => default; // 0x0000000184036A60-0x0000000184036B50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetSceneNpcPositionReq ShallowCopy() => default; // 0x0000000184036650-0x00000001840366F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000184036040-0x0000000184036090
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184036C70-0x0000000184036CC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184036CC0-0x0000000184036D10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184036090-0x0000000184036150
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184036320-0x00000001840363F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetSceneNpcPositionReq other) => default; // 0x00000001840361F0-0x0000000184036320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001840367E0-0x00000001840368E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184037050-0x0000000184037230
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184036DD0-0x0000000184036F10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001840363F0-0x0000000184036530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetSceneNpcPositionReq other) {} // 0x0000000184035F10-0x0000000184036040
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184035D40-0x0000000184035EB0
}

