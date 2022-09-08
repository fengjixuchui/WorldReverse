/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using Google.Protobuf.Reflection;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class CookRecipeDataNotify : MessageBase, IMessage<CookRecipeDataNotify> // TypeDefIndex: 24391
{
	// Fields
	private static readonly MessageParser<CookRecipeDataNotify> _parser; // 0x00
	public const int RecipeDataFieldNumber = 1; // Metadata: 0x00B06563
	private CookRecipeData recipeData_; // 0x18

	// Properties
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageParser<CookRecipeDataNotify> Parser { get => default; } // 0x000000018395FDD0-0x000000018395FE60 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static MessageDescriptor StaticDescriptor { get => default; } // 0x000000018395FB60-0x000000018395FBF0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override MessageDescriptor Descriptor { get => default; } // 0x000000018395F800-0x000000018395F880 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticClassName { get => default; } // 0x000000018395F030-0x000000018395F090 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ClassName { get => default; } // 0x0000000183960180-0x0000000183960270 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static string StaticFullClassName { get => default; } // 0x000000018395FFF0-0x0000000183960050 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string FullClassName { get => default; } // 0x000000018395FBF0-0x000000018395FCE0 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static ushort StaticCmdId { get => default; } // 0x0000000183960130-0x0000000183960180 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override ushort CmdId { get => default; } // 0x000000018395F920-0x000000018395FA10 
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CookRecipeData RecipeData { get => default; set {} } // 0x000000018395F430-0x000000018395F4D0 0x000000018395F1F0-0x000000018395F290

	// Nested types
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public static class Types // TypeDefIndex: 24392
	{
		// Nested types
		public enum CmdId // TypeDefIndex: 24393
		{
			None = 0,
			EnetChannelId = 0,
			EnetIsReliable = 1,
			CmdId = 131
		}
	}

	// Constructors
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CookRecipeDataNotify() {} // 0x0000000183960480-0x00000001839604E0
	static CookRecipeDataNotify() {} // 0x00000001839603C0-0x0000000183960480

	// Methods
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CookRecipeDataNotify Clone() => default; // 0x000000018395FCE0-0x000000018395FDD0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public CookRecipeDataNotify ShallowCopy() => default; // 0x000000018395F880-0x000000018395F920
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalSetInPool(bool value) {} // 0x000000018395F290-0x000000018395F310
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalAddReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018395FEF0-0x000000018395FF70
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	protected override void InternalDeleteReferenceMask(MessageReferenceMaskType mask) {} // 0x000000018395FF70-0x000000018395FFF0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void Reset() {} // 0x000000018395F310-0x000000018395F430
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override bool Equals(object other) => default; // 0x000000018395F5E0-0x000000018395F6B0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public bool Equals(CookRecipeDataNotify other) => default; // 0x000000018395F4D0-0x000000018395F5E0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int GetHashCode() => default; // 0x000000018395FA10-0x000000018395FB60
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override string ToString() => default; // 0x0000000183960270-0x00000001839603C0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void WriteTo(CodedOutputStream output) {} // 0x0000000183960050-0x0000000183960130
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override int CalculateSize() => default; // 0x000000018395F6B0-0x000000018395F800
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public void CopyFrom(CookRecipeDataNotify other) {} // 0x000000018395F090-0x000000018395F1F0
	[DebuggerNonUserCode] // 0x0000000189B51D30-0x0000000189B51D40
	public override void MergeFrom(CodedInputStream input) {} // 0x000000018395EF20-0x000000018395F030
}

