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

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoImageProgress : MonoBehaviour // TypeDefIndex: 30805
	{
		// Fields
		private float width; // 0x18
		private RectTransform _rectTrans; // 0x20
		private float _value; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public ImageProgressEvent onValueChange; // 0x30
		private bool _inited; // 0x38
	
		// Properties
		public float value { /* [XID] */ /* 0x0000000189646EE0-0x0000000189646F00 */ get => default; } // 0x00000001846FD600-0x00000001846FD6B0 
	
		// Nested types
		[Serializable]
		public class ImageProgressEvent : UnityEvent<float> // TypeDefIndex: 30806
		{
			// Constructors
			public ImageProgressEvent() {} // 0x00000001846F3190-0x00000001846F3200
		}
	
		// Constructors
		public MonoImageProgress() {} // 0x00000001846FD580-0x00000001846FD600
	
		// Methods
		// [XID] // 0x000000018964E650-0x000000018964E670
		private void Awake() {} // 0x00000001846FD280-0x00000001846FD320
		// [XID] // 0x0000000189655E40-0x0000000189655E60
		public void Setup() {} // 0x00000001846FD430-0x00000001846FD580
		// [XID] // 0x000000018965D620-0x000000018965D640
		public void SetValue(float rate) {} // 0x00000001846FD320-0x00000001846FD430
	}
}
