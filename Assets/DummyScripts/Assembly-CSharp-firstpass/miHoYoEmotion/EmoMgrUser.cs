/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace miHoYoEmotion
{
	public class EmoMgrUser : MonoBehaviour, IEmoTickable // TypeDefIndex: 8483
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected ElementManager.Type _type; // 0x18
		protected BaseEmoAnimation _emoAnim; // 0x20
		protected EmoStateManager _emoState; // 0x28
		private bool _isTickable; // 0x30
	
		// Properties
		public ElementManager.Type type { /* [XID] */ /* 0x0000000189B77050-0x0000000189B77070 */ get => default; } // 0x000000018732A5A0-0x000000018732A640 
		public BaseEmoAnimation emoAnim { /* [XID] */ /* 0x000000018996AE90-0x000000018996AEB0 */ get => default; } // 0x000000018732A300-0x000000018732A3A0 
		public ElementManager manager { /* [XID] */ /* 0x0000000189727A60-0x0000000189727A80 */ get => default; } // 0x000000018732A440-0x000000018732A500 
		public EmoStateManager emoState { /* [XID] */ /* 0x00000001899A7A40-0x00000001899A7A60 */ get => default; } // 0x000000018732A3A0-0x000000018732A440 
		public bool tickable { /* [XID] */ /* 0x0000000189736710-0x0000000189736730 */ get => default; /* [XID] */ /* 0x000000018973E4E0-0x000000018973E500 */ set {} } // 0x000000018732A500-0x000000018732A5A0 0x000000018732A640-0x000000018732A770
	
		// Constructors
		public EmoMgrUser() {} // 0x000000018732A280-0x000000018732A300
	
		// Methods
		// [XID] // 0x0000000189796AB0-0x0000000189796AD0
		protected virtual void Start() {} // 0x0000000187329F60-0x000000018732A000
		// [XID] // 0x000000018974D2F0-0x000000018974D310
		public void UpdateManger() {} // 0x000000018732A000-0x000000018732A280
		// [XID] // 0x0000000189610350-0x0000000189610370
		protected virtual void OnEnable() {} // 0x0000000187329E00-0x0000000187329EA0
		// [XID] // 0x000000018975BC10-0x000000018975BC30
		public void SetState(EmoStateManager.EmoState state) {} // 0x0000000187329EA0-0x0000000187329F60
		// [XID] // 0x0000000189763630-0x0000000189763650
		public void ClearState(EmoStateManager.EmoState state) {} // 0x0000000187329C80-0x0000000187329D40
		// [XID] // 0x000000018976AD70-0x000000018976AD90
		public bool IsState(EmoStateManager.EmoState state) => default; // 0x0000000187329D40-0x0000000187329E00
	}
}
