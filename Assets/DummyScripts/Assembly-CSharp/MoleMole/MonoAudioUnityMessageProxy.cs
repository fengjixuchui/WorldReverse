/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public abstract class MonoAudioUnityMessageProxy : MonoBehaviour // TypeDefIndex: 31712
	{
		// Fields
		private List<AudioUnityMessageReceiverStub> _targets; // 0x18
	
		// Constructors
		protected MonoAudioUnityMessageProxy() {} // 0x0000000184219820-0x0000000184219880
	
		// Methods
		// [XID] // 0x00000001897382D0-0x00000001897382F0
		public virtual void RegisterCallback(IAudioUnityMessageReceiver receiver, object cookie) {} // 0x00000001842196E0-0x0000000184219820
		// [XID] // 0x000000018973FFE0-0x0000000189740000
		protected virtual void ForwardMessage(AudioUnityMessageType messageType) {} // 0x0000000184219420-0x0000000184219590
		// [XID] // 0x0000000189747440-0x0000000189747460
		protected virtual void OnDestroy() {} // 0x0000000184219590-0x00000001842196E0
	}
}
