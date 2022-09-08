/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	// [AddComponentMenu] // 0x0000000189613F30-0x0000000189613F60
	public class MihoyoStandaloneInputModule : PointerInputModule // TypeDefIndex: 29977
	{
		// Fields
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private MihoyoHybridInput _input; // 0x58
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private bool _shouldActivateModule; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _shouldActivatePointer; // 0x61
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private float m_InputActionsPerSecond; // 0x64
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_RepeatDelay; // 0x68
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private bool m_ForceModuleActive; // 0x6C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _allowTouchInput; // 0x6D
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private bool _enableRightButton; // 0x6E
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _enableMiddleButton; // 0x6F
		private float m_PrevActionTime; // 0x70
		private Vector2 m_LastMoveVector; // 0x74
		private int m_ConsecutiveMoveCount; // 0x7C
		private Vector2 m_LastMousePosition; // 0x80
		private Vector2 m_MousePosition; // 0x88
		private GameObject m_CurrentFocusedGameObject; // 0x90
		private PointerEventData m_InputPointerEvent; // 0x98
	
		// Properties
		public new MihoyoHybridInput input { /* [XID] */ /* 0x0000000189681A40-0x0000000189681A60 */ get => default; } // 0x000000018114B120-0x000000018114B1C0 
		public bool forceModuleActive { /* [XID] */ /* 0x00000001896894B0-0x00000001896894D0 */ get => default; /* [XID] */ /* 0x0000000189691110-0x0000000189691130 */ set {} } // 0x000000018114AFD0-0x000000018114B070 0x000000018114B500-0x000000018114B5B0
		public float inputActionsPerSecond { /* [XID] */ /* 0x00000001896988C0-0x00000001896988E0 */ get => default; /* [XID] */ /* 0x000000018969FD30-0x000000018969FD50 */ set {} } // 0x000000018114B070-0x000000018114B120 0x000000018114B5B0-0x000000018114B660
		public float repeatDelay { /* [XID] */ /* 0x00000001896A6F70-0x00000001896A6F90 */ get => default; /* [XID] */ /* 0x00000001896AE5D0-0x00000001896AE5F0 */ set {} } // 0x000000018114B1C0-0x000000018114B270 0x000000018114B660-0x000000018114B710
		private bool shouldActivateModule { /* [XID] */ /* 0x00000001896CBAF0-0x00000001896CBB10 */ get => default; } // 0x000000018114A020-0x000000018114A1F0 
		private bool navigationActive { /* [XID] */ /* 0x00000001896D2DF0-0x00000001896D2E10 */ get => default; } // 0x0000000181149B10-0x0000000181149BF0 
		public bool shouldActivatePointer { /* [XID] */ /* 0x00000001896DA980-0x00000001896DA9A0 */ get => default; } // 0x000000018114B270-0x000000018114B330 
		public bool allowTouchInput { /* [XID] */ /* 0x0000000189707010-0x0000000189707030 */ get => default; /* [XID] */ /* 0x00000001898E9A70-0x00000001898E9A90 */ set {} } // 0x000000018114AF30-0x000000018114AFD0 0x000000018114B450-0x000000018114B500
	
		// Events
		public static event Action onPreClick;
	
		// Constructors
		protected MihoyoStandaloneInputModule() {} // 0x000000018114AD80-0x000000018114AE10
	
		// Methods
		// [XID] // 0x000000018967A210-0x000000018967A230
		protected override void Awake() {} // 0x0000000181148020-0x0000000181148180
		// [XID] // 0x00000001896B5DF0-0x00000001896B5E10
		private bool ShouldIgnoreEventsOnNoFocus() => default; // 0x000000018114A6C0-0x000000018114A780
		// [XID] // 0x00000001896BCFB0-0x00000001896BCFD0
		public override void UpdateModule() {} // 0x000000018114AB70-0x000000018114AD80
		// [XID] // 0x00000001896C4470-0x00000001896C4490
		public override bool IsModuleSupported() => default; // 0x0000000181149BF0-0x0000000181149D00
		// [XID] // 0x00000001896E2090-0x00000001896E20B0
		private bool ShouldActivatePointer() => default; // 0x000000018114A490-0x000000018114A5B0
		// [XID] // 0x00000001896E9590-0x00000001896E95B0
		public override bool ShouldActivateModule() => default; // 0x000000018114AAB0-0x000000018114AB70
		// [XID] // 0x00000001896F0830-0x00000001896F0850
		public override void ActivateModule() {} // 0x0000000181147E00-0x0000000181148020
		// [XID] // 0x00000001896F7FE0-0x00000001896F8000
		public override void DeactivateModule() {} // 0x0000000181148E30-0x0000000181148EE0
		// [XID] // 0x00000001896FF9C0-0x00000001896FF9E0
		public override void Process() {} // 0x000000018114A860-0x000000018114AAB0
		// [XID] // 0x0000000189715D30-0x0000000189715D50
		private bool ProcessTouchEvents() => default; // 0x000000018114A1F0-0x000000018114A490
		// [XID] // 0x000000018971D790-0x000000018971D7B0
		protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) {} // 0x0000000181148EE0-0x0000000181149700
		// [XID] // 0x0000000189724B50-0x0000000189724B70
		protected bool SendSubmitEventToSelectedObject() => default; // 0x0000000181149D60-0x000000018114A020
		// [XID] // 0x000000018972C380-0x000000018972C3A0
		protected bool SendMoveEventToSelectedObject() => default; // 0x0000000181149760-0x0000000181149B10
		// [IDTag] // 0x0000000189733A80-0x0000000189733AC0
		// [XID] // 0x0000000189733A80-0x0000000189733AC0
		protected void ProcessMouseEvent() {} // 0x0000000181148D90-0x0000000181148E30
		// [IDTag] // 0x000000018973E900-0x000000018973E940
		// [XID] // 0x000000018973E900-0x000000018973E940
		protected void ProcessMouseEvent(int id) {} // 0x0000000181148950-0x0000000181148D90
		// [XID] // 0x0000000189748F60-0x0000000189748F80
		protected bool SendUpdateEventToSelectedObject() => default; // 0x0000000181147C50-0x0000000181147E00
		// [XID] // 0x00000001897503D0-0x00000001897503F0
		protected void ProcessMousePress(MouseButtonEventData data) {} // 0x0000000181148180-0x0000000181148950
		// [XID] // 0x0000000189757970-0x0000000189757990
		protected GameObject GetCurrentFocusedGameObject() => default; // 0x000000018114A5B0-0x000000018114A660
	}
}
