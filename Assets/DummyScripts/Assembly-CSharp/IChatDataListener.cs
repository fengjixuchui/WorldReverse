/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface IChatDataListener // TypeDefIndex: 28454
{
	// Methods
	void AddChatData(ChatChannel channel, ChatInfo chatInfo, int msgType);
	void PushChatData(List<ChatInfo> listChatInfo);
	bool CheckChannel(ChatChannel channel, uint id);
}

