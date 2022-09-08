/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerCookReq : MessageBase, IMessage<PlayerCookReq> // TypeDefIndex: 24375
{
	// Fields
	private static readonly MessageParser<PlayerCookReq> _parser; // 0x00
	public const int RecipeIdFieldNumber = 1; // Metadata: 0x00B064CB
	private uint recipeId_; // 0x18
	public const int QteQualityFieldNumber = 2; // Metadata: 0x00B064CF
	private uint qteQuality_; // 0x1C
	public const int AssistAvatarFieldNumber = 3; // Metadata: 0x00B064D3
	private uint assistAvatar_; // 0x20
	public const int CookCountFieldNumber = 4; // Metadata: 0x00B064D7
	private uint cookCount_; // 0x24

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerCookReq> Parser { get => default; } // 0x00000001811FD6D0-0x00000001811FD760 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x00000001811FD280-0x00000001811FD310 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x00000001811FCF10-0x00000001811FCF90 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x00000001811FC5E0-0x00000001811FC640 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x00000001811FDB80-0x00000001811FDC70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x00000001811FD930-0x00000001811FD990 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x00000001811FD310-0x00000001811FD400 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x00000001811FDB30-0x00000001811FDB80 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x00000001811FD030-0x00000001811FD120 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RecipeId { get => default; set {} } // 0x00000001811FD590-0x00000001811FD630 0x00000001811FD890-0x00000001811FD930
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint QteQuality { get => default; set {} } // 0x00000001811FCA80-0x00000001811FCB20 0x00000001811FD630-0x00000001811FD6D0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AssistAvatar { get => default; set {} } // 0x00000001811FD4F0-0x00000001811FD590 0x00000001811FC9E0-0x00000001811FCA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint CookCount { get => default; set {} } // 0x00000001811FC6E0-0x00000001811FC780 0x00000001811FC640-0x00000001811FC6E0

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24376
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24377
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 126
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerCookReq() {} // 0x00000001811FE050-0x00000001811FE0B0
	static PlayerCookReq() {} // 0x00000001811FDF90-0x00000001811FE050

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerCookReq Clone() => default; // 0x00000001811FD400-0x00000001811FD4F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerCookReq ShallowCopy() => default; // 0x00000001811FCF90-0x00000001811FD030
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x00000001811FC900-0x00000001811FC950
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001811FD7F0-0x00000001811FD840
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x00000001811FD840-0x00000001811FD890
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x00000001811FC950-0x00000001811FC9E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x00000001811FCB20-0x00000001811FCBF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerCookReq other) => default; // 0x00000001811FCBF0-0x00000001811FCD40
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x00000001811FD120-0x00000001811FD280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x00000001811FDC70-0x00000001811FDF90
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x00000001811FD990-0x00000001811FDB30
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x00000001811FCD40-0x00000001811FCF10
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerCookReq other) {} // 0x00000001811FC780-0x00000001811FC900
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x00000001811FC4B0-0x00000001811FC5E0
}

