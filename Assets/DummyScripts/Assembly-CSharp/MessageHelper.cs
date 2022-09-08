/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class MessageHelper // TypeDefIndex: 21704
{
	// Fields
	public static UseMessageType UseType; // 0x00
	private static Dictionary<System.Type, IMessage> _messageMap; // 0x08

	// Constructors
	static MessageHelper() {} // 0x00000001835E4E90-0x00000001835E4F30

	// Methods
	private static T GetMessage<T>()
		where T : IMessage, new() => default;
	// [XID] // 0x0000000189BC4200-0x0000000189BC4220
	public static IMessage GetMessage(System.Type t) => default; // 0x00000001835E4B90-0x00000001835E4DB0
	public static bool CheckInMessageCache<T>(T t)
		where T : MessageBase, IMessage => default;
	// [XID] // 0x0000000189BCBBA0-0x0000000189BCBBC0
	public static void ClearMessageCache() {} // 0x00000001835E4DB0-0x00000001835E4E90
	public static T Allocate<T>()
		where T : MessageBase, IMessage, new() => default;
	// [XID] // 0x0000000189BD30D0-0x0000000189BD30F0
	public static void Deallocate(MessageBase message) {} // 0x00000001835E4710-0x00000001835E4B90
	public static void DeallocateByClone<T>(T message)
		where T : MessageBase, IMessage {}
	public static void DeallocateByClone<T>(RepeatedMessageField<T> repeatedMessage)
		where T : MessageBase, IMessage, IDeepCloneable<T> {}
	public static void DeallocateByShallowCopy<T>(T message)
		where T : MessageBase, IMessage {}
	public static RepeatedMessageField<T> AllocateRepeatedField<T>()
		where T : MessageBase, IMessage, IDeepCloneable<T> => default;
	public static void Deallocate<T>(RepeatedMessageField<T> repeatedMessage)
		where T : MessageBase, IMessage, IDeepCloneable<T> {}
	public static void ShallowCopy<T>(ref RepeatedMessageField<T> dstRepeatedMessage, RepeatedMessageField<T> repeatedMessage, MessageReferenceMaskType mask = MessageReferenceMaskType.Invalid /* Metadata: 0x00AFFC9A */)
		where T : MessageBase, IMessage, IDeepCloneable<T> {}
	public static void DeallocateByShallowCopy<T>(RepeatedMessageField<T> repeatedMessage)
		where T : MessageBase, IMessage, IDeepCloneable<T> {}
	public static T getData<T>(UseMessageType useMessageType = UseMessageType.UseMessageCache /* Metadata: 0x00AFFC9E */)
		where T : MessageBase, IMessage, new() => default;
	public static T GetMessageCache<T>()
		where T : MessageBase, IMessage, new() => default;
	public static T ShallowCopy<T>(T dest, T src, MessageReferenceMaskType mask = MessageReferenceMaskType.Invalid /* Metadata: 0x00AFFCA2 */)
		where T : MessageBase => default;
	public static RepeatedMessageField<T> ShallowCopy<T>(RepeatedMessageField<T> dest, RepeatedMessageField<T> src)
		where T : MessageBase, IDeepCloneable<T> => default;
}

