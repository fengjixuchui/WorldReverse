/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UpdatePlayerShowAvatarListReq : MessageBase, IMessage<UpdatePlayerShowAvatarListReq> // TypeDefIndex: 25660
{
	// Fields
	private static readonly MessageParser<UpdatePlayerShowAvatarListReq> _parser; // 0x00
	public const int ShowAvatarIdListFieldNumber = 1; // Metadata: 0x00B09467
	private static readonly FieldCodec<uint> _repeated_showAvatarIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> showAvatarIdList_; // 0x18
	public const int IsShowAvatarFieldNumber = 2; // Metadata: 0x00B0946B
	private bool isShowAvatar_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UpdatePlayerShowAvatarListReq> Parser { get => default; } // 0x0000000184732B40-0x0000000184732BD0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001847328D0-0x0000000184732960 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001847325D0-0x0000000184732650 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000184731F30-0x0000000184731F90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000184732EF0-0x0000000184732FE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000184732D00-0x0000000184732D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000184732960-0x0000000184732A50 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000184732EA0-0x0000000184732EF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001847326F0-0x00000001847327E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ShowAvatarIdList { get => default; } // 0x0000000184731F90-0x0000000184731FF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsShowAvatar { get => default; set {} } // 0x0000000184732FE0-0x0000000184733080 0x0000000184732120-0x00000001847321C0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25661
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25662
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4045
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdatePlayerShowAvatarListReq() {} // 0x0000000184733340-0x00000001847333D0
	static UpdatePlayerShowAvatarListReq() {} // 0x0000000184733260-0x0000000184733340

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdatePlayerShowAvatarListReq Clone() => default; // 0x0000000184732A50-0x0000000184732B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdatePlayerShowAvatarListReq ShallowCopy() => default; // 0x0000000184732650-0x00000001847326F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001847321C0-0x0000000184732210
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184732C60-0x0000000184732CB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000184732CB0-0x0000000184732D00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000184732210-0x00000001847322E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000184732400-0x00000001847324D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UpdatePlayerShowAvatarListReq other) => default; // 0x00000001847322E0-0x0000000184732400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001847327E0-0x00000001847328D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000184733080-0x0000000184733260
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000184732D60-0x0000000184732EA0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001847324D0-0x00000001847325D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UpdatePlayerShowAvatarListReq other) {} // 0x0000000184731FF0-0x0000000184732120
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000184731DC0-0x0000000184731F30
}

