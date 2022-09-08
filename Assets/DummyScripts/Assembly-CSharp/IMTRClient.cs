/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public interface IMTRClient // TypeDefIndex: 21179
{
	// Methods
	bool CheckIsValid();
	bool Start(string ip, IPAddress address, byte maxTTL, int timeOut, int maxTryCount, int abortTimeOutCount, MTRReason reason, Action<MTRData> callBack);
	void Stop();
	void WorkThreadInit();
	void WorkThreadCollect();
	void WorkThreadExecute();
	void WorkThreadFlush();
	void WorkThreadDestroy();
	bool IsWorking();
}

