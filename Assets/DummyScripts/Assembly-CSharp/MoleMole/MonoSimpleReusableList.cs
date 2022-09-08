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
	public class MonoSimpleReusableList : MonoBehaviour // TypeDefIndex: 30937
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private GameObject _itemPrefab; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _grid; // 0x20
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private bool _useMutiRoot; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform[] _roots; // 0x30
		private List<Transform> _itemList; // 0x38
		private MonoScrollerFadeManager _fadeManager; // 0x40
		// [Header] // 0x0000000189741530-0x00000001897415A0
		[SerializeField] // 0x0000000189741530-0x00000001897415A0
		// [Tooltip] // 0x0000000189741530-0x00000001897415A0
		private bool _invokeOnClickOnSelect; // 0x4C
		private int _currIndex; // 0x50
	
		// Properties
		public int capacityCount { /* [XID] */ /* 0x0000000189AF53A0-0x0000000189AF53C0 */ get => default; } // 0x0000000184FF68E0-0x0000000184FF69A0 
		public RectTransform grid { /* [XID] */ /* 0x0000000189AFC8F0-0x0000000189AFC910 */ get => default; } // 0x0000000184FF69A0-0x0000000184FF6A40 
		public int itemListCount { /* [XID] */ /* 0x0000000189B04070-0x0000000189B040B0 */ get; /* [XID] */ /* 0x0000000189B0E7F0-0x0000000189B0E830 */ private set; } // 0x0000000184FF6AE0-0x0000000184FF6B40 0x0000000184FF56B0-0x0000000184FF5710
		public bool invokeOnClickOnSelect { /* [XID] */ /* 0x0000000189B8E550-0x0000000189B8E570 */ get => default; } // 0x0000000184FF6A40-0x0000000184FF6AE0 
		public OnSelectChange onSelectChange { /* [XID] */ /* 0x0000000189BA48D0-0x0000000189BA4910 */ get; /* [XID] */ /* 0x0000000189BAEAB0-0x0000000189BAEAF0 */ set; } // 0x0000000184FF6B40-0x0000000184FF6BA0 0x0000000184FF6BA0-0x0000000184FF6C00
	
		// Constructors
		public MonoSimpleReusableList() {} // 0x0000000184FF6820-0x0000000184FF68E0
	
		// Methods
		// [XID] // 0x0000000189B18CC0-0x0000000189B18CE0
		public void Init(Action<Transform, int> initCallback, int count) {} // 0x0000000184FF4E30-0x0000000184FF52F0
		// [XID] // 0x0000000189B20390-0x0000000189B203B0
		public void ClearAll() {} // 0x0000000184FF4640-0x0000000184FF47B0
		// [XID] // 0x0000000189B27990-0x0000000189B279B0
		public Transform GetItemTransByIndex(int index) => default; // 0x0000000184FF4D40-0x0000000184FF4E30
		// [XID] // 0x0000000189B2EC90-0x0000000189B2ECB0
		private Transform GetNewItemInstance() => default; // 0x0000000184FF4340-0x0000000184FF4480
		// [XID] // 0x0000000189B36550-0x0000000189B36570
		public Transform AddItem(GameObject otherPrefab) => default; // 0x0000000184FF40B0-0x0000000184FF41F0
		// [XID] // 0x0000000189B3DD50-0x0000000189B3DD70
		public void PlayScrollViewAnimation() {} // 0x0000000184FF5C30-0x0000000184FF5E20
		// [XID] // 0x0000000189B45AD0-0x0000000189B45AF0
		private Transform GetNewItemInstanceByOtherPrefab(GameObject other) => default; // 0x0000000184FF5540-0x0000000184FF56B0
		// [XID] // 0x0000000189B4CF70-0x0000000189B4CF90
		public void ScrollToBegin() {} // 0x0000000184FF5E20-0x0000000184FF5EF0
		// [XID] // 0x0000000189B54690-0x0000000189B546B0
		public void ScrollToEnd() {} // 0x0000000184FF5EF0-0x0000000184FF5FC0
		// [XID] // 0x0000000189B5C260-0x0000000189B5C280
		public void ScrollToItem(RectTransform item) {} // 0x0000000184FF5FC0-0x0000000184FF6450
		// [XID] // 0x0000000189B63860-0x0000000189B63880
		private Vector3 GetWidgetWorldPoint(RectTransform target) => default; // 0x0000000184FF4870-0x0000000184FF4B80
		// [XID] // 0x0000000189B6B020-0x0000000189B6B040
		private Vector3 GetWorldPointInWidget(RectTransform target, Vector3 worldPoint) => default; // 0x0000000184FF41F0-0x0000000184FF4340
		// [XID] // 0x0000000189B72660-0x0000000189B72680
		public void SetNormalizedPosition(Vector2 normalizedPosition) {} // 0x0000000184FF6450-0x0000000184FF6570
		// [IDTag] // 0x0000000189B79BB0-0x0000000189B79BF0
		// [XID] // 0x0000000189B79BB0-0x0000000189B79BF0
		public void UpdateFocusTarget(int index, bool autoClear = true /* Metadata: 0x00B11AD4 */) {} // 0x0000000184FF6570-0x0000000184FF66E0
		// [IDTag] // 0x0000000189B84560-0x0000000189B845A0
		// [XID] // 0x0000000189B84560-0x0000000189B845A0
		public void UpdateFocusTarget(RectTransform trans, bool autoClear = true /* Metadata: 0x00B11AD5 */) {} // 0x0000000184FF66E0-0x0000000184FF6820
		// [XID] // 0x0000000189B95A10-0x0000000189B95A30
		public void ChangeForJoystick(ContextEventType contextEventType, bool forceMove = false /* Metadata: 0x00B11AD6 */) {} // 0x0000000184FF4480-0x0000000184FF4640
		// [XID] // 0x0000000189B9CFB0-0x0000000189B9CFD0
		private void OnRefreshForJoyStick(int currIndex, int prevIndex, bool forceMove = false /* Metadata: 0x00B11AD7 */) {} // 0x0000000184FF5970-0x0000000184FF5C30
		// [XID] // 0x0000000189BB8FF0-0x0000000189BB9010
		public int GetCurIndex() => default; // 0x0000000184FF4B80-0x0000000184FF4C20
		// [XID] // 0x0000000189BC0DC0-0x0000000189BC0DE0
		public Transform GetCurTransform() => default; // 0x0000000184FF4C20-0x0000000184FF4D40
		// [XID] // 0x0000000189BC8510-0x0000000189BC8530
		public bool IsNavigateEnd() => default; // 0x0000000184FF5450-0x0000000184FF5540
		// [XID] // 0x0000000189BCFD70-0x0000000189BCFD90
		public bool IsNavigateBegin() => default; // 0x0000000184FF53A0-0x0000000184FF5450
		// [XID] // 0x0000000189BD73B0-0x0000000189BD73D0
		public void NavigateTo(int index) {} // 0x0000000184FF58A0-0x0000000184FF5970
		// [XID] // 0x0000000189BDEEB0-0x0000000189BDEED0
		public void NavigateToBegin() {} // 0x0000000184FF5710-0x0000000184FF57B0
		// [XID] // 0x00000001895EBB40-0x00000001895EBB60
		public void NavigateToEnd() {} // 0x0000000184FF57B0-0x0000000184FF58A0
		// [XID] // 0x00000001895F2EC0-0x00000001895F2EE0
		public void ClearNavigateState() {} // 0x0000000184FF47B0-0x0000000184FF4870
		// [XID] // 0x00000001895FA720-0x00000001895FA740
		public bool IsCleanNaviagteState() => default; // 0x0000000184FF52F0-0x0000000184FF53A0
	}
}
