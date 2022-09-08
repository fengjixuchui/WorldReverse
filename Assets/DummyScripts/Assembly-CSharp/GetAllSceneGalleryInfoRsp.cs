/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class GetAllSceneGalleryInfoRsp : MessageBase, IMessage<GetAllSceneGalleryInfoRsp> // TypeDefIndex: 23272
{
	// Fields
	private static readonly MessageParser<GetAllSceneGalleryInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B03A83
	private int retcode_; // 0x18
	public const int GalleryInfoListFieldNumber = 3; // Metadata: 0x00B03A87
	private static readonly FieldCodec<SceneGalleryInfo> _repeated_galleryInfoList_codec; // 0x08
	private readonly RepeatedMessageField<SceneGalleryInfo> galleryInfoList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<GetAllSceneGalleryInfoRsp> Parser { get => default; } // 0x0000000181E8F5E0-0x0000000181E8F670 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181E8F370-0x0000000181E8F400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181E8F060-0x0000000181E8F0E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181E8E8F0-0x0000000181E8E950 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181E8FA70-0x0000000181E8FB60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181E8F880-0x0000000181E8F8E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181E8F400-0x0000000181E8F4F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181E8FA20-0x0000000181E8FA70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181E8F180-0x0000000181E8F270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x0000000181E8EFC0-0x0000000181E8F060 0x0000000181E8EBE0-0x0000000181E8EC80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<SceneGalleryInfo> GalleryInfoList { get => default; } // 0x0000000181E8F790-0x0000000181E8F7F0 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23273
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23274
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 5508
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAllSceneGalleryInfoRsp() {} // 0x0000000181E8FE50-0x0000000181E8FEE0
	static GetAllSceneGalleryInfoRsp() {} // 0x0000000181E8FD40-0x0000000181E8FE50

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAllSceneGalleryInfoRsp Clone() => default; // 0x0000000181E8F4F0-0x0000000181E8F5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public GetAllSceneGalleryInfoRsp ShallowCopy() => default; // 0x0000000181E8F0E0-0x0000000181E8F180
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181E8EAB0-0x0000000181E8EB00
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E8F700-0x0000000181E8F790
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E8F7F0-0x0000000181E8F880
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181E8EB00-0x0000000181E8EBE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181E8EC80-0x0000000181E8ED50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(GetAllSceneGalleryInfoRsp other) => default; // 0x0000000181E8ED50-0x0000000181E8EE80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181E8F270-0x0000000181E8F370
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181E8FB60-0x0000000181E8FD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181E8F8E0-0x0000000181E8FA20
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181E8EE80-0x0000000181E8EFC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(GetAllSceneGalleryInfoRsp other) {} // 0x0000000181E8E950-0x0000000181E8EAB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181E8E790-0x0000000181E8E8F0
}

