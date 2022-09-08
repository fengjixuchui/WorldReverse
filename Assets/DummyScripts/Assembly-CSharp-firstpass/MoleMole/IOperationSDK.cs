/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public interface IOperationSDK // TypeDefIndex: 9414
	{
		// Methods
		void InitSDK(string appKey, string channelId, bool isSandbox);
		void Register(string account, string eventName);
		void Login(string account, string eventName);
		void TrackEvent(string eventName);
		void ReYunSetOrder(string ryTID, string hbType, float hbAmount);
		void AdjustTrackRevenue(string eventName, float amount, string currency);
		void SetPrintLog(bool bPrint);
		string GetDeviceId();
		string GetCurrentCaid();
		string GetCachedCaid();
	}
}
