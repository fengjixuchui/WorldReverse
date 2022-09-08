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
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoCentreScroller : MonoBehaviour, IBeginDragHandler, IEndDragHandler // TypeDefIndex: 30722
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect _scroller; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _itemPrefab; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _grid; // 0x28
		// [Header] // 0x0000000189674200-0x0000000189674240
		[SerializeField] // 0x0000000189674200-0x0000000189674240
		private float _moveTime; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _autoScrollVelocity; // 0x34
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _normalLength; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _maxLength; // 0x3C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float _spaceLength; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string _itemScrollAudioEventName; // 0x48
		private uint _itemScrollAudioEvent; // 0x50
		private List<Transform> _itemList; // 0x58
		private float[] _itemRangeValue; // 0x60
		private float _scrollStepLen; // 0x68
		private float _startValue; // 0x6C
		private float _targetValue; // 0x70
		private float _currMoveTime; // 0x74
		private bool _inDrag; // 0x78
		private bool _shouldAutoScoll; // 0x79
		private int _itemListCount; // 0x7C
		private Action<Transform, float> _valueInRangeCB; // 0x80
		private Action<int> _setScrollIndexCB; // 0x88
	
		// Properties
		public ScrollRect scroller { /* [XID] */ /* 0x00000001896A5770-0x00000001896A5790 */ get => default; } // 0x0000000184807D30-0x0000000184807DD0 
		public Action<Transform, float> valueInRangeCB { /* [XID] */ /* 0x00000001896ACF90-0x00000001896ACFB0 */ set {} } // 0x0000000184807F20-0x0000000184807FD0
		public Action<int> setScrollIndexCB { /* [XID] */ /* 0x00000001896B45B0-0x00000001896B45D0 */ set {} } // 0x0000000184807E70-0x0000000184807F20
		public bool inDrag { /* [XID] */ /* 0x00000001896BB830-0x00000001896BB850 */ get => default; } // 0x0000000184807BF0-0x0000000184807C90 
		public bool shouldAutoScoll { /* [XID] */ /* 0x00000001896C2C80-0x00000001896C2CA0 */ get => default; } // 0x0000000184807DD0-0x0000000184807E70 
		public int itemListCount { /* [XID] */ /* 0x00000001896CA1A0-0x00000001896CA1C0 */ get => default; } // 0x0000000184807C90-0x0000000184807D30 
	
		// Constructors
		public MonoCentreScroller() {} // 0x0000000184807B00-0x0000000184807BF0
	
		// Methods
		// [XID] // 0x00000001896D1870-0x00000001896D1890
		public void OnBeginDrag(PointerEventData eventData) {} // 0x0000000184807590-0x0000000184807640
		// [XID] // 0x00000001896D9070-0x00000001896D9090
		public void OnEndDrag(PointerEventData eventData) {} // 0x0000000184807640-0x00000001848076F0
		// [XID] // 0x00000001896E08F0-0x00000001896E0910
		private void Start() {} // 0x0000000184807A60-0x0000000184807B00
		// [XID] // 0x00000001896E7B50-0x00000001896E7B70
		private void LateUpdate() {} // 0x0000000184806F20-0x00000001848071F0
		// [XID] // 0x00000001896EF1F0-0x00000001896EF210
		private int GetNearestItemIndex() => default; // 0x0000000184806D60-0x0000000184806F20
		// [XID] // 0x00000001896F6C00-0x00000001896F6C20
		public void SetTargetScrollIndex(int index) {} // 0x0000000184807910-0x0000000184807A60
		// [XID] // 0x00000001896FE4E0-0x00000001896FE500
		public void SetTargetIndexWithoutScroll(int index) {} // 0x00000001848077F0-0x0000000184807910
		// [XID] // 0x0000000189705640-0x0000000189705660
		public void Init(Action<Transform, int> initCallback, int count, int defaultIndex = 0 /* Metadata: 0x00B114C7 */, bool setTargetScroll = true /* Metadata: 0x00B114CB */) {} // 0x0000000184806980-0x0000000184806D60
		// [XID] // 0x000000018970D140-0x000000018970D160
		public void ClearAll() {} // 0x0000000184806220-0x0000000184806360
		// [XID] // 0x0000000189714570-0x0000000189714590
		public Transform GetItemTransByIndex(int index) => default; // 0x0000000184806630-0x0000000184806720
		// [XID] // 0x000000018971BFF0-0x000000018971C010
		private void InitCentreScroller() {} // 0x00000001848071F0-0x0000000184807590
		// [XID] // 0x00000001897234A0-0x00000001897234C0
		private void InitTransform(int count) {} // 0x0000000184806720-0x0000000184806980
		// [XID] // 0x000000018972ABE0-0x000000018972AC00
		private void OnScrollerValueChanged(Vector2 scrollerValue) {} // 0x0000000184806360-0x0000000184806630
		// [XID] // 0x00000001897322F0-0x0000000189732310
		private void OnCenterItemChanged(int index) {} // 0x00000001848076F0-0x00000001848077F0
		// [XID] // 0x00000001897399E0-0x0000000189739A00
		private Transform GetNewItemInstance() => default; // 0x00000001848060E0-0x0000000184806220
	}
}
