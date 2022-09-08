/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MoleMole
{
	public class TimerReceiver : IReusable // TypeDefIndex: 10599
	{
		// Fields
		private TimerManager.SimpleTimerEventHandler _timerEventHandler; // 0x10
		private uint _token; // 0x18
		private bool _isTimeUp; // 0x1C
		private float _delay; // 0x20
		private float _timeLeft; // 0x24
		private float _lastTimeScale; // 0x28
		private bool _active; // 0x2C
		private TimerManager.TimerEventHandler _callBack; // 0x30
		private int _loopCount; // 0x38
	
		// Properties
		public uint Token { /* [XID] */ /* 0x000000018991E5F0-0x000000018991E610 */ get => default; } // 0x000000018608A6C0-0x000000018608A760 
		public bool IsTimeUp { /* [XID] */ /* 0x0000000189961840-0x0000000189961860 */ get => default; } // 0x000000018608A570-0x000000018608A610 
		public float Delay { /* [XID] */ /* 0x0000000189959E70-0x0000000189959E90 */ get => default; } // 0x000000018608A4C0-0x000000018608A570 
		public float LastTimeScale { /* [XID] */ /* 0x00000001895EB5D0-0x00000001895EB5F0 */ get => default; } // 0x000000018608A610-0x000000018608A6C0 
		private bool Active { /* [XID] */ /* 0x00000001895F29C0-0x00000001895F29E0 */ get => default; } // 0x000000018608A420-0x000000018608A4C0 
	
		// Nested types
		public class Spawner : ISpawner<TimerReceiver> // TypeDefIndex: 10600
		{
			// Constructors
			public Spawner() {} // 0x0000000186086380-0x00000001860863E0
	
			// Methods
			// [XID] // 0x0000000189652780-0x00000001896527A0
			public TimerReceiver Spawn() => default; // 0x00000001860862C0-0x0000000186086380
		}
	
		// Constructors
		protected TimerReceiver() {} // 0x000000018608A3A0-0x000000018608A420
	
		// Methods
		// [XID] // 0x00000001895FA2E0-0x00000001895FA300
		public virtual void BeforeRecycle() {} // 0x0000000186089660-0x0000000186089870
		// [XID] // 0x0000000189601C90-0x0000000189601CB0
		public void SetActive(bool active) {} // 0x0000000186089E30-0x0000000186089F20
		// [IDTag] // 0x00000001896094A0-0x00000001896094E0
		// [XID] // 0x00000001896094A0-0x00000001896094E0
		public void SetTimer(float delay, int loopCount, float timeScale, Func<bool> callBack, bool isFixedUpdate = false /* Metadata: 0x00AE7B9E */) {} // 0x0000000186089FD0-0x000000018608A130
		// [IDTag] // 0x0000000189613A40-0x0000000189613A80
		// [XID] // 0x0000000189613A40-0x0000000189613A80
		public void SetTimer(float delay, int loopCount, float timeScale, TimerManager.TimerEventHandler callBack, bool isFixedUpdate = false /* Metadata: 0x00AE7B9F */) {} // 0x000000018608A130-0x000000018608A3A0
		// [XID] // 0x0000000189B26BE0-0x0000000189B26C00
		public void ReStartTimer(float timeScale) {} // 0x0000000186089AA0-0x0000000186089BD0
		// [XID] // 0x00000001896257F0-0x0000000189625810
		private void RefreshTimeLeft() {} // 0x0000000186089BD0-0x0000000186089D20
		// [XID] // 0x000000018962D050-0x000000018962D070
		public void ResetTimeScale(float timeScale) {} // 0x0000000186089D20-0x0000000186089E30
		// [XID] // 0x0000000189634C20-0x0000000189634C40
		public void KillTimer() {} // 0x0000000186089990-0x0000000186089AA0
		// [XID] // 0x0000000189854940-0x0000000189854960
		private bool CallBack(float delay) => default; // 0x0000000186089870-0x0000000186089990
		// [XID] // 0x0000000189643980-0x00000001896439A0
		public void AddInterval(float deltaTime) {} // 0x0000000186089570-0x0000000186089660
		// [XID] // 0x000000018964B020-0x000000018964B040
		public void SetDelay(float delay) {} // 0x0000000186089F20-0x0000000186089FD0
	}
}
