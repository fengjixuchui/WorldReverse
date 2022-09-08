/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeGetArrangementInfoRsp : MessageBase, IMessage<HomeGetArrangementInfoRsp> // TypeDefIndex: 23347
{
	// Fields
	private static readonly MessageParser<HomeGetArrangementInfoRsp> _parser; // 0x00
	public const int RetcodeFieldNumber = 1; // Metadata: 0x00B03D4B
	private int retcode_; // 0x18
	public const int SceneArrangementInfoListFieldNumber = 2; // Metadata: 0x00B03D4F
	private static readonly FieldCodec<HomeSceneArrangementInfo> _repeated_sceneArrangementInfoList_codec; // 0x08
	private readonly RepeatedMessageField<HomeSceneArrangementInfo> sceneArrangementInfoList_; // 0x20

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeGetArrangementInfoRsp> Parser { get => default; } // 0x00000001815AAC10-0x00000001815AACA0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001815AA940-0x00000001815AA9D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001815AA630-0x00000001815AA6B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001815A9EC0-0x00000001815A9F20 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001815AB040-0x00000001815AB130 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001815AAE50-0x00000001815AAEB0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001815AA9D0-0x00000001815AAAC0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001815AAFF0-0x00000001815AB040 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001815AA750-0x00000001815AA840 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public int Retcode { get => default; set {} } // 0x00000001815AA590-0x00000001815AA630 0x00000001815AA1B0-0x00000001815AA250
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public RepeatedMessageField<HomeSceneArrangementInfo> SceneArrangementInfoList { get => default; } // 0x00000001815AABB0-0x00000001815AAC10 

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23348
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23349
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 4464
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeGetArrangementInfoRsp() {} // 0x00000001815AB420-0x00000001815AB4B0
	static HomeGetArrangementInfoRsp() {} // 0x00000001815AB310-0x00000001815AB420

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeGetArrangementInfoRsp Clone() => default; // 0x00000001815AAAC0-0x00000001815AABB0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeGetArrangementInfoRsp ShallowCopy() => default; // 0x00000001815AA6B0-0x00000001815AA750
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001815AA080-0x00000001815AA0D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001815AAD30-0x00000001815AADC0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001815AADC0-0x00000001815AAE50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001815AA0D0-0x00000001815AA1B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001815AA250-0x00000001815AA320
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeGetArrangementInfoRsp other) => default; // 0x00000001815AA320-0x00000001815AA450
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001815AA840-0x00000001815AA940
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001815AB130-0x00000001815AB310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001815AAEB0-0x00000001815AAFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001815AA450-0x00000001815AA590
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeGetArrangementInfoRsp other) {} // 0x00000001815A9F20-0x00000001815AA080
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001815A9D60-0x00000001815A9EC0
}

