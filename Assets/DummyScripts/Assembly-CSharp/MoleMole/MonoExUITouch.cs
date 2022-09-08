/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using HedgehogTeam.EasyTouch;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoExUITouch : MonoBehaviour // TypeDefIndex: 30768
	{
		// Fields
		private FingerUtil _fingerUtil; // 0x18
		private BasePageContext _ownerContext; // 0x20
		private int _swipeDuration; // 0x28
		private MonoExUICamera _cameraUtil; // 0x30
		private static float _cd_touch_after_pinch; // 0x00
		private float _leftTime_touch_after_pinch; // 0x38
		private Vector2Event _onClicked; // 0x40
	
		// Properties
		public Vector2Event onClicked { /* [XID] */ /* 0x00000001897C4100-0x00000001897C4120 */ get => default; } // 0x00000001856282F0-0x0000000185628390 
	
		// Nested types
		public class FingerUtil // TypeDefIndex: 30769
		{
			// Fields
			private List<int> _fingerIDList; // 0x10
	
			// Constructors
			public FingerUtil() {} // 0x000000018561BB90-0x000000018561BC30
	
			// Methods
			// [XID] // 0x0000000189807C10-0x0000000189807C30
			public bool AddFinger(int id) => default; // 0x000000018561B8B0-0x000000018561B990
			// [XID] // 0x000000018980F4D0-0x000000018980F4F0
			public bool RemoveFinger(int id) => default; // 0x000000018561BAB0-0x000000018561BB90
			// [XID] // 0x0000000189816B80-0x0000000189816BA0
			public int GetFingerNum() => default; // 0x000000018561B7F0-0x000000018561B8B0
			// [XID] // 0x000000018981E430-0x000000018981E450
			public bool ContainFinger(int id) => default; // 0x000000018561B990-0x000000018561BAB0
			// [XID] // 0x00000001898258F0-0x0000000189825910
			public void ResetTouch() {} // 0x000000018561B590-0x000000018561B740
			// [XID] // 0x000000018982D0A0-0x000000018982D0C0
			public void Clear() {} // 0x000000018561B740-0x000000018561B7F0
		}
	
		// Constructors
		public MonoExUITouch() {} // 0x0000000185628250-0x00000001856282F0
		static MonoExUITouch() {} // 0x00000001856281F0-0x0000000185628250
	
		// Methods
		// [XID] // 0x000000018973CC50-0x000000018973CC70
		public void Init(BasePageContext owner) {} // 0x00000001856269B0-0x0000000185626A70
		// [XID] // 0x00000001897441D0-0x00000001897441F0
		public void Refresh() {} // 0x00000001856279F0-0x0000000185627A90
		// [XID] // 0x000000018974BED0-0x000000018974BEF0
		private void Update() {} // 0x0000000185628130-0x00000001856281F0
		// [XID] // 0x00000001897531B0-0x00000001897531D0
		public bool HasDialogsAtTop() => default; // 0x0000000185626690-0x0000000185626790
		// [XID] // 0x000000018975A580-0x000000018975A5A0
		public bool IsSwiping() => default; // 0x0000000185626C40-0x0000000185626D60
		// [XID] // 0x0000000189762240-0x0000000189762260
		public int GetSwipeDuration() => default; // 0x00000001856265F0-0x0000000185626690
		// [XID] // 0x0000000189769840-0x0000000189769860
		public bool IsPinching() => default; // 0x0000000185626B20-0x0000000185626C40
		// [XID] // 0x0000000189770DB0-0x0000000189770DD0
		public bool IsCDTouchAfterPinch() => default; // 0x0000000185626A70-0x0000000185626B20
		// [XID] // 0x0000000189778740-0x0000000189778760
		private void SetCDTouchAfterPinch() {} // 0x00000001856260C0-0x0000000185626190
		// [XID] // 0x000000018977FCA0-0x000000018977FCC0
		private void OnTouchStart(Gesture gesture) {} // 0x0000000185626790-0x00000001856269B0
		// [XID] // 0x0000000189787580-0x00000001897875A0
		private void OnTouchUp(Gesture gesture) {} // 0x0000000185626190-0x0000000185626330
		// [XID] // 0x000000018978EB90-0x000000018978EBB0
		private void OnSwipeStart(Gesture gesture) {} // 0x0000000185625C00-0x0000000185625EA0
		// [XID] // 0x0000000189796320-0x0000000189796340
		private void OnSwipe(Gesture gesture) {} // 0x0000000185627570-0x0000000185627800
		// [XID] // 0x000000018979E3F0-0x000000018979E410
		private void OnSwipeEnd(Gesture gesture) {} // 0x00000001856272E0-0x0000000185627570
		// [XID] // 0x00000001897A5B70-0x00000001897A5B90
		private void OnPinchStart(Gesture gesture) {} // 0x00000001856263D0-0x00000001856265F0
		// [XID] // 0x00000001897AD0E0-0x00000001897AD100
		private void OnPinchIn(Gesture gesture) {} // 0x0000000185626F50-0x0000000185627170
		// [XID] // 0x00000001897B5110-0x00000001897B5130
		private void OnPinchOut(Gesture gesture) {} // 0x0000000185625EA0-0x00000001856260C0
		// [XID] // 0x00000001897BCD80-0x00000001897BCDA0
		private void OnPinchEnd(Gesture gesture) {} // 0x0000000185626D60-0x0000000185626F50
		// [XID] // 0x00000001897CB980-0x00000001897CB9A0
		private void OnSimpleTap(Gesture gesture) {} // 0x0000000185627170-0x00000001856272E0
		// [XID] // 0x00000001897D3290-0x00000001897D32B0
		public void OnEnable() {} // 0x0000000185627950-0x00000001856279F0
		// [XID] // 0x00000001897DAD10-0x00000001897DAD30
		public void OnDisable() {} // 0x00000001856278B0-0x0000000185627950
		// [XID] // 0x00000001897E2420-0x00000001897E2440
		public void OnDestroy() {} // 0x0000000185627800-0x00000001856278B0
		// [XID] // 0x00000001897E9B90-0x00000001897E9BB0
		private void Clear() {} // 0x0000000185626330-0x00000001856263D0
		// [XID] // 0x00000001897F1850-0x00000001897F1870
		public void SubscribeEvent() {} // 0x0000000185627B50-0x0000000185627E50
		// [XID] // 0x00000001897F8F80-0x00000001897F8FA0
		public void UnsubscribeEvent() {} // 0x0000000185627E50-0x0000000185628130
		// [XID] // 0x0000000189800590-0x00000001898005B0
		public void ResetTouch() {} // 0x0000000185627A90-0x0000000185627B50
	}
}
