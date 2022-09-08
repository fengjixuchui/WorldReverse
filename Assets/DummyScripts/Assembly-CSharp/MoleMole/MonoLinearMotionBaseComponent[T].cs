/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public abstract class MonoLinearMotionBaseComponent<T> : MonoBehaviour // TypeDefIndex: 30618
		where T : struct
	{
		// Fields
		private bool _isMoving;
		private int _curFrame;
		private int _totalFrameCount;
		private float _deltaTime;
		private T _curId;
		private Coroutine _curTickCoroutine;
		private Action<T> _onFinish;
		private Action<T> _onTick;
		private Action<T> _onSuspend;
		private Vector3 _endPos;
		private Vector3 _curSpeed;
		private Vector3 _curForce;
	
		// Properties
		public T ID { get; set; }
		public int CurFrame { get; }
		public int TotalFrameCount { get; }
		public float TotalDuringTime { get; }
		public RectTransform rectTransform { get; }
		public Vector3 EndPosition { get; }
		public abstract Vector3 CurPosition { get; set; }
	
		// Constructors
		protected MonoLinearMotionBaseComponent() {}
	
		// Methods
		private void OnDestroy() {}
		public bool IsMoving() => default;
		public bool SetStartSpeed(Vector3 startSpeed) => default;
		public bool SetTotalFrameCount(int totalCount) => default;
		public bool SetTotaDuringTime(float totalSeconds) => default;
		public bool SetStartPosition(Vector3 pos) => default;
		public bool SetEndPosition(Vector3 pos) => default;
		public void Reset() {}
		public bool StartMove(Action<T> onTick = null, Action<T> onFinish = null, Action<T> onSuspend = null) => default;
		public void StopMove() {}
		private void ClearCoroutineAndCallbacks() {}
		[DebuggerHidden] // 0x0000000189A3F260-0x0000000189A3F270
		private IEnumerator TickCoroutine() => default;
	}
}
