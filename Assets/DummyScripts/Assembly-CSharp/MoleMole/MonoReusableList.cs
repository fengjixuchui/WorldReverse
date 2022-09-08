/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UniRx;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoReusableList : MonoBehaviour // TypeDefIndex: 30890
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private GameObject prefab; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _mountPoint; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _lightDeactive; // 0x28
		private Stack<MonoReusableListItem> _unusedItems; // 0x30
		private List<MonoReusableListItem> _validItems; // 0x38
		private List<Tuple<MonoReusableListItem, float>> _fadeOutItems; // 0x40
		private Coroutine _fadeOutCoroutine; // 0x48
		private int _iterIndex; // 0x50
		private MonoScrollerFadeManager _fadeManager; // 0x58
		private Dictionary<int, RectTransform> _transDict; // 0x60
	
		// Properties
		public int iterIndex { /* [XID] */ /* 0x0000000189846470-0x0000000189846490 */ get => default; /* [XID] */ /* 0x000000018984DA40-0x000000018984DA60 */ set {} } // 0x00000001844422E0-0x0000000184442380 0x0000000184442440-0x0000000184442530
		public int validItemCount { /* [XID] */ /* 0x0000000189854AC0-0x0000000189854AE0 */ get => default; } // 0x0000000184442380-0x0000000184442440 
		public int count { /* [XID] */ /* 0x000000018998FEF0-0x000000018998FF10 */ get => default; } // 0x0000000184442180-0x0000000184442240 
		public MonoReusableListItem this[int index] { /* [XID] */ /* 0x00000001898DD7E0-0x00000001898DD800 */ get => default; } // 0x00000001844420A0-0x0000000184442180 
		public GameObject itemPrefab { /* [XID] */ /* 0x0000000189988420-0x0000000189988440 */ get => default; } // 0x0000000184442240-0x00000001844422E0 
	
		// Constructors
		public MonoReusableList() {} // 0x0000000184441FA0-0x00000001844420A0
	
		// Methods
		// [XID] // 0x000000018985C320-0x000000018985C340
		public void IterateList(bool increase, bool loop = true /* Metadata: 0x00B116A5 */) {} // 0x0000000184440F20-0x00000001844410E0
		// [XID] // 0x0000000189863C60-0x0000000189863C80
		public void ActiveCurrTab() {} // 0x0000000184440500-0x0000000184440640
		// [XID] // 0x000000018986AF70-0x000000018986AF90
		public MonoReusableListItem Add() => default; // 0x0000000184440840-0x0000000184440910
		// [XID] // 0x0000000189872340-0x0000000189872360
		public MonoReusableListItem AddAt(int index) => default; // 0x0000000184440640-0x0000000184440840
		// [XID] // 0x00000001899E1160-0x00000001899E1180
		private MonoReusableListItem GetItem() => default; // 0x0000000184441440-0x0000000184441660
		// [XID] // 0x00000001898810F0-0x0000000189881110
		public bool RemoveAt(int index) => default; // 0x0000000184441AD0-0x0000000184441D60
		// [XID] // 0x00000001898886C0-0x00000001898886E0
		public bool Remove(MonoReusableListItem item) => default; // 0x0000000184441D60-0x0000000184441E70
		// [XID] // 0x000000018988FAA0-0x000000018988FAC0
		public bool ReuseAt(int index) => default; // 0x0000000184441E70-0x0000000184441FA0
		// [XID] // 0x0000000189896F80-0x0000000189896FA0
		public void ClearAll(bool setLast = false /* Metadata: 0x00B116A6 */) {} // 0x0000000184440AE0-0x0000000184440C60
		// [XID] // 0x000000018989E4E0-0x000000018989E500
		public void DestroyAll() {} // 0x0000000184440C60-0x0000000184440F20
		// [XID] // 0x00000001898A5FC0-0x00000001898A5FE0
		private void Awake() {} // 0x0000000184440910-0x0000000184440AE0
		// [XID] // 0x00000001898AD590-0x00000001898AD5B0
		private void OnDestroy() {} // 0x0000000184441750-0x0000000184441810
		[DebuggerHidden] // 0x00000001898B4B10-0x00000001898B4B50
		// [XID] // 0x00000001898B4B10-0x00000001898B4B50
		private IEnumerator WaitFadeOut(float startTime) => default; // 0x0000000184441660-0x0000000184441750
		// [XID] // 0x00000001898BF160-0x00000001898BF180
		private void OnDisable() {} // 0x0000000184441810-0x00000001844418B0
		// [XID] // 0x00000001898C6B00-0x00000001898C6B20
		private void FinishFadeOut() {} // 0x0000000184441260-0x0000000184441440
		// [XID] // 0x00000001898CE0E0-0x00000001898CE100
		private void Reuse(MonoReusableListItem item, bool setLast = true /* Metadata: 0x00B116A7 */) {} // 0x00000001844410E0-0x0000000184441260
		// [XID] // 0x00000001898EC8A0-0x00000001898EC8C0
		public void PlayScrollViewAnimation() {} // 0x00000001844418B0-0x0000000184441AD0
	}
}
