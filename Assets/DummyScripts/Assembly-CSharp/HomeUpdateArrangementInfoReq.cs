/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class HomeUpdateArrangementInfoReq : MessageBase, IMessage<HomeUpdateArrangementInfoReq> // TypeDefIndex: 23350
{
	// Fields
	private static readonly MessageParser<HomeUpdateArrangementInfoReq> _parser; // 0x00
	public const int SceneArrangementInfoFieldNumber = 1; // Metadata: 0x00B03D63
	private HomeSceneArrangementInfo sceneArrangementInfo_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<HomeUpdateArrangementInfoReq> Parser { get => default; } // 0x0000000183A97E50-0x0000000183A97EE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000183A97BE0-0x0000000183A97C70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000183A977E0-0x0000000183A97860 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000183A970B0-0x0000000183A97110 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183A98200-0x0000000183A982F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000183A98070-0x0000000183A980D0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000183A97C70-0x0000000183A97D60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183A981B0-0x0000000183A98200 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000183A97900-0x0000000183A979F0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeSceneArrangementInfo SceneArrangementInfo { get => default; set {} } // 0x0000000183A97B40-0x0000000183A97BE0 0x0000000183A972F0-0x0000000183A97390

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 23351
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 23352
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 4465
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeUpdateArrangementInfoReq() {} // 0x0000000183A98500-0x0000000183A98560
	static HomeUpdateArrangementInfoReq() {} // 0x0000000183A98440-0x0000000183A98500

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeUpdateArrangementInfoReq Clone() => default; // 0x0000000183A97D60-0x0000000183A97E50
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public HomeUpdateArrangementInfoReq ShallowCopy() => default; // 0x0000000183A97860-0x0000000183A97900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000183A97270-0x0000000183A972F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A97F70-0x0000000183A97FF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000183A97FF0-0x0000000183A98070
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000183A97390-0x0000000183A974B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000183A974B0-0x0000000183A97580
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(HomeUpdateArrangementInfoReq other) => default; // 0x0000000183A97580-0x0000000183A97690
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000183A979F0-0x0000000183A97B40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183A982F0-0x0000000183A98440
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183A980D0-0x0000000183A981B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000183A97690-0x0000000183A977E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(HomeUpdateArrangementInfoReq other) {} // 0x0000000183A97110-0x0000000183A97270
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000183A96FA0-0x0000000183A970B0
}

