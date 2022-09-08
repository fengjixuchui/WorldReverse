/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoScrollerFadeManager : MonoBehaviour // TypeDefIndex: 30921
	{
		// Fields
		private List<RectTransform> _itemList; // 0x18
		private ScrollRect _scroller; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _fadeInDuration; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _nextItemFadeInDelay; // 0x2C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _firstDelay; // 0x30
		private bool _isPlaying; // 0x34
	
		// Properties
		public bool IsPlaying { /* [XID] */ /* 0x000000018974BEB0-0x000000018974BED0 */ get => default; } // 0x0000000184113E60-0x0000000184113F00 
	
		// Constructors
		public MonoScrollerFadeManager() {} // 0x0000000184113DD0-0x0000000184113E60
	
		// Methods
		// [XID] // 0x0000000189753190-0x00000001897531B0
		public void Init(Dictionary<int, RectTransform> itemDict, Dictionary<int, RectTransform> oldItemList = null, Func<RectTransform, RectTransform, bool> isEqual = null) {} // 0x00000001841134F0-0x00000001841139D0
		// [XID] // 0x000000018975A560-0x000000018975A580
		public void Play() {} // 0x0000000184113AE0-0x0000000184113BA0
		// [XID] // 0x0000000189762220-0x0000000189762240
		public void Reset() {} // 0x0000000184113BA0-0x0000000184113DD0
		[DebuggerHidden] // 0x0000000189769790-0x00000001897697D0
		// [XID] // 0x0000000189769790-0x00000001897697D0
		private IEnumerator PlayAll() => default; // 0x00000001841130C0-0x00000001841131D0
		[DebuggerHidden] // 0x0000000189773C10-0x0000000189773C50
		// [XID] // 0x0000000189773C10-0x0000000189773C50
		private IEnumerator PlayStep(List<RectTransform> tranList, int num, int lastItemIndex) => default; // 0x00000001841131D0-0x0000000184113320
		// [XID] // 0x000000018977E440-0x000000018977E460
		private void BeginFadeIn() {} // 0x0000000184113320-0x00000001841134F0
		// [XID] // 0x0000000189785B70-0x0000000189785B90
		private void EndFadeIn() {} // 0x00000001841139D0-0x0000000184113AE0
	}
}
