/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class UpdatePlayerShowAvatarListRsp : MessageBase, IMessage<UpdatePlayerShowAvatarListRsp> // TypeDefIndex: 25663
{
	// Fields
	private static readonly MessageParser<UpdatePlayerShowAvatarListRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B09483
	private int retcode_; // 0x18
	public const int ShowAvatarIdListFieldNumber = 2; // Metadata: 0x00B09487
	private static readonly FieldCodec<uint> _repeated_showAvatarIdList_codec; // 0x08
	private readonly RepeatedPrimitiveField<uint> showAvatarIdList_; // 0x20
	public const int IsShowAvatarFieldNumber = 3; // Metadata: 0x00B0948B
	private bool isShowAvatar_; // 0x28

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<UpdatePlayerShowAvatarListRsp> Parser { get => default; } // 0x0000000181254410-0x00000001812544A0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001812541A0-0x0000000181254230 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181253E60-0x0000000181253EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001812535C0-0x0000000181253620 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181254800-0x00000001812548F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001812545D0-0x0000000181254630 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181254230-0x0000000181254320 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001812547B0-0x0000000181254800 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181253F80-0x0000000181254070 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181253DC0-0x0000000181253E60 0x00000001812539B0-0x0000000181253A50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedPrimitiveField<uint> ShowAvatarIdList { get => default; } // 0x0000000181253620-0x0000000181253680 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool IsShowAvatar { get => default; set {} } // 0x00000001812548F0-0x0000000181254990 0x00000001812537E0-0x0000000181253880

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 25664
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 25665
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4046
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdatePlayerShowAvatarListRsp() {} // 0x0000000181254CE0-0x0000000181254D70
	static UpdatePlayerShowAvatarListRsp() {} // 0x0000000181254C00-0x0000000181254CE0

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdatePlayerShowAvatarListRsp Clone() => default; // 0x0000000181254320-0x0000000181254410
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public UpdatePlayerShowAvatarListRsp ShallowCopy() => default; // 0x0000000181253EE0-0x0000000181253F80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181253880-0x00000001812538D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181254530-0x0000000181254580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181254580-0x00000001812545D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001812538D0-0x00000001812539B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181253A50-0x0000000181253B20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(UpdatePlayerShowAvatarListRsp other) => default; // 0x0000000181253B20-0x0000000181253C60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181254070-0x00000001812541A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181254990-0x0000000181254C00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181254630-0x00000001812547B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181253C60-0x0000000181253DC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(UpdatePlayerShowAvatarListRsp other) {} // 0x0000000181253680-0x00000001812537E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181253440-0x00000001812535C0
}

