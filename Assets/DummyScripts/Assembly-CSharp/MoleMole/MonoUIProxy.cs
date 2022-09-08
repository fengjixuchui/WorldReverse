/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoUIProxy : MonoSpriteProxy // TypeDefIndex: 30968
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		protected Animator _animator; // 0x20
		protected float _fadeInDuration; // 0x28
		// [Range] // 0x0000000189A52310-0x0000000189A52350
		[SerializeField] // 0x0000000189A52310-0x0000000189A52350
		protected float _fadeOutDuration; // 0x2C
		private Coroutine _coroutine; // 0x30
		private DoublyList<AsyncJob> _proxySet; // 0x38
	
		// Properties
		public Animator animator { /* [XID] */ /* 0x0000000189A5CE90-0x0000000189A5CEB0 */ get => default; } // 0x000000018489A190-0x000000018489A230 
		public float fadeInDuration { /* [XID] */ /* 0x0000000189A64710-0x0000000189A64730 */ get => default; } // 0x000000018489A230-0x000000018489A2E0 
		public float fadeOutDuration { /* [XID] */ /* 0x0000000189A6BFB0-0x0000000189A6BFD0 */ get => default; /* [XID] */ /* 0x0000000189A73680-0x0000000189A736A0 */ set {} } // 0x000000018489A2E0-0x000000018489A390 0x000000018489A390-0x000000018489A440
	
		// Constructors
		public MonoUIProxy() {} // 0x000000018489A110-0x000000018489A190
	
		// Methods
		// [XID] // 0x00000001897F2D20-0x00000001897F2D40
		public float FadeOut() => default; // 0x00000001848992F0-0x0000000184899440
		// [XID] // 0x0000000189A82940-0x0000000189A82960
		public void PlayTriggerAnimation(string trigger) {} // 0x0000000184899EE0-0x0000000184899FA0
		// [XID] // 0x0000000189A8A350-0x0000000189A8A370
		public virtual void PlayStart() {} // 0x0000000184899E40-0x0000000184899EE0
		// [XID] // 0x0000000189A91AD0-0x0000000189A91AF0
		public virtual bool PlayEnd(Action clearPerformFinishHandler) => default; // 0x0000000184899D10-0x0000000184899E40
		// [XID] // 0x0000000189A995C0-0x0000000189A995E0
		public virtual void DestroyForce() {} // 0x00000001848991A0-0x0000000184899290
		// [XID] // 0x0000000189AA06B0-0x0000000189AA06D0
		public MonoUIContainer GetVarientContainer(string varientName) => default; // 0x0000000184899870-0x0000000184899A10
		// [XID] // 0x0000000189AA7C50-0x0000000189AA7C70
		public GameObject GetVarientGameObject(string varientName) => default; // 0x0000000184899A10-0x0000000184899BB0
		// [XID] // 0x0000000189AAF700-0x0000000189AAF720
		public Button GetVarientContainerButton(string varientName) => default; // 0x0000000184899680-0x0000000184899870
		// [XID] // 0x0000000189AB6F50-0x0000000189AB6F70
		public void GetUIInstance(string path, UnityAction<GameObject> callBack) {} // 0x0000000184899440-0x0000000184899680
		// [XID] // 0x0000000189ABE9A0-0x0000000189ABE9C0
		public void RecycleUIInstance(string path, GameObject uiInstance, bool cacheLast = true /* Metadata: 0x00B11B25 */) {} // 0x0000000184899FA0-0x000000018489A110
		// [XID] // 0x0000000189AC6500-0x0000000189AC6520
		protected override void OnDestroy() {} // 0x0000000184899BB0-0x0000000184899D10
	}
}
