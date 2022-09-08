/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class PlayerCookArgsReq : MessageBase, IMessage<PlayerCookArgsReq> // TypeDefIndex: 24480
{
	// Fields
	private static readonly MessageParser<PlayerCookArgsReq> _parser; // 0x00
	public const int RecipeIdFieldNumber = 1; // Metadata: 0x00B06863
	private uint recipeId_; // 0x18
	public const int AssistAvatarFieldNumber = 2; // Metadata: 0x00B06867
	private uint assistAvatar_; // 0x1C

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<PlayerCookArgsReq> Parser { get => default; } // 0x0000000181E7E020-0x0000000181E7E0B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x0000000181E7DC70-0x0000000181E7DD00 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x0000000181E7D960-0x0000000181E7D9E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x0000000181E7D350-0x0000000181E7D3B0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000181E7E450-0x0000000181E7E540 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x0000000181E7E280-0x0000000181E7E2E0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x0000000181E7DD00-0x0000000181E7DDF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000181E7E400-0x0000000181E7E450 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x0000000181E7DA80-0x0000000181E7DB70 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint RecipeId { get => default; set {} } // 0x0000000181E7DF80-0x0000000181E7E020 0x0000000181E7E1E0-0x0000000181E7E280
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public uint AssistAvatar { get => default; set {} } // 0x0000000181E7DEE0-0x0000000181E7DF80 0x0000000181E7D5A0-0x0000000181E7D640

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24481
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24482
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			IsAllowClient = 1,
			CmdId = 159
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerCookArgsReq() {} // 0x0000000181E7E800-0x0000000181E7E860
	static PlayerCookArgsReq() {} // 0x0000000181E7E740-0x0000000181E7E800

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerCookArgsReq Clone() => default; // 0x0000000181E7DDF0-0x0000000181E7DEE0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public PlayerCookArgsReq ShallowCopy() => default; // 0x0000000181E7D9E0-0x0000000181E7DA80
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x0000000181E7D4E0-0x0000000181E7D530
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E7E140-0x0000000181E7E190
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x0000000181E7E190-0x0000000181E7E1E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x0000000181E7D530-0x0000000181E7D5A0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x0000000181E7D760-0x0000000181E7D830
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(PlayerCookArgsReq other) => default; // 0x0000000181E7D640-0x0000000181E7D760
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x0000000181E7DB70-0x0000000181E7DC70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000181E7E540-0x0000000181E7E740
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000181E7E2E0-0x0000000181E7E400
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x0000000181E7D830-0x0000000181E7D960
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(PlayerCookArgsReq other) {} // 0x0000000181E7D3B0-0x0000000181E7D4E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x0000000181E7D250-0x0000000181E7D350
}

